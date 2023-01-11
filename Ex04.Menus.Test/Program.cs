namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            runDelegateMenu();
            runInterfaceMenu();
        }

        private static void runDelegateMenu()
        {
            DelegateTestMenu delegateMenu = new DelegateTestMenu();
            delegateMenu.RunDelegateMenu();
        }

        private static void runInterfaceMenu()
        {
            InterfaceTestMenu interfaceMenu = new InterfaceTestMenu();
            interfaceMenu.RunInterfaceMenu();
        }
    }
}
