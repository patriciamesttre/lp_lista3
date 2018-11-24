using System;

namespace Lista3
{
    class Program
    {
        static void Main(string[] args)
        {
           /*Escreva um programa que armazene o valor 999 na variável A e
           o valor 555 na variável B. A seguir troque os conteúdos  
           fazendo com que o valor que está em A passe para B e
           vice-versa utilizando uma variável C para realizar a troca. */
         
           int A = 999;
           int B = 555;
           int C = 0;
           Console.WriteLine("A ==> " + A );
           Console.WriteLine("B ==> " + B );
           Console.WriteLine("C ==> " + C );
           Console.WriteLine("== TROCA == " );
           C = A;
           A = B;
           B = C;
           Console.WriteLine("A ==> " + A );
           Console.WriteLine("B ==> " + B );
           Console.WriteLine("C ==> " + C );
        }
    }
}
