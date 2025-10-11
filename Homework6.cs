namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        Professor p1 = new Professor();
        p1.profName = "Alice";
        p1.classTech = "Java";
       p1.Salary=9000;
        Console.WriteLine($"Professor {p1.profName} teaches {p1.classTech}, and the salary is: {p1.Salary}");

        
        Professor p2 = new Professor();
        p2.profName = "Bob";
        p2.classTech = "Math";
          p2.Salary=8000;
        Console.WriteLine($"Professor {p2.profName} teaches {p2.classTech}, and the salary is: {p2.Salary}");

        Student s1 = new Student();
        s1.studentName = "Lisa";
        s1.classEnroll = "Java";
        s1.studentGrade = 90;
        Console.WriteLine($"Student {s1.studentName} enrolls {s1.classEnroll}, and the grade is: {s1.studentGrade}");

         Student s2 = new Student();
        s2.studentName = "Tom";
        s2.classEnroll = "Math";
        s2.studentGrade = 80;
        Console.WriteLine($"Student {s2.studentName} enrolls {s2.classEnroll}, and the grade is: {s2.studentGrade}");

        Console.WriteLine($"The salary difference between {p1.profName} and {p2.profName} is: {p1.Salary - p2.Salary}");
        Console.WriteLine($"The total grade of  {s1.studentName} and {s2.studentName} is: {s1.studentGrade+s2.studentGrade}");
    }
}

class Professor
{
    public string profName;
    public string classTech;


    public double Salary { set; get; }
}    
          
class Student
{
    public string studentName;
    public string classEnroll;
    public  double studentGrade{get;set;}

}