// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void input_array(int[]array)
{
        for (int i = 0; i < array.Length; i++) 
        {
        Console.Write($"Введите элемент массива № {i+1}: ");
          array[i] = (int)Convert.ToDouble(Console.ReadLine());
        }
        
}

int release(int[]array)
{
int count=0;
for (int i =0; i<array.Length; i++)
     if (array[i] > 0)
         count ++;
     return count;
}


Console.Clear();
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[]array=new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(" ,  ", array)}]");
Console.WriteLine(release (array));

