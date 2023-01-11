using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class VersionPresentor : ISelecetedItemObserver
    {
        public void OnSelected()
        {
            Console.WriteLine("Version: 23.1.4.8859");
        }
    }
}
