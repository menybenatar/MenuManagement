using System;
using System.Linq;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegateTestMenu
    {
        public static void RunDelegateMenu()
        {
            MainMenu mainMenu = new MainMenu();
            SubMenu firstSub = new SubMenu("Version and Uppercase");
            ActionItem versionAction = new ActionItem("Show Version", eActionType.Event);
            versionAction.Selected += versionAction_Selected;
            firstSub.AddMenuItem(versionAction);
            ActionItem countUppercaseAction = new ActionItem("Count Uppercase", eActionType.Event);
            countUppercaseAction.Selected += countUppercaseAction_Selected;
            firstSub.AddMenuItem(countUppercaseAction);
            mainMenu.MainMenuItems.AddMenuItem(firstSub);

            SubMenu secondSub = new SubMenu("Show Date/Time");
            ActionItem dateAction = new ActionItem("Show Date", eActionType.Event);
            dateAction.Selected += dateAction_Selected;
            secondSub.AddMenuItem(dateAction);
            ActionItem timeAction = new ActionItem("Show Time", eActionType.Event);
            timeAction.Selected += timeAction_Selected;
            secondSub.AddMenuItem(timeAction);
            mainMenu.MainMenuItems.AddMenuItem(secondSub);

            mainMenu.Show();
        }

        private static void countUppercaseAction_Selected()
        {
            int uppercaseCounter = 0;
            Console.WriteLine($"Please Write A Sentence.{Environment.NewLine}The Program Will Count Uppercase Letters In Your Sentence.");
            string userSentence = Console.ReadLine();
            uppercaseCounter = userSentence.ToCharArray().Count(c => char.IsUpper(c));
            Console.WriteLine($"The Number Of Uppercase In Your Sentence Is: {uppercaseCounter}.");
        }

        private static void versionAction_Selected()
        {
            Console.WriteLine("Version: 23.1.4.8859");
        }

        private static void timeAction_Selected()
        {
            string timeMessage = string.Format("The Current Time Is:{0}{1}{0}", Environment.NewLine, DateTime.Now.ToString("T"));
            Console.WriteLine(timeMessage);
        }

        private static void dateAction_Selected()
        {
            string dateMessage = string.Format("The Current Date Is:{0}{1}{0}", Environment.NewLine, DateTime.Now.ToString("dd/MM/yyyy"));
            Console.WriteLine(dateMessage);
        }
    }
}
