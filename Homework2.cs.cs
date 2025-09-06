namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
         //Code for Q1.  
        Console.WriteLine("Please input a letter greade");
      string str_input= Console.ReadLine();
      
      if(str_input=="A")
        { 
            Console.WriteLine("GPA point: 4");  
        }
         
          else if(str_input == "B")
           {  
            Console.WriteLine("GPA point: 3");
           }  
           
             else if(str_input == "C") 
                {
                   Console.WriteLine("GPA point: 2"); 
                }
           

                 else if(str_input == "D") 
                   {
                    Console.WriteLine("GPA point: 1");     
                   }
                  
                     else  if(str_input == "F") 
                          {
                            Console.WriteLine("GPA point: 0");
                           
                          }
                           else 
                               Console.WriteLine("Wrong letter grade");
                  

            // Code for Q2.

          Console.WriteLine("Please input the first num:");
          string first_num = Console.ReadLine();
           Console.WriteLine("Please input the second num:");
          string second_num = Console.ReadLine();
           Console.WriteLine("Please input the third num:");
          string third_num = Console.ReadLine();

          int f_num = Convert.ToInt16(first_num);
           int s_num = Convert.ToInt16(second_num);
            int t_num = Convert.ToInt16(third_num);
               
          if (f_num<=s_num && f_num<=t_num) 
             {
              Console.WriteLine("The smallest number is:"+ f_num);
             }

       else  if (s_num<=f_num && s_num<=t_num) 
             {
              Console.WriteLine("The smallest number is:"+ s_num);
             }

         else  if (t_num<=f_num && t_num<=s_num) 
             {
              Console.WriteLine("The smallest number is:"+ t_num);
             }  
    

//Code for bonus.
   Console.WriteLine("Please enter your year.");
   string str_year= Console.ReadLine();
   int int_year = Convert.ToInt16(str_year);

    

      if((int_year%100==0 && int_year%400==0 )|| (int_year%100!=0 && int_year%4==0))
         {
          Console.WriteLine("Your year is a leap year!");
         }
         else
            Console.WriteLine("Your year is not a leap year!");
    }
}