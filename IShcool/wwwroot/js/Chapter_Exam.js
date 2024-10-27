if (document.body.classList.contains("chapter-exam")) {
    localStorage.setItem("teacherID2", document.getElementById("teacherID2").value);
    document.getElementById("examTitle").onkeyup = () => {
        localStorage.setItem("examTitle", document.getElementById("examTitle").value);
    }
    document.getElementById("teacherID2").onchange = () => {
        localStorage.setItem("teacherID2", document.getElementById("teacherID2").value);
    }
}
document.getElementById("getExamTitle").value = localStorage.getItem("examTitle");
document.getElementById("getTeacherID2").value = localStorage.getItem("teacherID2");