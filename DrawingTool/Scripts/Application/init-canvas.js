
$("#btn-browse-file").click(function () {
    $('#select-file').click();
});

$("#btn-draw").click(function () {
    var file = new FormData($('#file-upload').get(0));
});

$('#select-file').change(function () {
    var filename = $('input[type=file]').val().split('\\').pop();
    $('#file_name').val(filename);
});


var canvasImg = document.getElementById('canvasBucket');
download_img = function (e) {
    var image = canvasImg.toDataURL("image/jpeg");
    e.href = image;
};
