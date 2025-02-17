﻿using System;
class Program {
    public static void Main (string[] args) {
        int supermercados = int.Parse(Console.ReadLine());
        double menorPreco = 100000;
        for (int i = 0; i < supermercados; i++) {
            string linha = Console.ReadLine();
            string[] valores = linha.Split(' ');
            double preco = double.Parse(valores[0]);
            int peso = int.Parse(valores[1]);
            double x = (preco * 1000) / peso;
            if (x < menorPreco)
            menorPreco = x;
        }
        Console.WriteLine($"{menorPreco:F2}");
    }
}