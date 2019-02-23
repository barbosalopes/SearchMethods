using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public static class BinarySearch
    {

        private static int GetMidleItemPos(int[] array)
        {
            return (int)Math.Truncate((double)array.Length/2);
            
        }

        private static int[] GetNewArrayWithLowerItems(int[] array, int pos)
        {
            return (int[])array.Take(pos-1);
        }

        public static int Search(int[] array, int value)
        {
            int midleItemPos = GetMidleItemPos(array);
            int midleItem = array[midleItemPos];

            if(value == midleItemPos)
                return array[midleItemPos];
            else 
                if(value < midleItem)
                    return Search(GetNewArrayWithLowerItems(array, pos), value)
                else 
        }   
    }
}
