namespace LINEComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camparision camparision = new Camparision(1, 2, 3, 4);
            double line1 = camparision.CaculateLength();
            Console.WriteLine("length of first line" + line1);

            Camparision linecamparision = new Camparision(1, 2, 3, 4);
            double line2 = camparision.CaculateLength();
            Console.WriteLine("length of second line" + line2);
            if (line1.CompareTo(line2) == 0)
                Console.WriteLine("Both lines are same");
            if (line1.CompareTo(line2) > 0)
                
                Console.WriteLine("line 1 greator than line2 ");
                else
                 Console.WriteLine("line 2 greator than line 1");
            }
    }
    }
