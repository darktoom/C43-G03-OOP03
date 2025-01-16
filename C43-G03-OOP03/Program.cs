namespace C43_G03_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Employee[] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(1, "hatem", Gender.Male, SecurityLevel.Secretary, new Hiring_Date(1, 1, 2015), 1000);
            EmpArr[1]= new Employee(2,"ahmed",Gender.Male,SecurityLevel.DBA,new Hiring_Date(15,12,2012),5200);
            EmpArr[2] = new Employee(3,"alice",Gender.Female,SecurityLevel.Developer,new Hiring_Date(17,1,2023),1000);
            foreach (Employee employee in EmpArr) {
                Console.WriteLine(employee);
            }

            

        }
    }
}
