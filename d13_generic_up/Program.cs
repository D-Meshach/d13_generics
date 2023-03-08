using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d13_generic_up
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxInt;
            double maxFloat;
            String maxString;
            //To find Greatest among 3 number
            //T.C1 Max at first Position
            maxInt= MaximumNumberCheck.MaxNumCheck(4,3,2);
            Console.WriteLine("The greater number among 4,3,2 is " + maxInt);
            //T.C2 Max at second Position
            maxInt = MaximumNumberCheck.MaxNumCheck(2, 5, 3);
            Console.WriteLine("The greater number among 2, 5, 3 is " + maxInt);
            //T.C3 Max at third Positon
            maxInt = MaximumNumberCheck.MaxNumCheck(2, 6, 8);
            Console.WriteLine("The greater number among 2, 6, 8 is " + maxInt);

            Console.WriteLine("The greatest among float values");
            //Maximum among three float Integers
            //T.C1 Max at first Position
            maxFloat = MaximumNumberCheck.MaxFloatCheck(4.4, 2.2, 3.3);
            Console.WriteLine("The greater Float among 4.4,2.2,3.3 is " + maxFloat);
            //T.C2 Max at second Position
            maxFloat = MaximumNumberCheck.MaxFloatCheck(4.4, 5.5, 3.3);
            Console.WriteLine("The greater Float among 4.4, 5.5, 3.3 is " + maxFloat);
            //T.C3 Max at third Position
            maxFloat = MaximumNumberCheck.MaxFloatCheck(4.4, 2.2, 6.6);
            Console.WriteLine("The greater Float among 4.4, 2.2, 6.6 is " + maxFloat);

            Console.WriteLine("The greatest among Strings");
            //Maximum among three Strings
            //T.C1 Max at first Position
            maxString = MaximumNumberCheck.MaxStringCheck("c", "b", "a");
            Console.WriteLine("The greater Float among \"a\", \"b\", \"c\" is " + maxString);
            //T.C2 Max at second Position
            maxString = MaximumNumberCheck.MaxStringCheck("D", "F", "E");
            Console.WriteLine("The greater Float among \"D\", \"F\", \"E\" is " + maxString);
            //T.C3 Max at third Position
            maxString = MaximumNumberCheck.MaxStringCheck("J", "K", "L");
            Console.WriteLine("The greater Float among \"J\", \"K\", \"L\" is " + maxString);


        }
    }
}
