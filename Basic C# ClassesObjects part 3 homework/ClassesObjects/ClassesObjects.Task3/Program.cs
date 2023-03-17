// Exercise Task 3

//Create a class User with the following:

//Id - int
//Username - string
//Password - string
//Messages - Array of strings
//Create an array of users and add 3 users to it manually ( hard-coded ).

//Create a Console UI that will give the user two options to choose from:

//Log in - When selected the user should be asked for username and password. If the user is found print welcome message and the messages that the user has in the Messages property:
//Welcome NAME. Here are your messages:
//Message1
//Message2
//If not found, it should print an error message
//Register - When selected the user should be asked to enter ID, Username and password. It should then check if a there is already a username in the array of users like that. If there is, print a message that there is already a user called like that. If not, create a new user object from the information given in the console and add it to the Users array. Then print all the users by Id and Username
//Registration complete! Users:
//23 Username1
//44 Username2
//1 Username3
//56 Username4**

using ClassesObjects.Domain.Classes;

User[] users = new User[]
{
    new User() { Id = 15, Username = "User 1", Password = "Password 1", Messages = new string[] { "Message 1", "Message 2" } },
    new User() { Id = 20, Username = "User 2", Password = "Password 2", Messages = new string[] { "Message 3", "Message 4" } },
    new User() { Id = 25, Username = "User 3", Password = "Password 3", Messages = new string[] { "Message 5", "Message 6" } }
};

while (true)
{
    Console.WriteLine("Press 1 to LOG IN. Press 2 to to REGISTER: ");
    string option = Console.ReadLine();

    if (option == "1")
    {
        Console.Write("Please enter username: ");
        string username = Console.ReadLine();

        Console.Write("Please enter password: ");
        string password = Console.ReadLine();

        User foundUser = Array.Find(users, elem => elem.Username == username && elem.Password == password);

        if (foundUser != null)
        {
            Console.WriteLine($"Welcome {foundUser.Username}. Here are your messages:");

            foreach (string message in foundUser.Messages)
            {
                Console.WriteLine(message);
            }
            break;
        }
        else
        {
            Console.WriteLine("Account does not exist. Invalid credentials!");
            break;
        }
    }
    else if (option == "2")
    {
        Console.Write("Please enter ID: ");
        string id = Console.ReadLine();
        bool idCheck = int.TryParse(id, out int parsedId);
        if (parsedId < 1 && idCheck)
        {
            Console.WriteLine("Can't enter a ID with a value less than 1. Bye!");
            break;
        }

        if (idCheck)
        {
            Console.Write("Please enter username: ");
            string username = Console.ReadLine();

            Console.Write("Please enter password: ");
            string password = Console.ReadLine();

            User registerUser = Array.Find(users, elem => elem.Username == username);

            if (registerUser != null)
            {
                Console.WriteLine("There is already a registered user by that username");
                break;
            }
            else
            {
                Array.Resize(ref users, users.Length + 1);
                users[users.Length - 1] = new User() { Id = parsedId, Username = username, Password = password };

                Console.WriteLine("Registration complete! Users:");
                foreach (User user in users)
                {
                    Console.WriteLine($"{user.Id} {user.Username}");
                }
                break;
            }
        }
        else
        {
            Console.WriteLine("You did not enter an integer. Shutting down!");
            break;
        }
    }
    else
    {
        continue;
    }
}