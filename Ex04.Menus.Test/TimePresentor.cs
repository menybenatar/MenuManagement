using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class TimePresentor : ISelecetedItemObserver
    {
        public void OnSelected()
        {
            string timeMessage = $"The Current Time Is:{Environment.NewLine}{DateTime.Now.ToString("T")}{Environment.NewLine}";
            Console.WriteLine(timeMessage);
        }
    }
}
