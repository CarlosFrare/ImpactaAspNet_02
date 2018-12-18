const pesquisarButton = $("#pesquisarButton");


pesquisarButton.click(obterProdutoPorCategoria)


//#("#closePopover").click(function () {
//    pesquisarButton.popover("destroy");
//})

$(document).on("click", "#closePopover", () => pesquisarButton.popover("destroy"));

function obterProdutoPorCategoria() {
    const categoriaId = $("#CategoriaId").val();

    $.ajax({
        url: "/Admin/Produtos/Categoria",
        method: "get", //pode ser type: tambem
        data: {categoriaId}
    })
        .then(function (response) { exibirPopover(response);}) //pode ser tbm  .done()

.catch() // .fail() //error
    //alert("Passou aqui");
}

function exibirPopover(response) {
    pesquisarButton
        .popover("destroy")
        .popover({
            content: montarGridProdutos(response),
            html: true,
            animation: true,
            title: "Produtos desta categoria <span id='closePopover' class='close'>&times;</span>"
        })
        .popover("show");
}

function montarGridProdutos(produtos) {
    var html = "<table class='table table-striped'>";

    html += "<tr><th>Produto</th><th>Preço</th><th>Estoque</th></tr>";

    $(produtos).each(
        function (i) {
            html += "<tr>";
            html += "<td>" + produtos[i].Nome + "</td>";
            html += "<td>" + produtos[i].Preco.toLocaleString('pt-br', { style: 'currency', currency: 'BRL' }) + "</td>";
            html += "<td>" + produtos[i].Estoque + "</td>";
            html += "</tr>";
        }
    );

    return html + "</table>";
}