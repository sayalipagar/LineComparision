namespace LINEComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camparision camparision = new Camparision(1, 2, 3, 4);
            double line1=camparision.CaculateLength();
            Console.WriteLine("length of first line"+line1);

            Camparision linecamparision = new Camparision(1, 2, 3, 4);
            double line2 = camparision.CaculateLength();
            Console.WriteLine("length of second line" + line2);
            if (line1 == line2)
            {
                Console.WriteLine("Line 1 and Line 2 are equal");
            }
            else
                Console.WriteLine("Not Equal");
        }
    }
}