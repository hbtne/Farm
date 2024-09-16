
class Program
{
    public static void Main(string[] args)
    {
          Console.WriteLine("So bo ban dau: ");
        int soBo = int.Parse(Console.ReadLine());

        Console.WriteLine("So cuu ban dau: ");
        int soCuu = int.Parse(Console.ReadLine());

        Console.WriteLine("So de ban dau: ");
        int soDe = int.Parse(Console.ReadLine());

        Farm farm = new Farm(soBo, soCuu, soDe);

        Console.WriteLine("\nTieng keu o nong trai:");
        farm.TatCaGiaSucDoi();

        Console.WriteLine("\nThong ke:");
        farm.ThongKe();
    }
}
