using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual lista você deseja ?");
            int exercicio = Convert.ToInt32(Console.ReadLine());    

            
            switch (exercicio) 
            {
                case 1:
                    Console.WriteLine("lista 01");
                    Lista01.escolherExercicio();
                    break;

                    case 2:
                    Console.WriteLine("lista 02");
                    Lista02.escolherExercicio2();
                    break;

                case 3:
                    Console.WriteLine("lista03");
                    Lista03.escolherExercicio03();
                    break;

                    case 4:
                    Console.WriteLine("lista04");
                    Lista04.escolhaExercicio4();
                    break;





            }



            
        }
    }
}
