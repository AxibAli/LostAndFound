// General Function For Ajax Call

function ajaxCall(url_, data_, successCallback, type_ = 'POST') {
    debugger;
    var ajaxObj = {
        url: url_,
        type: type_,
        dataType: 'JSON',
        data: data_,
        success: successCallback,
        error: (error) => {
            swal('Error occured during processing request. Please check console');
            console.log(error);
        }
    };
    $.ajax(ajaxObj);
}