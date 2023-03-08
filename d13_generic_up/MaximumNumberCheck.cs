using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d13_generic_up
{
    internal class MaximumNumberCheck
    {

        public static int MaxNumCheck(int firstValue,int secondValue,int thirdValue) {

            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue)>0) 
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0) 
            {
                return thirdValue;
            }
            throw new Exception("FirstNumber,Second Number , Third Number are same");


        }
    }
}
