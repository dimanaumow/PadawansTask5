using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            bool flag = true;

            string Message = "Yes"; 
            for(int i = 0; i < source.Length; i++)
            {
                if(source[i] != source[source.Length - i - 1])
                {
                    flag = false; 
                }
            }

            if(!flag)
            {
                Message = "No"; 
            }

            return Message; 
        }
    }
}
