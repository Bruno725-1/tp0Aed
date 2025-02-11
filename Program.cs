using System;
class Program {
    public static void Main (string[] args) {
        int supermercados = int.Parse(Console.ReadLine());
        double menorPreco = 100;
        for (int i = 0; i < supermercados; i++) {
            string linha = Console.ReadLine();
            string[] preco = linha.Split(' ');
            double p = double.Parse(preco[0]);
            int g = int.Parse(preco[1]);
            if (p < menorPreco)
            menorPreco = p;
        }
        Console.WriteLine($"{menorPreco:F2}");
    }
}