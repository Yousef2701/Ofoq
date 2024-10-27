document.getElementById("getSubjects").value = localStorage.getItem("subjects");
document.querySelectorAll(".videos-container").forEach(element => {
    if (element.children.length > 1) {
        element.querySelectorAll(".card").forEach(ele => {
            ele.onclick = () => {
                element.querySelectorAll(".card").forEach(ele2 => {
                    ele2.classList.remove("active");
                });
                ele.classList.add("active");
                document.getElementById("getTeacherPhone").value = "";
                document.querySelectorAll(".active #teacherPhone").forEach(ele3 => {
                    document.getElementById("getTeacherPhone").value += "," + ele3.textContent;
                });
            };
            element.querySelector(".card").click();
        });
    }
});