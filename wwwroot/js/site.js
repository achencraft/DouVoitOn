// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




/* DEBUT JS pour la barre de recherche */

function createAuto(i, elem) {
    console.log('q');
    var input = $(elem);
    var dropdown = input.closest('.dropdown');
    var menu = dropdown.find('.dropdown-menu');
    var listContainer = dropdown.find('.list-autocomplete');
    var listItems = listContainer.find('.dropdown-item');
    var hasNoResults = dropdown.find('.hasNoResults');

    listItems.hide();
    listItems.each(function () {
        $(this).data('value', $(this).text());
        //!important, keep this copy of the text outside of keyup/input function
    });

    input.on("input", function (e) {

        if ((e.keyCode ? e.keyCode : e.which) == 13) {
            $(this).closest('.dropdown').removeClass('open').removeClass('in');
            return; //if enter key, close dropdown and stop
        }
        if ((e.keyCode ? e.keyCode : e.which) == 9) {
            return; //if tab key, stop
        }


        var query = input.val().toLowerCase();

        if (query.length > 0) {

            menu.addClass('show');

            listItems.each(function () {

                var text = $(this).data('value');
                if (text.toLowerCase().indexOf(query) > -1) {

                    var textStart = text.toLowerCase().indexOf(query);
                    var textEnd = textStart + query.length;
                    var htmlR = text.substring(0, textStart) + '<em>' + text.substring(textStart, textEnd) + '</em>' + text.substring(textEnd + length);
                    $(this).html(htmlR);
                    $(this).show();

                } else {

                    $(this).hide();

                }
            });

            var count = listItems.filter(':visible').length;
            (count > 0) ? hasNoResults.hide() : hasNoResults.show();

        } else {
            listItems.hide();
            dropdown.removeClass('open').removeClass('in');
            hasNoResults.show();
        }
    });

    listItems.on('click', function (e) {
        var txt = $(this).text().replace(/^\s+|\s+$/g, "");  //remove leading and trailing whitespace
        input.val(txt);
        menu.removeClass('show');
    });

}

$('.jAuto').each(createAuto);


$(document).on('focus', '.jAuto', function () {
    $(this).select();  // in case input text already exists
});

$(document).mouseup(function (e) {
    if ($(e.target).closest(".dropdown").length === 0) {
        $('.dropdown-menu').removeClass('show');
    }
});
/* FIN JS pour la barre de recherche */
