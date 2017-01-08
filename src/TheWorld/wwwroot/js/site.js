//site.js

(function () {

    //var ele = $("#username");
    //// document.getElementById("username");
    //// ele.innerHTML = "Είναι σούπερ παίδαρος!";
    //ele.text("Είναι σούπερ παίδαρος!");

    //var main = $("#main");

    ////main.onmouseover = function () {
    ////    main.style.backgroundColor = "#888";
    ////};

    //main.on("mouseenter", function () {
    //    main.style = "background-color: #888;";
    //});

    //main.on("mouseleave", function () {
    //    main.style = "";
    //});

    //var menuItems = $("ul.menu li a");
    //menuItems.on("click", function () {
    //    var me = $(this);
    //    alert(me.text());
    //});

    //alert("AAA");

    var $sidebarAndWrapper = $("#sidebar,#wrapper");
    var $icon = $("#sidebarToggle i.fa");

    $("#sidebarToggle").on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
            //$(this).text("Show Sidebar")
        } else {
            //$(this).text("Hide Sidebar")
            $icon.addClass("fa-angle-left");
            $icon.removeClass("fa-angle-right")
        };
    });

})();