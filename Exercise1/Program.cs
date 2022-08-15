string text = "В Турции уже 2 года как живет мой брат с семьей." +
                "Они уже обустроились, получили ВНЖ, выбрали район," +
                "где им понравилось больше всего и даже купили там квартиру." +
                "Дочка ходит в школу, на кружки, они работают (удаленно). " +
                "Все налажено, жизнь течёт)";

// string s = "qwerty"
//             012345
//             s[3] = r
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '.');
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);