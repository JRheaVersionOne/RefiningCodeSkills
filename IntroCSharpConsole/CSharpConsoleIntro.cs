//ConsoleIntro App
using System.Linq;
using System;
using System.Collections;
namespace CSharpConsoleIntro{
    public class SortChallenge
    {
        public void swap(int indexOne, int indexTwo, int[] array){
            if (indexOne < array.Length && indexTwo < array.Length){
                int temp = array[indexOne];
                array[indexOne] = array[indexTwo];
                array[indexTwo] = temp;
            }
        }
        public void Bubblesort(int[] array){
            int LoopCounter = 0;
            bool swapCheck = false;
            for (int i = 0; i < array.Length; i++)
            {
                swapCheck = false;
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j+1]){
                        swap(j, j+1, array);
                        swapCheck = true;
                    }
                }
                LoopCounter++;
                if (swapCheck == false){
                    break;
                }
            }
            Console.WriteLine("Number of loops till sort stop at: " + LoopCounter);
        }

        public void BinarySearch(int start, int end, int[] searchArray){

        }
        public static int DescendingOrder(int num)
        {
            if (num > 0){
                // string numString = num.ToString();
                // IOrderedEnumerable<char> numList = numString.OrderByDescending(e => e);
                // int sortListNum = int.Parse(string.Concat(numList));

                return int.Parse(string.Concat(num.ToString().OrderByDescending(e => e)));
            }
            
            return 0;
        }

        public static int SquareDigits(int n)
        {
            var listNums = String.Concat(n.ToString().Select(e => Math.Pow(char.GetNumericValue(e), 2)));

            return 0;
            
        }
    }
}

