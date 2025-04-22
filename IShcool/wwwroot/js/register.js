var data1 = '[{ "name": "الصف الأول الثانوى", "lessons": ["عام"] }, {"name": "الصف الثاني الثانوى","lessons": ["علمي", "أدبي"]}, {"name": "الصف الثالث الثانوى", "lessons": ["أدبي", "علمي علوم","علمي رياضيات"]}]';
var data = JSON.parse(data1);
// Get the lesson select element
var lessonSelect = document.getElementById("lessonSelect");
var Courses = document.getElementById("courseSelect");
// Add course as options in first dropdown list
for (let i = 0; i < data.length; i++) {
    addOption(Courses, data[i].name, data[i].name);
}
// Make the default options in the second dropdown list [first course options]
for (let j = 0; j < data[0].lessons.length; j++) {
    addOption(lessonSelect, data[0].lessons[j], data[0].lessons[j]);
}

function updateLessonOptions() {
    // Get the selected course value
    var selectedCourse = document.getElementById("courseSelect").value;

    // Clear existing options
    lessonSelect.innerHTML = "";
    //Add the New lessons on change course
    for (let i = 0; i < data.length; i++) {
        if (selectedCourse === data[i].name) {
            for (let j = 0; j < data[i].lessons.length; j++) {
                addOption(lessonSelect, data[i].lessons[j], data[i].lessons[j]);
            }
        }
    }
    if (lessonSelect.innerHTML == "") {
        document.getElementById("Department").style.display = "none";

    }
    else {
        document.getElementById("Department").style.display = "block";

    }
}

function addOption(selectElement, value, text) {
    var option = document.createElement("option");
    option.value = value;
    option.text = text;
    selectElement.add(option);
}