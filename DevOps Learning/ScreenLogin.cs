using DevOps_Learning.Class;
using Guna.UI2.WinForms;

namespace DevOps_Learning
{
    public partial class ScreenLogin : Form
    {
        private _VisiblePasswordControl _visiblePasswordControl;
        public ScreenLogin()
        {
            InitializeComponent();
            Dictionarys();
            InitializeClass();
            Events();
        }
        private void Events()
        {
            btnLogin.Click += new EventHandler(_visiblePasswordControl.showPassword);
        }
        private void Dictionarys() 
        {
            controlsDictionary();
        }
        private void InitializeClass() 
        {
            _visiblePasswordControl = new _VisiblePasswordControl(this,dictionaryControls);
        }

        public Dictionary<string, Control> dictionaryControls;
        public void controlsDictionary() 
        {
            dictionaryControls = new Dictionary<string, Control> 
            {
                {"txtPassword",txtPassword },
                {"txtUsername",txtUsername },
                {"btnExit",btnExit},
                {"btnLogin",btnLogin},
                {"btnToken",btnToken},
                {"btnShowPassword",btnShowPassword }
            };
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
