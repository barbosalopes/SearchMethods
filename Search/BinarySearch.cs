using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search
{
    public static class BinarySearch
    {      
        public static Nullable<int> Search(int[] array, int value)
        {
            int midleItemPos = (int)Math.Truncate((double)array.Length / 2);

            if (midleItemPos == 0)
                return null;
            else
            {
                int midleItem = array[midleItemPos];
                if (value == midleItemPos)
                    return array[midleItemPos];
                else
                {
                    if (value < midleItem)
                        return Search(new ArraySegment<int>(array, 1, 2), value);
                    else
                        //return Search(new ArraySegment<string>(a, 1, 2);, value);
                }
            }
        }   
    }
}
