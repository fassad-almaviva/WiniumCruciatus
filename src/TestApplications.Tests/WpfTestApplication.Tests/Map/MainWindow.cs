namespace WpfTestApplication.Tests.Map
{
    #region using

    using Winium.Cruciatus.Core;
    using Winium.Cruciatus.Elements;
    using Winium.Cruciatus.Extensions;

    #endregion

    public class MainWindow : CruciatusElement
    {
        #region Constructors and Destructors

        public MainWindow(CruciatusElement parent, By getStrategy)
            : base(parent, getStrategy)
        {
        }

        #endregion

        #region Public Properties

        public OpenFileDialog OpenFileDialog
        {
            get
            {
                return new OpenFileDialog(this, By.Name("Открытие").OrName("Open"));
            }
        }

        public Menu RibbonMenu
        {
            get
            {
                return new Menu(this, By.Uid("RibbonMenu"));
            }
        }

        public FirstRibbonTab RibbonTabItem1
        {
            get
            {
                return new FirstRibbonTab(this, By.Uid("RibbonTabItem1"));
            }
        }

        public SecondRibbonTab RibbonTabItem2
        {
            get
            {
                return new SecondRibbonTab(this, By.Uid("RibbonTabItem2"));
            }
        }

        public SaveFileDialog SaveFileDialog
        {
            get
            {
                return new SaveFileDialog(this, By.Name("Сохранение").OrName("Save As"));
            }
        }

        public Menu SetTextButtonContextMenu
        {
            get
            {
                return new Menu(this, By.Uid("SetTextButtonContextMenu"));
            }
        }

        public Menu SimpleMenu
        {
            get
            {
                return this.FindElementByUid("SimpleMenu").ToMenu();
            }
        }

        public FirstTab TabItem1
        {
            get
            {
                return new FirstTab(this, By.Uid("TabItem1"));
            }
        }

        public SecondTab TabItem2
        {
            get
            {
                return new SecondTab(this, By.Uid("TabItem2"));
            }
        }

        public ThirdTab TabItem3
        {
            get
            {
                return new ThirdTab(this, By.Uid("TabItem3"));
            }
        }

        #endregion
    }
}
