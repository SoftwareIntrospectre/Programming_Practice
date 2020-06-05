
/*
     Triple Step: 
    
        A child is running up a staircase with n steps and can hop either 1 step, 2 steps, or 3 steps at a time.
        Implement a method to count how many possible ways the child can run up the stairs
*/

using System;

namespace TripleStep
{
    class Program
    {
        static void Main(string[] args)
        {
            ChildStep childStep = new ChildStep();
            // Console.WriteLine(childStep.countWays(37)); //now, how do we check if this is valid? Let's see if this example works.
            Console.WriteLine(childStep.optimized_countSteps(37));
            //If there are 20 steps: That's 121,415 ways this could happen.
        
            //we chose to use Int16 for this to prevent an overload from int
                //this is important because we'd need enough space to account for the number of possiblities for large numbers
        }
    }

    public class ChildStep
    {
        //Step 1. Solve this with a Brute Force Approach to better understand how this works.

        public int countWays(int n) //taking in the number of steps, and output the number of ways this could be done
        {
            //we take in the number of steps
            //we can determine the nth step with the following:
                // Get to step n-1, then go up 1 step
                // Get to step n-2, then go up 2 steps
                // Get to step n-3, then go up 3 steps
                    // we're essentially splitting this into 2 parts for each portion: the amount of steps we know we need to take at the very end, and the remaining steps before that

            //I'm going to start with a brute-force solution, so that we can get AN answer...and use that as a foundation to opitimize it.

            //I'm thinking we can solve this using recursion. First we need to determine our base cases.
                //If n == 0, then we'll return 1. We could define it as 0, but it's simpler to define as 1
                    // In this case, the top step will be 1-1, which is 0. That means we're at the top of the stairs.
                    // 1-2 is -1, which is invalid. We would not count that case. Same for 1-3, which is an invalid -2.
                        // That leads us to our second base case: If n < 0, then return 0. This prevents the counter from decrementing when it shouldn't

            //With that out of the way, we can move onto the number of valid steps.
            //We want to consider each case, then add them up.
                // Since there are 3 possibliities, we want to add all of those combinations of steps together. We'll do this by calling the countWays function for each of those 3 cases 
                // using recursion


            if(n < 0)
            {
                return 0;
            }

            if(n == 0)
            {
                return 1;
            }

            else
            {
                return countWays(n - 1) + countWays(n - 2) + countWays(n - 3);
            }
        }

        public Int64 optimized_countSteps(Int64 n)
        {
            //now we're going to cache the values from repeated steps using memoization
            //We'll do this by initializing an array, and filling that with -1
            //The reason for this: -1 can be used as a "flag" that signifies that value has not been visited yet.

            Int64[] memoizationCache = new Int64[n + 1]; // the array can contain all of n, and 1 extra
            Array.Fill(memoizationCache, -1);
            //now we're going to computer this using a helper function: compute_CountSteps. Let's make that now
            return compute_CountSteps(n, memoizationCache);
        }

        private Int64 compute_CountSteps(Int64 n, Int64[] cache)
        {
            //the base cases are the same as before

             if(n < 0)
            {
                return 0;
            }

            if(n == 0)
            {
                return 1;
            }

            //now we have the additional case if cache[n] > -1, return that value
            else if(cache[n] > -1)
            {
                return cache[n];
            }

            //now we do the recursion. This accounts for all other operations until the base case has been met
            else
            {
                cache[n] = compute_CountSteps(n - 1, cache) + compute_CountSteps(n - 2, cache) + compute_CountSteps(n - 3, cache);

                //every time this computation is done, return the value within cache[n]
                return cache[n];

                //we'll use the results in this method for optimized_Countways' recursion
            }
        }
    }
}
