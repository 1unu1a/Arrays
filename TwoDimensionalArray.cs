namespace My.Home.Work.Arrays;

public class TwoDimensionalArray //ДЗ: Работа с конкретными строками/столбцами

{
    public int[,] array = new int [2, 3]
    {
        { 2, 4, 3 }, 
        { 5, 1, 6 }
    };

    public void PrintArray()
    {
        Console.WriteLine("Матрица: ");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        int sumRow2 = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow2 += array[1, j];
        }
        
        int productColumn1 = 1;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            productColumn1 *= array[i, 0];
        }
        
        Console.WriteLine($"Сумма второй строки: {sumRow2}");
        Console.WriteLine($"Произведение первого столбца: {productColumn1}");
    }
}