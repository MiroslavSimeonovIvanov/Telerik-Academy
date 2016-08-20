/* The statement of the problem:
   Write a function that by a given array of students
   finds the student with highest marks.
*/

(function () {
  'use strict';

  var students = [
    {name: "Warren Worthington", mark: 3},
    {name: "Hank McCoy", mark: 6},
    {name: "Scot Summers", mark: 5},
    {name: "Bobby Drake", mark: 6},
    {name: "Jean Grey", mark: 6},
    {name: "Illyana Rasputina", mark: 5}
  ];

  var requiredStudents = _.max(students, function () {
    for (var index = 0; index <= students.length; index++) {
      if (students[index].mark === 6) {
        console.log(students[index].name);
      }
    }
  });
}());
