$(".geraPonto").click(function (event) {
    event.preventDefault();

    $.ajax({
        url: this.href,
        type: 'POST',
        sucess: function (data) {
            if (data && data.sucess) {
                alert("Ponto Registrado!");
                location.href = "/Pontos/Index"
            } else {
                alert("Não foi possível registrar o seu ponto");
            }
        },
        error: function (x, y, err) {
            alert("Ponto não Registrado!");
        }
    });

});


