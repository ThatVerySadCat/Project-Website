// Is the currently entered username available for use?
var isCurrentUsernameAvailable = false;
// The element which contains the text saying the chosen username is available.
var usernameAvailableText;
// The element which contains the text saying the chosen username is unavailable.
var usernameNotAvailableText;

// The element which contains the inputted username.
var usernameInput;
// The element which contains the inputted password.
var passwordInput;
// The element which is the register button.
var registerBtn;

// Setup variables
$(document).ready(function () {
    usernameAvailableText = $(".username-available-text");
    usernameNotAvailableText = $(".username-not-available-text");

    usernameInput = $(".username-input");
    passwordInput = $(".password-input");
    registerBtn = $(".register-btn");
});

// Check if the Register btn can be enabled/disabled.
$(".password-input").keyup(function () {
    TryEnableRegisterButton();
});

// Send the username thus far given in to the controller to verify if it is available or not.
$(".username-input").keyup(function () {
    var usernameVal = $(this).val();
    if (usernameVal.length > 0) {
        $.ajax({
            url: "IsUsernameAvailable",
            type: "POST",
            dataType: "json",
            data: { username: usernameVal },
            success: function (isUserNameAvailable) {
                SetUsernameAvailableText(isUserNameAvailable);
                TryEnableRegisterButton();
            },
            error: function (error) {
                console.log("error");
            }
        });
    }
    else {
        DisableBothUsernameNotificationTexts();
        TryEnableRegisterButton();
    }
});

// Enable the Register btn if appropriate. Otherwise disable it.
function TryEnableRegisterButton() {
    var username = $(usernameInput).val();
    var password = $(passwordInput).val();

    if (username.length <= 0 || password.length <= 0 || !isCurrentUsernameAvailable) {
        $(registerBtn).attr("disabled", true);
    }
    else {
        $(registerBtn).attr("disabled", false);
    }
}

// Sets the correct text depending on if the isUsernameAvailable parameter is true or false.
function SetUsernameAvailableText(isUsernameAvailable) {
    isCurrentUsernameAvailable = isUsernameAvailable;

    if (isUsernameAvailable) {
        $(usernameAvailableText).attr("hidden", false);
        $(usernameNotAvailableText).attr("hidden", true);
    }
    else {
        $(usernameNotAvailableText).attr("hidden", false);
        $(usernameAvailableText).attr("hidden", true);
    }
}

// Hides both text elements.
function DisableBothUsernameNotificationTexts() {
    isCurrentUsernameAvailable = false;

    $(usernameAvailableText).attr("hidden", true);
    $(usernameNotAvailableText).attr("hidden", true);
}