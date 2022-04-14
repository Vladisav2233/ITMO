// See https://aka.ms/new-console-template for more information

string? ignition = "true";      //состояние зажигания
double FrontLeftWheel = 0;                //значение колесного датчика давления
int stoptime = 5000;         //время задержки опроса датчика в милисекундах
while (ignition == "true")
{
    Console.WriteLine("ввести значение колесного датчика давления переднего левого колеса");
    FrontLeftWheel = Convert.ToDouble(Console.ReadLine());
    if (FrontLeftWheel  < 2 & FrontLeftWheel  >= 0)
        Console.WriteLine("Проверьте левое переднее колесо " + FrontLeftWheel );
    else if (FrontLeftWheel >=2 && FrontLeftWheel <=2.4)
        Console.WriteLine("Левое переднее колесо " + FrontLeftWheel );
    else if (FrontLeftWheel  > 2.4)
        Console.WriteLine("Давление в  левом переднем колесе выше нормы " + FrontLeftWheel );
    else
        Console.WriteLine("Датчик неисправен");
    Thread.Sleep(stoptime);
    Console.WriteLine("Зажигание включено? (введиде true или false)");
    ignition = Console.ReadLine();
    
}
Console.WriteLine("Зажигание ВЫКЛ");