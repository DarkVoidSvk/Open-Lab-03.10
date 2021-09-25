using System;
using System.Linq; //The reason I added this library is because I want to use string.Count

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string words)
        {
            return words.Count(str => (str == letter));
        }
    }
}
