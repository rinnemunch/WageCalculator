// Ask for hours worked 
// Read and store input 

// Ask for hourly wage 
// Read and store input 

// Calculate total pay 

// Display total pay

Console.Write("Hours worked: ");
double hours = Convert.ToDouble(Console.ReadLine());

Console.Write("Hourly wage: ");
double wage = Convert.ToDouble(Console.ReadLine());

double totalPay; 
//overtime pay * 1.5 

if (hours <= 40)
{
    totalPay = hours * wage;
}
else
{
    double regularPay = 40 * wage;
    double overtimehours = hours - 40;
    double overtimePay = overtimehours * wage * 1.5;
    totalPay = regularPay + overtimePay;
}

    Console.WriteLine($"Total pay: ${totalPay:F2}");