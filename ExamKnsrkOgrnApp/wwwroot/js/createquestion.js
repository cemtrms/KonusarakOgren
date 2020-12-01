$("#ArticleTitle").change(function () {
    var data = this.value;
    debugger;
$.ajax({
    type: "GET",
    url: "/Home/Bind?title="+data,
    contentType: "application/json",
    dataType: "json",
    success: function (response) {
        debugger;
        document.getElementById("spnId").innerHTML = "";
        $('#spnId').append(response.response);
    },
    failure: function (response) {
        alert(response);
    }
});
});