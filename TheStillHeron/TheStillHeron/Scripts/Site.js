var banner_height;

function handleScroll(event) {
    var scrolled = $(window).scrollTop();
    if (banner_height - scrolled < 0) {
        $(".navbar-fixed-top").css("top", 0);
    }
    else {
        $(".navbar-fixed-top").css("top", banner_height - scrolled);
    }
}

function setLoadHeights() {
    var wH = $(window).outerHeight(true);
    var fH = $("footer").outerHeight(true);
    var bH = $(".site-banner").outerHeight(true);
    var bCH = wH - fH - bH;
    $("body").css("min-height", wH + "px");
    $(".body-content").css("min-height", bCH + "px");
}

$(document).ready(function () {
    banner_height = $(".navbar-fixed-top").css("top");
    banner_height = banner_height.replace("px", "");
    $(window).scroll(handleScroll);

    setLoadHeights();
});