namespace Program03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 20, 30, 40 };
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i);
            }
            String[] arr2 = new string[3];
            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(j);
            }

            double[] arr3 = new double[3];
            for (int k = 0; k < arr.Length; k++)
            {
                Console.WriteLine(k);
            }
            var m = arr1[0];
            Console.WriteLine(m);
        }
    }
}
