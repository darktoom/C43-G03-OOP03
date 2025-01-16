using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP03
{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }

    enum Gender:byte
    {
        Male=1,Female=2,M=1,F=2

    }

    internal class Employee
    {
       public int ID {  get; set; }
        public  string Name { get; set; }
       public Gender Gender { get; set; }
      public SecurityLevel SecurityLevel { get; set; }
       public  Hiring_Date Hiring_Date { get; set; }
        public int salary { get; set; }


   
        public Employee(int ID, string Name, Gender Gender , SecurityLevel SecurityLevel, Hiring_Date Hiring_Date,int salary) {
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.SecurityLevel = SecurityLevel;
            this.salary = salary;
            this.Hiring_Date = Hiring_Date;
            
        
        }

        public override string ToString()
        {
            return $"Name:{Name}\nID:{ID} \n hiring date:{Hiring_Date}\n salary:{salary}\nSecurityLevel:{SecurityLevel} ";
        }
      



    }
}
