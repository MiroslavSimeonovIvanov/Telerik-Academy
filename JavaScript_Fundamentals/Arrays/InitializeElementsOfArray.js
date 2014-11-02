/* The statement of the problem:
   Write a script that allocates array of 20 integers and
   initializes each element by its index multiplied by 5.
   Print the obtained array on the console.
*/

// Creating the array.
var intNumbersArray = new Array(20);

// With for loop we initialize the elements of the array by multiplying their indexes by 5.
for (var index = 0; index < intNumbersArray.length; index++) {
    intNumbersArray[index] = index * 5;
    console.log(intNumbersArray[index]);
}
