public class Produto {

    String nome;

    double preco;

    double desconto;

    public Produto(String nome, double preco, double desconto) {

        this.nome = nome;

        this.preco = preco;

        this.desconto = desconto;

    }

    public double calcularPrecoFinal() {

        return preco - (preco * desconto / 100);

    }

    public static void main(String[] args) {

        Produto produto = new Produto("Fone de ouvido", 200, 15);

        System.out.printf("Preço final de %s: R$ %.2f%n", produto.nome, produto.calcularPrecoFinal());

    }

}



- Execute e observe o resultado no console.

- Altere o valor do desconto para testar o comportamento com novo percentual.

- Inclua linha de comando para impressão do "Preço inicial" com 2 casas decimais, acima da exibição do "Preço final".

- A saída do código alterado deve ser como a da imagem.
