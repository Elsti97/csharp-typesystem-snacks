//snack1();
//snack2();
//snack3();
//snack4();
//snack5();
//snack6();
snack7();
//snack8();
//snack9();
//snack10();
//snack11();
//snack12();

void snack1()
{ 
    int num1 = Convert.ToInt32(Console.ReadLine());
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
}


void snack2() 
{
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
}


void snack3()
{
    int sum = 0;
    for (int i = 1; i <= 10; i++)
    {
        Console.Write("Inserisci un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());
        sum += num;
    }
    Console.WriteLine("La somma totale è: " + sum);
}


void snack4()
{
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
}


void snack5()
{
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
}


void snack6()
{
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
}


void snack7()
{
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
}


void snack8()
{

}


void snack9()
{

}


void snack10()
{

}


void snack11()
{

}


void snack12()
{

}