namespace Homework4;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1_method().
        int Larger_num = LargeNum(3, 5);
        Console.WriteLine($"The largest number is: {Larger_num} ");


        //Call Q_2 method().
        TriShape(25, "left");
         
    }

    //  Q1_Method.
    static int LargeNum(int a, int b)
    {
        Console.WriteLine($"a = {a}; b={b}");
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }

    }

    //Q_2 method.
    static void TriShape(int N, string shape)
    {   
        
       
        if (shape == "left")
        {
            Console.WriteLine($"N is:{N}; shape is left");
           
            for (int i = 0; i <= N - 1; i++)
            {
                for (int j = 0; j <= N - 1; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
           
        }
        if (shape == "right")
        {
            Console.WriteLine($"N is: {N}; shape is right");
           
            for (int i = 0; i <= N - 1; i++)
            {
                for (int j = N - 1; j >= 0; j--)
                {
                    if (i >= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }

        }
    }
}
