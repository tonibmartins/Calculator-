// Autor: @tonibmartis
// Autor Name: Antônio Martins
// Date: 30/04/2024

// Name of the project: "C# Console Calculator"
void ShowProgramName(){
    Console.WriteLine(@"
░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░████████╗░█████╗░██████╗░
██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║░░░██║░░░██║░░██║██████╔╝
██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║░░░██║░░░██║░░██║██╔══██╗
╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║░░░██║░░░╚█████╔╝██║░░██║
░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝");
}

void Menu(){
    Console.WriteLine(@"
[1] - Sum
[2] - Subtraction
[3] - Multiplication
[4] - Division
[5] - Exit
");

    Console.Write("Choose an option: ");
    int option = int.Parse(Console.ReadLine());

    switch(option){
        case 1:
            Sum();
            Console.WriteLine("Press 1 to continue or 2 to exit");
            int option2 = int.Parse(Console.ReadLine());
            if(option2 == 1){
                Menu();
            }else if (option2 == 2){
                Environment.Exit(0);
            }
            else{
                Console.WriteLine("Invalid option");}
            break;
        case 2:
            Subtraction();
            Console.WriteLine("Press 1 to continue or 2 to exit");
            int option3 = int.Parse(Console.ReadLine());
            if(option3 == 1){
                Menu();
            }else if (option3 == 2){
                Environment.Exit(0);
            }
            else{
                Console.WriteLine("Invalid option");
            }
            break;
        case 3:
            Multiplication();
            Console.WriteLine("Press 1 to continue or 2 to exit");
            int option4 = int.Parse(Console.ReadLine());
            if(option4 == 1){
                Menu();
            }else if (option4 == 2){
                Environment.Exit(0);
            }
            else{
                Console.WriteLine("Invalid option");
            }
            break;
        case 4:
            Division();
            Console.WriteLine("Press 1 to continue or 2 to exit");
            int option5 = int.Parse(Console.ReadLine());
            if(option5 == 1){
                Menu();
            }else if (option5 == 2){
                Environment.Exit(0);
            }
            else{
                Console.WriteLine("Invalid option");
            }
            break;
        case 5:
            Console.WriteLine("Exiting...");
            Environment.Exit(0);

            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }
}

void Sum(){
    Console.Write("Enter the first number: ");
    double number1 = double.Parse(Console.ReadLine());

    Console.Write("Enter the second number: ");
    double number2 = double.Parse(Console.ReadLine());

    double result = number1 + number2;
    Console.WriteLine($"The sum of {number1} and {number2} is {result}");
}

void Subtraction(){
    Console.Write("Enter the first number: ");
    double number1 = double.Parse(Console.ReadLine());

    Console.Write("Enter the second number: ");
    double number2 = double.Parse(Console.ReadLine());

    double result = number1 - number2;
    Console.WriteLine($"The subtraction of {number1} and {number2} is {result}");
}

void Multiplication(){
    Console.Write("Enter the first number: ");
    double number1 = double.Parse(Console.ReadLine());

    Console.Write("Enter the second number: ");
    double number2 = double.Parse(Console.ReadLine());

    double result = number1 * number2;
    Console.WriteLine($"The multiplication of {number1} and {number2} is {result}");
}

void Division(){
    Console.Write("Enter the first number: ");
    double number1 = double.Parse(Console.ReadLine());

    Console.Write("Enter the second number: ");
    double number2 = double.Parse(Console.ReadLine());

    double result = number1 / number2;
    Console.WriteLine($"The division of {number1} and {number2} is {result}");
}

int Main(){
    ShowProgramName();
    Menu();

    return 0;
}

Main();