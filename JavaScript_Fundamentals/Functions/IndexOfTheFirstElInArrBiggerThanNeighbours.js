/* The statement of the problem:
   Write a function that returns the index of the first
   element in array that is bigger than its neighbours, or
   -1, if there's no such element.
    - Use the function from the previous exercise.
*/

var arrayOfIntNums = new Array(10);

// Reading the input data.
for (var index = 0; index < arrayOfIntNums.length; index++) {
    arrayOfIntNums[index] = Number(window.prompt("Hello Sir/Madame! Would you mind entering the elements of the array", ""));
}

// Using the same function from the previous exercise but with return statements.
function isElementBiggerThanItsNeighbours(arrayOfIntNums) {
    for (var index = 0; index < arrayOfIntNums.length; index++) {
        if ((arrayOfIntNums[index - 1] < arrayOfIntNums[index]) && (arrayOfIntNums[index] > arrayOfIntNums[index + 1])) {
            return index;
        }
    }
    return -1;
}

// Calling the function.
isElementBiggerThanItsNeighbours(arrayOfIntNums);

// Print the result.
console.log(isElementBiggerThanItsNeighbours(arrayOfIntNums));
