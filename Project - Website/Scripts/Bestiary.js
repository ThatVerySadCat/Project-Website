// The Unity client instance.
var gameInstance;
// The timer used to send the initialization message as the Unity client has finished initialization.
var initializeTimer;
// Has the game client finished initializing?
var hasInitialized = false;

// The element which displays the currently active enemy name on the page.
var enemyName;
// The element which displays the currently active enemy creators username on the page.
var enemyCreatorName;

// Sets up variables and instantiates the Unity game client.
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

// Checks if the Unity player has initialized and, if so, sends the message to load the correct scene to the Unity client.
function CheckForInitialize() {
    if (hasInitialized) {
        gameInstance.SendMessage("Scene Switch Manager", "LoadSceneByID", 1);
        $("#gameContainer").attr("hidden", false);

        clearInterval(initializeTimer);
    }
}

// Uses the value in the search bar to filter through the bestiary-list-group items.
$(".search-bar-input").keyup(function () {
    var value = $(this).val().toLowerCase();
    $(".bestiary-list-group .list-group-item").filter(function () {
        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1);
    });
});

// Gives the enemy ID asociated with the pressed button to the Unity game client.
// Then the controller is asked for the correct data using ajax which is then used to set the correct elements.
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

// Sets the correct text on the page to the values found in the given viewModel.
function SetActiveEnemyInformation(viewModel) {
    $(enemyName).text(viewModel.Name);
    $(enemyCreatorName).text(viewModel.CreatorUsername);
    $(enemyCreatorName).attr("href", "/Account/AccountInfo/" + viewModel.CreatorID);
}

// Switches the currently active button to be inactive and set the given newActiveEnemyBtn as active.
function SwitchActiveEnemyBtn(newActiveEnemyBtn) {
    $(".active").removeClass("active");
    $(newActiveEnemyBtn).addClass("active");
}