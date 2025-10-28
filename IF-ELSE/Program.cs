namespace IF_ELSE
{
  internal class Program
  {
    //Sa se citeasca varsta unui user
    //Sa se afiseze daca este major sau minor
    static void Main(string[] args)
    {
      Console.WriteLine("Introduceti varsta dvs.");
      int age = int.Parse(Console.ReadLine());//"18"->18
      /*if age >= 18:
          print("Major")
      else:
          print("Minor")*/
      if (age >= 18)
      {
        Console.WriteLine("Major");
      }
      else
      {
        Console.WriteLine("Minor");
      }



      //EX2:
      /*
       Sa se citeasca un numar de la 1 la 7.
      Sa se afiseze ziua din saptamana careia i corespunde
       */
      Console.WriteLine("Introduceti o zi a saptamanii ca numar");
      int zi = int.Parse(Console.ReadLine());
      /*
       if zi == 1:
          print("Luni")
       elif zi == 2:
          print("Marti")
       elif zi == 3:
          print("Miercuri")
      ...
       else:
          print("Duminica")
       */
      if (zi == 1)
      {
        Console.WriteLine("Luni");
      }
      else if (zi == 2)
      {
        Console.WriteLine("Marti");
      }
      else if (zi == 3)
      {
        Console.WriteLine("Miercuri");
      }
      //....
      else
      {
        Console.WriteLine("Duminica");
      }
    }
  }
}
