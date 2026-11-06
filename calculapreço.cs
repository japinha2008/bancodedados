using System;

class Produto

{

    public string Nome { get; set; }

    public double Preco { get; set; }

    public double Desconto { get; set; }


    public double CalcularPrecoFinal()

    {

        return Preco - (Preco * Desconto / 100);

    }

}

class Program

{

    static void Main()

    {

        Produto produto = new Produto

        {

            Nome = "Fone de ouvido",

            Preco = 200,

            Desconto = 15

        };

        Console.WriteLine($"Preço final de {produto.Nome}: R$ {produto.CalcularPrecoFinal():F2}");

    }using System;

class Produto

{

    public string Nome { get; set; }

    public double Preco { get; set; }

    public double Desconto { get; set; }


    public double CalcularPrecoFinal()

    {

        return Preco - (Preco * Desconto / 100);

    }

}

class Program

{

    static void Main()

    {

        Produto produto = new Produto

        {

            Nome = "Fone de ouvido",

            Preco = 200,

            Desconto = 15

        };

        Console.WriteLine($"Preço final de {produto.Nome}: R$ {produto.CalcularPrecoFinal():F2}");

    }

}



- Execute e observe o resultado no console.

- Altere o valor do desconto para testar o comportamento com novo percentual.

- Inclua linha de comando para impressão do "Preço inicial" com 2 casas decimais, acima da exibição do "Preço final".

- A saída do código alterado deve ser como a da imagem.

Copie o link da execução do código alterado  no Programiz.
}



- Execute e observe o resultado no console.

- Altere o valor do desconto para testar o comportamento com novo percentual.

- Inclua linha de comando para impressão do "Preço inicial" com 2 casas decimais, acima da exibição do "Preço final".

- A saída do código alterado deve ser como a da imagem.

Copie o link da execução do código alterado  no Programiz.
