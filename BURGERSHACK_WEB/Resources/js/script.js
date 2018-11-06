/*
 * Retirado de
 * https://stackoverflow.com/questions/16260498/push-footer-to-bottom-when-page-is-not-full
 * 
 * Modificacao do calculo da margin.
 */


// function to set the height on fly
function autoHeight() {
    var docHeight = $(document).outerHeight(true);
    var footerPos = $('body').outerHeight(true);

    if (docHeight > footerPos) {

        var margin = docHeight - footerPos + 25;

        $('footer').css({
            marginTop: margin
        });
    }
}

// onDocumentReady function bind
$(document).ready(function () {
    autoHeight();

    $(document)
        .ajaxStart(NProgress.start)
        .ajaxStop(NProgress.done);
});

// onResize bind of the function
$(window).on('resize', function () {
    autoHeight();
});