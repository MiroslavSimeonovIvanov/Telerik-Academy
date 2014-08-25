/* The statement of the problem:
   Write a boolean expression that checks for given
   integer if it can be divided (without remainder) by 7
   and 5 in the same time.
*/

// Here we want from the user to enter a number.
var number = Number(window.prompt("Please enter a number", ""));

// In the next lines we check if the entered from the user number can be divided (without remainder) by 5 and 7 in the same time.
if (number % 35 === 0) {
    console.log("Hello, user! The number, you have entered - " + number + " is divisible by 5 and 7 in the same time.");
}
else {
    console.log("Arghhh! Sorry the number, you have entered - " + number + " isn't divisible by 5 and 7 in the same time.");
}
