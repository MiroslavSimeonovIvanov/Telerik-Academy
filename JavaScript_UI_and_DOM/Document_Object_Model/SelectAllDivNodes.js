/* The statement of the problem:
   Write a script that selects all the div nodes that are
   directly inside other div elements.
    - Create a function using querySelectorAll().
    - Create a function using getElementsByTagName().
*/

function selectDivNodes() {
    var wrapper = document.getElementById("wrapper");
    var wrapperParagraphs = wrapper.querySelectorAll("p");
    var number = wrapperParagraphs.length;
    window.alert("All div nodes are " + number + ".");
}

function selectDivNodesTwo() {
    var wrapper = document.getElementById("wrapper");
    var wrapperParagraphs = wrapper.getElementsByTagName("p");
    var number = wrapperParagraphs.length;
    window.alert("All div nodes are " + number + ".");
}
