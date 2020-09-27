// Student Name： Yuxi Wang    
// Student ID: 22001587

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D201BenchmarkApp
{
    /// <summary>
    /// All staff information variables.
    /// </summary>
    public class MyClass
    {
        private int id;
        private string staff_Name;
        private string birthday;
        private string email;
        private int salary;

        // Staff ID
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // Staff Name
        public string Staff_Name 
        {
            get { return staff_Name; }
            set { staff_Name = value; }
        }

        // Staff Date of Birth
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        // Staff Email address
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // Staff Salary
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // Initialize staff information. 
        public MyClass()
        {
            Id = 0;
            Staff_Name = "NA";
            Birthday = "NA";
            Email = "NA";
            Salary = 0;
        }
        
        /// <summary>
        /// Staff information format conversion.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Id + " " + Staff_Name + " " + Birthday + " " + Email + " $" + Salary;
        }

    }
}
