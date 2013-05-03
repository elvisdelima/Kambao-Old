$(document).ready(function () {
// configura drag and drop
    $(".faixa").sortable({
        connectWith: ['.faixa'],
        placeholder: 'dragHelper',
        scroll: true,
        revert: true,
        opacity: 0.40,
        stop: function (e, ui) {
            //salvaCookie();
        }
    });    
});
