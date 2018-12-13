﻿var gameInstance;
var intervalTimer;
var hasInitialized = false;

$(document).ready(function () {
    gameInstance = UnityLoader.instantiate("gameContainer", "/Unity/Build/Game - WebGL.json",
        {
            Module:
            {
                onRuntimeInitialized: function () {
                    hasInitialized = true;
                }
            }
        });

    intervalTimer = setInterval(CheckForInitialize, 100);
});

$(".search-bar-input").keyup(function () {
    var value = $(this).val().toLowerCase();
    $(".bestiary-list-group .list-group-item").filter(function () {
        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1);
    });
});

// Checks if the Unity player has initialized and, if so, runs the Setup function.
function CheckForInitialize() {
    if (hasInitialized) {
        Setup();
        clearInterval(intervalTimer);
    }
}

// Sends a Message to the Unity player to give it its necesary setup variables and unhides the Unity player on the page.
function Setup() {
    gameInstance.SendMessage("Scene Switch Manager", "LoadSceneByID", 1);
    $("#gameContainer").attr("hidden", false);
}

$(".enemy-btn").click(function () {
    var enemyID = parseInt($(this).children(".enemy-id").text());
    gameInstance.SendMessage("Enemy Spawn Manager", "ForceSpawnEnemy", enemyID);
});