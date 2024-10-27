//let questions = document.getElementById("getQuestion").textContent.split(",");
//let answers = document.getElementById("getAnswers").textContent.split("&&");
//let QuesType = document.getElementById("QuesType").textContent.split(",");
//let numberOfQuestions = questions.length;
//document.getElementById("showQuestion").textContent = questions[0];
//let fourAnswers = document.querySelectorAll(".answer label");
//let fourImgAnswers = document.querySelectorAll(".answer img");
//for (let i = 0; i < 3; i++) {
//    let text = answers[0].split(",")[i];
//    if (QuesType[0].toString().trim() == "true") {
//        fourImgAnswers[i].src = "/AnswersImages/" + text.toString().trim();
//        fourAnswers[i].textContent = text.toString().trim();
//        fourAnswers.forEach(ele => { ele.style.display = "none" });
//        fourImgAnswers.forEach(ele => { ele.style.display = "block" });
//        document.querySelector(".answers-area").classList.add("active-image");
//    }
//    else {
//        fourAnswers[i].textContent = text;
//        fourAnswers.forEach(ele => { ele.style.display = "block" });
//        fourImgAnswers.forEach(ele => { ele.style.display = "none" });
//        document.querySelector(".answers-area").classList.remove("active-image");
//    }

//}
//let questionNumber = 1;
//let check = 0;
//let notchecked = 0;
////the time of the exam
//let minutes = document.getElementById("getTime").textContent;
//let seconds = 0;
//let timer = setInterval(() => {
//    seconds--;
//    if (seconds === -1) {
//        minutes--;
//        seconds = 59;
//    }
//    document.getElementById("minutes").textContent = minutes;
//    document.getElementById("seconds").textContent = seconds;
//    if (minutes === 0 && seconds === 0) {
//        document.getElementById("next").style.backgroundColor = "#FFD700";
//        document.getElementById("next").setAttribute("type", "submit");
//        document.getElementById("next").textContent = "انهاء الامتحان";
//        document
//            .getElementById("minutes")
//            .parentElement.classList.add("d-none");
//        document.getElementById("next").parentElement.submit();
//    }
//}, 1000);
//window.onload = () => {
//    document.getElementById("spans").children[0].classList.add("on");
//};
//for (let i = 0; i < numberOfQuestions; i++) {
//    const span = document.createElement("span");
//    document.getElementById("spans").appendChild(span);
//}
//document.querySelectorAll(".answer").forEach((ele) => {
//    ele.onclick = () => {
//        ele.children[0].click();
//    };
//});
//document.querySelectorAll("input").forEach((ele) => {
//    ele.onclick = () => {
//        document.querySelectorAll("input").forEach((element) => {
//            element.parentElement.style.backgroundColor = "var(--main-color)";
//        });
//        ele.parentElement.style.backgroundColor = "var(--yellow-color)";
//    };
//});
//document.getElementById("next").onclick = () => {
//    document.querySelectorAll(".input").forEach((element) => {
//        if (element.checked === true) {
//            check++;
//            if (check === questionNumber) {
//                if (questionNumber === numberOfQuestions - 1) {
//                    document.getElementById("next").style.backgroundColor =
//                        "#FFD700";
//                    document.getElementById("next").textContent = "انهاء الامتحان";
//                }

//                document.querySelectorAll(".answer").forEach((element) => {
//                    if (
//                        element.style.backgroundColor === "var(--yellow-color)" ||
//                        element.style.backgroundColor === "#FFD700"
//                    ) {
//                        if (questionNumber === 1) {
//                            document.getElementById("storedData").value +=
//                                element.lastElementChild.textContent;
//                        } else {
//                            document.getElementById("storedData").value +=
//                                "," + element.lastElementChild.textContent;
//                        }
//                    }
//                });
//                if (questionNumber === numberOfQuestions) {
//                    document.getElementById("submit").click();
//                }
//                questionNumber++;
//                document.getElementById("questionNumber").textContent =
//                    questionNumber;
//                document.getElementById("showQuestion").textContent =
//                    questions[questionNumber - 1];
//                for (let i = 0; i < 3; i++) {
//                    let text = answers[questionNumber - 1].split(",")[i];
//                    if (QuesType[questionNumber - 1].toString().trim() == "true") {
//                        fourImgAnswers[i].src = "/AnswersImages/" + text.toString().trim();
//                        fourAnswers[i].textContent = text.toString().trim();
//                        fourAnswers.forEach(ele => { ele.style.display = "none" });
//                        fourImgAnswers.forEach(ele => { ele.style.display = "block" });
//                        document.querySelector(".answers-area").classList.add("active-image");
//                    }
//                    else {
//                        fourAnswers[i].textContent = text;
//                        fourAnswers.forEach(ele => { ele.style.display = "block" });
//                        fourImgAnswers.forEach(ele => { ele.style.display = "none" });
//                        document.querySelector(".answers-area").classList.remove("active-image");
//                    }

//                }
//                for (let i = 0; i < questionNumber; i++) {
//                    document
//                        .getElementById("spans")
//                        .children[i].classList.add("on");
//                }
//                document.querySelectorAll("input").forEach((element) => {
//                    element.parentElement.style.backgroundColor = "#1E1D1A";
//                    element.checked = false;
//                });
//            }
//        } else {
//            notchecked++;
//            if (notchecked === 3) {
//                alert("Please select an answer.");
//            }
//        }
//    });
//    notchecked = 0;
//};

let answers = [];
let minutes = document.getElementById("getTime").textContent;
let seconds = 0;
let timer = setInterval(() => {
    seconds--;
    if (seconds === -1) {
        minutes--;
        seconds = 59;
    }
    document.getElementById("minutes").textContent = minutes;
    document.getElementById("seconds").textContent = seconds;
    if (minutes === 0 && seconds === 1 || minutes < 0) {
        document.getElementById("submit").click();
    }
}, 1000);
document.querySelectorAll("input[type=radio]").forEach(e => {
    e.onchange = () => {
        e.parentElement.querySelectorAll("label").forEach(ele => {
            ele.style.backgroundColor = "#1E1D1A";
        })
        if (e.checked == true) {
            e.nextElementSibling.style.backgroundColor = "#FFD700";
        }
    }
})
document.getElementById("submitForm").onsubmit = () => {
    document.querySelectorAll("input[type=radio]").forEach(e => {
        if (e.checked == true) {
            answers.push(e.id.substring(e.id.length - 1, e.id.length));
        }
    })
    document.getElementById("storedData").value = answers;
}


