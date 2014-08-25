/* The statement of the problem:
   Write an expression that checks if given point(x, y)
   is within a circle K(0, 5).
*/

// Reading the point's coordinates.
var pointX = Number(window.prompt("Please enter the abscissa", ""));
var pointY = Number(window.prompt("Now please enter the ordinate", ""));

// Check if the point is within or outside the circle.
var radius = 5;
if (((pointX * pointX) + (pointY * pointY)) < (radius * radius)) {
    console.log("The point is within the circle.");
}
else {
    console.log("The point is out of the circle.");
}
