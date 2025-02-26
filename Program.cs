using System;
class Program {
    public static void Main (string[] args) {
        int x = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int acumulado = x;
        for (int i = 0; i < n; i++) {
            int m_i = int.Parse(Console.ReadLine());
            int saldo = x - m_i;
            acumulado = saldo + acumulado;
            
        }
        Console.WriteLine(acumulado);
    }
}