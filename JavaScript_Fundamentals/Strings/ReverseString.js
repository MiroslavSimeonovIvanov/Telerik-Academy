/* The statement of the problem:
   Write a JavaScript function reverses string and
   returns it.
   Example: "sample"  "elpmas"
*/

// Reading the input data.
var enteredString = window.prompt("Hello user! Please enter a string", "");

function reverseString(enteredString) {
    var reversedString = enteredString.split("").reverse().join("");
    return reversedString;
}

// Calling the function and print the result.
reverseString(enteredString);

console.log(reverseString(enteredString));
