/* The statement of the problem:
   Write a script that finds the greatest of given 5
   variables.
*/

// Reading the input data.
var firstNumber = Number(window.prompt("Hi sir/madame! Would you mind typing a number", ""));
var secondNumber = Number(window.prompt("Nice job! Now please enter second number", ""));
var thirdNumber = Number(window.prompt("Please enter third number", ""));
var fourthNumber = Number(window.prompt("Fourth number is waiting to be entered", ""));
var fifthNumber = Number(window.prompt("I'm really sorry but I need one last number", ""));

// We use Math.max() method to find the greatest number.
var biggestNumber = Math.max(firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);

console.log("From all numbers that you have entered the biggest one is " + biggestNumber + ".");
