/* The statement of the problem:
   Write a script that finds the max and min number
   from a sequence of numbers.
*/

// Reading the length of the sequence.
var sequenceLength = Number(window.prompt("Please enter the length of the sequence", ""));

// Here we declare two variables for the min and max number.
var minNumber = sequenceLength;
var maxNumber = 0;

// Waiting for the user to enter the numbers and after that we find the min and max number.
for (var index = 1; index <= sequenceLength; index++) {
    var number = Number(window.prompt("", ""));

    if (number < minNumber) {
        minNumber = number;
    }

    if (number > maxNumber) {
        maxNumber = number;
    }
}

// Printing the result.
console.log("Sir/Madame the biggest number from the sequence you have entered is " + maxNumber + ".");
console.log("The smallest one is " + minNumber + ".");
