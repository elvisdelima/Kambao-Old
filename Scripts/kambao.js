/*$(document).ready(function () {
    $('.card').draggable({
        cursor: 'move',          // sets the cursor apperance
        opacity: 0.40            // opacity while the element is dragged
    });
});*/

$(function () {
    // configura drag and drop
    $(".faixa").sortable({
        connectWith: ['.faixa'],
        placeholder: 'dragHelper',
        scroll: true,
        revert: true,
        stop: function (e, ui) {
            //salvaCookie();
        }
    });



    // maximizar boxes
    $('.lnk-maximizar').click(function () {
        var div = $(this).parent().parent().parent();
        var largura = ($(window).width() - 16);
        var altura = ($(window).height() - 16);
        if ($(div).width() == largura && $(div).height() == altura) {
            $(div).css({
                position: 'relative',
                width: '480px',
                height: '250px',
                top: 0,
                left: 0,
                zIndex: 1
            });
        }
        else {
            $(div).css({
                position: 'absolute',
                top: $(window).scrollTop(),
                left: $(window).scrollLeft(),
                width: largura + 'px',
                height: altura + 'px',
                zIndex: 10
            });
        }
        return false;
    });
    // minimizar boxes
    $('.lnk-minimizar').click(function () {
        var ul = $(this).parent().parent().parent().find('ul');
        if ($(ul).is(':visible')) {
            $(ul).slideUp();
            $(this).html('[ + ]');
        } else {
            $(ul).slideDown();
            $(this).html('[ - ]');
        }
        return false;
    });
    // remover box
    $('.lnk-remover').click(function () {
        $(this).parent().parent().parent().fadeOut();
        return false;
    });

});
