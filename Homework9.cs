using System.Net.Mail;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;

namespace Homework9;

class Program
{
  static void Main(string[] args)
  {
    Student s1 = new Student(inputID: 111, inputName: "Alice");
    Student s2 = new Student(inputID: 222, inputName: "Bob");
    Student s3 = new Student(inputID: 333, inputName: "Cathy");
    Student s4 = new Student(inputID: 444, inputName: "David");



    Dictionary<string, double> GradeBook = new Dictionary<string, double>();
    GradeBook.Add("Alice", 4.0);
    GradeBook.Add("Bob", 3.6);
    GradeBook.Add("Cathy", 2.5);
    GradeBook.Add("David", 1.8);
    if (GradeBook.ContainsKey("Tom"))
    {
      Console.WriteLine("Tom is include.");
    }
    else
    {
      GradeBook.Add("Tom", 3.3);
    }


    double TotalGpa = 0;
    int count = 0;
    foreach (var gpa in GradeBook)

    {
      TotalGpa += gpa.Value;
      count++;
    }
    double AvgGpa = TotalGpa / count;
    Console.WriteLine($"The average GPA is: {AvgGpa}");


        

foreach (var gpa in GradeBook)

      {
      foreach (var nam in Student.student_list)
        {
        if (gpa.Value > AvgGpa)
        {

         nam.PrintInfo(gpa.Key);

        
        }
        
          }
        
    }



  } 
}
class Student
{
  public static List<Student> student_list = new List<Student>();
  private int stuID { get; set; } = 0;
  private string stuName { get; set; } = string.Empty;
  public void PrintInfo(string stuName)
  {
   
      
        Console.WriteLine($"student Id: {stuID}, Student name: {stuName}");
      }
    
  

  public Student(int inputID, string inputName)
  {
    stuID = inputID;
    stuName = inputName;
    student_list.Add(this);
  }
}