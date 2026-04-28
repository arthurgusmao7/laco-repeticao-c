/*
Melhore o programa do exercício 4 para que ele possa receber um número inteiro do usuário 
e mostrar a tabuada desse número. O programa deve continuar pedindo um número até que o 
usuário digite um número negativo, momento em que o programa deve ser encerrado.

Regras:
- utilizar do/while em um dos laços de repetição
- utilizar while em um dos laços de repetição
- apresentar cada operação de forma organizada
- mostrar a tabuada completa do número informado pelo usuário
*/
using System;

public static class Atv05
{
    public static void Executar()
    {
        int numero;

        do
        {
            Console.Write("Digite um número inteiro (negativo para sair): ");
            numero = int.Parse(Console.ReadLine()!);

            if (numero >= 0)
            {
                int contador = 1;

                Console.WriteLine();
                Console.WriteLine($"Tabuada do {numero}:\n");

                while (contador <= 10)
                {
                    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                    contador = contador + 1;
                }

                Console.WriteLine();
            }

        } while (numero >= 0);

        Console.WriteLine("Programa encerrado.");
    }
}