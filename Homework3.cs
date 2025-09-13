namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1.
        Console.WriteLine("Input an integer:");
        int N = Convert.ToInt16(Console.ReadLine());

        
        
        int i=2;
            while(i<N)
            {
             if(N%i==0)
             {
                Console.WriteLine("N is  non-prime");
                break;
             }
            
             else
             {
                Console.WriteLine("N is prime");
                break;
             }
            } 
               i++;

         //Code for Q2.
         
           Console.WriteLine("Assign an int value to N");
        N = Convert.ToInt16(Console.ReadLine());
            
          
          for( i=0;i<=N-1;i++)
             {
                for(int j = 0; j<=N-1;j++)
                   {
                    Console.Write("#");
                   }
                 Console.WriteLine();
             }

             
         //Code for Q3.
         
           Console.WriteLine("Assign an int value to N");
        N = Convert.ToInt16(Console.ReadLine());
             
           for( i=0;i<=N-1;i++)
             {
                for(int j = 0; j<=N-1;j++)
                   {
                    if(i>=j)
                      {
                        Console.Write("*");
                      }
                   }
                 Console.WriteLine();
             }   
             
             //Code for Bonus.
         
           Console.WriteLine("Assign an int value to N");
        N = Convert.ToInt16(Console.ReadLine());
             
           for( i=N-1;i>=0;i--)
             {
                for(int j = 0; j<=N-1;j++)
                   {
                    if(i>j)
                      {
                        Console.Write(" ");
                      }
                    else 
                       {
                        Console.Write(N-i);
                       }

                   }
                 Console.WriteLine();
             }   

        
    }
}
