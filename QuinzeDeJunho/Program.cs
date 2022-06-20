using System;

namespace QuinzeDeJunho
{
    class Program  
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1-Soma\r\n2-Subtração\r\n3-Divisão\r\n4-Multiplicação");
                int select = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o primeiro valor");
                double valor1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor");
                double valor2 = double.Parse(Console.ReadLine());
                Calculo calc = new Calculo(valor1, valor2);

                if (select == 1)
                {
                    calc.Soma();
                    Console.WriteLine("Resultado: " + calc.ToString());
                }
                else if (select == 2)
                {
                    calc.Subtracao();
                    Console.WriteLine("Resultado: " + calc.ToString());
                }
                else if (select == 3)
                {
                    calc.Divisao();
                    Console.WriteLine("Resultado: " + calc.ToString());
                }
                else if (select == 4)
                {
                    calc.Multiplicacao();
                    Console.WriteLine("Resultado: " + calc.ToString());
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nào pode dividir por 0");
            }
            catch(FormatException)
            {
                Console.WriteLine("Digite um valor valido");
            }
        }

    }
}
