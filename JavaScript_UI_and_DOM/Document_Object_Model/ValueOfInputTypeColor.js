/* The statement of the problem:
   Create a function that gets the value of <input
   type="color" /> and sets the background of the body
   to this value.
*/

function getValueOfInputTypeColor() {    
    document.body.style.backgroundColor = document.getElementById("color").value;
}
