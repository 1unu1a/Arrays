namespace My.Home.Work.Arrays;

public class Split //ДЗ: Split

{
    string text = "Привет, выведи весь этот текст по одному слову";

    public void PrintSplitArray()
    {
        string[] splitArray = text.Split(' ');
        Console.WriteLine("Слова в тексте: ");

        foreach (string element in splitArray)
        {
            Console.WriteLine(element);
        }
    }

}