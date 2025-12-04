namespace Condicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region condição simples e encadeada
            //int valor = 15;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Valor é maior que 5");
            //}
            //else if (valor >= 5 && valor < 10)
            //{
            //    Console.WriteLine("Valor é menor que 10 e maior ou igual a 5");
            //}
            //else if (valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("Valor é menor que 20 e maior ou igual a 10");
            //}
            //else
            //{ 
            //Console.WriteLine("Valor é maior ou igual a 20");
            //}
            //    Console.ReadKey();

            #endregion

            #region condição aninhada

            //int numero = 10;

            //if (numero > 5)
            //{
            //    Console.Write("O numero é maior que 5");

            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine(" e é par.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" e é impar.");
            //    }

            //}
            #endregion

            #region Operador Ternário

            //int numero = 10;
            //string mensagem = "";

            //if (numero > 5)
            //{
            //    mensagem = "Maior que 5";
            //}
            //else
            //{
            //    mensagem = "Menor que 5";
            //}

            // condição ? true : false;

            //mensagem = numero > 5 ? "maior que 5" : "menor que 5";

            //Console.WriteLine(mensagem);
            //Console.ReadKey();

            // pode ser feita a operação ternaria no print

            //Console.WriteLine(numero > 5 ? "maior que 5" : "menor que 5");
            //Console.ReadKey();


            #endregion

            #region IMC
            double peso, altura, imc;

            Console.Write("Digite seu peso (kg): ");
            peso = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite sua altura (m): ");
            altura = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 20)
            {
                Console.WriteLine("\n IMC = " + imc + " -> Abaixo do peso");
            }
            else if ( imc >= 20 && imc <=24)
            {
                Console.WriteLine("\n IMC = " + imc + " -> Peso normal");
            }
            else if (imc >= 25 && imc <= 29)
            {
                Console.WriteLine("\n IMC = " + imc + " -> Acima do peso");
            }
            else if (imc >= 30 && imc <= 34)
            {
                Console.WriteLine("\n IMC = " + imc + " -> Muito acima do peso");
            }


            #endregion
        }
    }
}
