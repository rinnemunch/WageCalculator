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

double totalPay = hours * wage;

Console.WriteLine($"Total pay: ${totalPay:F2}");