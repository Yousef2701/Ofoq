using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace IShcool.Controllers
{
    public class Identity : Controller
    {

        #region Dependancey injuction

        private readonly IUserRepository _userRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly ITeacherRepository _teacherRepository;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<HomeController> _logger;
        private readonly SignInManager<IdentityUser> _signInManager;

        public Identity(IUserRepository userRepository,
                        IStudentRepository studentRepository,
                        ISubjectRepository subjectRepository,
                        ITeacherRepository teacherRepository,
                        IEnrollmentRepository enrollmentRepository,
                        IHttpContextAccessor httpContextAccessor,
                        UserManager<IdentityUser> userManager,
                        ILogger<HomeController> logger,
                        SignInManager<IdentityUser> signInManager)
        {
            _userRepository = userRepository;
            _studentRepository = studentRepository;
            _subjectRepository = subjectRepository;
            _teacherRepository = teacherRepository;
            _enrollmentRepository = enrollmentRepository;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _logger = logger;
            _signInManager = signInManager;
        }

        #endregion



        #region Student Register

        #region Student Data

        [HttpGet]
        public IActionResult Student_Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Student_Register(Student_Register_VM model)
        {
            if (model.Par_Phone == null) { model.Par_Phone = "01000000000"; }
            if (model.Password.Length < 8)
            {
                TempData["ErrorMessage"] = "كلمة السر يجب ان تكون 8 أحرف او أرقام على الأقل";
                return View(model);
            }
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = model.Phone + "@gmail.com",
                    Email = model.Phone + "@gmail.com",
                    PhoneNumber = model.Phone
                };
                if (_userRepository.CheckUser(model.Phone + "@gmail.com"))
                {
                    TempData["ErrorMessage"] = "هذا الحساب موجود بالفعل";
                    return View(model);
                }

                if (model.Password == model.ConfirmPassword)
                {
                    var result = await _userManager.CreateAsync(user, model.Password);

                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, true);

                        Claim claim = new Claim("Student", "Student");
                        await _userManager.AddClaimAsync(user, claim);

                        await _studentRepository.CreateNewStudent(model,user.Id);

                        _userRepository.ConfirmEmail(user.Id);

                        if (user.Id != null)
                        {
                            TempData["SuccessMessage"] = "تمت العملية بنجاح!";
                            _logger.LogInformation("User created a new account with password.");
                            return RedirectToAction("Choose_Subjects");
                        }

                        TempData["ErrorMessage"] = "حدثت مشكلة أثناء التحقق من الهوية .";
                        return View(model);
                    }
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
                TempData["ErrorMessage"] = "كلمة المرور غير متطابقة.";
            }
            TempData["ErrorMessage"] = "هذا الحساب موجود بالفعل";
            return View(model);
        }

        #endregion

        #region Choose Subjects

        [HttpGet]
        public async Task<IActionResult> Choose_Subjects()
        {
            var student = await _studentRepository.GetStudentById(await _userRepository.GitLoggingUserId());
            if (student != null)
            {
                var subjectlist =await _subjectRepository.GetSubjectList(student.Grade, student.Department);
                ViewBag.Subjectlist = subjectlist;
                if (ViewBag.Subjectlist != null)
                {
                    ViewBag.SecondLang = student.SecondLang;
                    ViewBag.AcademyYear = student.Grade;
                    return View();
                }
                TempData["ErrorMessage"] = "خطأ في تحميل المواد الدراسية";
                return RedirectToAction("Student_Register");
            }
            return RedirectToAction("Student_Register");
        }

        [HttpPost]
        public async Task<IActionResult> Choose_Subjects(Subjects_VM model)
        {
            if (model != null)
                return RedirectToAction("Choose_Teachers", model);
            else
                return View();
        }

        #endregion

        #region Choose Teachers

        [HttpGet]
        public async Task<IActionResult> Choose_Teachers(Subjects_VM model)
        {
            if (model != null)
            {
                string[] subjectlist = await _subjectRepository.SplitSubjectList(model.Subjects);
                var student = await _studentRepository.GetStudentById(await _userRepository.GitLoggingUserId());
                int subjectnumber = subjectlist.Length;
                ViewBag.SubjectList = subjectlist;
                ViewBag.SubNum = subjectnumber;
                ViewBag.Teachers = await _subjectRepository.GitSubjectsTeachers(subjectlist, student);
                return View();
            }
            else
                return RedirectToAction("Student_Register");         
        }

        [HttpPost]
        public async Task<IActionResult> Choose_Teachers(Enrollment_VM model)
        {
            if (model.Subjects != null && model.TeachersPhones != null)
            {
                var subjects = await _subjectRepository.SplitSubjectList(model.Subjects);
                var teachersId = await _teacherRepository.GitTeachersIdList(model.TeachersPhones);
                var studentId = await _userRepository.GitLoggingUserId();
                if (subjects != null && teachersId != null && studentId != null)
                {
                    _enrollmentRepository.NewEnrollment(studentId, teachersId);
                    return RedirectToAction("Get_Payment");
                }
                return RedirectToAction("Student_Register");
            }
            else
                return RedirectToAction("Student_Register");
        }

        #endregion

        #region Payment

        [HttpGet]
        public async Task<IActionResult> Get_Payment()
        {
            var Id = await _userRepository.GitLoggingUserId();
            if (Id != null)
            {
                var student = await _studentRepository.GetStudentById(Id);
                if (student != null)
                {
                    var studentSubjects = await _enrollmentRepository.GitEnrollmentSubjects(Id);
                    var subjectNo = studentSubjects.Count();

                    if (student.Grade == "أولى ثانوي" & subjectNo > 4)
                    {
                        ViewBag.Total = 100;
                    }
                    else if (student.Grade == "أولى ثانوي" & subjectNo <= 4)
                    {
                        ViewBag.Total = subjectNo * 25;
                    }
                    else if (student.Grade == "ثانية ثانوي" & subjectNo > 4)
                    {
                        ViewBag.Total = 150;
                    }
                    else if (student.Grade == "ثانية ثانوي" & subjectNo <= 4)
                    {
                        ViewBag.Total = subjectNo * 35;
                    }
                    else if (student.Grade == "ثالثة ثانوي" & subjectNo > 4)
                    {
                        ViewBag.Total = 200;
                    }
                    else if (student.Grade == "ثالثة ثانوي" & subjectNo <= 4)
                    {
                        ViewBag.Total = subjectNo * 50;
                    }


                    ViewBag.Subjects = studentSubjects;
                    ViewBag.Pachnum = subjectNo;
                    return View();
                }

            }
            return RedirectToPage("Login");
        }

        #endregion

        #endregion


        #region Teacher Register

        [HttpGet]
        public IActionResult Teacher_Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Teacher_Register(Teacher_Register_VM model)
        {

                if (ModelState.IsValid)
                {
                    bool excest = _userRepository.CheckUser(model.Phone + "@gmail.com");
                    if (excest == true)
                    {
                        TempData["TeacherExcet"] = "موجود بالفعل";
                        return View();
                    }
                    var user = new IdentityUser
                    {
                        UserName = model.Phone + "@gmail.com",
                        Email = model.Phone + "@gmail.com",
                        PhoneNumber = model.Phone
                    };


                    if (model.Password == model.ConfirmPassword)
                    {
                        var result = await _userManager.CreateAsync(user, model.Password);
                        if (result.Succeeded)
                        {

                            await _signInManager.SignInAsync(user, true);

                            Claim claim = new Claim("Teacher", "Teacher");
                            await _userManager.AddClaimAsync(user, claim);

                            await _teacherRepository.CreateNewTeacher(model,user.Id);

                            _userRepository.ConfirmEmail(user.Id);

                            if (user.Id != null)
                            {
                                TempData["SuccessMessage"] = "تمت العملية بنجاح!";
                                _logger.LogInformation("User created a new account with password.");
                                return RedirectToAction("Index","Admin");
                            }

                            TempData["ErrorMessage"] = "حدثت مشكلة أثناء التحقق من الهوية .";
                            return View(model);
                        }
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                    }
                    TempData["ErrorMessage"] = "كلمة المرور غير متطابقة.";
                }
                TempData["TeacherExcet"] = "حدثت مشكلة أثناء التحقق من الهوية";
                return View(model);
        }

        #endregion


        #region Pending Account

        [HttpPost]
        public async Task<IActionResult> PendingAccount(Id_VM model)
        {
            await _userRepository.PendingUser(model.Id);

            return RedirectToAction("StudentList", "Admin");
        }

        #endregion


        #region Activing Account

        [HttpPost]
        public async Task<IActionResult> ActivingAccount(Id_VM model)
        {
            await _userRepository.ActivingUser(model.Id);

            return RedirectToAction("StudentList", "Admin");
        }

        #endregion

    }
}
