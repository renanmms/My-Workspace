function obterFormasPagamento() {
    $.ajax({
        method: "GET",
        url: $("#obterFormasPagamento").val(),
        dataType: "json",
        success: function(response) {
            var selectElement = $("#pagamento"); // Get the select element
            selectElement.empty(); // Clear existing options

            // Populate options from the response dictionary
            for (var key in response) {
                if (response.hasOwnProperty(key)) {
                    var option = $("<option>").text(key).val(response[key]);
                    selectElement.append(option);
                }
            }
        }
    });
}