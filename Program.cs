//Console.WriteLine("Gülleni tek-tek at!");
//Console.WriteLine("Güllenin hamısını birden at!");
//Console.WriteLine("Mermini yeniden doldur!");
//Console.WriteLine("Oyundan çıx!");
//Console.WriteLine("Mermi sayını göster!");
//Console.WriteLine("-------------------------------"); 

//string order = Console.ReadLine();
//firstOrder(order);
//secondOrder(order);


//static void firstOrder(string order)
//{
//    int ammo = 30;
//    if (order == "1")
//    {
//        do
//        {
//            ammo -= 1;
//            Console.WriteLine("Gulle atildi");
//            Console.WriteLine(ammo);
//        }
//        while (ammo == 0);
//    }
//}

//static void secondOrder(string order)
//{
//    int ammo = 30;
//    if (order == "2")
//    {
//        do
//        {
//            ammo = 0;
//            Console.WriteLine($"{ammo}gulle bitdi");
//        }
//        while (ammo == 0);
//    }
//}



//string click = Console.ReadLine();

//switch (click)
//{
//    case "1":
//        Console.WriteLine("sadad");
//        break;

//}



//static void weapon() {
//    int ammo = 30;


//}


//int ammo = 30;
//do
//{
//    int num = int.Parse(Console.ReadLine());
//    if (num > 0)
//    {
//        switch (num)
//        {
//            case 1:
//                do
//                {
//                    firstOrder(ammo);
//                } while (ammo == 0);
//                int NewCommand = int.Parse(Console.ReadLine());
//                    num = NewCommand;
//                break;

//            case 2:
//                secondOrder(ammo);
//                break;

//            case 3:
//                thirdOrder(ammo);
//                break;

//            case 4:
//                fourthOrder(ammo);
//                break;

//            case 5:
//                fifthOrder(ammo);
//                break;

//            default:
//                Console.WriteLine("Duzgun emr daxil edin!");
//                break;
//        }
//    }
//} while (ammo > 0);




Console.WriteLine("1.Gülleni tek-tek at!");
Console.WriteLine("2.Güllenin hamısını birden at!");
Console.WriteLine("3.Mermini yeniden doldur!");
Console.WriteLine("4.Oyundan çıx!");
Console.WriteLine("5.Mermi sayını göster!");
Console.WriteLine("--------------CHOOSE--------------");

int ammo = 30;


while (true)
{
    string num = Console.ReadLine();
    if (num == "1")
    {
        firstOrder(ammo);
    }
    else if (num == "2")
    {
        secondOrder(ammo);
    }
    else if (num == "3")
    {
        thirdOrder(ammo);
    }
    else if (num == "4")
    {
        fourthOrder(ammo);
        return;
    }
    else if (num == "5")
    {
        fifthOrder(ammo);
    }
    else
    {
        Console.WriteLine("DUZGUN EMR DAXIL EDIN!");
    }
}






static void firstOrder(int ammo)
{
    if (ammo > 0)
    {
        ammo--;
        Console.WriteLine("Gulle atildi!");
        Console.WriteLine(ammo);
    }
    else
    {
        Console.WriteLine("Gulleni yenileyin");
    }
}

static void secondOrder(int ammo)
{
    ammo = 0;
    Console.WriteLine("Mermi bitti");
    Console.WriteLine(ammo);
}

static void thirdOrder(int ammo)
{
    ammo = 30;
    Console.WriteLine("Gulle yenilendi!");
    Console.WriteLine(ammo);
}

static void fourthOrder(int ammo)
{
    Console.WriteLine("Oyun bitti");
}

static void fifthOrder(int ammo)
{
    ammo = ammo;
    Console.WriteLine($"{ammo} gulleniz var");
}
