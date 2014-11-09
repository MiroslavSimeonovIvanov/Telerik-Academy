/* The statement of the problem:
   Write a function that counts how many times given
   number appears in given array. Write a test function
   to check if the function is working correctly.
*/

// Reading the input data.
var number = Number(window.prompt("User please enter a number", ""));
var arrayOfNumbers = new Array(20);

for (var index = 0; index < arrayOfNumbers.length; index++) {
    arrayOfNumbers[index] = Number(window.prompt("OK! Now please type the elements of the array", ""));
}

// Here we create the function that counts how many times given number appears in given array.
function countingNumAppearanceInArray(number, arrayOfNumbers) {
    var counter = 0;
    for (var index = 0; index < arrayOfNumbers.length; index++) {
        if (number === arrayOfNumbers[index]) {
            counter++;
        }
    }
    console.log("Nice! The number you have entered is appearing " + counter + " times in the array.");
}

// Calling the function and print the result.
countingNumAppearanceInArray(number, arrayOfNumbers);
