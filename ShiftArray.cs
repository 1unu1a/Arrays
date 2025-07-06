namespace My.Home.Work.Arrays;

public class ShiftArray //ДЗ: Сдвиг значений массива
{
    int[] array = new int [10];
    Random random = new Random();
    public int input;
    public int shift;

    public void ShiftLeft()
    {
        Console.WriteLine("Исходный массив:");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 50);
            Console.Write($"{array[i]} ");
        }
        
        Console.WriteLine("\nВведиите количество сдвигов влево:");
        input = Convert.ToInt32(Console.ReadLine());
        shift = input % array.Length;

        for (int i = 0; i < shift; i++)
        {
            int temp = array[0];
            for (int j = 0; j < array.Length - 1; j++)
            {
                array[j] = array[j + 1];
            }
            array[array.Length - 1] = temp;
        }
        
        Console.WriteLine("Массив после сдвига:");
        
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
}