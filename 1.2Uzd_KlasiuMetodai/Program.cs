namespace _1._2Uzd_KlasiuMetodai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();
            rectangle.Heigth = Convert.ToDouble(Console.ReadLine());
            rectangle.Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(rectangle.Perimeter());
            Console.WriteLine(rectangle.Area());    
        }
    }
}