using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class TimePresentor : ISelecetedItemObserver
    {
        public void OnSelected()
        {
            string timeMessage = string.Format("The Current Time Is:{0}{1}{0}", Environment.NewLine, DateTime.Now.ToString("T"));
            Console.WriteLine(timeMessage);
        }
    }
}
