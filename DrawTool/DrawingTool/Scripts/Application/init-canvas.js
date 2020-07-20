
$("#btn-browse-file").click(function () {
    $('#select-file').click();
});

$("#btn-draw").click(function () {
    var file = new FormData($('#file-upload').get(0));
    //UploadFile(file);
});

$('#select-file').change(function () {
    var filename = $('input[type=file]').val().split('\\').pop();
    $('#file_name').val(filename);
    console.log(filename);
});

function UploadFile(file) {
    $.ajax({
        url: '/Home/UploadFile',
        type: 'POST',
        data: file,
        async: false,
        cache: false,
        processData: false,
        contentType: false,
        success: function (data) {
            console.log(data);
        }
    });

}

function download(text, filename) {
    var file = new Blob([text], { type: 'text/plain' });
    if (window.navigator.msSaveOrOpenBlob) // IE10+
        window.navigator.msSaveOrOpenBlob(file, filename);
    else { // Others
        var a = document.createElement("a"),
            url = URL.createObjectURL(file);
        a.href = url;
        a.download = filename;
        document.body.appendChild(a);
        a.click();
        setTimeout(function () {
            document.body.removeChild(a);
            window.URL.revokeObjectURL(url);
        }, 0);
    }
}