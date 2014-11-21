/* The statement of the problem:
   Write a JavaScript function that finds how many
   times a substring is contained in a given text
   (perform case insensitive search).
   Example: The target substring is "in". The text is as
   follows:
   We are living in an yellow submarine. We don't
   have anything else. Inside the submarine is very
   tight. So we are drinking all the day. We will
   move out of it in 5 days.
   The result is: 9.
*/

// Waiting for the user to enter some text.
var subString = 'in';
var text = window.prompt("Hi Sir/Madame! Would you mind entering a text", "");

function countingSubstrInGivenText(subString, text) {
    var counter = 0;

    for (var index = 0; index < text.length; index++) {
        if (text[index] === subString) {
            counter++;
        }
    }
    return counter;
}

// Calling the function.
countingSubstrInGivenText(subString, text);

// Print the result.
console.log(countingSubstrInGivenText(subString, text));
