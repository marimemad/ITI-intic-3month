using System;

namespace MyApplication
{
  class Employee{
        int id;
        string name;
        float salary;
        public void setId(int id){
            this.id=id;
        }
        public int getId(){
            return id;
        }

        public void setName(string name){
            this.name=name;
        }
        public string getName(){
            return name;
        }

        public void setSalary(float salary){
            this.salary=salary;
        }
        public float getSalary(){
            return salary;
        }
        public Employee(){
            Console.WriteLine("The Object initialized");
        }
        public Employee(int id){
            this.id=id;
        }
        public Employee(int id, string name){
            this.id = id;
            this.name = name;
        }
        public Employee(int id, string name, float salary){
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
    }
  
   abstract class Person{
        int id;
        string name;
        public void setId(int id){
            this.id=id;
        }
        public int getId(){
            return id;
        }

        public void setName(string name){
            this.name=name;
        }
        public string getName(){
            return name;
        }
        public Person(){
            Console.WriteLine("The Object initialized");
        }
        public Person(int id, string name){
            this.id = id;
            this.name = name;
        }
        public abstract  void print_data();
        
  }
  
  class Costomer:Person{
        int account_number;
        public void setAccount_number(int account_number){
            this.account_number=account_number;
        }
        public int getAccount_number(){
            return (account_number);
        }
        public Costomer(){
            Console.WriteLine("The Object initialized");
        }
        public Costomer(int id, string name, int account_number):base(id, name){
            this.account_number = account_number;
        }
        public override void print_data(){
            Console.WriteLine("The Id : {0}",getId());
            Console.WriteLine("The Name : {0}",getName());
            Console.WriteLine("The Salary : {0}",getAccount_number());
        }
  }

  class Employe:Person{
        float salary;
        public void setSalary(float salary){
            this.salary=salary;
        }
        public float getSalary(){
            return salary;
        }
        public Employe(){
            Console.WriteLine("The Object initialized");
        }
        public Employe(int id, string name, float salary):base(id, name) {
            this.salary = salary;
        }
        public override void print_data(){
            Console.WriteLine("The Id : {0}",getId());
            Console.WriteLine("The Name : {0}",getName());
            Console.WriteLine("The Salary : {0}",getSalary());
        }
        
  }
  class Program
  {
    public static Employee fill_data(Employee obj){
        int id;
        string name;
        float salary;

        Console.Write("Plese Enter The data");
        Console.Write("The Id : ");
        id= int.Parse(Console.ReadLine());

        Console.Write("The Name : ");
        name= Console.ReadLine();

        Console.Write("The Salary : ");
        salary= float.Parse(Console.ReadLine());

        obj.setId(id);
        obj.setName(name);
        obj.setSalary(salary);
        
        return (obj);
    }

    public static void print_data(Employee obj){
        Console.WriteLine("The Id : {0}",obj.getId());

        Console.WriteLine("The Name : {0}",obj.getName());

        Console.WriteLine("The Salary : {0}",obj.getSalary());
    }
    
    static void Main(string[] args)
    {
        Employee obj;
        obj = new Employee();
        
        obj = fill_data(obj);
        print_data(obj);

        float s=1500;
        int an=5, i=60;
        string n="marim";

        Person obj1= new Employe(i,n,s);
        Person obj2 = new Costomer(i,n,an);
        Console.WriteLine("__________________");
        obj1.print_data();
        Console.WriteLine("__________________");
        obj2.print_data();
      
    }
  }
}