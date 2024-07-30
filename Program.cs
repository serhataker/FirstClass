using System;
using System.Threading.Channels;
namespace FirstClass
{

    class First
    {

        static void Main(string[] args)
        {

            Person student1 = new Person();// create the instance for the student1
            student1.Name = "Ali";//input the student1 name
            student1.Surname = "Osmanaga"; //input the student1 surname
            student1.BirthDay= new DateTime(1993,1,1); //input the student1 birthday 

            Console.WriteLine($"Student Info: Name:{student1.Name} Surename:{student1.Surname} BirthDate:{student1.BirthDay:dd:MM:yyyy}");// write the console we give the date format for the handle birthday
           
            
            Person student2 = new Person();// create the instance for the student2
            student2.Name = "Hayri";
            student2.Surname = "Hakverdi";
            student2.BirthDay= new DateTime(1998,1,5);
            
            Console.WriteLine($"Student Info: Name:{student2.Name} Surename:{student2.Surname} BirthDate:{student2.BirthDay:dd:MM:yyyy}"); 
          
            
            Person teacher1 = new Person();// create the instance for the tecaher1
            teacher1.Name = "Arslan";
            teacher1.Surname = "Süt";
            teacher1.BirthDay= new DateTime(1991,2,5);
            
            Console.WriteLine($"Teacher Info: Name:{teacher1.Name} Surename:{teacher1.Surname} BirthDate:{teacher1.BirthDay:dd:MM:yyyy}"); Person 

            teacher2 = new Person();// create the instance for the tecaher2
            teacher1.Name = "Arslan";
            teacher2.Name = "Halil";
            teacher2.Surname = "Kahraman";
            teacher2.BirthDay= new DateTime(1981,10,02);
            
            Console.WriteLine($"Teacher Info: Name:{teacher2.Name} Surename:{teacher2.Surname} BirthDate:{teacher2.BirthDay:dd:MM:yyyy}");
        }
    }

}