using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec29_2PM
{
     public abstract class Area
         {
        public abstract void Calculate();
        }
    class circle : Area 
    {
        double r = 3.15;
      public override void Calculate()
        {
            double are = r * r * 3.14;
            Console.WriteLine("Area of Circle = "+are);
        }
    }
    class rectangular :Area
    {
        double side = 5;
        public override void Calculate()
        {
            double area=side*side;
            Console.WriteLine("Area of Rectangular = "+area);
        }
    }
    class Test
    {
        public static void Main(string[] args)
        {
            Area area = new circle();
            Area area1 = new  rectangular();
            area.Calculate();
            area1.Calculate();

        }
    }

    class Student
    {
        public int ID { get; }
        public string Name { get;}
       public Student(int id,string name) 
        {
            this.ID = id;
            this.Name = name;
        }
        public Student(Student x3)
        {
            ID=x3.ID; Name=x3.Name;
            Console.WriteLine(ID);
            Console.WriteLine(Name);
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student x = new Student(5,"Suresh");
            Student x1 = new Student(x);
        }
    }
   public  interface A
    {
        void M1();
    }
    public interface B
    {
        void M2();
    }
   public interface C
    {
        void M3();
    }
    public class d: A, B, C
    {
       public void M1()
        {
        Console.WriteLine("interface 1");
        }
    public void M2()
    {
        Console.WriteLine("interface 2");
    }
    public void M3()
        {
            Console.WriteLine("Interface 3");
        }
    }
    class Test2
    {
        public static void Main(string[] args)
        {
            A x1 = new d();
            B x2 = new d();
            C x3 = new d();
            x1.M1();
            x2.M2();
            x3.M3();
        }
    }
}
