namespace program01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region InputMethod.ReadLine()
            Console.WriteLine("enter the name(string)");
            String value = Console.ReadLine();
            Console.WriteLine(value);

            Console.WriteLine("enter the boolean value");
            bool bool1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(bool1);
            #endregion
        }
    }
}
