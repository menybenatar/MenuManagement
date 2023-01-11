namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private eActionType m_ActionType;
        private ISelecetedItemObserver m_SelecetedItemObserver;

        public eActionType ActionType
        {
            get { return m_ActionType; }
        }

        public ISelecetedItemObserver SelecetedItemObserver
        {
            get { return m_SelecetedItemObserver; }
            set { m_SelecetedItemObserver = value; }
        }

        public ActionItem(string i_Title, eActionType i_TypeOfAction)
            : base(i_Title)
        {
            m_ActionType = i_TypeOfAction;
        }

        public void DoWhenSelected()
        {
            OnSelect();
        }

        private void OnSelect()
        {
            m_SelecetedItemObserver?.OnSelected();
        }
    }
}
