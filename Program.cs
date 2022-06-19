using System;
using System.Globalization;

namespace OOP {
    class Pessoa {
        public string? Name;
        public int Age;
    }

    class program {
        static void Main() {
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Pessoa 1:\nDigite seu nome e sua idade: ");
            a.Name = Console.ReadLine();
            a.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Pessoa 2:\nDigite seu nome e sua idade: ");
            b.Name = Console.ReadLine();
            b.Age = int.Parse(Console.ReadLine());

            Pessoa mais_velha = maisVelha(a, b);
            Console.WriteLine($"Pessoa mais velha: {mais_velha.Name}");
        }

        static Pessoa maisVelha(Pessoa a, Pessoa b) {
            if (a.Age > b.Age)
                return a;
            else
                return b;
        }
    }
}
