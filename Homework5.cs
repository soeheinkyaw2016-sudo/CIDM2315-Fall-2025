namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        //Call Q1 method.
        int a1, b1, c1, e1, f1;
        c1 = LargerNum(out a1, out b1);
        Console.WriteLine($"a={a1}; b={b1}");
        Console.WriteLine($"The largest number is:{c1}");

        //Call Q2.
        e1 = F_Largest(out a1, out b1, out c1, out f1);
        Console.WriteLine($"a1:{a1}; b:{b1}; c:{c1};; d:{f1}");
        Console.WriteLine($"The largest number is:{e1}");

        //Cal Q3 method.
        createAccount();

    }

    // Q1 method.

    static int LargerNum(out int a, out int b)
    {


        a = Convert.ToInt16(Console.ReadLine());

        b = Convert.ToInt16(Console.ReadLine());

        if (a > b)
        {

            return a;
        }
        else
        {

            return b;
        }
    }
    static int LargerNum(int a, int b)
    {



        if (a > b)
        {

            return a;
        }
        else
        {

            return b;
        }
    }

    //Q2 method.

    static int F_Largest(out int a2, out int b2, out int c2, out int d1)
    {
        int e;


        int c = LargerNum(out a2, out b2);


        int d = LargerNum(out c2, out d1);


        e = LargerNum(c, d);

        return e;

    }

    //Q3 method.
    static bool checkAge(int birth_year)
    {
        int current_year = 2025;
        int age = current_year - birth_year;
        if (age >= 18)

        {
            return true;
        }
        else
        {
            return false;
        }

    }


    static void createAccount()
    {

        Console.WriteLine("Enter Your Username:");
        string U_name = Console.ReadLine();
        Console.WriteLine("Enter Your Password:");
        string pass_w = Console.ReadLine();
        Console.WriteLine("Enter Your Password Again:");
        string pass_w1 = Console.ReadLine();
        Console.WriteLine("Enter Your Birthyear:");
        int B_year = Convert.ToInt16(Console.ReadLine());

        if (checkAge(B_year) == true)
        {
            if (pass_w == pass_w1)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account.");
          }
        
    }


      
      
}
