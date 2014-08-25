/* The statement of the problem:
   Write an expression that calculates rectangle's area
   by given width and height.
*/

// Reading the width and the height of the rectangle.
var rectangleWidth = Number(window.prompt("Please enter the width of the rectangle", ""));
var rectangleHeight = Number(window.prompt("Now please enter the height of the rectangle", ""));

// Calculating the area of the rectangle.
var areaOfRectangle = rectangleWidth * rectangleHeight;

// Printing the result.
console.log("width = " + rectangleWidth);
console.log("height = " + rectangleHeight);
console.log("Area = ?");
console.log("----------");
console.log("Area = " + areaOfRectangle);
