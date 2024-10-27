if (document.body.classList.contains("create-lesson")) {
    localStorage.setItem("teacherID", document.getElementById("teacherID").value);
    document.getElementById("videoUrl").onkeyup = () => {
        localStorage.setItem("videoUrl", document.getElementById("videoUrl").value);
    }
    document.getElementById("teacherID").onchange = () => {
        localStorage.setItem("teacherID", document.getElementById("teacherID").value); 
    }
}
document.getElementById("getVideoUrl").value = localStorage.getItem("videoUrl");
document.getElementById("getTeacherID").value = localStorage.getItem("teacherID");