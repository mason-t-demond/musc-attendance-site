// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $("#otherDescriptionGroup").hide();
    $("#programPhotoGroup").hide();
    $('#programDescriptionGroup').show();

    // Handle radio button change event
    $("input[name='Form.Type']").change(function () {
        if ($(this).val() == "Other") {
            $("#otherDescriptionGroup").show();
        } else {
            $("#otherDescriptionGroup").hide();
        }
    });

    $('#hasProgram').change(function () {
        var checkbox = document.getElementById("hasProgram")
        if (checkbox.checked) {
            $('#programPhotoGroup').show();
            $('#programDescriptionGroup').hide();
        } else {
            $('#programPhotoGroup').hide();
            $('#programDescriptionGroup').show();
        }
    });
});
