/* The statement of the problem:
   Write an expression that checks for given integer if
   its third digit (right-to-left) is 7.
   E.g. 1732  true.
*/

// Read the input number.
var number = Number(window.prompt("User please enter a number", ""));

// Here we trim the number and the result is the third bit.
var floatingNumber = (number % 1000) * 0.01;
var result = parseInt(floatingNumber);

if (result === 7) {
    console.log(true);
}
else {
    console.log(false);
}
