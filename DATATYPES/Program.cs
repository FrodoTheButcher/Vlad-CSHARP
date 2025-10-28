namespace DATATYPES
{
  internal class Program
  {

    // Entry point of the program
    static void Main(string[] args)
    {
      bool bol = false;//1 or 0| true or false

      ushort u = 2;//[0,2^16] -> DOAR NUMERE INTREGI    
      uint c = 5; //[0,2^32] -> DOAR NUMERE INTREGI 
      ulong v = 5; //[0,2^64] -> DOAR NUMERE INTREGI

      short x0 = 2;//[-2^16,2^16] -> DOAR NUMERE INTREGI 
      int x = 5; //[-2^32,2^32] -> DOAR NUMERE INTREGI 
      float z = 5.5f;//[-2^32,2^32] -> ARE VOIE NUMERE REALE 
      long x2 = 5; //[-2^64,2^64] -> DOAR NUMERE INTREGI
      double z2 = 5.5;//[-2^64,2^64] -> ARE VOIE NUMERE REALE

      string a = "hello";//SIRURI DE CARACTERE  NEEAPARAT ""!
      char caracter = 'a';//CARACTER NEEAPARAT ''!

    }
  }
}
