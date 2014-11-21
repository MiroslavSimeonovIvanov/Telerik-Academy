/* The statement of the problem:
   Write a JavaScript function to check if in given
   expression the brackets are put correctly.
   Example of correct expression: ((a + b)/ 5 - d).
   Example of incorrect expression: )(a + b)).
*/

// Here we want from the user to enter an expression.
var expression = window.prompt("User please type an expression", "");

function areBracketsPutCorrectly(expression) {
    for (var index = 0; index < expression.length; index++) {
        if ((expression[index] === ')') < (expression[index] === ')')) {
            console.log("Incorrect!!!");
        }
        else {
            console.log("Correct!");
        }
    }
}

// Calling the function and print the result.
areBracketsPutCorrectly(expression);
