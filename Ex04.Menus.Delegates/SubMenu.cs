using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private readonly List<MenuItem> r_MenuItems;
        private readonly bool r_IsMainMenu;

        public bool IsMainMenu
        {
            get { return r_IsMainMenu; }
        }

        public List<MenuItem> MenuItems
        {
            get { return r_MenuItems; }
        }

        public SubMenu(string i_Title, bool i_IsMainMenu = false)
            : base(i_Title)
        {
            ActionItem backOrExistAction = i_IsMainMenu ? new ActionItem("Exit", eActionType.Exit) : new ActionItem("Back", eActionType.Back);
            r_MenuItems = new List<MenuItem>();
            r_IsMainMenu = i_IsMainMenu;
            r_MenuItems.Add(backOrExistAction);
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            i_MenuItem.OptionIndex = r_MenuItems.Count;
            r_MenuItems.Add(i_MenuItem);
        }

        public void DisplayMenu(int i_CurrentLevel)
        {
            StringBuilder menu = new StringBuilder();
            menu.AppendLine(IsMainMenu ? $"{Title}" : $"{OptionIndex}. {Title}");
            menu.AppendLine($"Current Level: {i_CurrentLevel}");
            menu.AppendLine("===================");
            foreach (MenuItem menuItem in r_MenuItems)
            {
                if (menuItem.OptionIndex != 0)
                {
                    menu.AppendFormat("{0}. {1}{2}", menuItem.OptionIndex, menuItem.Title, Environment.NewLine);
                }
            }

            menu.Append($"0. {r_MenuItems[0].Title}");
            Console.WriteLine(menu);
        }
    }
}