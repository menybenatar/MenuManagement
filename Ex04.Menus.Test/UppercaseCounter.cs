using System;
using System.Linq;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class UppercaseCounter : ISelecetedItemObserver
    {
        public void OnSelected()
        {
            int uppercaseCounter = 0;
            Console.WriteLine($"Please Write A Sentence.{Environment.NewLine}The Program Will Count Uppercase Letters In Your Sentence.");
            string userSentence = Console.ReadLine();
            uppercaseCounter = userSentence.ToCharArray().Count(c => char.IsUpper(c));
            Console.WriteLine($"The Number Of Uppercase In Your Sentence Is: {uppercaseCounter}.");
        }
    }
}
