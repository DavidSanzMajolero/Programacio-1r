using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Activitats
{
    public class Program
    {
        public static void Main()
        {
            int[] array = {1,2,3,4,5,6,7,8,9,10};
            var myLinQuery = from num in array
                             where (num % 2) == 0
                             select num;
            foreach (int num in myLinQuery)
            {
                Console.Write("{0} ", num);
            }

        }
    }
}