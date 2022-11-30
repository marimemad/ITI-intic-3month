
using System;

namespace MyAppp
{
  class Program {
    static void Main(string[] args) {
      int size, row, col, value;

      Console.Write("Enter odd number: ");
      size=int.Parse(Console.ReadLine());
      
      while (size%2 !=1){
        Console.Write("Enter odd number: ");
        size=int.Parse(Console.ReadLine());
      }

      row=1;
      col=(size+1)/2;
      value=1;
      Console.WriteLine("r={0} , c={1}  ----> {2}",row, col, value);

      for (value=2; value<= size*size; value++){
        if((value-1)%size!=0){
            row-=1;
            col-=1;

            if(row<=0){
                row=size;
            }

            if (col<=0){
                col=size;
            }
        }
        else{
            row+=1;
        }
      Console.WriteLine("r={0} , c={1}  ----> {2}",row, col, value);
      }

    }
  }
}

