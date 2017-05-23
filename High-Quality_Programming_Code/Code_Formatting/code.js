var addScroll = false;
var pX = 0;
var pY = 0;
var document = Object.create();
var Event = Object.create();
var event = Object.create();
var theLayer = Object.create();
var navigator = Object.create();
var browser = navigator.appName;

if ((navigator.userAgent.indexOf("MSIE 5") > 0) || (navigator.userAgent.indexOf("MSIE 6")) > 0) {
    addScroll = true;
}

if (browser === "Netscape") {
    document.captureEvents(Event.MOUSEMOVE);
}

function PopTip() {
    "use strict";
    var window = 0;

    if (browser === "Netscape") {
        theLayer = eval("document.layers[\'ToolTip\']");

        if ((pX + 120) > window.innerWidth) {
            pX = window.innerWidth - 150;
        }

        theLayer.left = pX + 10;
        theLayer.top = pY + 15;
        theLayer.visibility = "show";
    } else {
        theLayer = eval("document.all[\'ToolTip\']");

        if (theLayer) {
            pX = event.x - 5;
            pY = event.y;

            if (addScroll) {
                pX = pX + document.body.scrollLeft;
                pY = pY + document.body.scrollTop;
            }

            if ((pX + 120) > document.body.clientWidth) {
                pX = pX - 150;
            }

            theLayer.style.pixelLeft = pX + 10;
            theLayer.style.pixelTop = pY + 15;
            theLayer.style.visibility = "visible";
        }
    }
}

function HideTip() {
    "use strict";

    if (browser === "Netscape") {
        document.layers["ToolTip"].visibility = "hide";
    } else {
        document.all["ToolTip"].style.visibility = "hidden";
    }
}

function HideMenu1() {
    "use strict";

    if (browser === "Netscape") {
        document.layers["menu1"].visibility = "hide";
    } else {
        document.all["menu1"].style.visibility = "hidden";
    }
}

function ShowMenu1() {
    "use strict";

    if (browser === "Netscape") {
        theLayer = eval("document.layers[\'menu1\']");
        theLayer.visibility = "show";
    } else {
        theLayer = eval("document.all[\'menu1\']");
        theLayer.style.visibility = "visible";
    }
}

function HideMenu2() {
    "use strict";

    if (browser === "Netscape") {
        document.layers["menu2"].visibility = "hide";
    } else {
        document.all["menu2"].style.visibility = "hidden";
    }
}

function ShowMenu2() {
    "use strict";

    if (browser === "Netscape") {
        theLayer = eval("document.layers[\'menu2\']");
        theLayer.visibility = "show";
    } else {
        theLayer = eval("document.all[\'menu2\']");
        theLayer.style.visibility = "visible";
    }
}

function mouseMove(evn) {
    "use strict";
    document.onmousemove = mouseMove;

    if (browser === "Netscape") {
        pX = evn.pageX - 5;
        pY = evn.pageY;
    } else {
        pX = event.x - 5;
        pY = event.y;
    }

    if (browser === "Netscape") {
        if (document.layers["ToolTip"].visibility === "show") {
            new PopTip();
        }
    } else {
        if (document.all["ToolTip"].style.visibility === "visible") {
            new PopTip();
        }
    }
}
