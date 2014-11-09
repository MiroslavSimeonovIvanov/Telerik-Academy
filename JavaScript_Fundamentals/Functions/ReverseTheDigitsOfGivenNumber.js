/* The statement of the problem:
   Write a function that reverses the digits of given
   decimal number. Example: 256  652
*/

// Reading the input data.
var enteredNumber = window.prompt("Hello user! Please type a number", "");

// Create the function reverseDigitsOfNumber().
// With methods split(), reverse() and join() we reverse the digits of the given number.
function reverseDigitsOfNumber(enteredNumber) {
    var reversedNumber = enteredNumber.split("").reverse().join("");
    console.log(reversedNumber);
}

// Calling the function and see the result.
reverseDigitsOfNumber(enteredNumber);
