
function calcularPrecoFinal(produto) {
  const desconto = produto.desconto ?? 0;

  const precoFinal = produto.preco - (produto.preco * desconto / 100);

  console.log(`Preço final de ${produto.nome}: R$ ${precoFinal.toFixed(2)}`);

}

// Exemplo de uso

const produto1 = {

  nome: "Fone de ouvido",

  preco: 200,

  desconto: 15

};

calcularPrecoFinal(produto1);



- Execute e observe o resultado no console.

- Altere o valor do desconto para testar o comportamento com novo percentual.

- Inclua linha de comando para impressão do "Preço inicial" com 2 casas decimais, acima da exibição do "Preço final".
