$(function () {

    $('a.confirm').on("click", function () {
        if (!confirm("Are you sure?")) return false;
    });

});