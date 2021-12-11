using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 111, 214, 5, 21 };
            
            int UcReqemliCem = 0;
            int DigerCem = 0;
            int result;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 100 && arr[1]<=999)
                {
                    UcReqemliCem = UcReqemliCem + arr[i];
                }
                else
                {
                    DigerCem = DigerCem + arr[i];
                }
            }
            result = UcReqemliCem - DigerCem;
            Console.WriteLine(result);
            
        }
    }
}
