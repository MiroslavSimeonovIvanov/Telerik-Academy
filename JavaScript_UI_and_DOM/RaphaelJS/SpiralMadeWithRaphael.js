/* The statement of the problem:
   Create a spiral with Raphael.
   * Hint: use many circles with radius 1px
*/

function draw() {
    var paper = Raphael(400, 90, 493, 485);

    // Drawing the spiral.
    var spiral = paper.setStart();
    paper.circle(240, 240, 200);
    paper.circle(240, 260, 180);
    paper.circle(240, 240, 160);
    paper.circle(240, 260, 140);
    paper.circle(240, 240, 120);
    paper.circle(240, 260, 100);
    paper.circle(240, 240, 80);
    paper.circle(240, 260, 60);
    paper.circle(240, 240, 40);
    paper.circle(240, 260, 20);
    paper.circle(240, 250, 10);
    paper.circle(240, 255, 5);
    spiral = paper.setFinish();

    spiral.attr({
        fill: 'transparent',
        stroke: '#000000'
    });
}
