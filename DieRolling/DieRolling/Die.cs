using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRolling
{
    /// <summary>
    /// this class is about Rolling the Die and the events that rise during the process.
    /// </summary>
    public class Die
    {
        public delegate void RollEvent();//Delegate declaration for events that rise during the rolling process
        public event RollEvent TwoSequentialFours;//the event of meeting two sequant fours in a row! 
        public event RollEvent SumIsGreatThanTwenty;//the event that rises when five sequential numbers sum is great than 20


        //Rolling the die and operating the events
        public void Rolling()
        {
            //List for collecting all rolled dies numbers
            var RolledDies = new List<int>();
            var random = new Random();

            var Sum = new List<Int32>();
            int j = 1; //variable for comparing two sequal rolled dies' numbers

            //Rolling the die
            for (int i = 0; i < 50; ++i)
            {
                //Checking if the count of list for five sequance nubers is five 
                if (Sum.Count == 5)
                {
                    HelpSum(Sum);
                    Sum.Remove(Sum[0]);
                    
                }

                RolledDies.Add(random.Next(1, 7)); // Rolling the die
                Sum.Add(RolledDies[i]);
                Console.WriteLine("Rolled die number is {0}", RolledDies[i]);
                if (i > 0 && i < 50)
                {
                    //checking the condition foe the event of two sequance equal rolled die numbers
                    if (RolledDies[j] == RolledDies[j - 1] && RolledDies[j] == 4)
                    {
                        //checkig whether there is a subscribed function
                        if (TwoSequentialFours != null)
                        {
                            //rising the event
                            TwoSequentialFours();
                            //chekincg if i is the index of prefinal element
                            if (i < 49)
                            {

                                //if i is not tne prefinal elements index add new element
                                RolledDies.Add(random.Next(1, 7));
                                Console.WriteLine("Rolled die number is {0}", RolledDies[i]);
                                ++i;
                                ++j;

                                //Checking if the count of list for five sequance nubers is five 
                                if (Sum.Count == 5)
                                {
                                    HelpSum(Sum);
                                    Sum.Remove(Sum[0]);

                                }
                                else
                                {
                                    Sum.Add(RolledDies[i]);
                                }

                            }
                        }
                    }
                    ++j;
                }
            }

        }

        /// <summary>
        /// Helper function for calculating the sum of members in the list of ints and rising the event
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private void HelpSum(List<Int32> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; ++i)
            {
                sum += list[i];
            }
            if (sum > 20)
            {
                SumIsGreatThanTwenty();
            }
        }
         

    }
}
