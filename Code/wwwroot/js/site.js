// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function(){
    $(".SWD100").click(function(){
        $(this).text("Course Description: This course will cover the basics of web development. Students will learn how a website is composed of html, css, and javascript and how to use each one.",
        "Final Project: Using HTML CSS and JavaScript, create a website with a form to gather information from the user in order to generate an ID Card."
        );

        /*
        let CurricDrop = $(".SWD100");
        let isHidden = CurricDrop.is(":hidden");

        if(isHidden) CurricDrop.show();
        else CurricDrop.hide();
        */
    });
});