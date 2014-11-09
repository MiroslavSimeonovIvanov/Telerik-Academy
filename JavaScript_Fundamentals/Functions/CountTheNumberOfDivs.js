/* The statement of the problem:
   Write a function to count the number of divs on the
   web page.
*/

function countingDivs() {
    var divElements = document.getElementsByTagName("div");
    var number = divElements.length;
    console.log("Hello user! The number of all divs in the current web page is " + number + ".");
}
