/* The statement of the problem:
   Draw the following graphics using canvas.
*/

// Here we create the function draw() with which we will draw on the canvas.
function draw() {
    var canvas = document.getElementById("canvas");
    var ctx = canvas.getContext("2d");

    // Drawing the man.
    ctx.beginPath();
    ctx.arc(250, 238, 45, 0, Math.PI * 2, true);
    ctx.fillStyle = "#8FC9D6";
    ctx.fill();
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.ellipse(240, 260, 6, 18, 30, 0, Math.PI * 2, false);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(240, 225);
    ctx.lineTo(230, 245);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(230, 245);
    ctx.lineTo(240, 245);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.ellipse(223, 225, 7, 5, 0, Math.PI * 2, false);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.ellipse(221, 225, 2, 4, 0, Math.PI * 2, false);
    ctx.fillStyle = "#21535E";
    ctx.fill();
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.ellipse(256, 225, 7, 5, 0, Math.PI * 2, false);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.ellipse(254, 225, 2, 4, 0, Math.PI * 2, false);
    ctx.fillStyle = "#21535E";
    ctx.fill();
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.ellipse(246, 202, 50, 8, 0, 0, Math.PI * 2, true);
    ctx.fillStyle = "#396592";
    ctx.fill();
    ctx.strokeStyle = "#000000";
    ctx.stroke();
    ctx.closePath();

    ctx.fillStyle = "#396592";
    ctx.fillRect(225, 145, 50, 50);
    ctx.strokeStyle = "#000000";
    ctx.strokeRect(225, 145, 50, 50);

    ctx.beginPath();
    ctx.ellipse(250, 145, 25, 8, 0, 0, Math.PI * 2, true);
    ctx.fillStyle = "#396592";
    ctx.fill();
    ctx.strokeStyle = "#000000";
    ctx.stroke();
    ctx.closePath();

    ctx.beginPath();
    ctx.ellipse(250, 194, 25, 8, 0, 0, Math.PI, false);
    ctx.fillStyle = "#396592";
    ctx.fill();
    ctx.strokeStyle = "#000000";
    ctx.stroke();
    ctx.closePath();

    // Drawing the bicycle.
    ctx.beginPath();
    ctx.arc(210, 490, 45, 0, Math.PI * 2, true);
    ctx.fillStyle = "#8FC9D6";
    ctx.fill();
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(210, 490);
    ctx.lineTo(265, 435);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(210, 490);
    ctx.lineTo(285, 490);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(265, 435);
    ctx.lineTo(370, 435);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(285, 490);
    ctx.lineTo(370, 435);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(285, 490);
    ctx.lineTo(257, 415);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(242, 415);
    ctx.lineTo(272, 415);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.arc(285, 490, 10, 0, Math.PI * 2, true);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(279, 483);
    ctx.lineTo(272, 473);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(291, 497);
    ctx.lineTo(298, 507);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.arc(380, 490, 45, 0, Math.PI * 2, true);
    ctx.fillStyle = "#8FC9D6";
    ctx.fill();
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(380, 490);
    ctx.lineTo(365, 405);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(365, 405);
    ctx.lineTo(337, 415);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(365, 405);
    ctx.lineTo(385, 383);
    ctx.strokeStyle = "#21535E";
    ctx.stroke();

    // Drawing the house.
    ctx.fillStyle = "#965A5A";
    ctx.fillRect(550, 230, 225, 170);
    ctx.strokeStyle = "#000000";
    ctx.strokeRect(550, 230, 225, 170);

    ctx.fillStyle = "#000000";
    ctx.fillRect(565, 250, 39, 25);

    ctx.fillStyle = "#000000";
    ctx.fillRect(606, 250, 39, 25);

    ctx.fillStyle = "#000000";
    ctx.fillRect(565, 277, 39, 25);

    ctx.fillStyle = "#000000";
    ctx.fillRect(606, 277, 39, 25);

    ctx.fillStyle = "#000000";
    ctx.fillRect(680, 250, 39, 25);

    ctx.fillStyle = "#000000";
    ctx.fillRect(721, 250, 39, 25);

    ctx.fillStyle = "#000000";
    ctx.fillRect(680, 277, 39, 25);

    ctx.fillStyle = "#000000";
    ctx.fillRect(721, 277, 39, 25);

    ctx.fillStyle = "#000000";
    ctx.fillRect(680, 322, 39, 25);

    ctx.fillStyle = "#000000";
    ctx.fillRect(721, 322, 39, 25);

    ctx.fillStyle = "#000000";
    ctx.fillRect(680, 349, 39, 25);

    ctx.fillStyle = "#000000";
    ctx.fillRect(721, 349, 39, 25);

    ctx.beginPath();
    ctx.ellipse(605, 338, 33, 13.5, 0, 0, Math.PI, true);
    ctx.strokeStyle = "#000000";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(572, 338);
    ctx.lineTo(572, 399);
    ctx.strokeStyle = "#000000";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(605, 324.5);
    ctx.lineTo(605, 399);
    ctx.strokeStyle = "#000000";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(638, 338);
    ctx.lineTo(638, 399);
    ctx.strokeStyle = "#000000";
    ctx.stroke();

    ctx.beginPath();
    ctx.arc(597, 376, 3, 0, Math.PI * 2, true);
    ctx.strokeStyle = "#000000";
    ctx.stroke();

    ctx.beginPath();
    ctx.arc(613, 376, 3, 0, Math.PI * 2, true);
    ctx.strokeStyle = "#000000";
    ctx.stroke();

    ctx.beginPath();
    ctx.moveTo(550, 230);
    ctx.lineTo(662.5, 108);
    ctx.lineTo(775, 230);
    ctx.closePath();
    ctx.fillStyle = "#965A5A";
    ctx.fill();
    ctx.strokeStyle = "#000000";
    ctx.stroke();

    ctx.fillStyle = "#965A5A";
    ctx.fillRect(712.5, 147.5, 20, 55);
    ctx.strokeStyle = "#000000";
    ctx.strokeRect(712.5, 147.5, 20, 55);

    ctx.strokeStyle = "#965A5A";
    ctx.strokeRect(712.5, 202.5, 20, 1);

    ctx.beginPath();
    ctx.ellipse(722.5, 147.5, 10, 2.75, 0, 0, Math.PI * 2, true);
    ctx.fillStyle = "#965A5A";
    ctx.fill();
    ctx.strokeStyle = "#000000";
    ctx.stroke();
}
