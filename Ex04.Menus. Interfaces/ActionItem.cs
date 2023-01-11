namespace Ex04.Menus.Interfaces
{
    public class ActionItem : MenuItem
    {
        private readonly eActionType r_ActionType;
        private ISelecetedItemObserver m_SelecetedItemObserver;

        public eActionType ActionType
        {
            get { return r_ActionType; }
        }

        public ISelecetedItemObserver SelecetedItemObserver
        {
            set { m_SelecetedItemObserver = value; }
        }

        public ActionItem(string i_Title, eActionType i_TypeOfAction)
            : base(i_Title)
        {
            r_ActionType = i_TypeOfAction;
        }

        public void DoWhenSelected()
        {
            onSelect();
        }

        private void onSelect()
        {
            m_SelecetedItemObserver?.OnSelected();
        }
    }
}
