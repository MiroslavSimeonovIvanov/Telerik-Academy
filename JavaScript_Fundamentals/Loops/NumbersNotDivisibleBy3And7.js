/* The statement of the problem:
   Write a script that prints all the numbers from 1 to
   N, that are not divisible by 3 and 7 at the same time.
*/

// Here we want from the user to enter N.
var numberN = Number(window.prompt("User please type a number", ""));

/* With for loop we run through all the numbers and if there are numbers that
   aren't divisible by 3 and 7 at the same time then print the result.
*/
for (var numbers = 1; numbers <= numberN; numbers++) {
    if (!(numbers % 3 === 0 && numbers % 7 === 0)) {
        console.log(numbers);
    }
}
