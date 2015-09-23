/* The statement of the problem:
   Create the following images using Raphael.
*/

function draw() {
    var paper = Raphael(5, 5, 579, 426);

    // Firstly we draw the Telerik's logo.
    var telerikLogo = paper.setStart();
    paper.rect(62, 82, 38.2, 15.5).rotate(-45, 62, 82);
    paper.rect(141, 55, 38.2, 15.5).rotate(45, 141, 55);
    paper.rect(89, 55, 89.1, 15.5).rotate(45, 89, 55);
    paper.rect(78, 118, 89.1, 15.5).rotate(-45, 78, 118);
    paper.rect(89, 107, 52.3, 15.5).rotate(45, 89, 107);
    paper.rect(104, 144, 52.3, 15.5).rotate(-45, 104, 144);
    telerikLogo = paper.setFinish();

    telerikLogo.attr({
        fill: '#5ce600',
        stroke: 'transparent'
    });

    var telerikText = paper.text(350, 108, "Telerik");
    var secondTelerikText = paper.text(383, 180, "Develop experiences");
    var trademarkSymbol = paper.text(529, 105, "®");

    telerikText.attr({
        'font-family': 'Segoe UI',
        'font-size': '105',
        'font-weight': 'bold',
        fill: '#282828'
    });

    secondTelerikText.attr({
        'font-family': 'Segoe UI',
        'font-size': '40',
        'font-weight': 'normal',
        fill: '#282828'
    });

    trademarkSymbol.attr({
        'font-family': 'Segoe UI',
        'font-size': '26.25',
        'font-weight': 'bold',
        fill: '#282828'
    });

    // After that we draw the YouTube's logo.
    var youTubeText = paper.text(165, 325, "You");
    var youTubeLogo = paper.rect(275, 260, 285, 135, 35);
    var secondYouTubeText = paper.text(420, 325, "Tube");

    youTubeText.attr({
        'font-family': 'Tahoma',
        'font-size': '105',
        'font-weight': 'bold',
        fill: '#4b4b4b'
    });

    youTubeLogo.attr({
        fill: '#ec2828',
        stroke: 'transparent'
    });

    secondYouTubeText.attr({
        'font-family': 'Tahoma',
        'font-size': '105',
        'font-weight': 'bold',
        fill: '#ffffff'
    });
}
