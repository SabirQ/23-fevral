using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    partial class Student       //Fields
    {
        public string Fullname;
        public string GroupNo;
        public byte Age;
       
       
    }
    partial class Student        //Constructor
    {
        public Student(string fullname, string groupno, byte age)
        {
            if (CheckFullname(fullname))
            {
                Fullname = fullname;
            }
            else
            {
                do
                {
                    Console.WriteLine("Ad,Soyad boyuk heriflerle bashlamali ve aralarinda boshluq olmalidir yeniden cehd edin");
                    fullname = Console.ReadLine();

                } while (!CheckFullname(fullname));
                Fullname = fullname;

            }

            if (CheckGroupNo(groupno))
            {
                GroupNo = groupno;
            }
            else
            {
                do
                {
                    Console.WriteLine("Grup nomresi boyuk herfle bashlamali ve ardicil 3 reqem qeyd olunmalidir yeniden cehd edin");
                    groupno = Console.ReadLine();

                } while (!CheckGroupNo(groupno));
                GroupNo = groupno;
            }
          
            Age = age;           
        }
    }
    partial class Student        //Methods
    {
        public static bool CheckGroupNo(string groupno)
        {
            bool Result = false;

            if (groupno.Length == 4 && Char.IsUpper(groupno[0]) && Char.IsDigit(groupno[1]) && Char.IsDigit(groupno[2]) && Char.IsDigit(groupno[3]))
            {
                Result = true;
            }
            return Result;
        }
        public static bool CheckFullname(string full)
        {
            bool check = false;
            bool check1 = false;
            bool check2 = false;
            bool final = false;
            int SpaceIndex = 0;

            if (full.Contains(' '))
            {
                check = true;

            }
            for (int i = 3; i < full.Length - 3; i++)
            {
                if (full[i] == ' ')
                {
                    SpaceIndex = i;
                }
            }
            if (Char.IsUpper(full[0]) && Char.IsLetter(full[1]) && Char.IsLetter(full[2]))
            {
                check1 = true;
            }
            if (Char.IsUpper(full[SpaceIndex + 1]) && Char.IsLetter(full[full.Length - 1]) && Char.IsLetter(full[full.Length - 2]) && Char.IsLetter(full[full.Length - 3]))
            {
                check2 = true;
            }
            if (check == true && check1 == true && check2 == true)
            {
                final = true;
            }
            return final;
        }

        public void Info()
        {
            Console.WriteLine($"Fullname:{Fullname}\nGroupNo:{GroupNo}\nAge:{Age}");
        }
        
    }
}
