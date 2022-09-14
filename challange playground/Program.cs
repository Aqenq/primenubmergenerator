int sayi1;
sayi1 = int.Parse(Console.ReadLine());
int sayi2 = sayi1 - 1;
a:
while (true)
{

    while (sayi1 % sayi2 != 0)
    {
        sayi2 = sayi2 - 1;
    }
    if (sayi2 == 1)
        {
            Console.WriteLine(sayi1 + "sayı asaldır");
            break;
        }
    if (sayi1 % sayi2 == 0)
{  
        break;
}
}
sayi1++;
sayi2 = sayi1 - 1;
goto a;
    
    
    
    