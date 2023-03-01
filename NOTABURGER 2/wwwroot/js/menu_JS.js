function Details(id) {
    console.log(id)
    $.get('ShowPopUp/' + id,
        function (data) {
            $('.modal-body').html(data);
        }
    );

    $("#myModal").modal("show");
}