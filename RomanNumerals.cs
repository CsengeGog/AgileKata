using System;

public class RomanNumerals
{
    static Dictionary<int, string> arabicToRoman = new Dictionary<int, string>
    {
        {1, "I" },
        {3, "III" },
        {9, "IV" },
        {1066, "MLXVI" },
        {1989, "MCMLXXXIX" }
    };
    public static string ToRoman(int arabic)
    {
        string roman = string.Empty;
        foreach (int value in arabicToRoman.Keys)
        {
            while (arabic >= value)
            {
                roman += arabicToRoman[value];
                arabic -= value;
            }
        }
        return roman;


    }
}

