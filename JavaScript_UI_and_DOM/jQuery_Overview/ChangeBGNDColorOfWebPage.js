/* The statement of the problem:
   Implement functionality to change the background
   color of a web page
    - i.e. select a color from a color picker and set this color
    as the background color of the page;
*/

$(document).ready(function () {

    // Creating the function onButtonClick() which we will use to change the background color.
    function onButtonClick() {
        $("body").css("background-color", "#760000");
    }

    $("button").on("click", onButtonClick);

});
