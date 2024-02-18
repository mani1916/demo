using System.Text;

namespace demo
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(3, 5) };
            foreach (Shape item in shapes)
            {
                item.GetInfo();
                System.Console.WriteLine(item.ToString());
                // System.Console.WriteLine(item.Area());
            }

            int[] a = { 1, 2, 3, 4 };
            double[] ab = { 1, 2, 3, 4 };
            String[] s = { "1", "2", "3", "4" };
            // display(a);
            // display(ab);
            // display(s);

        }
        public static void display<Thing>(Thing[] a){
            foreach(Thing b in a)
            System.Console.WriteLine(b);
        }

    }
}
