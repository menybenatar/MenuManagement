using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceTestMenu
    {
        public static void RunInterfaceMenu()
        {
            MainMenu mainMenu = new MainMenu();
            SubMenu firstSub = new SubMenu("Version and Uppercase");
            ActionItem versionAction = new ActionItem("Show Version", eActionType.Event);
            ActionItem countUppercaseAction = new ActionItem("Count Uppercase", eActionType.Event);
            versionAction.SelecetedItemObserver = new VersionPresentor();
            countUppercaseAction.SelecetedItemObserver = new UppercaseCounter();
            firstSub.AddMenuItem(versionAction);
            firstSub.AddMenuItem(countUppercaseAction);
            mainMenu.MainMenuItems.AddMenuItem(firstSub);

            SubMenu secondSub = new SubMenu("Show Date/Time");
            ActionItem dateAction = new ActionItem("Show Date", eActionType.Event);
            dateAction.SelecetedItemObserver = new DatePresentor();
            secondSub.AddMenuItem(dateAction);
            ActionItem timeAction = new ActionItem("Show Time", eActionType.Event);
            timeAction.SelecetedItemObserver = new TimePresentor();
            secondSub.AddMenuItem(timeAction);
            mainMenu.MainMenuItems.AddMenuItem(secondSub);

            mainMenu.Show();
        }
    }
}
