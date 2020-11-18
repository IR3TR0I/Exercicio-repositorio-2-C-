using System;

namespace Exercicio_2_de_Repetição_C_
{
    class Program
    {
        static void Main(string[] args)
        {

            string login = "";
            string senha = "";

            while(true){
                Console.WriteLine("Digite seu login");
                login = Console.ReadLine();

                
                Console.WriteLine("Digite sua senha: ");
                senha = Console.ReadLine();

                if(login == senha){
                    Console.WriteLine("Há algo de errado no login ou na senha");
                }else{break;}
            }
            Console.WriteLine("Login aprovado,Bem-vindo" +login);
        }
    }
}
