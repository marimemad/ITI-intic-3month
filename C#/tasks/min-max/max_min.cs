// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;

namespace MyAppp
{
  class Program {
    public static void swap(int x, int y){
      int temp;
      temp=x;
      x=y;
      y=temp;
    }
    static void Main(string[] args) {
      int max,min,number,counter,numbers, a, b;
      a=3;
      b=5;
      swap(a,b);
      Console.Write(a+b);
      Console.Write("enter number of numbers :");
      numbers=int.Parse(Console.ReadLine());

      Console.Write("Enter a number: ");
      number=int.Parse(Console.ReadLine());
      max=min=number;
      
      for (counter=1;counter<numbers;counter++){
        Console.Write("Enter a number: ");
        number=int.Parse(Console.ReadLine());
        if(number>max){
            max=number;
        }
        if(number<min)
        {
            min=number;
        }
      }
      Console.WriteLine("The Maxmum number: {0}",max);
      Console.WriteLine("The Minmum number: {0}",min);
      Console.WriteLine("The Value of " + min + " + " + min + " = " + (min+min));


    }
  }
}

