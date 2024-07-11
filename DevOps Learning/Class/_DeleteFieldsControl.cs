using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps_Learning.Class
{
    internal class _DeleteFieldsControl
    {
        private _ScreenLogin _screenLogin;
        public _DeleteFieldsControl(_ScreenLogin screenLogin, Dictionary<string, Control> dictionaryControls) 
        {
            _screenLogin = screenLogin;
            this._dictionaryControls = dictionaryControls;
        }
        private Dictionary<string, Control> _dictionaryControls;
        private Guna2TextBox _txtUsername;
        private Guna2TextBox _txtPassword;
        private void dictionaryControlsDefinition() 
        {
            if(_screenLogin != null && _screenLogin.dictionaryControls != null) 
            {
                
                var txtBoxs = _screenLogin.dictionaryControls;
                if (txtBoxs.ContainsKey("txtUsername") &&
                    txtBoxs.ContainsKey("txtPassword"))
                {
                    _txtUsername = txtBoxs["txtUsername"] as Guna2TextBox;
                    _txtPassword = txtBoxs["txtPassword"] as Guna2TextBox;

                }
                else 
                {
                    MessageBox.Show("Debug: _screenLogin.dictionaryControls is null");
                }
            }
            else 
            {
                MessageBox.Show("Debug: dictionaryControlsDefinition() not initialize");
            }
            
        } 
        public void deleteFields(object sender, EventArgs e) 
        {
            dictionaryControlsDefinition();
            if (_txtUsername != null) _txtUsername.Clear();
            if (_txtPassword != null) _txtPassword.Clear();
        }
    }
}
