using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class DatePresentor : ISelecetedItemObserver
    {
        public void OnSelected()
        {
            string dateMessage = string.Format("The Current Date Is:{0}{1}{0}", Environment.NewLine, DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine(dateMessage);
        }
    }
}
