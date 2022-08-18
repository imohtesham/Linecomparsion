namespace Linecomparsion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start(x1,y1) and End-point(x2, y2) co-ordinates line :");
            Console.WriteLine("x1 : ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y1 : ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("x2 : ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y2 : ");     
            int y2 = Convert.ToInt32(Console.ReadLine());

            //length of line
            double Length = Math.Sqrt((x2 - x1) * (x1 - x2) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("Length of line have co-ordinates({0}{1}) and({2}{3}) is : {4}" , x1,y1 ,x2,y2);

        }
    }
}