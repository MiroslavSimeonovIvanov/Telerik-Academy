/* The statement of the problem:
   Write a function that removes all elements with a
   given value.
   var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
   arr.remove(1); // arr = [2, 4, 3, 4, 111, 3, 2, '1'];
    - Attach it to the array type
    - Read about prototype and how to attach methods
*/

var elementToRemove = 1;
var arrayOfIntNums = new Array(13);

for (var index = 0; index < arrayOfIntNums.length; index++) {
    arrayOfIntNums[index] = Number(window.prompt("Hello user! Please enter the elements of the array", ""));
}

console.log(arrayOfIntNums[index]);

function remove(elementToRemove, arrayOfIntNums) {
    this.remove = function () {
        if (elementToRemove === arrayOfIntNums[index]) {
            delete arrayOfIntNums.elementToRemove;
            console.log(arrayOfIntNums[index]);
        }
    }
}

remove(elementToRemove, arrayOfIntNums);
