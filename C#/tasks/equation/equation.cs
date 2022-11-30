 
// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;

namespace equation
{
  class Program {
    static void Main(string[] args) {
      int a,b,c,value;
      double x1,x2;
      Console.Write("Enter a the value of a: ");
      a=int.Parse(Console.ReadLine());
      
      Console.Write("Enter a the value of b: ");
      b=int.Parse(Console.ReadLine());
      
      Console.Write("Enter a the value of c: ");
      c=int.Parse(Console.ReadLine());
      
      value=b*b-(4*a*c);
      if (value<0){
        Console.WriteLine("the value of the first root = {0}+img",(-b/2*a));
        Console.WriteLine("the value of the second root = {0}-img",(-b/2*a));
      }
      else{
      	x1=(-b+(Math.Sqrt(value)))/(2*a);
        x2=(-b-(Math.Sqrt(value)))/(2*a);
        
        Console.WriteLine("the value of the first root = {0}",x1);
        Console.WriteLine("the value of the second root = {0}",x2);
      }
    }
  }
}
