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
    function approveItem(itemId) {
        $.ajax({
            type: "POST",
            url: "/Details/OnPostAsync",
            data: { id: itemId },
            success: function (data) {
                console.log("Item approved successfully");
                
                // If you want to redirect after approval, you can use window.location
                // window.location.href = "/Students/Details?id=" + itemId;
            },
            error: function () {
                // Handle error if needed
                console.log("Error approving item");
            }
        });
    }

    
});
