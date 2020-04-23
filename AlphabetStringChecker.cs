using System;

namespace StringCompression
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString1 = "1256";
            
            string testString2 = "abfawegagAgwaefeA";

            string testString3 = "-+;";

            string testString4 = null;

            string testString5 = "";


            isStringOnlyAlphabet(testString1);

            isStringOnlyAlphabet(testString2);

            isStringOnlyAlphabet(testString3);

            isStringOnlyAlphabet(testString4);

            isStringOnlyAlphabet(testString5);
        }

          public static bool isStringOnlyAlphabet(string inputString)
            {
                //ensures there's no blank strings as an input
                if(inputString == null || inputString == "")
                {
                    Console.WriteLine("No string present. exiting.");
                    return false;
                }

                else
                {
                    for (int i = 0; i < inputString.Length; i++)
                    {
                        char characterInString = inputString[i];

                        //checks to see if each character is anything outside of a-z and A-Z
                        if((!(characterInString >= 'a' && characterInString <= 'z')) && (!(characterInString >= 'A' && characterInString <= 'Z')))
                        {
                            Console.WriteLine("'" + characterInString + "'" + " is not a valid character. It's not part of the alphabet.");
                            return false;
                        }
                    }
                }

                Console.WriteLine("This string is valid. All characters are only part of the alphabet.");
                return true;
            }
        }
    }
