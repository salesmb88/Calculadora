using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("      Menu Calculadora");
            Console.WriteLine("");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Potenciação");
            Console.WriteLine("6 - Radiciação");
            Console.WriteLine("7 - Porcentagem");
            Console.WriteLine("8 - Sair");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Escolha um número das Opções Acima:");
            int menuInput = int.Parse(Console.ReadLine());

            switch (menuInput)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: Potenciacao(); break;
                case 6: Radiciacao(); break;
                case 7: Porcentagem(); break;
                case 8: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro Número da Soma:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite o Segundo Número da Soma:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float soma = v1 + v2;
            Console.WriteLine($"O Resultado da Soma é: {soma}");
            Console.WriteLine("");
            Console.WriteLine("Aperte Enter para Voltar a Menu!");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro Número da Subtração:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite o Segundo Número da Subtração:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float subtracao = v1 - v2;
            Console.WriteLine($"O Resultado da Subtração é: {subtracao}");
            Console.WriteLine("");
            Console.WriteLine("Aperte Enter para Voltar a Menu!");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro Número da Multiplicação:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite o Segundo Número da Multiplicação:");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float multiplicacao = v1 * v2;
            Console.WriteLine($"O Resultado da Multiplicação é: {multiplicacao}");
            Console.WriteLine("");
            Console.WriteLine("Aperte Enter para Voltar a Menu!");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro Número da Divisão (Dividendo):");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite o Segundo Número da Divisão (Divisor):");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            float divisao = v1 / v2;
            Console.WriteLine($"O Resultado da Divisão é: {divisao}");
            Console.WriteLine("");
            Console.WriteLine("Aperte Enter para Voltar a Menu!");
            Console.ReadKey();
            Menu();
        }
        static void Potenciacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro Número da Potenciação (Base):");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite o Segundo Número da Potenciação (Expoente):");
            double v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double potenciacao = Math.Pow(v1, v2);
            Console.WriteLine($"O Resultado da Potenciação é: {potenciacao}");
            Console.WriteLine("");
            Console.WriteLine("Aperte Enter para Voltar a Menu!");
            Console.ReadKey();
            Menu();
        }
        static void Radiciacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro Número da Radiciação (Radicando):");
            double v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite o Segundo Número da Radiciaçao (índice):");
            double v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double radiciacao = Math.Pow(v1, 1/v2);
            Console.WriteLine($"O Resultado da Radiciação é: {radiciacao}");
            Console.WriteLine("");
            Console.WriteLine("Aperte Enter para Voltar a Menu!");
            Console.ReadKey();
            Menu();
        }
        static void Porcentagem()
        {
            Console.Clear();
            Console.WriteLine("Digite o Primeiro Número (Percentual%):");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Digite o Segundo Número:");
            float v2 = float.Parse(Console.ReadLine());
            float percentual = (v1/100) * v2;
            Console.WriteLine($"O Resultado da Porcentagem é: {percentual}");
            Console.WriteLine("");
            Console.WriteLine("Aperte Enter para Voltar a Menu!");
            Console.ReadKey();
            Menu();
        }
    }
}
