// General Function For Ajax Call

function ajaxCall(url_, data_, successCallback, type_ = 'POST') {
    debugger;
    var ajaxObj = {
        url: url_,
        type: type_,
        dataType: 'JSON',
        data: data_,
        //beforeSend: function () {
        //    $("#divLoader").show();
        //},
        success: successCallback,
        //complete: function () {
        //    $("#divLoader").hide();
        //},
        error: (error) => {
            swal('Error occured during processing request. Please check console');
            console.log(error);
        }
    };
    $.ajax(ajaxObj);
}











//success: function (result) {
//    swal({
//        title: "Good job!",
//        text: "You clicked the button!",
//        icon: "success",
//        button: "Aww yiss!",
//    });
//    alert("success");

//},
//error: function (error) {
//    console.log(error);
//}