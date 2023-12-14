
Sample1();
void Sample1()
{
    (string username, string password) user = ("admin", "123");

    bool flag = true;
    while (flag)
    {
        Console.WriteLine("<= Login olun => ");

        Console.Write("Istifadeci adi daxil edin : ");
        string loginName = Console.ReadLine();

        Console.Write("Sifr' daxil edin : ");
        string loginPassword = Console.ReadLine();

        if (loginName == user.Item1 && loginPassword == user.Item2)
        {
            Console.WriteLine("Ugurlu emeliyyat");
            flag = false;
        }
        else
        {
            Console.WriteLine("Istifadeci adi ve ya sifre yalnisdir.Tekrar yoxlayin");
        }
    }
}