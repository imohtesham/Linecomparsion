namespace Linecomparsion
{
    public class Program

    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start line(x1, y1) and End-point(x2 , y2) co-ordinates of line : ");

            Console.Write("x1 : ");
            int x1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("y1 : ");
            int y1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("x2 : ");
            int x2 =Convert.ToInt32(Console.ReadLine());
            Console.Write("y2 : ");
            int y2 =Convert.ToInt32(Console.ReadLine());

            //length
            double length = Math.Sqrt(x2 - x1) * (y2 - y1);
            Console.WriteLine("Length of line have cooridnates(0,1) and (2,3) IS :(4)",x1,x2,y1,y2, length);
            
        }
        
           
    }
}