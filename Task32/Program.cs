// //Task32 Задайте массив из элементов, заполненный случайными числами из промежутка [-9, 9].
// Положительные элементы заменить на отрицательные и наборот


void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-9, 10); // [-9, 9]
}


void ReleaseArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   array[i] *= (-1);
  
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
