
var v;

 //Função de verificação dos dados do cliente, verifica se todos os campos foram preenchidos corretamente.

    function verificarCli() {
        v = cliente_nome.value.trim();

        if (v.trim() == "") {
            alert("O preenchimento do nome é obrigatório");
            return false;
        }


        v = cliente_tipo.value.trim();

        if (v.trim() == "") {
            alert("O preenchimento do tipo é obrigatório");
            return false;
        }


        v = cliente_cnpj.value.trim();

        if (v.trim() == "") {
            alert("O preenchimento do CPF/CNPJ é obrigatório");
            return false;
        }

        v = cliente_logradouro.value.trim();

        if (v.trim() == "") {
            alert("O preenchimento do logradouro é obrigatório");
            return false;
        }

        v = cliente_rua.value.trim();

        if (v.trim() == "") {
            alert("O preenchimento da rua é obrigatório");
            return false;
        }

        v = cliente_numero.value.trim();

        if (v.trim() == "") {
            alert("O preenchimento do numero da casa do cliente é obrigatório");
            return false;
        }

        v = cliente_bairro.value.trim();

        if (v.trim() == "") {
            alert("O preenchimento do bairro é obrigatório");
            return false;
        }


        v = cliente_cep.value.trim();

        if (v.trim() == "") {
            alert("O preenchimento do CEP é obrigatório");
            return false;
        }

        v = cliente_email.value.trim();

        if (v.trim() == "") {
            alert("O preenchimento do email é obrigatório");
            return false;
        }

        v = cliente_telefone.value.trim();
        
        if (v.trim() == "") {
            alert("O preenchimento do telefone é obrigatório");
            return false;
        }


        return true;
}


//Chama a função de verificar os dados e caso esteja tudo ok, retorna uma mensagem de sucesso e "clica no botão" de submit do ASP.NET
    function Cli_cad() {
        if (verificarCli()) {
            alert("Boas vindas ao novo cliente " + cliente_nome.value + " que foi cadastrado com sucesso");

        }

    }


function verificarForn() {

    v = fornecedor_nomefantasia.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento do nome é obrigatório");
        return false;
    }

    v = fornecedor_cnpj.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento do CNPJ é obrigatório");
        return false;
    }

    v = fornecedor_rua.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento da rua é obrigatório");
        return false;
    }

    v = fornecedor_numero.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento do numero é obrigatório");
        return false;
    }

    v = fornecedor_bairro.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento do bairro é obrigatório");
        return false;
    }

    v = fornecedor_cidade.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento da cidade é obrigatório");
        return false;
    }


    v = fornecedor_uf.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento da UF é obrigatório");
        return false;
    }

    v = fornecedor_email.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento do email é obrigatório");
        return false;
    }

    v = fornecedor_telefone.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento do telefone é obrigatório");
        return false;
    }


    return true;
}

function Forn_cad() {
    if (verificarForn()) {
        alert("Boas vindas ao novo fornecedor " + fornecedor_nomefantasia.value + " que foi cadastrado com sucesso");
    }
}


function verificarProd() {

    v = produto_descricao.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento do nome é obrigatório");
        return false;
    }

    v = produto_marca.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento da marca é obrigatório");
        return false;
    }

    v = produto_codbarras.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento do código de barras é obrigatório");
        return false;
    }

    v = produto_precocusto.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento do preço de custo é obrigatório");
        return false;
    }

    v = produto_precovenda.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento do preço de venda é obrigatório");
        return false;
    }

    v = produto_estoque.value.trim();

    if (v.trim() == "") {
        alert("O preenchimento do estoque é obrigatório");
        return false;
    }

    return true;
}

function Prod_cad() {
    if (verificarProd()) {
        alert("Olhá! um novo produto! " + produto_descricao.value + " foi cadastrado com sucesso");
    }
}

function Cli_del() {
    alert("Adeus " + document.querySelector("#nomeDel").innerText + " você foi deletado");
}

function Forn_del() {
    alert("Adeus " + document.querySelector("#fornnomeDel").innerText + " você foi deletado");
}

function Prod_del() {
    alert("Adeus " + document.querySelector("#prodnomeDel").innerText + " você foi deletado");
}

function Cli_edit() {
    if (verificarCli()) {
        alert(cliente_nome.value + " foi editado com sucesso, espero que esteja tudo certo agora :)");
    }
}

function Forn_edit() {
    if (verificarForn()) {
        alert(fornecedor_nomefantasia.value + " foi editado com sucesso, espero que esteja tudo certo agora :)");
    }
}

function Prod_edit() {
    if (verificarProd()) {
        alert(produto_descricao.value + " foi editado com sucesso, espero que esteja tudo certo agora :)");
    }
}

$('#PeP').scrollspy({ target: "#Politicas" })

