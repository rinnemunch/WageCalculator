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

if (hours <= overtimeThreshold)
{
    //just the regular pay
    totalPay = hours * wage;
    Console.WriteLine($"Regular pay: ${totalPay:F2}");
}
else
{
    double regularPay = overtimeThreshold * wage;
    double overtimeHours = hours - overtimeThreshold;
    double overtimePay = overtimeHours * wage * 1.5;
    totalPay = regularPay + overtimePay;

    Console.WriteLine($"Regular pay: ${regularPay:F2}");
    Console.WriteLine($"Overtime pay: ${overtimePay:F2}");
}

Console.WriteLine($"Total pay: ${totalPay:F2}");

