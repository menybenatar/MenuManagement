using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegateTestMenu
    {
        public static void RunDelegateMenu()
        {
            MainMenu mainMenu = new MainMenu();
            SubMenu firstSub = new SubMenu("Version and Uppercase");
            firstSub.AddMenuItem(new ActionItem("Show Version", eActionType.Event));
            firstSub.AddMenuItem(new ActionItem("Count Uppercase", eActionType.Event));
            SubMenu secondSub = new SubMenu("Show Date/Time");
            secondSub.AddMenuItem(new ActionItem("Show Date", eActionType.Event));
            secondSub.AddMenuItem(new ActionItem("Show Time", eActionType.Event));
            secondSub.AddMenuItem(new SubMenu("Submenu"));
            mainMenu.MainMenuItems.AddMenuItem(firstSub);
            mainMenu.MainMenuItems.AddMenuItem(secondSub);
            mainMenu.Show();
        }
    }
}
