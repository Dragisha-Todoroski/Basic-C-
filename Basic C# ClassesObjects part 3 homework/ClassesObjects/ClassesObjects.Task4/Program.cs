using ClassesObjects.Domain.Classes;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

//Create an ATM application. A customer should be able to authenticate with card number and pin and should be greeted with a message greeting them by full name. After that they can choose one of the following:

//Balance checking - This should print out the current balance of money on their account
//Cash withdrawal - This should try and withdraw cash from the users account and print a message. If it has enough it should print a success message that contains the money withdrawn and the balance of money after the withdrawal
//Cash deposition - This should deposit cash on the account and give a message with the new balance of money on the account after the deposit.
//In order for the ATM app to work we need Customers. This ATM asks for the number ( string ) of the card and searches through the customers if a card like that exists. After that it asks for a pin. If the Pin matches that customer a welcome message is shown and the customer can now choose the options.

//Example
//Welcome to the ATM app
//Please enter your card numer:
//> 1234 - 1234 - 1234 - 1234
//Enter Pin:
//> 4325
//Welcome Bob Bobsky!
//What would you like to do:
//Check Balance
//Cash Withdrawal
//Cash Deposit
//> 2
//You withdrew 250$. You have 400$ left on your account.
//Thank you for using the ATM app.
//Bonus: The balance and pin should not be public

//Bonus: The ATM card number to be a number instead of a string. The user should still input 1234-1234-1234-1234.

//Bonus: When the Customer finishes with a transaction a question must pop up if the Customer wants to do another action. If not it should print a goodbye message and show up the login menu again.

//Bonus: Add an option to register a new card in the system that store the customer in the system if the card number is not used for any other customer

Customer[] database = new Customer[]
{
    new Customer("Angel", "Mitrov", new Card(1234123412341234, 100), new Wallet(300)),
    new Customer("John", "Doe", new Card(4321432143214321, 1000), new Wallet(700))
};


foreach (Customer customer in database)
{
    customer.GetCustomerInfo();
}

bool Atm()
{
    while (true)
    {
        Console.WriteLine("Welcome to the ATM app\n\nChoose option:\n\na. Enter Bank Account\nb. Register Card\nc. Exit ATM");
        string beginningOption = Console.ReadLine().ToLower();

        if (beginningOption == "a" || beginningOption == "enter" || beginningOption == "enter bank account" || beginningOption == "enter bank")
        {
            EnterBankAccount(database);
            return false;
        }
        else if (beginningOption == "b" || beginningOption == "register" || beginningOption == "register card")
        {
            database = RegisterCard(database);
            return false;
        }
        else if (beginningOption == "c" || beginningOption == "exit" || beginningOption == "exit atm")
        {
            Console.WriteLine("Thank you for putting your trust in us. Have a wonderful day!");
            return true;
        }
        else
        {
            Console.WriteLine("Try again.");
        }
    }
}

void EnterBankAccount(Customer[] objArr)
{
    Console.WriteLine("Please enter your card number:");
    string cNumberInput = Console.ReadLine();
    bool cNumberInputCheck = long.TryParse(cNumberInput, out long parsedCNumberInput);

    if (cNumberInputCheck)
    {
        Customer foundCNumber = Array.Find(objArr, cNumber => cNumber.Card.Number == parsedCNumberInput);

        if (foundCNumber == null)
        {
            Console.WriteLine("Card number does not exist.");
        }
        else
        {
            Console.WriteLine("Please enter your PIN:\n");
            string pinInput = Console.ReadLine();
            bool pinInputCheck = int.TryParse(pinInput, out int parsedPinInput);

            if (pinInputCheck)
            {
                Customer foundCustomer = Array.Find(objArr, card => card.Card.GetCardPin() == parsedPinInput && card.Card.Number == parsedCNumberInput);

                if (foundCustomer == null)
                {
                    Console.WriteLine("Incorrect PIN.");
                }
                else
                {
                    Console.WriteLine($"Welcome {foundCustomer.Firstname} {foundCustomer.Lastname}!\n");
                    int flag = 0;
                    while (true)
                    {
                        if (flag == 0)
                        {
                            Console.WriteLine("What would you like to do:\n\na. Check Balance\nb. Cash Withdrawal\nc. Cash Deposit\nd. Exit");
                            string option = Console.ReadLine().ToLower();

                            if (option == "a" || option == "check balance")
                            {
                                foundCustomer.CheckBalance();
                            }
                            else if (option == "b" || option == "cash withdrawal")
                            {
                                foundCustomer.CashWithdrawal();
                            }
                            else if (option == "c" || option == "cash deposit")
                            {
                                foundCustomer.CashDeposit();
                            }
                            else if (option == "d" || option == "exit")
                            {
                                Console.WriteLine("Thank you for putting your trust in us. Have a wonderful day!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Try again.");
                                continue;
                            }
                            Console.WriteLine("Do you want to perform another action on your account? Y/N");
                        }
                        flag = 0;
                        string performAnotherActionInput = Console.ReadLine().ToLower();
                        if (performAnotherActionInput == "n" || performAnotherActionInput == "no")
                        {
                            break;
                        }
                        else if (performAnotherActionInput == "y" || performAnotherActionInput == "yes")
                        {
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Unavailable choice. Y/N");
                            flag++;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Please only enter whole numbers.");
            }
        }
    }
    else
    {
        Console.WriteLine("Please only enter whole numbers.");
    }
}

Customer[] RegisterCard(Customer[] objArr)
{
    Console.WriteLine("Enter first name:\n");
    string firstNameInput = Console.ReadLine();
    Console.WriteLine("Enter last name:\n");
    string lastNameInput = Console.ReadLine();
    Console.WriteLine("Enter card number:\n");
    string cNumberInput = Console.ReadLine();
    bool cNumberInputCheck = long.TryParse(cNumberInput, out long parsedCNumberInput);
    Customer foundCNumber = Array.Find(objArr, cNumber => cNumber.Card.Number == parsedCNumberInput);
    Console.WriteLine("Enter starting balance:\n");
    string balanceInput = Console.ReadLine();
    bool balanceInputCheck = double.TryParse(balanceInput, out double parsedBalanceInput);
    Console.WriteLine("Enter wallet cash:");
    string cashInput = Console.ReadLine();
    bool cashInputCheck = double.TryParse(cashInput, out double parsedCashInput);

    if (cNumberInputCheck && balanceInputCheck && parsedBalanceInput >= 0 && parsedCNumberInput.ToString().Length == 16)
    {
        if (foundCNumber == null)
        {
            Array.Resize(ref objArr, objArr.Length + 1);
            objArr[objArr.Length - 1] = new Customer(firstNameInput, lastNameInput, new Card(parsedCNumberInput, parsedBalanceInput), new Wallet(parsedCashInput));
            Console.WriteLine("Successfully registered card.");
            objArr[objArr.Length - 1].GetCustomerInfo();
            return objArr;
        }
        else
        {
            Console.WriteLine("Card has already been registered.");
            return objArr;
        }
    }
    else
    {
        Console.WriteLine("Incorrect inputs.");
        return objArr;
    }
}
while (true)
{
    if (Atm())
    {
        break;
    }
}