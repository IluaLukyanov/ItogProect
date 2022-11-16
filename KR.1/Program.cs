int Schetchik(string[] mas) // метод нужен для нахождения длины массива, предназначенного для записи
{
    int ind = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i].Length <= 3)
        {
            ind++;
        }
    }
    return ind;
}

string[] Scaner(string[] mass, int count) // метод находит элементы длиною меньше 3, записывает их в возвращаемый массив
{
    string[] result = new string[count];
    int index = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            result[index] = mass[i];
            index++;
        }
    }
    return result;
}

Console.WriteLine("Введите массив строк через пробел");
string[] mass = Console.ReadLine()!.Split(' ');

Console.WriteLine("Элементы не длинее 3 символов:");

for (int i = 0; i < Schetchik(mass); i++)
{
    Console.Write("{0} ", Scaner(mass, Schetchik(mass))[i]);
}
