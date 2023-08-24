// 01 -  Escreva um programa em C# que peça ao usuário que digite um número inteiro e então imprima o número digitado pelo usuário.


using System;

namespace Atividade_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("O numero digitado foi: " + numero);
        }
    }
}


// 02 - Escreva um código em C# que Solicite ao usuário que escreva seu nome e depois solicite o seu sobrenome. Ao final, imprima no console o nome e o sobrenome juntos em uma mesma linha.

using System;

namespace Atividade_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Seu nome completo é: " + nome + " " + sobrenome);
        }
    }
}



// 03 - Elabore um programa em C# que peça ao usuário sua data de nascimento e calcule sua idade. Em seguida, exiba a idade em anos.

using System;

namespace Atividade_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua data de nascimento: ");
            string dataNascimento = Console.ReadLine();
            Console.WriteLine(" A Sua idade é: " + (DateTime.Now.Year - Convert.ToDateTime(dataNascimento).Year));
        }
    }
}


// 04 - Desenvolva uma aplicação em linguagem C# que solicite ao usuário um número e retorne a tabuada desse número de 0 a 10.

using System;

namespace Atividade_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero * i));
            }
        }
    }
}


// 05 - Construa uma aplicação em C# em que o usuário insere um númnero e a aplicação retorna se o número é par ou ímpar.


using System;

namespace Atividade_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é ímpar");
            }
        }
    }
}

// 06 Escreva um programa em C# que compute a soma de dois valores numéricos inseridos pelo usuário. Se os valores forem iguais, retornar o triplo da soma entre ambos.

using System;

namespace Atividade_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            int numero2 = int.Parse(Console.ReadLine());
            if (numero1 == numero2)
            {
                Console.WriteLine("O triplo da soma dos números é: " + (numero1 + numero2) * 3);
            }
            else
            {
                Console.WriteLine("A soma dos números é: " + (numero1 + numero2));
            }
        }
    }
}