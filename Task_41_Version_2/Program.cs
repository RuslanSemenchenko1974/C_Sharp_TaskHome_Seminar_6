// 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

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
// Метод преобразует строку чисел через пробел в массив чисел
double[] StringToArray(string quantity)
{
int strLength=quantity.Length;
string namber=String.Empty;
char ifWhitespace=Convert.ToChar(" ");
int count=0;
double[] arrayOfNumber=new double[strLength/2];
for(int i=0;i<strLength; i++) 
    {
        if (quantity[i]==ifWhitespace)
        {
            arrayOfNumber[count]=Convert.ToDouble(namber);
            count++;
            namber="";
        }
        else 
        {
           namber=namber+quantity[i];
        }
    }
    arrayOfNumber[count]=Convert.ToDouble(namber);
    return arrayOfNumber;
}

Console.Clear();
Console.WriteLine("Введите числа через пробел: ");
try
{
   string quantity=Console.ReadLine();

   Console.WriteLine($"Количество положительных чисел : {Calc(StringToArray(quantity))}");
}

catch(Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
