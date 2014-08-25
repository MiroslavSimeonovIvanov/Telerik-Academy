/* The statement of the problem:
   Write an expression that checks for given point (x, y)
   if it is within the circle K((1,1), 3) and out of the
   rectangle R(top=1, left=-1, width=6, height=2).
*/

// Here we want from the user to enter the abscissa and the ordinate of the point.
var pointX = Number(window.prompt("Please enter the abscissa", ""));
var pointY = Number(window.prompt("Now please enter the ordinate", ""));

// Checking if the point is within the circle and outside the rectangle.
var isInCircle = Math.sqrt(pointX * pointX + pointY * pointY) <= 3;
var isOutsideRectangle = pointX < 1 || pointX > 6 || pointY < -1 || pointY > 2;
var isInCircleAndOutsideRectangle = isInCircle && isOutsideRectangle;

// Printing the result.
if (isInCircleAndOutsideRectangle) {
    console.log("The point you have entered is within the circle and outside of the rectangle.");
}
else {
    console.log("The point you have entered is outside the circle and within the rectangle.");
}
