// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Метод подсчитывает количество положительных чисел
int Calc(double[] array)
{
int count =0;
for (int i=0; i<array.Length; i++)
    {
        if (array[i]>0) count++;
    }
    return count;
}


Console.Clear();
Console.WriteLine("Введите количество чисел : ");
try
{
int quantity=Math.Abs(Convert.ToInt32(Console.ReadLine()));
double[] array=new double[quantity];
Console.WriteLine();
for (int i=0; i<quantity; i++)
    {
        Console.Write($"{i+1})= ");
        array[i]=Convert.ToDouble(Console.ReadLine());

    }

Console.WriteLine($"Количество положительных чисел : {Calc(array)}");

}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
