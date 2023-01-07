using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            runDelegateMenu();
        }

        private static void runDelegateMenu()
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
