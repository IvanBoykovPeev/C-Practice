using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_sort
{
    static class MyLibrary
    {
        static public void SwapElements(this int[] array, int indexOne, int indexTwo)
        {
            int tmp = array[indexOne];
            array[indexOne] = array[indexTwo];
            array[indexTwo] = tmp;
        }

        static public void SelectionSort(int[] array)
        {
            int position;
            int n = array.Length;
            int minElement;

            for (int currentElement = 0; currentElement < n-1; currentElement++)
            {
                minElement = array[currentElement];
                position = currentElement;
                for (int nextElement = currentElement + 1; nextElement < n; nextElement++)
                {
                    if (array[nextElement] < minElement)
                    {
                        minElement = array[nextElement];
                        position = nextElement;
                    }
                }
                array.SwapElements(currentElement, position);
            }
        }

        static public void InsertionSort(int[] array)
        {
            int end = array.Length;

            for (int currentElement = 1; currentElement < end; currentElement++)
            {
                int searchingElement = array[currentElement];
                int previusElement = currentElement - 1;
                while (previusElement >= 0 && searchingElement < array[previusElement])
                {
                    array[previusElement + 1] = array[previusElement--];
                    array[previusElement + 1] = searchingElement;
                }
            }
        }

        public static void BubbleSort(int[] arrray)
        {
            bool exchange;
            int index;
            int rightSide;
            int endArray = arrray.Length;

            for(rightSide = endArray - 1;rightSide > 0; rightSide--)
            {
                exchange = false;
                for (index = 0; index < rightSide; index++)
                {
                    if(arrray[index] > arrray[index + 1])
                    {
                        arrray.SwapElements(index, index + 1);
                        exchange = true;
                    }
                    if (!exchange)
                    {
                        break;
                    }
                }
            }
        }

        public static void ShellSort(int[] array)
        {
            int step;
            int i;
            int k;
            int x;
            int arrayLength = array.Length;

            step = 2; //използваме редица от стъпки ... 31,15,7,3,1
            while (step < arrayLength) step <<= 1;
            step = step / 2 - 1;
            while (step >= 1)
            {
                for (i = step; i < arrayLength; i++)
                {
                    x = array[i];
                    k = i - step;
                    while (k >= 0 && array[k] > x)
                    {
                        array[k + step] = array[k];
                        k -= step;
                    }
                    array[k + step] = x;
                }
                step = step / 2;
            }
        }
    }
}
