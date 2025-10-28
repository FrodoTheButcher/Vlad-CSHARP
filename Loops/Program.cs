namespace Loops
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //EX1:Sa se afiseze numerele de la 1 la 10
      //for i in range(1,11): -> i va merge de la 1 la 10
      //   print(i)

      for (int i = 1; i <= 10; i++)
      {
        Console.WriteLine(i);
      }

      //EX2:Sa se afiseze numerele de la 1 la n
      /*
       n = int(input("Introduceti numarul pana unde sa se afiseze"))
       for i in range(1,n+1):
         print(i)
       */
      int n = int.Parse(Console.ReadLine());
      for (int i = 1; i <= n; i++)
      {
        Console.WriteLine(i);
      }

      //EX3:Sa se afiseze numerele de la a la b unde a <b
      /*
       a = int(input("Introduceti capatul inferior al intervalului"))
       b = int(input("Introduceti capatul superior al intervalului"))
       for i in range(a,b+1):
         print(i)
       */
      Console.WriteLine("Introduceti capatul inferior al intervalului");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Introduceti capatul superior al intervalului");
      int b = int.Parse(Console.ReadLine());
      for (int i = a; i <= b; i++)
      {
        Console.WriteLine(i);
      }


      /*WHILE LOOPS*/
      /*int x = 0;
      while(x<=10)
      {
        Console.WriteLine(x);//0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 00 0 0 0  INFINITE LOOP !GRESIT
      }*/
      int x = 0;
      while (x <= 10)
      {
        Console.WriteLine(x);//0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 00 0 0 0  INFINITE LOOP !GRESIT
        x++;//NU MAI E INFINITE LOOP
      }
    }

  }
}
