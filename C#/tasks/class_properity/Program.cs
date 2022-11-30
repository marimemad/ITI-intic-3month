using System;

namespace MyApplication
{
    class Employee{
        public string Name{set;get;}
        public int Id{set;get;}
        public int Salary{set;get;}
        public string Position{set;get;}
        public string Jop_Type{set;get;}

        public Employee() : this("Marim", 55, 1500, "Senior", "Full time"){}
        public Employee(string name, int id, int salary, string position, string jop_type){
            Name=name;
            Id=id;
            Salary=salary;
            Position=position;
            Jop_Type=jop_type;
        }
    }

  
  class Program
  {    
    public static string reverse(string sentance){
        string reversed="";
        for(int i= sentance.Length; i>0; i--){
            reversed+=sentance[i-1];
        }
        return(reversed);
    }

    public static void chack(string Fdata, string Sdata){
        Console.WriteLine("{0}  {1}",Fdata.Length,Sdata.Length);
        if(Fdata.Length==Sdata.Length){
            int i=0;
            while(Fdata[i]==Sdata[i] && i<Fdata.Length-1){
                i++;
            }
            if (i==Fdata.Length-1){
                Console.WriteLine("valid");    
            }
            else{
                Console.WriteLine("not valid");
            }
        }
        else{
            Console.WriteLine("not valid");
        }
    }
    
    public static void sum(int[][] arr){
        int s;
        foreach (int[] a in arr){
            s=0;
            foreach(int n in a){
                s+=n;
            }
            Console.WriteLine("sum= {0}",s);
        }
    }
    static void Main(string[] args)
    {
        string username, password;

        Employee opj= new();
        Console.WriteLine("the employee name: {0}",opj.Name);
        Console.WriteLine(reverse("Mohamed"));

        username=(string)Console.ReadLine();
        password=(string)Console.ReadLine();
        chack("Mohamed",username);
        chack("M123**",password);

        int[][] arr;
        int n;
        arr= new int[4][];

        for(int i=0;i<4;i++){
            n= int.Parse(Console.ReadLine());
            arr[i]= new int[n];
            for (int j=0; j<n; j++){
                arr[i][j]= int.Parse(Console.ReadLine());
            }
        }
        arr[0]= new int[5] {9,6,4,2,3};
        arr[1]= new int[6] {3,2,6,8,1,5};
        arr[2]= new int[3] {3,2,1};
        arr[3]= new int[5] {3,2,6,8,1};
        sum(arr);

    }
  }
}