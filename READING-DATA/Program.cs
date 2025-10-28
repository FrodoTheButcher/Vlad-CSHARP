namespace READING_DATA
{
  internal class Program
  {
    static void Main(string[] args)
    {
      /*
       mesaj = input()
       print(mesaj)
       */
      string mesaj = Console.ReadLine();
      Console.WriteLine(mesaj);


      /*
       x = int(input("Introduceti primul numar"))
       y = int(input("Introduceti al doilea numar"))
       sum = x+y
       print(sum)
       */

      Console.WriteLine("Introduceti primul numar");
      int x = int.Parse(Console.ReadLine());
      Console.WriteLine("Introduceti al doilea numar");
      int y = int.Parse(Console.ReadLine());
      int sum = x + y;
      Console.WriteLine(sum);
    }
  }
}
