// See https://aka.ms/new-console-template for more information
using System;

namespace MyApplication
{
  class Program
  {
    static void index_of_min_max()
    {
        int[] numbers;
        numbers = new int[5];
        int max, min,i;

        Console.WriteLine("Enter a numbers: ");
        for (i=0; i<5; i++){
            numbers[i]=int.Parse(Console.ReadLine());
        }
        max=min=0;
        for(i=0;i<5;i++){
            if(numbers[i]>=numbers[max]){
                max=i;
            }
            if (numbers[i]<=numbers[min]){
                min=i;
            }

        }
        Console.WriteLine("The maxmum = {0}, The minmum = {1}",max,min);
    }

    static void two_dimensional(){
        int[,] students;
        students = new int[3,4];
        int i,j,sum=0,avg;
        
        for(i=0;i<3;i++){
            Console.Write("enter the grades of the student: ");
            for (j=0;j<4;j++){
                students[i,j]=int.Parse(Console.ReadLine());
            }
        }

        for(i=0;i<3;i++){
            sum=0;
            for (j=0;j<4;j++){
                sum+=students[i,j];
            }
            Console.WriteLine("The sum of the student = {0}",sum);
        }

        for(i=0;i<4;i++){
            sum=0;
            for (j=0;j<3;j++){
                sum+=students[j,i];
            }
            avg=sum/4;
            Console.WriteLine("The avarage of the subject = {0}",avg);
        }
    }
    

    static void Main(string[] args)
    {
        index_of_min_max();
        two_dimensional();
        //Console.WriteLine(index_of_min_max());
    }
  }
}