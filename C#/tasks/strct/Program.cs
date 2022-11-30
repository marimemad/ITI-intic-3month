// See https://aka.ms/new-console-template for more information
using System;

namespace MyApplication
{
  class Program
  {
    enum position {Manager , Leader , Senior , Junior };
    enum job_type {full_time,part_time};
    struct Employee{
            public string name;
            public int salary;
            public int id;
            public position p;
            public job_type jt;

            public void fill_data(string name, int salary, int id,position p, job_type jt){
                this.name=name;
                this.salary=salary;
                this.id=id;
                this.p=p;
                this.jt=jt;
            }
            public void print_data(){
                Console.WriteLine("The name {0}",name);
                Console.WriteLine("The salary {0}",salary);
                Console.WriteLine("The id {0}",id);
                Console.WriteLine("The position {0}",p);
                Console.WriteLine("The jop type {0}",jt);
            }
        }

    public static void  welcome(params string[] list){
        
        for(int i=0;i<list.Length;i++){
            Console.WriteLine("Welcome {0}",list[i]);
        }
    }
    static void Main(string[] args)
    {
        Employee emp= new Employee();
        emp.fill_data("marim", 1500, 55, position.Senior, job_type.full_time);
        emp.print_data();
        welcome("Ahmed","Emad","mohamed");
    }
  }
       
}
        
