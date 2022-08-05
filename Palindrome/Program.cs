


    Console.WriteLine("Entrez un mot");
    string good = Console.ReadLine();
    string word = good;
    //char[] CHAR_IN = { 'À', 'Ä', 'Â', 'É', 'È', 'Ë', 'Ê', 'Ù', 'Û', 'Ü', 'Ô', 'Ö', 'Î', 'Ï', 'Ç' };
    //char[] CHAR_OUT = { 'A', 'A', 'A', 'E', 'E', 'E', 'E', 'U', 'U', 'U', 'O', 'O', 'I', 'I', 'C' };
    word = word.ToLower();
    word = word.Replace('ê', 'e').Replace('é', 'e').Replace('è', 'e').Replace('ë', 'e');
    word = word.Replace('à', 'a').Replace('â', 'a').Replace('ä', 'a');
    word = word.Replace('î', 'i').Replace('ï', 'i');
    word = word.Replace('û', 'u').Replace('ù', 'u').Replace('ü', 'u');
    word = word.Replace('ô', 'o').Replace('ö', 'o');
    word = word.Replace('ç', 'c');
    word = word.ToUpper();
    string reverse = "";

    //static string RemoveSpecialChars(string reverse)
    
    for (int i = word.Length - 1; i >= 0; i--)
    {
        //reverse = reverse.Replace(CHAR_IN[i], CHAR_OUT[i]);
        reverse = reverse + word[i];
    }
    
    if (reverse == word)
    {
        Console.WriteLine($"{good} est un palindrome.");
    }
    else
    {
        Console.WriteLine($"{good} n'est pas un palindrome.");
    }
