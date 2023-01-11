namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private readonly string r_Title;
        private int m_OptionIndex = 0;

        public string Title
        {
            get { return r_Title; }
        }

        public int OptionIndex
        {
            get { return m_OptionIndex; }
            set { m_OptionIndex = value; }
        }

        public MenuItem(string i_Title)
        {
            r_Title = i_Title;
        }
    }
}
