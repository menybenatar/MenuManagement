using System;
using System.Linq;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegateTestMenu
    {
        private MainMenu m_MainMenu;

        public void RunDelegateMenu()
        {
            menuTestInit();
            m_MainMenu.Show();
        }

        private void menuTestInit()
        {
            m_MainMenu = new MainMenu("Delegates Main Menu");
            SubMenu firstSub = new SubMenu("Version and Uppercase");
            SubMenu secondSub = new SubMenu("Show Date/Time");
            ActionItem versionAction = new ActionItem("Show Version", eActionType.Event);
            ActionItem countUppercaseAction = new ActionItem("Count Uppercase", eActionType.Event);
            firstSub.AddMenuItem(versionAction);
            firstSub.AddMenuItem(countUppercaseAction);
            versionAction.Selected += versionAction_Selected;
            countUppercaseAction.Selected += countUppercaseAction_Selected;
            ActionItem dateAction = new ActionItem("Show Date", eActionType.Event);
            ActionItem timeAction = new ActionItem("Show Time", eActionType.Event);
            secondSub.AddMenuItem(dateAction);
            secondSub.AddMenuItem(timeAction);
            dateAction.Selected += dateAction_Selected;
            timeAction.Selected += timeAction_Selected;
            m_MainMenu.MainMenuItems.AddMenuItem(firstSub);
            m_MainMenu.MainMenuItems.AddMenuItem(secondSub);
        }

        private void countUppercaseAction_Selected()
        {
            int uppercaseCounter = 0;
            string upperMessage = $"Please Write A Sentence.{Environment.NewLine}The Program Will Count Uppercase Letters In Your Sentence.";
            Console.WriteLine(upperMessage);
            string userSentence = Console.ReadLine();
            uppercaseCounter = userSentence.ToCharArray().Count(c => char.IsUpper(c));
            Console.WriteLine($"The Number Of Uppercase In Your Sentence Is: {uppercaseCounter}.");
        }

        private void versionAction_Selected()
        {
            Console.WriteLine("Version: 23.1.4.8859");
        }

        private void timeAction_Selected()
        {
            string timeMessage = $"The Current Time Is:{Environment.NewLine}{DateTime.Now.ToString("T")}{Environment.NewLine}";
            Console.WriteLine(timeMessage);
        }

        private void dateAction_Selected()
        {
            string dateMessage = $"The Current Date Is:{Environment.NewLine}{DateTime.Now.ToString("dd/MM/yyyy")}{Environment.NewLine}";
            Console.WriteLine(dateMessage);
        }
    }
}
