

namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);

        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);

        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);

        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
        Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        //Call Q1 question.
        TotalCredits(customer_list);
        AmarilloAverageAge(customer_list);
        CanyonAge(customer_list);

    }

    public static void TotalCredits(Customer[] customer_list)
    {

        double T_Credits = 0;
        foreach (var Credits in customer_list)
        {
            T_Credits += Credits.customerCredit;

        }
        Console.WriteLine($"Q1: The total Credits: {T_Credits}");
    }


    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        double count = 0.0;
        double total_age = 0.0;
        foreach (var city in customer_list)
        {


            if (city.customerCity == "Amarillo")
            {
                total_age += city.customerAge;
                count++;
            }

        }

        double Avg_age = total_age / count;
        Console.WriteLine($"Q2: The average age of customers in Amarillo: {Avg_age}");
    }
    
      public static void CanyonAge(Customer[] customer_list)
    {
               Console.Write("Q3: Customers who live in Canyon and over 30 years old: ");

        foreach (var city in customer_list)
        {

        
            if (city.customerCity == "Canyon")
            {
                if (city.customerAge > 30)
                {
                    Console.Write($"{city.customerName}," + " ");
                }

            }
            
         

        }

      
        
    }

    
}

class Customer
{
    public string customerName{ get; set; } = string.Empty;
    public int customerAge { get; set; } = 0;
    public string customerCity { get; set; } = string.Empty;
    public double customerCredit { get; set; } = 0.0;

   public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
}

