using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        private SubMenu m_MainMenuItems;
        private SubMenu m_CurrentMenu;
        private Stack m_PreviousMenus;

        public SubMenu MainMenuItems
        {
            get { return m_MainMenuItems; }
            set { m_MainMenuItems = value; }
        }

        public Stack PreviousMenus
        {
            get { return m_PreviousMenus; }
            set { m_PreviousMenus = value; }
        }

        public MainMenu()
        {
            const bool v_IsMainMenu = true;
            m_MainMenuItems = new SubMenu("Main Menu", v_IsMainMenu);
            m_CurrentMenu = m_MainMenuItems;
            m_PreviousMenus = new Stack();
        }

        public void Show()
        {
            bool isMenuAlive = true;

            while (isMenuAlive)
            {
                m_CurrentMenu.DisplayMenu();
                int menuItemIndex = getInputAndValidate();
                if (m_CurrentMenu.MenuItems[menuItemIndex] is ActionItem actionItem)
                {
                    ExecuteAction(actionItem, ref isMenuAlive);
                }
                else
                {
                    m_PreviousMenus.Push(m_CurrentMenu);
                    m_CurrentMenu = m_CurrentMenu.MenuItems[menuItemIndex] as SubMenu;
                }

                Console.Clear();
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

        private void ExecuteAction(ActionItem i_ActionItem, ref bool io_KeepShowingMenu)
        {
            switch (i_ActionItem.ActionType)
            {
                case eActionType.Event:
                    Console.Clear();
                    i_ActionItem.DoWhenSelected();
                    Console.WriteLine("Please Enter Any Key...");
                    Console.ReadKey();
                    break;
                case eActionType.Back:
                    m_CurrentMenu = m_PreviousMenus.Pop() as SubMenu;
                    break;
                case eActionType.Exit:
                    io_KeepShowingMenu = false;
                    break;
            }
        }

        private int getUserInput()
        {
            bool isInputInvalid = true;
            string userInput = string.Empty;
            string askToSelect = m_CurrentMenu.MenuItems.Count == 0
                                     ? "Press 0 To Go Back"
                                     : $"Please enter your choice (1 - {m_CurrentMenu.MenuItems.Count - 1} or 0 to exit):{Environment.NewLine}>> ";

            Console.Write(askToSelect);

            do
            {
                userInput = Console.ReadLine();
                isInputInvalid = validateUserInput(userInput);

                if (isInputInvalid)
                {
                    Console.WriteLine($"Your Input Is Invalid! Please Select Options 0 - {m_CurrentMenu.MenuItems.Count - 1}");
                }
            }
            while (isInputInvalid);

            return int.Parse(userInput);
        }

        private bool validateUserInput(string i_UserInput)
        {
            bool isInputNumber = int.TryParse(i_UserInput, out int inputNumber);

            return !(isInputNumber && inputNumber >= 0 && inputNumber <= (m_CurrentMenu.MenuItems.Count - 1));
        }
    }
}