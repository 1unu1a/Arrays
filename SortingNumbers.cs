namespace My.Home.Work.Arrays;

public class SortingNumbers //ДЗ: Сортировка чисел

{
    int[] array = new int [10];
    Random random = new Random();

    public void PrintSortArray()
    {
        Console.WriteLine("Исходный массив:");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 50);
            Console.Write($"{array[i]} ");
        }

        SortArray();
        
        Console.WriteLine("\nПузырьковая сортировка:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }

    public void SortArray()
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}