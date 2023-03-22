// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(100, 1000);
  }
}
void PositiveCount(int[] massiv)
{
  int n = 0;
  for (int count = 0; count < massiv.Length; count++)
  {
    if (massiv[count]%2 == 0)
      n = n + 1;  
  }
  Console.WriteLine($"количество четных чисел = {n}");
}

Console.Clear();
int[] array = new int[8];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
PositiveCount(array);



















