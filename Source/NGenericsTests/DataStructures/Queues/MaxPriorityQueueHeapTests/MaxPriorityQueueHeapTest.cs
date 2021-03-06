/*  
  Copyright 2007-2017 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the MIT License.  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at https://opensource.org/licenses/MIT.
*/



using NGenerics.DataStructures.Queues;

namespace NGenerics.Tests.DataStructures.Queues.MaxPriorityQueueHeapTests
{

    public class MaxPriorityQueueTest
    {

        internal static PriorityQueue<string, int> GetSimpleTestPriorityQueue()
        {
            return new PriorityQueue<string, int>(PriorityQueueType.Maximum)
                                          {
                                              {"a", 1},
                                              {"b", 2},
                                              {"c", 3},
                                              {"d", 4},
                                              {"e", 5},
                                              {"f", 6}
                                          };
        }

        internal static PriorityQueue<string, int> GetTestPriorityQueue()
        {
            return new PriorityQueue<string, int>(PriorityQueueType.Maximum)
                                          {
                                              {"a", 1},
                                              {"b", 2},
                                              {"c", 3},
                                              {"d", 4},
                                              {"e", 5},
                                              {"f", 6},
                                              {"z", 6},
                                              {"y", 5},
                                              {"x", 4},
                                              {"w", 3},
                                              {"v", 2},
                                              {"u", 1}
                                          };
        }

    }
}