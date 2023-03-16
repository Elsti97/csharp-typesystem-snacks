snack1();

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
