/* The statement of the problem:
   Write an if statement that examines two integer
   variables and exchanges their values if the first one
   is greater than the second one.
*/

// Here we want from the user to enter two numbers.
var firstNumber = Number(window.prompt("Please enter a number", ""));
var secondNumber = Number(window.prompt("Hello again user! Now please enter a second number", ""));

console.log("x = " + firstNumber);
console.log("y = " + secondNumber);

/* Firstly with if statement we check if the first number is bigger than the second one.
   After that we exchange their values with a variable.
*/
if (firstNumber > secondNumber) {
    var middleNumber = firstNumber;
    firstNumber = secondNumber;
    secondNumber = middleNumber;
    console.log("x = " + firstNumber);
    console.log("y = " + secondNumber);
}
