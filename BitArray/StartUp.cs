namespace BitArray
{
    using System;
    using Models;

    class StartUp
    {
        static void Main()
        {
            var firstArr = new BitArray64(3462674);

            Console.WriteLine("Bin: {0}", firstArr);
            Console.WriteLine("First bit = {0}, Tenth = {1}, Twentieth = {2}, Thirtieth = {3}, Fortieth = {4}, Fiftieth = {5}, Sixtieth = {6}, Last = {7}", firstArr[0], firstArr[9], firstArr[19], firstArr[29], firstArr[39], firstArr[49], firstArr[59], firstArr[63]);

            Console.WriteLine(firstArr[0] == firstArr[63]);

            //enum
            foreach (var bit in firstArr)
            {
                Console.Write(bit + " ");
            }
            Console.WriteLine();

            //equal
            var secondArr = new BitArray64(3462674);
            var thirdArr = new BitArray64(231513521);

            Console.WriteLine(firstArr.Equals(secondArr) == true ? "true" : "false");
            Console.WriteLine(firstArr.Equals(thirdArr) == true ? "true" : "false");
        }
    }
}
