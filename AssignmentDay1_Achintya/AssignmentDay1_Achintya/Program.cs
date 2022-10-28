// See https://aka.ms/new-console-template for more information
using AssignmentDay1_Achintya;
    
Console.WriteLine("Hello, World!");
var a = new TCS(132,"Name1","SRE","SDE1",30000);
var b = new WellsFargo(123,"Name2","Cloud","SDE2",35000);

Console.WriteLine("TCS:\n");
Console.WriteLine("PF amount: "+a.EmployeePF(a.basicSalary));
Console.WriteLine("Gratuity amount: " + a.gratuityAmount(12,a.basicSalary));
Console.WriteLine("Leave details: " + a.LeaveDetails());
Console.WriteLine("\nWells Fargo: \n");
Console.WriteLine("PF amount: " + b.EmployeePF(b.basicSalary));
Console.WriteLine("Gratuity amount: " + b.gratuityAmount(12, b.basicSalary));
Console.WriteLine("Leave details: " + b.LeaveDetails());