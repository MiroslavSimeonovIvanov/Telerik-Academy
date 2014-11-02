/* The statement of the problem:
   Write a script that compares two char arrays
   lexicographically (letter by letter).
*/

// Here we initialize the arrays.
var firstCharArray = ['a', 'b'];
var secondCharArray = ['b', 'b'];

// Comparing the two char arrays with nested for loop.
for (var indexChar = 0; indexChar < firstCharArray.length; indexChar++) {
    for (var secondIndexChar = 0; secondIndexChar < secondCharArray.length; secondIndexChar++) {
        if (firstCharArray[indexChar] === secondCharArray[secondIndexChar]) {
            console.log("Char arrays are equal.");
        }

        if (firstCharArray[indexChar] > secondCharArray[secondIndexChar]) {
            console.log(firstCharArray[indexChar]);
        }
        else {
            console.log(secondCharArray[secondIndexChar]);
        }
    }
}
