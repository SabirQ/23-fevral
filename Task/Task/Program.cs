using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)  
        {   
              //Do-While prossesi Constructor-da gedir 


            Student student = new Student("Sabir Quliyev","P127",24);       //Duz yaradilmish telebe
            student.Info();
            
            
            Student student1 = new Student("AvazAvazli", "o127", 28);       //Sehv yaradilmish telebe
            student1.Info();
        }
    }
}
