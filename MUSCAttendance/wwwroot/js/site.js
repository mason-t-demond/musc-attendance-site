// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $("#otherDescriptionGroup").hide();
    $('#programDescriptionGroup').hide();


    // Handle radio button change event
    $("input[name='Form.Type']").change(function () {
        if ($(this).val() === "Other") {
            $("#otherDescriptionGroup").show();
        } else {
            $("#otherDescriptionGroup").hide();
        }
    });

    $('#hasProgramNo').change(function () {
        if ($('#hasProgramNo').prop('checked')) {
            $('#programDescriptionGroup').show();
        } else {
            $('#programDescriptionGroup').hide();
        }
        if (!$('#hasProgramNo').prop('checked')) {
            $('#programDescriptionGroup').hide();
        } 
    });
    
});
