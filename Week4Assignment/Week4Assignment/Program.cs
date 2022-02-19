using System;

namespace Week4Assignment
{
    class Program
    {
        public static Random random;
        static void Main(string[] args)
        {
            random = new Random();
            //variable initialization
            int l ;
            int w ;
            int min = 1;
            int max = 20;
            //Calling the GetRandomSize function to get the length and width and send the min and max
            GetRandomSize(out l, out w, min, max);
            
            Console.WriteLine("Length: " + l);
            Console.WriteLine("Width: " + w);
            //calling on the GetArea and Get perimeter functions
            Console.WriteLine("Area: " + GetArea(l,w));
            Console.WriteLine("Area: " + GetPerimeter(l, w));

        }
        // To get the Length and width of the recatangle
        static void GetRandomSize(out int l, out int w, int min, int max)
        {
            l = random.Next(min,max);
            w = random.Next(min,max);
        }
        // To get the area of the rectangle
        static int GetArea(int l, int w)
        {
            return l * w;
        }
        //To get the perimeter of the rectangle
        static int GetPerimeter(int l, int w)
        {
            return 2 * (l + w);
        }
 
    }
}








