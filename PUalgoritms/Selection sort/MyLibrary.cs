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
    }
}
