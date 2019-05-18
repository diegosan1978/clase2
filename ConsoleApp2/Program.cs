using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //esto llama a la funcion grados farenheit
            int centigrados = 15;
            int resultado = convertirafarenheit(centigrados);
            Console.WriteLine;


        }

        //funcion a grados farenheit
       static int convertirafarenheit(int gradoscentigrados){

            int gradosfarenheit = 9 / 5 * gradoscentigrados + 32;
            return gradosfarenheit;

        }
    }
}
