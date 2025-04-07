Console.Write("Enter your pay period (daily/weekly/biweekly/monthly): ");
string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("No input given. Defaulting to 'weekly'. ");
    input = "weekly"; 
} 

string period = input.ToLower();

//setting overtime threshold; 
double overtimeThreshold;


switch (period)
{
    case "daily":
        overtimeThreshold = 8;
        break;
    case "weekly":
        overtimeThreshold = 40;
        break;
    case "biweekly":
        overtimeThreshold = 80;
        break;
    case "monthly":
        overtimeThreshold = 160;
        break;
    default:
        Console.WriteLine("Invalid pay period entered. Using weekly by default.");
        overtimeThreshold = 40;
        break;
}

Console.Write("Enter hours worked: ");
double hours = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter hourly wage: ");
double wage = Convert.ToDouble(Console.ReadLine());

double totalPay;

if (hours <= 40)
{
    totalPay = hours * wage;
}
else
{
    double regularPay = wage * 40;
    double overtimeHours = hours - 40;
    double overtimePay = wage * overtimeHours * 1.5;
    totalPay = regularPay + overtimePay;
}

Console.WriteLine($"Total pay: ${totalPay:F2}");

