using System;

namespace Ex04.Menus.Delegates
{
    public class ActionItem : MenuItem
    {
        public event Action Selected;

        private eActionType m_ActionType;

        public eActionType ActionType
        {
            get { return m_ActionType; }
        }

        public ActionItem(string i_Title, eActionType i_TypeOfAction)
            : base(i_Title)
        {
            m_ActionType = i_TypeOfAction;
        }

        public void DoWhenSelected()
        {
            onSelect();
        }

        private void onSelect()
        {
            Selected?.Invoke();
        }
    }
}