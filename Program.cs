    abstract class Employee
    {
     protected int employeeId;
     protected string employeeName;
     protected double salaryPerDay;

     public Employee(int employeeId,string employeeName,double salaryPerDay)
     {
      this.employeeId=employeeId;
      this.employeeName=employeeName;
      this.salaryPerDay=salaryPerDay;
     }
     //non- abstract method
     public virtual void Display()
     {
      Console.WriteLine("EmpId : " + employeeId);
      Console.WriteLine("EmpName : " + employeeName);
      Console.WriteLine("Emp Sal Per Day : " + salaryPerDay);
     }
     // Abstract method
     public abstract void CalculateSalary(int days);
    }

    class LabAssistant : Employee
    {
     protected int labNo;
     public LabAssistant(int employeeId, string employeeName, double salaryPerDay,int labNo)
     :base(employeeId,employeeName,salaryPerDay)
     { 
      this.labNo = labNo;
     }
    //overriding the base class method
     public override void Display()
     {
      base.Display();
      Console.WriteLine("LabNo :" + labNo);
     }
     //abstract method definition 
     public override void CalculateSalary(int days)
     {
      double grossSalary = salaryPerDay * days;
      Console.WriteLine("Gross Salary is :"+grossSalary);
     }
    }

   class Lecturer : Employee
   {
    protected string subject;
    public Lecturer(int employeeId, string employeeName, double salaryPerDay, string subject)
            : base(employeeId, employeeName, salaryPerDay)
    {
     this.subject = subject;
    }
    //overriding base class method
    public override void Display()
    {
     base.Display();
     Console.WriteLine("Subject Handling :" + subject);
    }
    // abstarct method definition
    public override void CalculateSalary(int days)
    {
     double grossSalary = (salaryPerDay * days)+((salaryPerDay * days)*20/100);
     Console.WriteLine("Gross Salary is :" + grossSalary);
    }
   }

   class Admin : Employee
   {
    public Admin(int employeeId, string employeeName, double salaryPerDay)
            : base(employeeId, employeeName, salaryPerDay)
    {
    }

    public override void CalculateSalary(int days)
    {
     double grossSalary = (salaryPerDay * days) + ((salaryPerDay * days) * 15 / 100);
     Console.WriteLine("Gross Salary is :" + grossSalary);
    }
   }

   class Program
   {
    static void Main(string[] args)
    {
     Employee employee; //local variable
     employee = new LabAssistant(123, "Peter", 67.7, 34);
     Console.WriteLine("Enter You Choice");
     Console.WriteLine("1.LabAssistant 2.Lecturer 3.Admin ");
     int choice = int.Parse(Console.ReadLine());

     switch (choice)
     {
      case 1:
      employee = new LabAssistant(123, "Peter", 67.7, 34);
      break;
      
      case 2:
      employee = new Lecturer(124, "Tom", 89.6, "MS.Net");
      break;
     
      case 3:
      employee = new Admin(126, "Lilly", 45.8);
      break;

      

      default:
      break;
     }

     employee.Display();
     employee.CalculateSalary(25);

     Console.ReadLine();
    }
   }
