string sep   = ", ";
Console.WriteLine("Введите массив строк через пробел");
string[] mass = Console.ReadLine()!.Split(' ');
string[] result = new string[mass.Length];
int index = 0;
for (int i=0; i<mass.Length;i++)
{
    if (mass[i].Length <= 3) 
    {
        result[index] = mass[i];
        index++;
    }
}
Array.Resize(ref result, index);
Console.WriteLine("Элементы не длинее 3 символов:");
Console.WriteLine(string.Join(sep, result, 0, index));
Console.WriteLine("Число элементов не длинее 3 равно: {0}", result.Length);
