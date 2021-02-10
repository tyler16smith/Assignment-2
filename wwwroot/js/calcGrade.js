// Calculate the final grade
$("#submitBtn").click(function () {
    
    // Collect inputs & calculate weights
    var assignments = $("#Assignments").val() * 0.50;
    var groupprojects = $("#Groupprojects").val() * 0.10;
    var quizzes = $("#Quizzes").val() * 0.10;
    var exams = $("#Exams").val() * 0.20;
    var intex = $("#Intex").val() * 0.10;

    var finalGrade = assignments + groupprojects + quizzes + exams + intex;
    finalGrade = finalGrade.toFixed(2);

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

    // Alert the final grade
    alert("Final grade: " + finalGrade + "% (" + letterGrade + ")");
})