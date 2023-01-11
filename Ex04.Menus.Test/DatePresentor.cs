using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class DatePresentor : ISelecetedItemObserver
    {
        public void OnSelected()
        {
            string dateMessage = $"The Current Date Is:{Environment.NewLine}{DateTime.Now.ToString("dd/MM/yyyy")}{Environment.NewLine}";
            Console.WriteLine(dateMessage);
        }
    }
}
