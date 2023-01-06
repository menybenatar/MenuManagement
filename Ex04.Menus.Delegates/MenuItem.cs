using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuItem
    {
        protected string m_Title;
        protected int m_OptionNumber = 0;

        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }

        public int OptionNumber
        {
            get { return m_OptionNumber; }
            set { m_OptionNumber = value; }
        }

        public MenuItem(string i_Title)
        {
            m_Title = i_Title;
        }
    }
}
