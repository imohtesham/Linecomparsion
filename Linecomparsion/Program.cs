namespace Linecomparsion
{
    public class line

    {
        int x1;
        int x2;
        int y1;
        int y2;

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter start line(x1, y1) and End-point(x2 , y2) co-ordinates of line : ");

            Console.Write("x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 : ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            //length
            double length = Math.Sqrt(x2 - x1) * (y2 - y1);
            Console.WriteLine("Length of line have cooridnates(0,1) and (2,3) IS :(4)", x1, x2, y1, y2, length);
            

            line myobj = new line();
    
            myobj.x1 = x1; myobj.y1 = y1;
            myobj.x2 = x2; myobj.y2 = y2;

            Console.WriteLine(myobj.x1);
            Console.WriteLine(myobj.y1);
            Console.WriteLine(myobj.x2);
            Console.WriteLine(myobj.y2);


            Console.WriteLine("Using equals() method: {0}", x1.Equals(y1));
            Console.WriteLine("Using equals() method: {0}", x2.Equals(y2));


            //CompareTso
            int status = x1.CompareTo(y1);

            // checking the status
            if (status > 0)
                Console.WriteLine("{0} is greater than {1}", x1, y1);

            else if (status < 0)
                Console.WriteLine("{0} is less than {1}", x1, y1);

            else
                Console.WriteLine("{0} is equal to {1}", x1, y1);
            Console.ReadLine();


            int status2 = x2.CompareTo(y2);

            // checking the status
            if (status > 0)
                Console.WriteLine("{0} is greater than {1}", x2, y2);

            else if (status < 0)
                Console.WriteLine("{0} is less than {1}", x2, y2);

            else
                Console.WriteLine("{0} is equal to {1}", x2, y2);
            Console.ReadLine();



        }








    }
}