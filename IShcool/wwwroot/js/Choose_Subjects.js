document.getElementById("selectAll").onclick = () => {
    document.querySelectorAll(".card").forEach((ele) => {
        if (!ele.classList.contains("active")) {
            ele.click();
        }

    });
};
document.querySelectorAll(".card").forEach((ele) => {
    ele.onclick = () => {
        ele.classList.toggle("active");
        document.getElementById("subject").value = "";
        document.querySelectorAll(".active #subjectName").forEach((ele) => {
            document.getElementById("subject").value += "," + ele.textContent;
            localStorage.setItem(
                "subjects",
                document.getElementById("subject").value
            );
        });
    };
});