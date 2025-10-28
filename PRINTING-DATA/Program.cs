namespace PRINTING_DATA
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //python->print("Hello world!");
      Console.WriteLine("Hello world!");


      int a = 5;
      int b = 6;
      int suma = a + b;
      /*
       python:
      a=5
      b=6
      suma=a+b
      print("Suma lui"+a+" si "+b+" este " + suma);
       */
      Console.WriteLine("Suma lui "+a+" si "+ b + " este "+suma);//INEFICIENT
      //SAU
      Console.WriteLine($"Suma lui {a} si {b} este {suma}");//EFICIENT 
     }
  }
}

/*
 class Console{

  print(),
  readData(),
  validate()
}

 */