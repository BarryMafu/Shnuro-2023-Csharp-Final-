using System.CodeDom;

namespace Shnuro
{
    public partial class Form1 : Form
    {
        /* This is used to keep the singleton instance safe in thread */
        private static readonly object objSingletonLocker = new object();

        private static Form1? instance = null;

        private ControlEnum nControlNo = ControlEnum.Empty;

        public enum ControlEnum
        {
            Empty = -1,
            StartInterface,
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
            SwitchTo(0);
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
            if (controlno == nControlNo)
            {
                return;
            }
            else
            {
                nControlNo = controlno;
                /* Switch between differt cases */
                #region ControlNoSwitch
                switch (controlno)
                {
                    case ControlEnum.StartInterface:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new UserControls.StartInterface());
                        break;
                    case ControlEnum.Settings:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new UserControls.Settings());
                        break;
                    case ControlEnum.LoginInterface:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new UserControls.LoginInterface());
                        break;
                    case ControlEnum.MusicPackSelect:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new UserControls.MusicPackSelect());
                        break;
                    case ControlEnum.MusicSelect:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new UserControls.MusicSelect());
                        break;
                    case ControlEnum.GameInterface:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new UserControls.GameInterface());
                        break;
                    case ControlEnum.SettlementInterface:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new UserControls.SettlementInterface());
                        break;
                    case ControlEnum.EditSelect:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new UserControls.EditSelect());
                        break;
                    case ControlEnum.EditPreInformation:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new UserControls.EditPreInformation());
                        break;
                    case ControlEnum.EditInterface:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new UserControls.EditInterface());
                        break;
                    default:
                        pnlMainPanel.Controls.Clear();
                        break;
                }
                #endregion ControlNoSwitch
            }
        }
    }
}