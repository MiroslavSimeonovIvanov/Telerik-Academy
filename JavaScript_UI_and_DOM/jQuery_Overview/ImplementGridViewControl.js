/* The statement of the problem:
   *Implement a GridView control:
    - Rows can be added dynamically;
    - A header row can be added dynamically;
     - Each GridView can have at most one header row;
    - Each row can have a nested GridView;
     - Each GridView can have at most one nested GridView;
*/

$(document).ready(function () {

    // Here we create the function that adds rows dynamically.
    function addRow() {
        var $dynamicRow = $("<tr><td>11</td><td>Misua</td><td>$1.79</td><td>1 - 8 oz pkg</td><td>101</td><td><input type='checkbox' /></td></tr>");
        $dynamicRow.appendTo("tbody");
    }

    $("#AddRow").on("click", addRow);

    // With the following function we add header row dynamically.
    function addHeaderRow() {
        var $dynamicHeaderRow = $("<tr id='FirstPartOfThead'><td colspan='6'><p>Drag a column header and drop it here to group by that column</p></td></tr>");
        $("thead").prepend($dynamicHeaderRow);
    }

    $("#AddHeaderRow").one("click", addHeaderRow);
});
