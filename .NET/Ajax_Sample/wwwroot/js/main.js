function obterFormasPagamento() {
    $.ajax({
        method: "GET",
        url: $("#obterFormasPagamento").val(),
        dataType: "json",
        success: function(response) {
            let selectElement = $("#pagamento"); // Get the select element
            selectElement.empty(); // Clear existing options

            // Populate options from the response array
            for (const element of response) {
                let option = $("<option>").text(element);
                selectElement.append(option);
            }

            $("#formas-pagamento").removeAttr("hidden");
        }
    });
}