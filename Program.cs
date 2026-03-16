// service bot

int option;
float balance = 1200F;

Console.WriteLine("                          Enter the desired option:                                      ");
Console.WriteLine("                          1 - Unlock Card                                                ");
Console.WriteLine("                          2 - Lock Card                                                  ");
Console.WriteLine("                          3 - Check account balance                                      ");
Console.WriteLine("                          4 - Make a transfer                                            ");
Console.WriteLine("                          5 - View transaction history                                   ");
Console.WriteLine("                        ============================                                    ");

option = int.Parse(Console.ReadLine());

switch(option)
{
    case 1:
        {
            Console.WriteLine("Card successfully unlocked!");
            break;
        }
    case 2:
        {
            Console.WriteLine("Card successfully locked! (to unlock it restart the program and choose option 1.)");
            break;
        }
    case 3:
        {
            Console.WriteLine("Your account balance is: " + "$" + balance);
            break;
        }
    case 4:
        {
            Console.WriteLine("Enter the PIX key to make the transfer: ");
            Console.WriteLine("This is the available balance: " + balance);
            break;
        }
    case 5:
        {
            Console.WriteLine("Here you can check your transaction history: ");
            List<string> statement = new List<string>();
            statement.Add("Transfer of 500 to João on 02/17");
            statement.Add("Deposit of 1700 on 02/14");
            statement.Add("Withdrawal of 100 on 02/12");
            
            foreach (string item in statement)
            {
                Console.WriteLine(item);
            }
            break;
        }
    default:
        {
            Console.WriteLine("No option selected, closing the system...");
            break;
        }
}
