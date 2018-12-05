$(document).ready(function () {
    var title = document.title.toLowerCase();
    $(".navbar-nav .nav-" + title).parent().addClass("active");
});