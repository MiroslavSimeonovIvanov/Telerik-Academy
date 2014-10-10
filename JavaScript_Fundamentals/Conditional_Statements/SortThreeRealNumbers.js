/* The statement of the problem:
   Sort 3 real values in descending order using nested if
   statements.
*/

// Here we want from the user to enter three real numbers.
var firstNumber = Number(window.prompt("User please type a number", ""));
var secondNumber = Number(window.prompt("OK! Now please type a second number", ""));
var thirdNumber = Number(window.prompt("I'm really sorry but I need one last third number", ""));

// With nested if statements we cover all combinations and finally we print the result.
if (firstNumber < secondNumber && firstNumber < thirdNumber) {
    if (secondNumber > firstNumber && secondNumber < thirdNumber) {
        if (thirdNumber > firstNumber && thirdNumber > secondNumber) {
            console.log(thirdNumber + ", " + secondNumber + ", " + firstNumber);
        }
    }
    else {
        console.log(secondNumber + ", " + thirdNumber + ", " + firstNumber);
    }
}

if (firstNumber > secondNumber && firstNumber < thirdNumber) {
    if (secondNumber < firstNumber && secondNumber < thirdNumber) {
        if (thirdNumber > firstNumber && thirdNumber > secondNumber) {
            console.log(thirdNumber + ", " + firstNumber + ", " + secondNumber);
        }
    }
}
else if (firstNumber < secondNumber && firstNumber > thirdNumber) {
    if (secondNumber > firstNumber && secondNumber > thirdNumber) {
        if (thirdNumber < firstNumber && thirdNumber < secondNumber) {
            console.log(secondNumber + ", " + firstNumber + ", " + thirdNumber);
        }
    }
}

if (firstNumber > secondNumber && firstNumber > thirdNumber) {
    if (secondNumber < firstNumber && secondNumber < thirdNumber) {
        if (thirdNumber < firstNumber && thirdNumber > secondNumber) {
            console.log(firstNumber + ", " + thirdNumber + ", " + secondNumber);
        }
    }
    else {
        console.log(firstNumber + ", " + secondNumber + ", " + thirdNumber);
    }
}
