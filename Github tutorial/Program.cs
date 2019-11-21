using System;

namespace Github_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sim, senha;
            String no = "não", yes = "sim", name;


            Console.WriteLine("Desaja criar um conta sim ou não?:");
            name = Console.ReadLine();
            

            while (true)
            {

                if (name == yes)
                {
                    Console.WriteLine("Digite o nome da conta");
                    name = Console.ReadLine();
                }
                if (name == no)
                {
                    Console.WriteLine("Tudo bem!");
                    break;

                }
              



                Console.WriteLine("Agora registre uma senha apenas com numeros");
                senha = (int.Parse(Console.ReadLine()));




                Console.WriteLine("Confira a senha");
                n = (int.Parse(Console.ReadLine()));
                if (n == senha)
                    Console.WriteLine("Senha Correta");


                else
                {
                    Console.WriteLine("Senha Incorreta");
                    Console.WriteLine("deseja tentar novamente, se sim pressione 1");
                    sim = (int.Parse(Console.ReadLine()));


                    if (sim == 1)
                        Console.WriteLine("Digite a senha novamente");
                    n = (int.Parse(Console.ReadLine()));



                    if (n == senha)
                    {
                        Console.WriteLine("Senha correta");
                    }



                    else
                        Console.WriteLine("limite de tentativas atingido");
                    break;

                }

                Console.WriteLine("Esses são os dados da conta");
                Console.WriteLine("o nome é" + ' ' + name);
                Console.WriteLine("a senha é" + ' ' + senha);

                Console.ReadLine();






























            }
        }
    }
}
