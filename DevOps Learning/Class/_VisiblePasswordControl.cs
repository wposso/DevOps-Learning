using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps_Learning.Class
{
    internal class _VisiblePasswordControl
    {
        private _ScreenLogin _screenLogin;
        private _ScreenRegister _screenRegister;

        public _VisiblePasswordControl(_ScreenLogin screenlogin, Dictionary<string, Control> dictionaryControls, _ScreenRegister screenRegister)
        {
            _screenLogin = screenlogin;
            this.dictionaryControls = dictionaryControls;
            dictionaryControlsDefinition();
            _screenRegister = screenRegister;
        }

        private Dictionary<string, Control> dictionaryControls;
        private Control _btnShowPassword;
        private Guna2TextBox _txtPassword;
        private void dictionaryControlsDefinition()
        {
            if (_screenLogin != null && _screenLogin.dictionaryControls != null)
            {
                var controls = _screenLogin.dictionaryControls;
                if (controls.ContainsKey("btnShowPassword") &&
                    controls.ContainsKey("txtPassword"))
                {
                    _btnShowPassword = controls["btnShowPassword"];
                    _txtPassword = controls["txtPassword"] as Guna2TextBox;
                }
            }
            else
            {
                MessageBox.Show("Debug: _screenLogin.dictionaryControls not initialized");
            }
        }
        public void showPassword(object sender, EventArgs e)
        {
            if (dictionaryControls != null) 
            {
                _btnShowPassword.Visible = true;
            }
            
        }
        public void hidePassword(object sender, EventArgs e)
        {
            if (dictionaryControls != null) 
            {
                _btnShowPassword.Visible = false;
            }
            
        }
        public void mouseEnter(object sender, EventArgs e) 
        {
            if (dictionaryControls != null) 
            {
                _txtPassword.PasswordChar = '\0';
            }
            
        }
        public void mouseLeave(object sender, EventArgs e) 
        {
            if (dictionaryControls != null) 
            {
                _txtPassword.PasswordChar = '•';
            }
        }
    }
}
