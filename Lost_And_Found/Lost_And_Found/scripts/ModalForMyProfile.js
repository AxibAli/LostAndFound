
//Show The Popup Modal For Edit User Record

function EditAdminRecord(Admin_ID) {
    var url = "/Admin/GetAdminById?Admin_ID=" + Admin_ID;
    $("#ModalTitle").html("Update User Profile");
    $("#MyModal").modal();
    $.ajax({
        type: "GET",
        url: url,
        success: function (data) {
            var obj = JSON.parse(data);
            $("#AdminId").val(obj.Admin_ID);
            $("#AdminFullName").val(obj.Admin_FullName);
            $("#AdminEmail").val(obj.Admin_Email);
            $("#AdminContact").val(obj.Admin_Contact);
            $("#AdminPass").val(obj.Admin_Password);
            $("#AdminGender").val(obj.Admin_Gender);

        }
    })
}

$("#SaveAdminRecord").click(function () {

    var data = {
        adminid: $('#AdminId').val(),
        adminname: $('#AdminFullName').val(),
        adminemail: $('#AdminEmail').val(),
        admincontact: $('#AdminContact').val(),
        adminpass: $('#AdminPass').val(),
        admingender: $('#AdminGender').val()
    }
    $.ajax({
        type: "Post",
        url: "/Admin/UpdateDataInDatabase",
        data: data,
        success: function (result) {
            alert("Successfully Updated....");
            window.location.href = "/Admin/Dashboard";
            $("#MyModal").modal("hide");
        }
    })
})
$(document).ready(function () {
    $("#sendMessage").click(function () {
        debugger;
        var data = {
            postMessage: $('#message').val(),
            productid: $('#Id').val()
        }
        $.ajax({
            type: "Post",
            url: "/User/SendMessage",
            data: data,

            success: function (result) {
                alert("Successfully Sent!....");
                window.location.href = "/User/Home";
                $("#MyModal").modal("hide");

            }
        });
    });
});
