namespace My.Home.Work.Arrays;

public class DinamicArray //ДЗ: Динамический массив

{
    int[] array = new int [1];
    int countElement = 0;

    public void PrintDinamicArray()
    {
        while (true)
        {
            Console.Write("Текущий массив:");


            for (int i = 0; i < countElement; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            Console.WriteLine("Введите число или команду exit:");
            string imput = Console.ReadLine();

            if (imput == "sum")
            {
                int sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                    Console.WriteLine($"Ваша сумма: {sum}");
                }
            }
            else if (imput == "exit")
            {
                Console.WriteLine("Выход");
                break;
            }
            else
            {
                if (int.TryParse(imput, out int number))
                {
                    if (countElement == array.Length)
                    {
                        int[] result = new int[array.Length * 2];
                        for (int i = 0; i < array.Length; i++)
                        {
                            result[i] = array[i];
                        }

                        array = result;
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
    }
}