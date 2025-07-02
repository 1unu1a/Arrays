namespace My.Home.Work.Arrays
{
    internal class Program //Блок массивы
    {
        static void Main(string[] args)
        {
            var dimensionalArray = new TwoDimensionalArray();
            dimensionalArray.PrintArray();
            
            var maxElementArray = new MaxElement();
            maxElementArray.PrintMaxArray();
            
            var localMaxArray = new LocalMax();
            localMaxArray.PrintLocalMaxArray();
            
            var dinamicArray = new DinamicArray();
            dinamicArray.PrintDinamicArray();
            
            var subarrayRepeating = new SubarrayRepeating();
            subarrayRepeating.PrintSubArray();

            var sortingArray = new SortingNumbers();
            sortingArray.PrintSortArray();
            
            var split = new Split();
            split.PrintSlitArray();
            
            var shiftArray = new ShiftArray();
            shiftArray.ShiftLeft();
            
            var bracketExpression = new BracketExpression();
            bracketExpression.PrintBracketExpression();
        }
    }
}