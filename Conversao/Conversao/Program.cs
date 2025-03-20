using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte num1 = 100; // 8 bits, de 0 a 255
            ushort num2; // 16 bits, 0 a 65.535
            //conversao explicita:
            float num3 = 100f;
            int num4 = (int)num3;
            //metodo parse
            string txt = "2984";
            int numero = int.Parse(txt);
        }
    }
}
