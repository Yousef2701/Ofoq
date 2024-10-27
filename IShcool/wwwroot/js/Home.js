document.querySelectorAll("#faqContainer").forEach((ele) => {
    ele.onclick = () => {
        ele.classList.toggle("paused");
    };
});
function scrollContent(direction) {
    var scrollStep = 300; // Set your scroll step value
    var content = document.getElementById("content");

    if (direction === "right") {
        content.scrollLeft += scrollStep;
    } else if (direction === "left") {
        content.scrollLeft -= scrollStep;
    }
}

window.onscroll = () => {
    const triggerBottom = window.innerHeight / 5 * 4;

    const mainCircleTop = document.querySelector(".main-circle").getBoundingClientRect().top;
    if (mainCircleTop < triggerBottom) {
        document.querySelector(".main-circle").style.opacity = "1";
        if (window.innerWidth > 786) {
            document.querySelector(".main-circle").style.transform = "rotate(0deg) translate(-50%, -50%) rotate(-360deg)";
            document.querySelector(".feature-circle1").style.transform = "rotate(60deg) translate(-250px) rotate(-60deg)";
            document.querySelector(".feature-circle2").style.transform = "rotate(120deg) translate(-250px) rotate(-120deg)";
            document.querySelector(".feature-circle3").style.transform = "rotate(180deg) translate(-250px) rotate(-180deg)";
            document.querySelector(".feature-circle4").style.transform = "rotate(240deg) translate(-250px) rotate(-240deg)";
            document.querySelector(".feature-circle5").style.transform = "rotate(300deg) translate(-250px) rotate(-300deg)";
            document.querySelector(".feature-circle6").style.transform = "rotate(360deg) translate(-250px) rotate(-360deg)";
        } else {
            document.querySelector(".main-circle").style.transform = "rotate(0deg) translate(-50%, -50%) rotate(-360deg)";
            document.querySelector(".feature-circle1").style.transform = "rotate(60deg) translate(-150px) rotate(-60deg)";
            document.querySelector(".feature-circle2").style.transform = "rotate(120deg) translate(-150px) rotate(-120deg)";
            document.querySelector(".feature-circle3").style.transform = "rotate(180deg) translate(-150px) rotate(-180deg)";
            document.querySelector(".feature-circle4").style.transform = "rotate(240deg) translate(-150px) rotate(-240deg)";
            document.querySelector(".feature-circle5").style.transform = "rotate(300deg) translate(-150px) rotate(-300deg)";
            document.querySelector(".feature-circle6").style.transform = "rotate(360deg) translate(-150px) rotate(-360deg)";
        }
    } else {
        document.querySelector(".main-circle").style.opacity = "0";
        document.querySelector(".main-circle").style.transform = "rotate(0deg) translate(-50%, -50%) rotate(0deg)";
        document.querySelector(".feature-circle1").style.transform = "rotate(120deg) translate(-900px) rotate(-120deg)";
        document.querySelector(".feature-circle2").style.transform = "rotate(180deg) translate(-900px) rotate(-180deg)";
        document.querySelector(".feature-circle3").style.transform = "rotate(240deg) translate(-900px) rotate(-240deg)";
        document.querySelector(".feature-circle4").style.transform = "rotate(300deg) translate(-900px) rotate(-300deg)";
        document.querySelector(".feature-circle5").style.transform = "rotate(360deg) translate(-900px) rotate(-360deg)";
        document.querySelector(".feature-circle6").style.transform = "rotate(420deg) translate(-900px) rotate(-420deg)";
    }
    if (this.innerWidth > 786) {

    }

}