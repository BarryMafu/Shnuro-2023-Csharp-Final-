namespace Shnuro
{
    public partial class Form1 : Form
    {
        /* This is used to keep the singleton instance safe in thread */
        private static readonly object objSingletonLocker = new object();

        private static Form1? instance = null;

        private ControlEnum nControlNo = ControlEnum.StartInterface;

        public enum ControlEnum
        {
            StartInterface = 0,
            Settings,
            LoginInterface,
            MusicPackSelect,
            MusicSelect,
            GameInterface,
            SettlementInterface,
            EditSelect,
            EditPreInformation,
            EditInterface,
        }
        private Form1()
        {
            InitializeComponent();
        }
        public static Form1 Instance
        {
            get
            {
                lock (objSingletonLocker)
                {
                    if (instance == null)
                    {
                        instance = new Form1();
                    }
                }
                return instance;
            }
        }

        public void SwitchTo(ControlEnum controlno)
        {

        }
    }
}