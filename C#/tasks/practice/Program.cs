using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      int[,] arr;
      int fd,sd, sum=0, in_r=0, in_c=0, value;

      Console.Write("Enter number of rows: ");
      fd=int.Parse(Console.ReadLine());

      Console.Write("Enter number of colums: ");
      sd=int.Parse(Console.ReadLine());

      arr = new int[fd,sd];
      
      Console.WriteLine("Enter element of array");
      for (int r= 0; r<fd; r++){
        for (int c=0; c<sd; c++){
            arr[r,c]=int.Parse(Console.ReadLine());
        }
      }

      for (int r= 0; r<fd-1; r++){
        for (int c=0; c<sd-1; c++){
            value=arr[r,c]+arr[r,c+1]+arr[r+1,c]+arr[r+1,c+1];
            if(sum<=value){
                sum=value;
                in_r=r;
                in_c=c;
            }
        }
      }
      Console.WriteLine("The maxmum sum= {0}",sum);
      Console.WriteLine("The starting index: ({0},{1})",in_r,in_c);
    }
  }
}