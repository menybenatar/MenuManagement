using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private List<MenuItem> m_MenuItems;
        private bool m_IsMainMenu;

        public bool IsMainMenu
        {
            get { return m_IsMainMenu; }
            set { m_IsMainMenu = value; }
        }

        public List<MenuItem> MenuItems
        {
            get { return m_MenuItems; }
            set { m_MenuItems = value; }
        }

        public SubMenu(string i_Title, bool i_IsMainMenu = false)
            : base(i_Title)
        {
            ActionItem backOrExistAction = i_IsMainMenu ? new ActionItem("Exit", eActionType.Exit) : new ActionItem("Back", eActionType.Back);
            m_MenuItems = new List<MenuItem>();
            m_IsMainMenu = i_IsMainMenu;
            m_MenuItems.Add(backOrExistAction);
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            i_MenuItem.OptionIndex = m_MenuItems.Count;
            m_MenuItems.Add(i_MenuItem);
        }

        internal void DisplayMenu(int i_CurrentLevel)
        {
            StringBuilder menu = new StringBuilder();
            menu.AppendLine(IsMainMenu ? $"{Title}" : $"{OptionIndex}. {Title}");
            menu.AppendLine($"Current Level: {i_CurrentLevel}");
            menu.AppendLine("===================");
            foreach (MenuItem menuItem in m_MenuItems)
            {
                if (menuItem.OptionIndex != 0)
                {
                    menu.AppendFormat("{0}. {1}{2}", menuItem.OptionIndex, menuItem.Title, Environment.NewLine);
                }
            }

            menu.Append($"0. {m_MenuItems[0].Title}");
            Console.WriteLine(menu);
        }
    }
}