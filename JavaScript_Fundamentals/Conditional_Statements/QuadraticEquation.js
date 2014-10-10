/* The statement of the problem:
   Write a script that enters the coefficients a, b and c
   of a quadratic equation
   a*x^2 + b*x + c = 0
   and calculates and prints its real roots. Note that
   quadratic equations may have 0, 1 or 2 real roots.
*/

console.log("------ Quadratic equation ------");

// In the next rows we want the user to enter the quadratic coefficients a, b and c.
var coefficientA = Number(window.prompt("a = "));
var coefficientB = Number(window.prompt("b = "));
var coefficientC = Number(window.prompt("c = "));

// Here we calculate the discriminant and x, x1, x2.
var discriminantD = (coefficientB * coefficientB) - (4 * coefficientA * coefficientC);
var rootX = (-coefficientB) / (2 * coefficientA);
var rootX1 = (-coefficientB + Math.sqrt(discriminantD)) / (2 * coefficientA);
var rootX2 = (-coefficientB - Math.sqrt(discriminantD)) / (2 * coefficientA);

// With this if statements we cover all cases of the cases of the task.
if (coefficientA === 0) {
    console.log("If a = 0, then the equation is linear, not quadratic.");
}

if (discriminantD > 0) {
    console.log("Discriminant D = " + discriminantD);
    console.log("x1 = " + rootX1);
    console.log("x2 = " + rootX2);
}

if (discriminantD === 0) {
    console.log("x = " + rootX);
}

if (discriminantD < 0) {
    console.log("The discriminant is negative, then there are no real roots.");
}
