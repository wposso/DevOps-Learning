using DevOps_Learning.Class;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace DevOps_Learning
{
    public partial class _ScreenLogin : Form
    {
        private _VisiblePasswordControl _visiblePasswordControl;
        private _LoginMethodControl _loginMethod;
        private _ScreenRegister _screenRegister;
        private _ScreenToken _ScreenToken;
        private _TokenValidateControl _tokenValidateControl;
        private _DeleteFieldsControl _DeleteFieldsControl;
        
        public _ScreenLogin()
        {
            InitializeComponent();
            //InitializeDrawnControls();
            Dictionarys();
            InitializeScreens();
            InitializeClass();
            Events();
        }
        private void InitializeScreens()
        {
            _screenRegister = new _ScreenRegister();
            _ScreenToken = new _ScreenToken();
        }

        private void InitializeClass()
        {
            _visiblePasswordControl = new _VisiblePasswordControl(this, dictionaryControls);
            _DeleteFieldsControl = new _DeleteFieldsControl(this, _ScreenToken,dictionaryControls,dictionaryControls);
            _loginMethod = new _LoginMethodControl(this, _DeleteFieldsControl, dictionaryControls);
            _tokenValidateControl = new _TokenValidateControl(_ScreenToken, _DeleteFieldsControl,dictionaryControls);

        }
        private void Dictionarys()
        {
            controlsDictionary();
        }
        private void Events()
        {
            btnShowPassword.MouseEnter += new EventHandler(_visiblePasswordControl.mouseEnter);
            btnShowPassword.MouseLeave += new EventHandler(_visiblePasswordControl.mouseLeave);
        }
        private void buttonsChange() 
        {
            if(_buttonLogout.Visible == true) 
            {
                btnLogin.Visible = false;
            }
            else 
            {
                _buttonLogout.Visible = false;
            }
        }

        private Label _signatureControl;
        private Button _tokenLoginControl;
        private Guna2Button _buttonLogout;
        private void InitializeDrawnControls() 
        {
            _signatureControl = _DrawingControl.labelSignature();
            this.Controls.Add( _signatureControl );
            pnlContainer.Controls.Add(_signatureControl);
            _signatureControl.BringToFront();
        }
        private void InitializeCallControl() 
        {
            //if (_tokenLoginControl == null) 
            //{
            //    _tokenLoginControl = _DrawingControl.buttonLogin();
            //    this.Controls.Add(_tokenLoginControl);
            //    pnlContainer.Controls.Add(_tokenLoginControl);
            //    _tokenLoginControl.BringToFront();
            //    _tokenLoginControl.Click += TokenLoginMethod;
            //}
            if (_buttonLogout == null) 
            {
                _buttonLogout = _DrawingControl.buttonLogout();
                this.Controls.Add(_buttonLogout);
                pnlContainer.Controls.Add( _buttonLogout );
                _buttonLogout.BringToFront();
                _buttonLogout.Click += TokenLoginMethod;
            }
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
            _loginMethod._loginMethod(sender, e);
        }
        private void TokenLoginMethod(object sender, EventArgs e) 
        {
            _tokenValidateControl.tokenValidate(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            _visiblePasswordControl.showPassword(sender, e);
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                _visiblePasswordControl.hidePassword(sender, e);
            }
        }
        private void Container(object _container)
        {
            pnlContainer.Controls.Clear();
            Form A = _container as Form;
            A.TopLevel = false;
            A.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(A);
            this.pnlContainer.Tag = A;
            A.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Container(_screenRegister);
        }

        private void tokenContainer(object _token)
        {
            pnlToken.Controls.Clear();
            Form A = _token as Form;
            A.TopLevel = false;
            A.Dock = DockStyle.Fill;
            this.pnlToken.Controls.Add(A);
            this.pnlToken.Tag = A;
            A.Show();
        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            tokenContainer(_ScreenToken);

            InitializeCallControl();
        }
    }
    
}
