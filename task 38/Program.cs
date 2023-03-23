// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(0, 100);
  }
}

int MaxNumber(int[] massiv)
{
  int max = massiv[0];
  for (int i = 1; i < massiv.Length; i++)
  {
    if (massiv[i] > max)
      max = massiv[i];  
  }
return max;
}

int MinNumber(int[] massiv)
{
  int min = massiv[0];
  for (int i = 1; i < massiv.Length; i++)
  {
    if (massiv[i] < min)
      min = massiv[i];  
  }
return min;
}

Console.Clear();
Console.Write("Введите количество элементов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(MaxNumber(array) - MinNumber(array));