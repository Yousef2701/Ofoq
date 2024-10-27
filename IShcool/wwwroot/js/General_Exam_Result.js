// Sample JSON object (replace with your actual data)
console.log(document.getElementById("data").textContent);
var examData = JSON.parse(document.getElementById("data").textContent);
//console.log(JSON.stringify(examData));
var correct = 0;

// Function to generate HTML based on the exam data
function generateExamHTML(data) {
    var questionsContainer = document.getElementById("questions-container");

    data.forEach(function (q, index) {
        var questionDiv = document.createElement("div");
        questionDiv.classList.add("question-container");

        var questionHeading = document.createElement("h3");
        questionHeading.textContent = "السؤال " + (index + 1) + ":";
        questionDiv.appendChild(questionHeading);

        var questionText = document.createElement("p");
        questionText.textContent = q.question;
        questionDiv.appendChild(questionText);

        var choicesList = document.createElement("ul");

        q.choices.forEach(function (choice, choiceIndex) {
            var choiceItem = document.createElement("li");

            if (
                choiceIndex === q.correctAnswer &&
                choiceIndex === q.studentAnswer
            ) {
                choiceItem.classList.add("correct-answer");
                correct++;
            } else if (
                choiceIndex === q.correctAnswer &&
                choiceIndex !== q.studentAnswer
            ) {
                choiceItem.classList.add("selected-answer");
            } else if (choiceIndex === q.studentAnswer) {
                choiceItem.classList.add("wrong-answer");
            }
            if (q.QuestType == "true") {
                var img = document.createElement("img");
                img.src = "/AnswersImages/" + choice;
                choiceItem.appendChild(img);
                choicesList.appendChild(choiceItem);
                img.parentElement.parentElement.classList.add("active-image");
                img.parentElement.classList.add("answer");
            }
            else {
                choiceItem.textContent = choice;
                choicesList.appendChild(choiceItem);
            }

        });

        questionDiv.appendChild(choicesList);
        questionsContainer.appendChild(questionDiv);
    });
}

// Call the function with the exam data
generateExamHTML(examData);
document.getElementById("degree").textContent = correct + "/" + examData.length;
document.getElementById("correctQuestionsNumber").value = correct;