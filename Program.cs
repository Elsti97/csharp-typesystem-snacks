
bool exit = false;

while (!exit)
{
    Console.WriteLine("Inserisci il numero dello snack da eseguire da 1 a 12 oppure digita 'esci' per terminare il programma");
    string input = Console.ReadLine() ?? "";
    Console.WriteLine();

    switch (input)
    {
        case "1":
            snack1();
            break;
        case "2":
            snack2();
            break;
        case "3":
            snack3();
            break;
        case "4":
            snack4();
            break;
        case "5":
            snack5();
            break;
        case "6":
            snack6();
            break;
        case "7":
            snack7();
            break;
        case "8":
            snack8();
            break;
        case "9":
            snack9();
            break;
        case "10":
            snack10();
            break;
        case "11":
            snack11();
            break;
        case "12":
            snack12();
            break;
        case "esci":
            exit = true;
            break;
        default:
            Console.WriteLine("Errore, riprova");
            break;
    }
}


void snack1()
{
    Console.WriteLine("1)Scrivi 2 numeri, stamperò il maggiore");
    Console.WriteLine("Inserisci un numero: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Inserisci un altro numero: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int maggiore = num1 > num2 ? num1 : num2;

    if (num1 == num2)
    {
        Console.WriteLine("Numeri uguali");
    }
    else
    {
        Console.WriteLine("il maggiore è: " + maggiore);
    }
    Console.WriteLine();
}


void snack2()
{
    Console.WriteLine("2)Scrivi 2 parole, le metterò in ordine di grandezza");
    Console.WriteLine("Inserisci una parola");
    string str1 = Console.ReadLine() ?? "";

    Console.WriteLine("Inserisci un'altra parola");
    string str2 = Console.ReadLine() ?? "";

    if (str1.Length < str2.Length)
    {
        Console.WriteLine("La parola più corta è: " + str1);
        Console.WriteLine("La parola più lunga è: " + str2);
    }
    else
    {
        Console.WriteLine("La parola più corta è: " + str2);
        Console.WriteLine("La parola più lunga è: " + str1);
    }
    Console.WriteLine();
}


void snack3()
{
    Console.WriteLine("3)Scrivi 10 numeri, farò la somma");
    int sum = 0;
    for (int i = 1; i <= 10; i++)
    {
        Console.Write("Inserisci un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        sum += num;
    }
    Console.WriteLine("La somma totale è: " + sum);
    Console.WriteLine();
}


void snack4()
{
    Console.WriteLine("4)Ecco la somma dei numeri da 2 a 10");
    int sum = 0;
    int min = 2;
    int max = 10;
    int nums = 0;

    for (int i = min; i <= max; i++)
    {
        sum += i;
        nums++;
    }
    double avg = sum / nums;
    Console.WriteLine("La somma è: " + sum);
    Console.WriteLine("La media è: " + avg);
    Console.WriteLine();
}


void snack5()
{
    Console.WriteLine("5)Inserisci un numero, se è pari lo accetto, se dispari lo trasformerò nel numero dopo");
    Console.Write("Inserisci un numero: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine("Il numero inserito è pari: " + num);
    }
    else
    {
        Console.WriteLine("Il numero inserito è dispari, ecco il numero pari subito dopo: " + (num + 1));
    }
    Console.WriteLine();
}


void snack6()
{
    Console.WriteLine("6)Scrivi il tuo nome, dirò se sei stato invitato alla festa");
    string[] guestList = { "Aldo", "Giovanni", "Giacomo", "Parrego", "Nagasella", "Nagheso", "Pasaghella", "Parrassanna", "Franco" };

    Console.Write("Inserisci il tuo nome: ");
    string name = Console.ReadLine() ?? "";

    if (guestList.Contains(name, StringComparer.OrdinalIgnoreCase))
    {
        Console.WriteLine("Puoi partecipare alla festa del grande Gasby");
    }
    else
    {
        Console.WriteLine("Non sei stato invitato");
    }
    Console.WriteLine();
}


void snack7()
{
    Console.WriteLine("7)Scrivi 6 numeri, alla fine ti dirò quali sono dispari");
    int[] oddArray = new int[0];

    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine("Inserisci un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 != 0)
        {
            int[] newArray = new int[oddArray.Length + 1];

            for (int j = 0; j < oddArray.Length; j++)
            {
                newArray[j] = oddArray[j];
            }

            newArray[oddArray.Length] = num;

            oddArray = newArray;
        }
    }

    Console.WriteLine("Numeri dispari inseriti:");
    foreach (int odd in oddArray)
    {
        Console.Write(odd + " ");
    }

    Console.WriteLine();
    Console.WriteLine();
}


void snack8()
{
    Console.WriteLine("8)Ecco la somma dei numeri in posizione dispari");
    int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int oddSum = 0;

    for (int i = 1; i < nums.Length; i += 2)
    {
        oddSum += nums[i];
    }

    Console.WriteLine("La somma dei numeri in posizione dispari è: " + oddSum);
    Console.WriteLine();
}


void snack9()
{
    Console.WriteLine("9)Scrivi un numero, te li chiederò fino alla somma di 50");
    int[] numArray = new int[0];
    int sum = 0;

    while (sum < 50)
    {
        Console.WriteLine("Inserisci un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int[] newArray = new int[numArray.Length + 1];

        for (int i = 0; i < numArray.Length; i++)
        {
            newArray[i] = numArray[i];
        }

        newArray[numArray.Length] = num;

        numArray = newArray;

        sum = 0;

        for (int i = 0; i < numArray.Length; i++)
        {
            sum += numArray[i];
        }
    }

    Console.WriteLine("La somma ha raggiunto 50, il risultato è: " + sum);
    Console.WriteLine();
}



void snack10()
{
    Console.WriteLine("10)Scrivi un numero, creerò N array con numeri casuali");
    Console.WriteLine("Inserisci un numero: ");

    int N = Convert.ToInt32(Console.ReadLine());

    var random = new Random();

    for (int i = 0; i < N; i++)
    {
        int[] array = new int[10];

        for (int j = 0; j < array.Length; j++)
        {
            array[j] = random.Next(0, 100);
        }

        foreach (var num in array)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void snack11()
{
    Console.WriteLine("11)Scrivi 2 parole, le stamperò se sono uguali o (se diverse) la più lunga");
    Console.Write("Inserisci la prima parola: ");
    string str1 = Console.ReadLine() ?? "";

    Console.Write("Inserisci la seconda parola: ");
    string str2 = Console.ReadLine() ?? "";

    if (str1.Length == str2.Length)
    {
        Console.WriteLine("Le due parole sono entrambe lunghe " + str1.Length + " caratteri e sono: " + str1 + " e " + str2);
    }
    else
    {
        string longer = str1.Length > str2.Length ? str1 : str2;
        Console.WriteLine("La parola più lunga è: " + longer);
    }
    Console.WriteLine();
}


bool isEven(int num)
{
    return num % 2 == 0;
}

void snack12()
{
    Console.WriteLine("12)Scrivi un numero, ti dirò se è pari o dispari");
    Console.Write("Inserisci un numero: ");
    int num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Il numero inserito è: {(isEven(num) ? "pari" : "dispari")}");

    Console.WriteLine();
}

