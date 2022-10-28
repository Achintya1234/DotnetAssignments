using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay1_Achintya
{
    internal class WellsFargo : IGovtRules
    {
        public double basicSalary;
        int empID;
        string Name;
        string Dept;
        string designation;
        public WellsFargo()
        {
            basicSalary = 0.0;
            empID = 0;
            Name = "";
            Dept = "";
            designation = "";
        }

        public WellsFargo(int id, string a, string b, string c, double sal)
        {
            basicSalary = sal;
            empID = id;
            Name = a;
            Dept = b;
            designation = c;
        }

        public double EmployeePF(double a)
        {
            a = this.basicSalary;
            return 0.12 * a + 0.12 * a;

        }
        public string LeaveDetails()
        {
            return "\n Casual Leave : 2 \n Sick Leave : 5 \n Privelege Leave : 5";
        }

        public double gratuityAmount(float x, double b)
        {
            
            return 0;
        }
    }
}
