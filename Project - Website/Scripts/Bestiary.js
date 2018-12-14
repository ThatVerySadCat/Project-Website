var gameInstance;
var initializeTimer;
var hasInitialized = false;

var enemyName;
var enemyCreatorName;

$(document).ready(function () {
    enemyName = $(".enemy-name");
    enemyCreatorName = $(".enemy-creator-name");

    gameInstance = UnityLoader.instantiate("gameContainer", "/Unity/Build/Game - WebGL.json",
        {
            Module:
            {
                onRuntimeInitialized: function () {
                    hasInitialized = true;
                }
            }
        });

    initializeTimer = setInterval(CheckForInitialize, 1000);
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
        clearInterval(initializeTimer);
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

    var localBtn = $(this);

    $.ajax({
        url: "SwitchActiveEnemy",
        type: "POST",
        dataType: "json",
        data: { id: enemyID },
        success: function (viewModel) {
            SetActiveEnemyInformation(viewModel);
            SwitchActiveEnemyBtn(localBtn);
        },
        error: function (error) {
            console.log("error");
        }
    });
});

function SwitchActiveEnemyBtn(newActiveEnemyBtn) {
    $(".active").removeClass("active");
    $(newActiveEnemyBtn).addClass("active");
}

function SetActiveEnemyInformation(viewModel) {
    $(enemyName).text(viewModel.Name);
    $(enemyCreatorName).text(viewModel.CreatorUsername);
    $(enemyCreatorName).attr("href", "/Account/AccountInfo/" + viewModel.CreatorID);
}