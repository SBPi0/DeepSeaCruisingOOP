using DeepSeaCruisingOOP;

//do-while kører indtil applikationen lukkes, da while's condition er boolean "true"
do
{
    Console.Clear();
    Console.Write("(A)dmin eller (K)unde login?: ");
    switch (Console.ReadLine().ToUpper())
    {
        case "A":
            //Initialisering af AdminLogin klassen, og derefter køres AdminLogin.Run() metoden
            AdminLogin Admin = new();
            Admin.Run();
            break;
        case "K":
            KundeOpret Kunde = new();
            Kunde.Run();
            break;
        default:
            Console.WriteLine("Ugyldigt valg, prøv venligst igen.");
            break;
    }
    Console.ReadKey();
} while (true);