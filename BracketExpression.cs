namespace My.Home.Work.Arrays;

public class BracketExpression //ДЗ: Скобочное выражение
{
    public void PrintBracketExpression()
    {
        Console.WriteLine("\nВведите скобочки:");
        string input = Console.ReadLine();

        int depth = 0;
        int maxDepth = 0;
        bool isValid = true;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                depth++;
                if (depth > maxDepth)
                    maxDepth = depth;
            }
            else if (input[i] == ')')
            {
                depth--;
                if (depth < 0)
                {
                    isValid = false;
                    break;
                }
            }
            else
            {
                isValid = false;
                break;
            }
        }
        if (depth != 0)
            isValid = false;
        if (isValid)
        {
            Console.WriteLine("Строка корректная");
            Console.WriteLine($"Максимальная глубина вложенности: {maxDepth}");
        }
        else
        {
            Console.WriteLine("Строка некорректная");
        }
    }
}