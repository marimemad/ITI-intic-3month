using System;

namespace MyApplication
{
  class Program
  {
    static void Swap(ref int n1,ref int n2 )
    {
        int temp;
        temp=n1;
        n1=n2;
        n2=temp;
    }
    static void swap(int x, int y){
      int temp;
      temp=x;
      x=y;
      y=temp;
    }
    static int Power(int number, int basee){
        int result=number;
        if (basee!=1){
            result=number*Power(number,basee-1);
        }
        return (result);
    }

    static int Facturial(int number){
        int result=1;
        if (number!=1){
            result=number*Facturial(number-1);
        }
        return (result);
    }

    static void Main(string[] args)
    {
      int n1,n2, result=1;

      Console.Write("Emter The first number ");
      n1=int.Parse(Console.ReadLine());

      Console.Write("Emter The second number ");
      n2=int.Parse(Console.ReadLine());
      swap(n1,n2);
      Console.WriteLine("The first number {0}",n1);
      Console.WriteLine("The second number {0}",n2);
       
      Swap( ref n1, ref n2);
      Console.WriteLine("The first number {0}",n1);
      Console.WriteLine("The second number {0}",n2);


      Console.WriteLine(Power(n1,n2));
      Console.WriteLine(Facturial(n2));
      for(int i=1;i<=n2;i++){
        result*=i;
      }
      Console.WriteLine(result);

    }
  }
}