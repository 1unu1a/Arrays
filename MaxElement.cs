namespace My.Home.Work.Arrays;

public class MaxElement //ДЗ: Наибольший элемент

{
    const int MIN_ELEMENT_ARRAY = 10;
    const int MAX_ELEMENT_ARRAY = 100;
    int[,] array = new int[10, 10];
    int maxElement = int.MinValue;
    Random random = new Random();

    public void PrintMaxArray()
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(MIN_ELEMENT_ARRAY, MAX_ELEMENT_ARRAY);
                Console.Write(array[i, j] + " ");
                
                if (maxElement < array[i, j])
                {
                    maxElement = array[i, j];
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine($"Наибольший элемент матрицы: {maxElement}");

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == maxElement)
                {
                    array[i, j] = 0;
                }

                Console.Write(array[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}