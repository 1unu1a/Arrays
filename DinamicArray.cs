namespace My.Home.Work.Arrays;

public class DinamicArray //ДЗ: Динамический массив

{
    int[] array = new int [1];
    int countElement = 0;

    public void RunArray()
    {
        while (true)
        {
            PrintArray();

            Console.Write("Введите число или команду sum (для сложения) / exit (для выхода):");
            string input = Console.ReadLine();

            switch (input)
            {
                case "sum":
                    PrintSum();
                    break;

                case "exit":
                    Console.WriteLine("Выход");
                    return;

                default:
                    AddNumber(input);
                    break;
            }
        }
    }
    public void PrintArray()
    {
        Console.Write("Текущий массив: ");
        for (int i = 0; i < countElement; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine();
    }

    public void PrintSum()
    {
        int sum = 0;
        for (int i = 0; i < countElement; i++)
        {
            sum += array[i];
        }
        Console.WriteLine($"Сумма всех чисел: {sum}");
    }

    public void AddNumber(string input)
    {
        if (int.TryParse(input, out int number))
        {
            if (countElement == array.Length)
            {
                int[] newArray = new int[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }

            array[countElement] = number;
            countElement++;
        }
        else
        {
            Console.WriteLine("Ошибка, введите число или команду exit");
        }
    }
}