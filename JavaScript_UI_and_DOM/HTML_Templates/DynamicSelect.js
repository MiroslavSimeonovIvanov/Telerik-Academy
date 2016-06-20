/* The statement of the problem:
   Create a dynamic select using Handlebars.js.
    - The options in the select should be generated based on
    a collection of JavaScript objects.
    - Example:
    var items = [{
      value: 1,
      text: 'One'
    }, {
      value: 2,
      text: 'Two'
    }];

    var selectHTML = selectTemplate(items);
*/

var items,
    selectTemplateHTML,
    selectTemplate;

items = [{
    value: 1,
    text: "One"
}, {
    value: 2,
    text: "Two"
}, {
    value: 3,
    text: "Three"
}, {
    value: 4,
    text: "Four"
}, {
    value: 5,
    text: "Five"
}, {
    value: 6,
    text: "Six"
}, {
    value: 7,
    text: "Seven"
}];

selectTemplateHTML = document.getElementById("select-template").innerHTML;
selectTemplate = Handlebars.compile(selectTemplateHTML);
document.getElementById("root").innerHTML = selectTemplate({
    items: items
});
