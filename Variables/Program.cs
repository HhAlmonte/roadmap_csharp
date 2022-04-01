using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Byte y Sbyte

            byte byte1 = 255;
            byte byte2 = 240;

            Console.WriteLine(byte1 + byte2);

            Console.WriteLine("-------------------------------");

            sbyte sbyte1 = 127;
            sbyte sbyte2 = -128;

            Console.WriteLine(sbyte1 + sbyte2);
            #endregion

            #region Short
            short short1 = 30000;

            #endregion

            #region INT
            uint myNumber = 1;
            int myNumber2 = 121;

            #endregion

            int MyNumber1 = 100;
            int MyNumber2 = 200;

            int result = MyNumber1 + MyNumber2;
            Console.WriteLine(result);
        }
    }
}