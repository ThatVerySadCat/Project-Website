var globalLeaderboardBtn;
var globalListGroup;
var personalLeaderboardBtn;
var personalListGroup;
var isGlobalLeaderboardActive = true;

$(document).ready(function () {
    globalLeaderboardBtn = $(".global-leaderboard-btn");
    globalListGroup = $(".global-list-group");
    personalLeaderboardBtn = $(".personal-leaderboard-btn");
    personalListGroup = $(".personal-list-group");
});

$(".search-bar-input").keyup(function () {
    var value = $(this).val().toLowerCase();
    if (isGlobalLeaderboardActive) {
        $(".global-list-group .list-group-item").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1);
        });
    }
    else {
        $(".personal-list-group .list-group-item").filter(function () {
            $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1);
        });
    }
});

$(".global-leaderboard-btn").click(function () {
    $(globalLeaderboardBtn).attr("disabled", true);
    $(personalLeaderboardBtn).attr("disabled", false);

    $(personalListGroup).addClass("hidden");
    $(globalListGroup).removeClass("hidden");

    isGlobalLeaderboardActive = true;
});

$(".personal-leaderboard-btn").click(function () {
    $(personalLeaderboardBtn).attr("disabled", true);
    $(globalLeaderboardBtn).attr("disabled", false);

    $(globalListGroup).addClass("hidden");
    $(personalListGroup).removeClass("hidden");

    isGlobalLeaderboardActive = false;
});