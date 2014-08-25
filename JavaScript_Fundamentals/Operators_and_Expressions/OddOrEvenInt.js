/* The statement of the problem:
   Write an expression that checks if given integer
   is odd or even.
*/

// Here we want from the user to enter a number.
var number = Number(window.prompt("Please type a number", ""));

// With if - else statement we check whether the entered from the user number is odd or even.
if (number % 2 === 0) {
    console.log("Hello, user! The number, you have entered - " + number + " is even.");
}
else {
    console.log("Hello, user! The number, you have entered - " + number + " is odd.");
}
