namespace My.Home.Work.Arrays;

public class SubarrayRepeating //ДЗ: Подмассив повторений чисел

{
    int[] array = new int [30];
    Random random = new Random();

    public void PrintSubArray()
    {
        Console.WriteLine("Исходный массив:");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 15);
            Console.Write($"{array[i]} ");
        }

        int maxCount = 1;
        int currentCount = 1;
        int repeatedNumber = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentCount++;
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    repeatedNumber = array[i];
                }
            }
            else
            {
                currentCount = 1;
            }
        }

        if (maxCount > 1)
        {
            Console.WriteLine($"\nЧисло, повторяющееся подряд дольше всех: {repeatedNumber}");
            Console.WriteLine($"Количество повторений подряд: {maxCount}");
        }
        else
        {
            Console.WriteLine("\nВ массиве нет повторяющихся чисел");
        }
    }
}