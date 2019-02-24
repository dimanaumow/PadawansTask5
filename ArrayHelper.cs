using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if(source.Length == 0)
            {
                throw new ArgumentException("Source Cannot Be Empty"); 
            }

            if(source == null)
            {
                throw new ArgumentNullException(nameof(source)); 
            }

            string Message = "Yes";
            
            for(int i = 0; i < source.Length; i++)
            {
                if(source[i] != source[source.Length - i - 1])
                {
                    Message = "No";  
                }
            }

            return Message; 
        }
    }
}
