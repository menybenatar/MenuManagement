using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        private string m_Title;
        private int m_OptionIndex = 0;
        private int m_CurrentMenuLevel = 0;

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public int OptionIndex
        {
            get { return m_OptionIndex; }
            set { m_OptionIndex = value; }
        }

        public int CurrentMenuLevel
        {
            get { return m_CurrentMenuLevel; }
            set { m_CurrentMenuLevel = value; }
        }

        public MenuItem(string i_Title)
        {
            m_Title = i_Title;
        }
    }
}
