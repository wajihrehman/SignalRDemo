using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prep
{
    internal class Examples
    {
        class solution
        {
            public int calcu(int win, int draw, int lose)
            {

                var points = (win*3)+(draw*1)+(lose*0);
                return points;
            } 
        }
        public class caller
        {
            public static void Main()
            {
                var call = new solution();
                Console.WriteLine("Enter Win:");
                var win = Console.ReadLine();
                Console.WriteLine("Enter draw:");
                var draw = Console.ReadLine();
                Console.WriteLine("Enter lose:");
                var lose =Console.ReadLine();
                var result=call.calcu(int.Parse(win),int.Parse(draw),int.Parse(lose));
                Console.WriteLine("Points : "+result);
            }
        }
    }
}
