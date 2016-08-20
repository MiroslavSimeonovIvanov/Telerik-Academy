/* The statement of the problem:
   Write function that finds the first name and last
   name of all students with age between 18 and 24.
   Use Underscore.js.
*/

(function () {
  'use strict';

  var students = [
    {name: "Warren Worthington", age: 33},
    {name: "Hank McCoy", age: 40},
    {name: "Scot Summers", age: 25},
    {name: "Bobby Drake", age: 24},
    {name: "Jean Grey", age: 25},
    {name: "Illyana Rasputina", age: 20}
  ];

  var requiredStudents = _.filter(students, function () {
    for (var index = 0; index <= students.length; index++) {
      if (students[index].age >= 18 && students[index].age <= 24) {
        console.log(students[index].name);
      }
    }
  });
}());
