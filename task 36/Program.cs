// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-99, 100);
  }
}
int SumNumber(int[] massiv)
{
  int sum = 0;
  for (int i = 0; i < massiv.Length; i++)
  {
    if (i % 2 == 1)
      sum = sum + massiv[i];  
  }
return sum;
}

Console.Clear();
Console.Write("Введите количество элементов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(SumNumber(array));











