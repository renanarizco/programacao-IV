function ola(){
    document.write("Aula de javascript");
}

function escrevenatela(valor){
    document.write(valor);
    document.write("<br/>");
}

function somar(n1, n2){
    var resultado = parseInt(n1) + parseInt(n2);

    return resultado;
}

ola();
document.write("<br/>");
escrevenatela("Codificando funções");
