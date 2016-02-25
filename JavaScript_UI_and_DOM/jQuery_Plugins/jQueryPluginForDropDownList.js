/* The statement of the problem:
   Create a jQuery plugin for creating dropdown list
   - By given the following:
    <select id="dropdown">
      <option value="1">One</option>
      <option value="2">Two</option>
    </select>
    $('#dropdown').dropdown()
   - Produces the following HTML:
    <select id="dropdown" style="display: none">…</select>
    <div class="dropdown-list-container">
      <ul class="dropdown-list-options">
        <li class="dropdown-list-option" data-value="0">One</li>
        …
      </ul>
    </div>
   - And make it work as SELECT node
    - Selecting an one of the generated LI nodes, selects the
      corresponding OPTION node
      - So $('#dropdown:selected') works
*/

// The plugin for creating dropdown list.
(function ($) {
    $.fn.dropdown = function () {
        var $this = $(this);
        $("option").on("select", function () {
            $this.css("display", "none");
        });
        $("div").appendTo("body")
            .addClass("dropdown-list-container");
        $("ul").appendTo("div")
            .addClass("dropdown-list-options");
        $("li").appendTo("ul")
            .addClass("dropdown-list-option")
            .html("One");
    }
}(jQuery));

$('#dropdown').dropdown();
