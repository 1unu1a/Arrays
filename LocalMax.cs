namespace My.Home.Work.Arrays;

public class LocalMax //ДЗ: Локальные максимумы

{
    int [] array = new int [30];
    Random random = new Random();

    public void PrintLocalMaxArray()
    {
        Console.WriteLine("Исходный массив:");
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 25);
            Console.Write($"{array[i]} ");
        }
        
        Console.WriteLine("\nЛокальные максимумы:");

        for (int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                if (array.Length > 1 && array[i] > array[i + 1])
                    Console.Write($"{array[i]} ");
                else if (array.Length == 1)
                    Console.Write($"{array[i]} ");
            }
            else if (i == array.Length - 1)
            {
                if (array[i] > array[i - 1])
                    Console.Write($"{array[i]} ");
            }
            else
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                    Console.Write($"{array[i]} ");
            }
        }
    }
}