using System;

class Program
{
    static void Main()
    {
        // Número a ser verificado (pode ser trocado por Console.ReadLine() se quiser entrada do usuário)
        int numero = 21;

        // Variáveis para calcular a sequência de Fibonacci
        int a = 0;
        int b = 1;
        bool pertence = false;

        // Verifica até que o valor de 'a' ultrapasse ou iguale o número informado
        while (a <= numero)
        {
            if (a == numero)
            {
                pertence = true;
                break;
            }

            int proximo = a + b;
            a = b;
            b = proximo;
        }

        if (pertence)
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        else
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci.");
    }
}
