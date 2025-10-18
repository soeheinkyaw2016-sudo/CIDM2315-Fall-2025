namespace Homework7;

class Program
{
    static void Main(string[] args)
    {
        //Answer Q1 and Q2.
        Customer Alice = new Customer(cus_id: 110,cus_name: "Alice", cus_age:28);
        Customer Bob = new Customer(cus_id: 111, cus_name: "Bob", cus_age: 30);
        Alice.PrintCusInfo();
        Bob.PrintCusInfo();
         
        Alice.ChangeID(220);
        Bob.ChangeID(221);

         Alice.PrintCusInfo();
        Bob.PrintCusInfo();

        Bob.CompareAge(Alice);
      
    }
}

class Customer

{   
    //Code for Customer class.
    private int cus_id = 0;
    public string cus_name = string.Empty;
    public int cus_age = 0;
    public Customer(int cus_id, string cus_name, int cus_age)


    {
        this.cus_id = cus_id;
        this.cus_age = cus_age;
        this.cus_name = cus_name;
    }



    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    public void PrintCusInfo()
    {
        Console.WriteLine($"Customer:{cus_id}, name: {cus_name}, age:{cus_age}");
    }

    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older");

        }
        else
            Console.WriteLine($"{objCustomer.cus_name} is older");
    }
}     
            
        
            
        
            
        



       
        
    

    

    
