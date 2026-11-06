interface Produto {
  nome: string;
  preco: number;
  desconto?: number;
}

function calcularPrecoFinal(produto: Produto): number {
  const desconto = produto.desconto ?? 0;
  return produto.preco - (produto.preco * desconto / 100);
}

const produto1: Produto = {
  nome: "Fone de ouvido",
  preco: 200,
  desconto: 20
};

console.log(`Preço inicial: R$ ${produto1.preco.toFixed(2)}`);
console.log(`Preço final de ${produto1.nome}: R$ ${calcularPrecoFinal(produto1).toFixed(2)}`);ados
