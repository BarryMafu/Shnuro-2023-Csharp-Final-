using System.CodeDom;
using System.Data.SQLite;

namespace Shnuro
{
    public partial class Form1 : Form
    {
        /* This is used to keep the singleton instance safe in thread */
        private static readonly object objSingletonLocker = new object();

        private static Form1? instance = null;

        private ControlEnum nControlNo = ControlEnum.Empty;

        public SQLiteConnection connection;
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
            this.AllowTransparency = true;
            ConnectToDatabase();
            InsertIntoDatabase_testonly();
            SwitchTo(0);
        }
        private void InsertIntoDatabase_testonly()
        {
            string[] field = {"PackIndex","PackName","Description","SongsCount" };
            string[] values = new string[4];
            for(int i = 0; i < 100; i++)
            {
                values[0] = (i + 2).ToString();
                values[1] = "Pack" + i.ToString();
                values[2] = "Description" + i.ToString()+" : blahblahblah";
                values[3] = (new Random()).Next(0,100).ToString();
                string sql = Helpers.SQLHelper.MakeInsertSql(field, values, "SongPackGuide");
                (new SQLiteCommand(sql, connection)).ExecuteNonQuery();
            }
        }
        private void ConnectToDatabase()
        {
            string file = @"..\..\..\DataBase\ShnuroDatabase.sqlite";
            connection = new SQLiteConnection(
                "Data Source=" + file + ";Version=3;");
            connection.Open();
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
                        pnlMainPanel.Controls.Add(new ShowcaseControls.StartInterface());
                        break;
                    case ControlEnum.Settings:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new ShowcaseControls.Settings());
                        break;
                    case ControlEnum.LoginInterface:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new ShowcaseControls.LoginInterface());
                        break;
                    case ControlEnum.MusicPackSelect:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new ShowcaseControls.MusicPackSelect());
                        break;
                    case ControlEnum.MusicSelect:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new ShowcaseControls.MusicSelect());
                        break;
                    case ControlEnum.GameInterface:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new ShowcaseControls.GameInterface());
                        break;
                    case ControlEnum.SettlementInterface:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new ShowcaseControls.SettlementInterface());
                        break;
                    case ControlEnum.EditSelect:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new ShowcaseControls.EditSelect());
                        break;
                    case ControlEnum.EditPreInformation:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new ShowcaseControls.EditPreInformation());
                        break;
                    case ControlEnum.EditInterface:
                        pnlMainPanel.Controls.Clear();
                        pnlMainPanel.Controls.Add(new ShowcaseControls.EditInterface());
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