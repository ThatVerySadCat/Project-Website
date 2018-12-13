var isCurrentUsernameAvailable = false;
var usernameAvailableText;
var usernameNotAvailableText;

var usernameInput;
var passwordInput;
var registerBtn;

$(document).ready(function () {
    usernameAvailableText = $(".username-available-text");
    usernameNotAvailableText = $(".username-not-available-text");

    usernameInput = $(".username-input");
    passwordInput = $(".password-input");
    registerBtn = $(".register-btn");
});

// Check if the Register btn can be enabled/Disabled.
$(".username-input").keyup(function () {
    TryEnableRegisterButton();
});

// Check if the Register btn can be enabled/disabled.
$(".password-input").keyup(function () {
    TryEnableRegisterButton();
});

// Enable the Register btn if appropriate. Otherwise disable it.
function TryEnableRegisterButton() {
    if (isCurrentUsernameAvailable) {
        var username = $(usernameInput).val();
        var password = $(passwordInput).val();

        if (username.length > 0 && password.length > 0) {
            $(registerBtn).attr("disabled", false);
            return;
        }
    }

    $(registerBtn).attr("disabled", true);
}

// Send the username thus far given in to the controller to verify if it is available or not.
$(".username-input").keyup(function () {
    var usernameVal = $(this).val();
    if (usernameVal.length > 0) {
        var data = {
            username: $(this).val(),
        }
        $.ajax({
            url: "IsUsernameAvailable",
            type: "POST",
            dataType: "json",
            data: JSON.stringify(data),
            success: function (isUserNameAvailable) {
                SetUsernameAvailableText(isUserNameAvailable);
            },
            error: function (error) {
                console.log("error");
            }
        });
    }
    else {
        DisableBothUsernameNotificationTexts();
    }
});

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