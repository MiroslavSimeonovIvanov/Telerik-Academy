/* The statement of the problem:
   Write a function that checks if the element at given
   position in given array of integers is bigger than its
   two neighbours (when such exist).
*/

var arrayOfIntNums = new Array(10);

// Here we want from the user to enter the elements of the array.
for (var index = 0; index < arrayOfIntNums.length; index++) {
    arrayOfIntNums[index] = Number(window.prompt("Hello Sir/Madame! Would you mind entering the elements of the array", ""));
}

// Create the function.
function isElementBiggerThanItsNeighbours(arrayOfIntNums) {
    for (var index = 0; index < arrayOfIntNums.length; index++) {
        if ((arrayOfIntNums[index - 1] < arrayOfIntNums[index]) && (arrayOfIntNums[index] > arrayOfIntNums[index + 1])) {
            console.log("Bigger is the element " + arrayOfIntNums[index] + " than the two neighbours " + arrayOfIntNums[index - 1] + " and " + arrayOfIntNums[index + 1] + ".");
        }
    }
}

// Printing the result.
isElementBiggerThanItsNeighbours(arrayOfIntNums);
