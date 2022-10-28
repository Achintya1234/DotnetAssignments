using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay1_Achintya
{
     public class TCS: IGovtRules
    {
        int empID;
        string Name;
        string Dept;
        string designation;

        public double basicSalary;
        
        TCS()
        {
            basicSalary = 0.0;
            empID = 0;
            Name = "";
            Dept = "";
            designation = "";
        }

        public TCS(int id, string a, string b, string c,double sal)
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
            return 0.12 * a + 0.0833 * a;

        }
        public string LeaveDetails()
        {
            return "\n Casual Leave : 1 \n Sick Leave : 12 \n Privelege Leave : 10";
        }

        public double gratuityAmount (float x, double b)
        {
            if (x >= 5) return b;
            else if (x >= 10) return 2 * b;
            else if (x >= 20) return 3 * b;
            else return 0;
             
        }


    }
}
