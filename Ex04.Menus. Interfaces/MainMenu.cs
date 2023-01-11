using System;
using System.Collections;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private readonly Stack r_PreviousMenus;
        private readonly SubMenu r_MainMenuItems;
        private SubMenu m_CurrentMenu;

        public SubMenu MainMenuItems
        {
            get { return r_MainMenuItems; }
        }

        public MainMenu(string i_Title)
        {
            const bool v_IsMainMenu = true;
            r_MainMenuItems = new SubMenu(i_Title, v_IsMainMenu);
            r_PreviousMenus = new Stack();
            m_CurrentMenu = r_MainMenuItems;
        }

        public void Show()
        {
            bool isMenuAlive = true;
            while (isMenuAlive)
            {
                m_CurrentMenu.PrintMenu(r_PreviousMenus.Count);
                int menuItemIndex = getInputAndValidate();
                Console.Clear();
                if (m_CurrentMenu.MenuItems[menuItemIndex] is ActionItem actionItem)
                {
                    isMenuAlive = executeAction(actionItem);
                    Console.Clear();
                }
                else
                {
                    r_PreviousMenus.Push(m_CurrentMenu);
                    m_CurrentMenu = m_CurrentMenu.MenuItems[menuItemIndex] as SubMenu;
                }
            }
        }

        private int getInputAndValidate()
        {
            const bool v_IsNotValid = true;
            int userInput;
            string message = m_CurrentMenu.MenuItems.Count > 0 ? $"Please Select A Number Between 0 and {m_CurrentMenu.MenuItems.Count - 1}"
                : "Please Select 0 To Go Back";
            Console.WriteLine(message);
            while (v_IsNotValid)
            {
                if (int.TryParse(Console.ReadLine(), out userInput))
                {
                    if (userInput >= 0 && userInput <= m_CurrentMenu.MenuItems.Count - 1)
                    {
                        break;
                    }
                }

                Console.WriteLine($"Your Input Is Not Valid! Please Select Number between 0 and {m_CurrentMenu.MenuItems.Count - 1}");
            }

            return userInput;
        }

        private bool executeAction(ActionItem i_ActionItem)
        {
            bool isMenuAlive = true;
            switch (i_ActionItem.ActionType)
            {
                case eActionType.Event:
                    i_ActionItem.DoWhenSelected();
                    Console.WriteLine("Please Enter Any Key To Return...");
                    Console.ReadKey();
                    break;
                case eActionType.Back:
                    m_CurrentMenu = r_PreviousMenus.Pop() as SubMenu;
                    break;
                case eActionType.Exit:
                    isMenuAlive = false;
                    break;
            }

            return isMenuAlive;
        }
    }
}
