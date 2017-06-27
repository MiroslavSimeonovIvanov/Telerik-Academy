(function browserDetect() {
    "use strict";

    var myWindow = window;
    var browser = myWindow.navigator.appCodeName;
    var isMozilla = true;

    if (browser === isMozilla) {
        if (isMozilla === "Mozilla") {
            alert("Yes");
        } else {
            alert("No");
        }
    }
}());
