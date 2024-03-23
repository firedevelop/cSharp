class myMethod
{
    public static void PrintmyMethod()
    {
        // Sample string
        string myString = "   Hello, World!   ";

        // ToCharArray: H, e, l, l, o, ,,  , W, o, r, l, d, !,  ,  
        char[] charArray = myString.ToCharArray();
        Console.WriteLine($"ToCharArray: {string.Join(", ", charArray)}");

        // Substring: Hello
        string substring = myString.Substring(1, 3);
        Console.WriteLine($"Substring: {substring}");

        // CopyTo: l, l, o, ,,  
        char[] destinationArray = new char[5];  // Inicialization Array
        // 3 = ___
        // 0= H
        // 5 = o
        myString.CopyTo(3, destinationArray, 0, 5);
        Console.WriteLine($"CopyTo: {string.Join(", ", destinationArray)}");

        // CompareTo: 1 (result of string comparison)
        string otherString = "hello";
        int compareToResult = myString.CompareTo(otherString);
        Console.WriteLine($"CompareTo: {compareToResult}");

        // Contains: True
        bool containsResult = myString.Contains("World");
        Console.WriteLine($"Contains: {containsResult}");

        // IndexOf: 7 (index of the substring "World")
        int indexOfResult = myString.IndexOf("World");
        Console.WriteLine($"IndexOf: {indexOfResult}");

        // Insert:    Beautiful Hello, World!   
        string insertedString = myString.Insert(7, "Beautiful ");
        Console.WriteLine($"Insert: {insertedString}");

        // Trim: Hello, World!
        string trimmedString = myString.Trim();
        Console.WriteLine($"Trim: {trimmedString}");

        // Replace:    Hello, Universe!   
        string replacedString = myString.Replace("World", "Universe");
        Console.WriteLine($"Replace: {replacedString}");

        // Remove:    Hello, !
        string removedString = myString.Remove(7, 6);
        Console.WriteLine($"Remove: {removedString}");

        // Split: Hello, World!   (no commas found, array will have a single element)
        string[] splitArray = myString.Split(',');
        Console.WriteLine($"Split: {string.Join(", ", splitArray)}");

        // ToLower:    hello, world!   
        string lowerCaseString = myString.ToLower();
        Console.WriteLine($"ToLower: {lowerCaseString}");

        // ToUpper:    HELLO, WORLD!   
        string upperCaseString = myString.ToUpper();
        Console.WriteLine($"ToUpper: {upperCaseString}");
    }
}
