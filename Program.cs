using System;
using System.Globalization;

namespace OOP {
    class Funcionario {
        public string? Name;
        public float Salario;
    }

    class program {
        static void Main() {
            Funcionario a, b;
            a = new Funcionario();
            b = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario:");
            a.Name = Console.ReadLine();
            a.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario: ");
            b.Name = Console.ReadLine();
            b.Salario = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float salario_medio = (a.Salario + b.Salario) / 2;
            Console.WriteLine($"Salário Médio: {salario_medio}");
        }
    }
}
