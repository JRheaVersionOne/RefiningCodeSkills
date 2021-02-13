//ConsoleIntro App

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

        public static string ToCamelCase(string str){
            
            if (str.Contains('-') || str.Contains('_')){
                var stringList = str.Split('-', '_');
                for(int i = 1; i < stringList.Length; i ++){
                    stringList[i] = char.ToUpper(stringList[i][0]) + stringList[i].Substring(1).ToLower();
                }
                str = string.Concat(stringList);
            }
            return str;
            
        }
    }
}
