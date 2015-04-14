/* The statement of the problem:
   Draw a circle that flies inside a box:
    - When it reaches an edge, it should bounce that edge
*/

var canvas = document.getElementById("canvas");
var ctx = canvas.getContext("2d");

var xasp, yasp, maxx, maxy, alpha, key;

function point() {
    var x, y;
}

function ball() {
    var center, radius, color, drctn, speed, step;
    ball.center.x = random(maxx);
    ball.center.y = random(maxy);
    ball.radius = 10;
    ball.step = 10;
    ball.color = random(14) + 1;
    ball.drctn = random(360);
}

function board() {
    var lUCorner, rDCorner, thickness, length, color, drctn, speed, step;
    board.length = 900;
    board.thickness = 5;
    board.lUCorner.x = maxx / 2 - board.length / 2;
    board.lUCorner.y = maxy - board.thickness;
    board.rDCorner.x = board.lUCorner.x + board.length;
    board.rDCorner.y = maxy;
    board.step = 10;
    board.color = 15;
}

function onTouch(k) {
    var i = 0;
    if (k.center.x + k.radius >= maxx) i = 1;
    if ((k.center.x + k.radius >= maxx) && (k.center.y - k.radius <= 0)) i = 2;
    if (k.center.y - k.radius <= 0) i = 3;
    if ((k.center.y - k.radius <= 0) && (k.center.x - k.radius <= 0)) i = 4;
    if (k.center.x - k.radius <= 0) i = 5;
    if ((k.center.x - k.radius <= 0) && (k.center.y + k.radius >= maxy)) i = 6;
    if (k.center.y + k.radius >= maxy) i = 7;
    if ((k.center.x + k.radius >= maxx) && (k.center.y + k.radius >= maxy)) i = 8;
    if ((k.center.y + k.radius >= maxy - b.thickness) &&
       (k.center.x >= b.LUcorner.x) &&
       (k.center.x <= b.RDcorner.x))
        i = 9;
    return i;
}

function random() {
    return Math.random();
}

function draw() {

    do {
        do {
            ctx.stroke(board.color);
            ctx.fill();

            ball.center.x = ball.center.x + ball.step * Math.cos(alpha);
            ball.center.y = ball.center.y - ball.step * Math.sin(alpha);
            if (ball.center.x < 0) {
                ball.center.x = 0;
            }

            if (ball.center.y < 0) {
                ball.center.y = 0;
            }

            switch (onTouch(ball())) {
                case 1: ball.drctn = 180 - ball.drctn; ball.color = random(14) + 1; break;
                case 2: ball.drctn = 180 + ball.drctn; ball.color = random(14) + 1; break;
                case 3: ball.drctn = 360 - ball.drctn; ball.color = random(14) + 1; break;
                case 4: ball.drctn = 180 + ball.drctn; ball.color = random(14) + 1; break;
                case 5: ball.drctn = 180 - ball.drctn; ball.color = random(14) + 1; break;
                case 6: ball.drctn = 180 + ball.drctn; ball.color = random(14) + 1; break;
                case 7: ball.drctn = 360 - ball.drctn; ball.color = random(14) + 1; break;
                case 8: ball.drctn = 180 + ball.drctn; ball.color = random(14) + 1; break;
                case 9: ball.drctn = 360 - ball.drctn; ball.color = random(14) + 1; break;
            }

            while (ball.drctn >= 360) {
                ball.drctn = ball.drctn - 360;
            }

            while (ball.drctn < 0) {
                ball.drctn = ball.drctn + 360;
            }

            alpha = ball.drctn * 2 * Math.PI() / 360;

            if (key === 75) {
                if (board.lUCorner.x > 0) {
                    board.lUCorner.x = board.lUCorner.x - board.step;
                    board.rDCorner.x = board.lUCorner.x + board.length;
                    key = 0;
                }
            }

            if (key === 77) {
                if (board.rDCorner.x < maxx) {
                    board.lUCorner.x = board.lUCorner.x + board.step;
                    board.rDCorner.x = board.lUCorner.x + board.length;
                    key = 0;
                }
            }

        } while (!kbhit());

        key = String.fromCharCode();
        if (key === 0) {
            key = String.fromCharCode();
        }

    } while (key != 27);
}
