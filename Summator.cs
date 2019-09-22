using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byndyusoft
{
    public class Summator
    {
        public static int GetSumOfMinElements(int[] inputArray)
        {           
            if (inputArray.Length == 0)
                return default(int);
            else if (inputArray.Length == 1)
                return inputArray[0];
            else if (inputArray.Length == 2)
                return inputArray[0] + inputArray[1];
            else
            {
                var minElements = new int[2];
                minElements = GetMinElements(inputArray, 2);
                return minElements[0] + minElements[1];
            }
        }

        private static int[] GetMinElements(int[] array, int numberOfValues)
        {
            var resultArray = new int[numberOfValues];
            int currentValue;
            
            for (int i = 0; i < numberOfValues; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        currentValue = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = currentValue;
                    }
                }
            }
            for (int i = 0; i < numberOfValues; i++)
                resultArray[i] = array[array.Length - 1 - i];            
            return resultArray;
        }
    }
}
