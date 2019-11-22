using System;
using System.Collections.Generic;

namespace PracticProblemEnvironment
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        class Solution
        {

            // https://www.hackerrank.com/challenges/compare-the-triplets/problem

            static List<int> compareTriplets(List<int> a, List<int> b)
            {

                List<int>[] scoreResult = new List<int>[2];

                foreach (int aliceIndex in a)
                {
                    foreach (int bobIndex in b)
                    {
                        if (aliceIndex > bobIndex)
                            scoreResult[aliceIndex] = scoreResult[aliceIndex] + 1;
                        Console.WriteLine("Alice gets a point.");

                        if (aliceIndex < bobIndex)
                            scoreResult[bobIndex] = bobIndex + 1;
                        Console.WriteLine("Bob gets a point.");

                        //how to increment the value of an index inside an array

                        if (aliceIndex == bobIndex)
                            Console.WriteLine("No points given");

                        return scoreResult;
                    }
                }
            }

        }
}

