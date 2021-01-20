
function calcGrade() {
    var assignments = document.getElementById("assignments").value * 0.50;
    var groupprojects = document.getElementById("groupprojects").value * 0.10;
    var quizzes = document.getElementById("quizzes").value * 0.10;
    var exams = document.getElementById("exams").value * 0.20;
    var intex = document.getElementById("intex").value * 0.10;

    var finalGrade = assignments + groupprojects + quizzes + exams + intex;
    finalGrade = finalGrade.toFixed(2)

    if (finalGrade >= 90) {
        letterGrade = "A"
    }
    else if (finalGrade >= 80) {
        letterGrade = "B"
    }
    else if (finalGrade >= 70) {
        letterGrade = "C"
    }
    else if (finalGrade >= 60) {
        letterGrade = "D"
    }
    else if (finalGrade >= 50) {
        letterGrade = "F"
    }
    else {
        letterGrade = "E"
    }

    alert("Final grade: " + finalGrade + "% (" + letterGrade + ")");
}