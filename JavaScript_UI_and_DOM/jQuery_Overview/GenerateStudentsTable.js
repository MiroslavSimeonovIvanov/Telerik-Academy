/* The statement of the problem:
   By given an array of students, generate a table that
   represents these students.
    - Each student has first name, last name and grade.
    - Use jQuery.
*/

// Here we create the function with which we will generate the table.
$(document).ready(function () {
    $("body").append("<table></table>");

    $("<tr></tr>").appendTo("table");
    $("<th>First name</th>").appendTo("tr");
    $("<th>Last name</th>").appendTo("tr");
    $("<th>Grade</th>").appendTo("tr");

    $("<tr id=firstRow></tr>").appendTo("table");
    $("<td>Peter</td>").appendTo("#firstRow");
    $("<td>Ivanov</td>").appendTo("#firstRow");
    $("<td>3</td>").appendTo("#firstRow");

    $("<tr id=secondRow></tr>").appendTo("table");
    $("<td>Milena</td>").appendTo("#secondRow");
    $("<td>Grigorova</td>").appendTo("#secondRow");
    $("<td>6</td>").appendTo("#secondRow");

    $("<tr id=thirdRow></tr>").appendTo("table");
    $("<td>Gergana</td>").appendTo("#thirdRow");
    $("<td>Borisova</td>").appendTo("#thirdRow");
    $("<td>12</td>").appendTo("#thirdRow");

    $("<tr id=fourthRow></tr>").appendTo("table");
    $("<td>Boyko</td>").appendTo("#fourthRow");
    $("<td>Petrov</td>").appendTo("#fourthRow");
    $("<td>7</td>").appendTo("#fourthRow");

    $("table").css("border", "1.5px solid black")
        .css("border-collapse", "collapse");
    $("th").css("border", "1.5px solid black")
        .css("padding", "5px");
    $("td").css("border", "1.5px solid black")
        .css("padding", "5px");
});
