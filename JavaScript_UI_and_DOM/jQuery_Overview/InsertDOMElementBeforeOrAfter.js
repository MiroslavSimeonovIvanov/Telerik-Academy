/* The statement of the problem:
   Using jQuery implement functionality to insert a
   DOM element before or after another element.
*/

// We implement the functionality with the following code.
$(document).ready(function () {
    $("<h2><em>The Flash</em></h2>").insertBefore($("p"));
    $("<p>Despite his speed, Barry can become so obsessed with crime-solving he can still lose track of everything else around him, leaving the fastest man alive constantly running a minute behind.</p>").insertAfter($("p"));
});
