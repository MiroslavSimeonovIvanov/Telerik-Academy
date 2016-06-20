/* The statement of the problem:
   Create the following using Handlebars.js.
*/

var course,
    courseTemplateHTML,
    courseTemplate;

course = {
    lessons: [{
        number: "0",
        title: "Course Introduction",
        dateOne: "Wed 18:00, 28-May-2014",
        dateTwo: "Thu 14:00, 29-May-2014"
    }, {
        number: "1",
        title: "Document Object Model",
        dateOne: "Wed 18:00, 28-May-2014",
        dateTwo: "Thu 14:00, 29-May-2014"
    }, {
        number: "2",
        title: "HTML5 Canvas",
        dateOne: "Thu 18:00, 29-May-2014",
        dateTwo: "Fri 14:00, 30-May-2014"
    }, {
        number: "3",
        title: "Kinect JS Overview",
        dateOne: "Thu 18:00, 29-May-2014",
        dateTwo: "Fri 14:00, 30-May-2014"
    }, {
        number: "4",
        title: "SVG and RaphaelJS",
        dateOne: "Wed 18:00, 04-Jun-2014",
        dateTwo: "Thu 14:00, 05-Jun-2014"
    }, {
        number: "5",
        title: "Animations with Canvas and SVG",
        dateOne: "Wed 18:00, 04-Jun-2014",
        dateTwo: "Thu 14:00, 05-Jun-2014"
    }, {
        number: "6",
        title: "DOM operations",
        dateOne: "Thu 18:00, 05-Jun-2014",
        dateTwo: "Fri 14:00, 06-Jun-2014"
    }, {
        number: "7",
        title: "Event model",
        dateOne: "Thu 18:00, 05-Jun-2014",
        dateTwo: "Fri 14:00, 06-Jun-2014"
    }, {
        number: "8",
        title: "jQuery overview",
        dateOne: "Wed 18:00, 11-Jun-2014",
        dateTwo: "Thu 14:00, 12-Jun-2014"
    }, {
        number: "9",
        title: "HTML templates",
        dateOne: "Wed 18:00, 11-Jun-2014",
        dateTwo: "Thu 14:00, 12-Jun-2014"
    }, {
        number: "10",
        title: "Exam preparation",
        dateOne: "Thu 18:00, 12-Jun-2014",
        dateTwo: "Fri 14:00, 13-Jun-2014"
    }, {
        number: "11",
        title: "Exam",
        dateOne: "Tue 10:00, 17-Jun-2014",
        dateTwo: "Tue 16:30, 17-Jun-2014"
    }, {
        number: "12",
        title: "Teamwork Defense",
        dateOne: "Thu 10:00, 19-Jun-2014",
        dateTwo: "Thu 10:00, 19-Jun-2014"
    }]
};

courseTemplateHTML = document.getElementById("course-template").innerHTML;
courseTemplate = Handlebars.compile(courseTemplateHTML);
document.getElementById("root").innerHTML = courseTemplate(course);
