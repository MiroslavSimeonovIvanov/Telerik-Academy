/* The statement of the problem:
   Write functions working with shapes in standard
   Planar coordinate system.
    - Points are represented by coordinates P(X, Y)
    - Lines are represented by two points, marking their
    begginning and ending
        - L(P1(X1, Y1), P2(X2, Y2))
    - Calculate the distance between two points
    - Check if three segment lines can form a triangle
*/

// Reading the input data.
var pointXOne = Number(window.prompt("x1 = ", ""));
var pointYOne = Number(window.prompt("y1 = ", ""));

var pointXTwo = Number(window.prompt("x2 = ", ""));
var pointYTwo = Number(window.prompt("y2 = ", ""));

function cartesianCoordinateSystem(x1, y1, x2, y2) {
    var calcDisBetweenTwoPoints = Math.sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
    console.log(calcDisBetweenTwoPoints);
}

// Calling the function and print the result.
cartesianCoordinateSystem(pointXOne, pointYOne, pointXTwo, pointYTwo);
