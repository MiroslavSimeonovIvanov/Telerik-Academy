/* The statement of the problem:
   Write script that asks for a digit and depending on
   the input shows the name of that digit (in English)
   using a switch statement.
*/

// Waiting for the user's choice.
var enteredDigit = Number(window.prompt("Please enter a digit", ""));

// Printing the name of the digit that the user entered.
switch (enteredDigit) {
    case 0: console.log("zero")
        break;
    case 1: console.log("one")
        break;
    case 2: console.log("two")
        break;
    case 3: console.log("three")
        break;
    case 4: console.log("four")
        break;
    case 5: console.log("five")
        break;
    case 6: console.log("six")
        break;
    case 7: console.log("seven")
        break;
    case 8: console.log("eight")
        break;
    case 9: console.log("nine")
        break;
    default:
        console.log("ERROR!!!")
        break;
}
