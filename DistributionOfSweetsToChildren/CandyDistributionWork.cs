using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributionOfSweetsToChildren;

public class CandyDistributionWork
{
    public static int DistributionOfSweets(List<int> CandyForChildren)
    {
        if (CandyForChildren.Count != 1 && CandyForChildren.Count != 0)
        {
            var counter = 0;
            var theLargestNumber = 0;
            for (int i = 0; i < CandyForChildren.Count; i++)
            {
                if (CandyForChildren[i] > theLargestNumber)
                {
                    theLargestNumber = CandyForChildren[i];
                    continue;
                }
            }
            CandyForChildren.Remove(theLargestNumber);
            for (int j = 0; j < CandyForChildren.Count;)
            {
                if (CandyForChildren[j] < theLargestNumber)
                {
                    CandyForChildren[j]++;
                    counter++;
                    continue;
                }
                else
                {
                    j++;
                    continue;
                }
            }
            return counter;
        }
        else
        {
            return -1;
        }
    }
}
