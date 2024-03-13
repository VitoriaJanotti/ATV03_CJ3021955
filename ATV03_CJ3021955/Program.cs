namespace ATV03_CJ3021955
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 1");

            Console.WriteLine("Digite um número inteiro");

            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)

            {
                Console.WriteLine("O numero é par");
            }

            else Console.WriteLine("O numero é impar");


            Console.WriteLine("Exercicio 2");

            Console.WriteLine("Digite um lado do triangulo: ");

            float l1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo lado do triangulo");

            float l2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro lado do triangulo");

            float l3 = float.Parse(Console.ReadLine());

            if ((l1 == l2) && (l1 != l3) || (l2 == l3) && (l2 != l1) || (l1 == l3) && (l1 != l2))

            {

                Console.WriteLine("O triangulo é isoceles");

            }

            if ((l1 == l3) && (l2 == l3))

            {

                Console.WriteLine("O triangulo é equilatero");

            }

            if ((l1 != l2) && (l2 != l3) && (l1 != l3))

            {

                Console.WriteLine("O trianguo é escaleno");

            }

            Console.WriteLine("Exercicio 3");

            Console.WriteLine("Exercicio 4");

            Console.WriteLine("Coloque o usuario: ");

            Console.WriteLine("Coloque a senha: ");

            string nome = Console.ReadLine();

            string senha = Console.ReadLine();

            if ((nome == "admin") && (senha == "admin123"))
            {

                Console.WriteLine("Acesso Concedido");


            }
            else Console.WriteLine("Acesso negado");

            Console.WriteLine("Exercicio 5");

            Console.WriteLine("Digite a nota de 0 a 100");

            int nota = int.Parse(Console.ReadLine());

            if ((nota


            {

                Console.WriteLine("Sua nota é A");

            }

            if ((nota


            {

                Console.WriteLine("Sua nota é B");

            }

            if ((nota


            {

                Console.WriteLine("Sua nota é C");

            }

            if ((nota


            {

                Console.WriteLine("Sua nota é D");

            }

            if (nota < 60)

            {

                Console.WriteLine("Sua nota é F");

            }

            Console.WriteLine("Exercício 6");

            Console.WriteLine("Exercicio 7");

            Console.WriteLine("Digite o valor do produto");

            int produto = int.Parse(Console.ReadLine());

            if ((produto > 100) && (produto < 200))
            {

                int produto2 = (((produto / 100) * 10) - produto);

                Console.WriteLine("O valor do produto ficou depois do desconto com o valor de ", produto2);

            }

            if ((produto > 200) && (produto < 300))
            {

                int produto3 = (((produto / 100) * 20) - produto);

                Console.WriteLine("O valor do produto ficou depois do desconto com o valor de ", produto3);

            }

            if ((produto > 300) && (produto < 400))

            {

                int produto4 = (((produto / 100) * 30) - produto);

                Console.WriteLine("O valor do produto ficou depois do desconto com o valor de", produto4);

            }

            if (produto > 400)

            {

                int produto5 = (((produto / 100) * 40) - produto);

                Console.WriteLine("O valor do produto ficou depois do desconto com o valor de", produto5);

            }


            Console.WriteLine("Exercicio 8");

            Console.WriteLine("Digite o seu peso em kg");

            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua altura em metros");

            float altura = float.Parse(Console.ReadLine());

            float imc = (peso / (altura * altura));

            if (imc < 18.5)

            {

                Console.WriteLine("Voce está abaixo do peso");

            }

            if ((imc > 18.5) && (imc < 24.9))

            {

                Console.WriteLine("Voce está no peso normal");

            }

            if ((imc > 24.9) && (imc < 29.9))

            {

                Console.WriteLine("Voce está no sobrepeso");

            }

            if ((imc > 30) && (imc < 34.9))

            {

                Console.WriteLine("Voce esta na obesidade grau I");

            }

            if ((imc > 34.9) && (imc < 39.9))

            {

                Console.WriteLine("Voce esta na obesidade grau II");

            }

            if (imc > 40)

            {

                Console.WriteLine("Voce esta na obesidade grau III");

            }

        }
    }
}
