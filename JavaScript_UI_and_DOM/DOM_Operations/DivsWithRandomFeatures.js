/* The statement of the problem:
   Write a script that creates a number of div elements.
   Each div element must have the following:
   - Random width and height between 20px and 100px
   - Random background color
   - Random font color
   - Random position on the screen (position: absolute)
   - A strong element with text "div" inside the div
   - Random border radius
   - Random border color
   - Random border width between 1px and 20px
*/

// Here we want from the user to enter the number of the divs.
var numberOfDivs = (window.prompt("Hello user! Please enter the number of divs", ""));

// Create function for random generating numbers.
function randomGenerator(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

// This function is for creating the div elements.
function createDivElements(numberOfDivs) {
    for (var counter = 0; counter <= numberOfDivs; counter++) {
        var divElements = document.createElement("div");
    }
}
