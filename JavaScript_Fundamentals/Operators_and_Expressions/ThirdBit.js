/* The statement of the problem:
   Write a boolean expression for finding if the bit 3
   (counting from 0) of a given integer is 1 or 0.
*/

// Here we want from the user to type a number.
var number = Number(window.prompt("Hello user! Please type a number", ""));
var numberInBinaryType = number.toString(2);

// Print the number in its decimal and binary type.
console.log(number + "(Dec)");
console.log(numberInBinaryType + "(Bin)");

// On the next line we scan for the third bit with the charAt() method.
var thirdBit = numberInBinaryType.charAt(numberInBinaryType.length - 4);
console.log("Search complete. The third bit of the number is " + thirdBit + ".");
