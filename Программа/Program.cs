// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше 
// либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения 
// алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

Console.WriteLine("Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами");

string[] massiv = new string[5]{ "rome", "cool", "451", "geo", ":" };
string[] massivThreeSymbol = new string[massiv.Length];
void SecondArray(string[] massiv, string[] massivThreeSymbol)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        if (massiv[i].Length <= 3)
        {
            massivThreeSymbol[i] = massiv[i];
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($" {array[i]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Заданный массив:");
PrintArray(massiv);
Console.Write("Элементы меньше или равные трем знакам: ");
SecondArray(massiv, massivThreeSymbol);
Console.WriteLine();
PrintArray(massivThreeSymbol);
