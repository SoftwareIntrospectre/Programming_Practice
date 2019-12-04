    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[3,3];

            array[0,0] = "One";
            array[0,1] = "Two";
            array[0, 2] = "Three";
            array[1, 0] = "Four";
            array[1, 1] = "Five";
            array[1, 2] = "Six";
            array[2, 0] = "Seven";
            array[2, 1] = "Eight";
            array[2, 2] = "Nine";

            int uBound0 = array.GetUpperBound(0);

            int uBound1 = array.GetUpperBound(1);

            for(int i = 0; i <= uBound0; i++)
            {
                for(int j = 0; j <= uBound1; j++)
                {
                    string res = array[i,j];
                    Console.WriteLine(res);
                }
            }
        }
    }
