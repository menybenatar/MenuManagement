using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceTestMenu
    {
        private MainMenu m_MainMenu;

        public void RunInterfaceMenu()
        {
            menuTestInit();
            m_MainMenu.Show();
        }

        private void menuTestInit()
        {
            m_MainMenu = new MainMenu("Interfaces Main Menu");
            SubMenu firstSub = new SubMenu("Version and Uppercase");
            SubMenu secondSub = new SubMenu("Show Date/Time");
            ActionItem versionAction = new ActionItem("Show Version", eActionType.Event);
            ActionItem countUppercaseAction = new ActionItem("Count Uppercase", eActionType.Event);
            versionAction.SelecetedItemObserver = new VersionPresentor();
            countUppercaseAction.SelecetedItemObserver = new UppercaseCounter();
            firstSub.AddMenuItem(versionAction);
            firstSub.AddMenuItem(countUppercaseAction);
            ActionItem dateAction = new ActionItem("Show Date", eActionType.Event);
            ActionItem timeAction = new ActionItem("Show Time", eActionType.Event);
            dateAction.SelecetedItemObserver = new DatePresentor();
            timeAction.SelecetedItemObserver = new TimePresentor();
            secondSub.AddMenuItem(dateAction);
            secondSub.AddMenuItem(timeAction);
            m_MainMenu.MainMenuItems.AddMenuItem(firstSub);
            m_MainMenu.MainMenuItems.AddMenuItem(secondSub);
        }
    }
}
