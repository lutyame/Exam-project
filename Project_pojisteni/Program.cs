using Project_pojisteni;

UserRegister register = new UserRegister();


Console.WriteLine("--------------------------\n User Register \n--------------------------\n");
bool end = false;



while (!end)
{
    Console.WriteLine("\nChoose your action\n\n1 - Add a new user\n2 - Write all users\n3 - Search for a user\n4 - End\n");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {

        case 1:
            Console.WriteLine("\nEnter name: ");
            string name = Console.ReadLine().Trim();

            Console.WriteLine("\nEnter surname: ");
            string surname = Console.ReadLine().Trim();

            Console.WriteLine("\nEnter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter your phone number: ");
            int phoneNumber = int.Parse(Console.ReadLine());
            register.AddNewUser(name, surname, age, phoneNumber);

            Console.WriteLine("\nData has been saved, continue by pressing any key");
            Console.ReadKey();
            break;

        case 2:
            Console.WriteLine();
            Console.WriteLine("All users:\n");
            register.ReturnUser();
            Console.WriteLine("\nContinue by pressing any key");
            Console.ReadKey();
            break;

        case 3:
            Console.WriteLine("\nEnter name: ");
            string searchedName = Console.ReadLine().Trim();

            Console.WriteLine("\nEnter surname: ");
            string searchedSurname = Console.ReadLine().Trim();

            register.SearchUser(searchedName, searchedSurname);
            Console.WriteLine("\nContinue by pressing any key");
            Console.ReadKey();
            break;

        case 4:
            end = true;
            break;

        default:
            Console.WriteLine("You entered invalid number");
            break;
    }
}