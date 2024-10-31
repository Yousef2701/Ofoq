using IShcool.Data;
using IShcool.Interfaces;
using IShcool.IRepo;
using IShcool.Repository;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

builder.Services.Configure<IdentityOptions>(o => {
    o.Password.RequiredLength = 8;
    o.Password.RequiredUniqueChars = 0;
    o.Password.RequireDigit = false;
    o.Password.RequireLowercase = false;
    o.Password.RequireUppercase = false;
    o.Password.RequireNonAlphanumeric = false;
});

builder.Services.AddAuthorization(options =>
    options.AddPolicy("AdminRole", op => op.RequireClaim("Admin", "Admin"))
    );

builder.Services.AddAuthorization(options =>
    options.AddPolicy("TeacherRole", op => op.RequireClaim("Teacher", "Teacher"))
    );

builder.Services.AddAuthorization(options =>
    options.AddPolicy("StudentRole", op => op.RequireClaim("Student", "Student"))
    );

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ISubjectRepository, SubjectRepository>();
builder.Services.AddScoped<ITeacherRepository, TeacherRepository>();
builder.Services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();
builder.Services.AddScoped<IChapterRepository, ChapterRepository>();
builder.Services.AddScoped<ILessonRepository, LessonRepository>();
builder.Services.AddScoped<IQuestionBanqRepository, QuestionBanqRepository>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<ILessonTestRepository, LessonTestRepository>();
builder.Services.AddScoped<IParentRepository, ParentRepository>();
builder.Services.AddScoped<ILoginManagement, LogInManagement>();


//builder.WebHost.ConfigureKestrel(options =>
//{
//    options.Limits.MaxRequestBodySize = 536870912; // 512 MB
//});

//builder.Services.Configure<FormOptions>(options =>
//{
//    options.MultipartBodyLengthLimit = 536870912; // 512 MB
//});

//builder.WebHost.UseKestrel(options =>
//{
//    options.Limits.MaxRequestBodySize = 536870912; // 512 MB
//});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
