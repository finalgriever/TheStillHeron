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

$(document).ready(function () {
    banner_height = $(".navbar-fixed-top").css("top");
    banner_height = banner_height.replace("px", "");

    $(window).scroll(handleScroll);
});