class Program
{
    static void Main()
    {
        string[] array1 = { "USA", "Canada", "Mexico", "France", "Germany" };
        string[] array2 = { "Germany", "France", "Italy", "Spain" };

        var difference = array1.Except(array2).ToArray();
        Console.WriteLine("Difference (elements in first array not in second):");
        Console.WriteLine(string.Join(", ", difference));

        var intersection = array1.Intersect(array2).ToArray();
        Console.WriteLine("Intersection (common elements in both arrays):");
        Console.WriteLine(string.Join(", ", intersection));

        var union = array1.Union(array2).ToArray();
        Console.WriteLine("Union (elements of both arrays without duplicates):");
        Console.WriteLine(string.Join(", ", union));

        var firstArrayWithoutRepeating = array1.Distinct().ToArray();
        Console.WriteLine("First array without repeating elements:");
        Console.WriteLine(string.Join(", ", firstArrayWithoutRepeating));
    }
}
