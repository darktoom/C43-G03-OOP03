using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_OOP03
{
    internal class Hiring_Date
    {
        int day {  get; set; }
        int month { get; set; }
        int year { get; set; }

      public  Hiring_Date(int day,int month ,int year) { 
        this.day = day;
            this.month = month;
            this.year = year;
        
        }

        public override string ToString()
        {
            return $"Day:{day}/month:{month}/ year{year}";
        }

    }
}
