// See https://aka.ms/new-console-template for more information
bool go()
{
bool result = false;
int[] Mas = new int[5];
    Mas[0] = 10;
    Mas[1] = 11;
    Mas[2] = 12;
    Mas[3] = 13;
    Mas[4] = 4;

    int n = Mas.Length;

    for (int i = 0; i < n; i++)
    {
        if (Mas[i] == i)
            Console.WriteLine("Значение True для элемента массива " + i);
        result = true;
    }
    return result;
}
go();
