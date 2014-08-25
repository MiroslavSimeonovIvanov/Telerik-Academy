/* The statement of the problem:
   Write an expression that checks if given positive
   integer number n (n <= 100) is prime.
   E.g. 37 is prime.
*/

// Here we want from the user to enter a positive integer number.
var numberN = Number(window.prompt("Please type a positive integer number", ""));

// Checking whether the number is prime or not.
if (numberN === 2 || numberN === 3 || numberN === 5 || numberN === 7) {
    console.log("Hello, user! The number you have entered - " + numberN + " is prime.");
}
else {
    if (((numberN % 2) !== 0) && ((numberN % 3) !== 0) && ((numberN % 5) !== 0) && ((numberN % 7) !== 0)) {
        console.log("Hello, user! The number you have entered - " + numberN + " is prime.");
    }
    else {
        console.log("Hello, user! The number you have entered - " + numberN + " isn't prime.");
    }
}
