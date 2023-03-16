//snack1();
//snack2();
snack3();

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