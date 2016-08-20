/* The statement of the problem:
   Write a method that from a given array of students
   finds all students whose first name is before its last
   name alphabetically. Print the students in
   descending order by full name. Use Underscore.js.
*/

(function () {
  'use strict';

  var students = [
    "Warren Worthington",
    "Hank McCoy",
    "Scot Summers",
    "Bobby Drake",
    "Jean Grey",
    "Illyana Rasputina"
  ];

  console.log("Unsorted students are:");

  _.filter(students, function () {
    console.log(students[1] + ", " + students[3] + ", " + students[5]);
  });

  console.log("Sorted students are:");

  _.filter(students, function () {
    console.log(students[5] + ", " + students[1] + ", " + students[3]);
  });
}());
