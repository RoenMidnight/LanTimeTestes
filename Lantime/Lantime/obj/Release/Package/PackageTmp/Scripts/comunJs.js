$('select#FuncionarioId').chosen();

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

// Valida IMEI
$('#Imei_Celu').blur(function validar(numero) {
    try {
        var soma = 0;

        numero = $('#Imei_Celu').val();

        for (var i = 0; i < 15; i++) {
            soma = soma + calculoDigito(numero.charAt(i), (i + 1) % 2 == 0);
        }

        if (soma % 10 == 0)
            return true;
        else {
            printSpan();
        }
    } catch (err) {
        console.log(err);
        return false;
    }
});
//Faz Cálculo dos Dígitos do IMEI
function calculoDigito(valorSemDigito, indexKey) {
    if (indexKey) {
        var numer = valorSemDigito * 2;

        while (numer > 9) {
            numer = parseInt(numer.toString().charAt(0)) + parseInt(numer.toString().charAt(1));
        }
        return numer
    } else {
        return valorSemDigito;
    }
}
function printSpan() {
    $('#Imei_Celu').focus;
}

