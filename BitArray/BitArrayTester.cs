namespace BitArray
{
    using System;

    static class BitArrayTester
    {
        static void Main()
        {
            var num = new BitArray(100000);

            num[876] = 1;

            Console.WriteLine(num);
            
        }
    }
}
