using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsCSharp
{
    internal class CreatePhoneNumber
    {
        public static string Kata(int[] numbers)
        {
           var msg = string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], numbers[5], numbers[6], numbers[7], numbers[8],numbers[9]);
            

            return msg;
        }
    }
}
