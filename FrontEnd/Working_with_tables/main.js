let linhas = $("tr[id^='linha-']");

linhas.each(function (index){
    $("#linha-" + (index + 1)).addClass("peca-nao-aceita");
});