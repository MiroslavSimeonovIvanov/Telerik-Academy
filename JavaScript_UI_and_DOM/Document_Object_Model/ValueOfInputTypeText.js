/* The statement of the problem:
   Create a function that gets the value of <input
   type="text" /> and prints its value to the console. 
*/

function getValueOfInputTypeText() {
    var inputTypeText = document.getElementById("text").value;
    document.getElementById("result").innerHTML = inputTypeText;
}
