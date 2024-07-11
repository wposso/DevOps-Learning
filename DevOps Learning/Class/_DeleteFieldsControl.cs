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
        private _ScreenToken _screenToken;
        public _DeleteFieldsControl(_ScreenLogin screenLogin, _ScreenToken screenToken, Dictionary<string, Control> dictionaryControls, Dictionary<string, Control> dictionaryTokenControls) 
        {
            _screenLogin = screenLogin;
            _screenToken = screenToken;
            this._dictionaryControls = dictionaryControls;
            this._dictionaryTokenControls = dictionaryTokenControls;
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

        private Dictionary<string, Control> _dictionaryTokenControls;
        private Guna2TextBox _txtToken1;
        private Guna2TextBox _txtToken2;
        private Guna2TextBox _txtToken3;
        private Guna2TextBox _txtToken4;
        private void dictionarTokenDefinition() 
        {
            if(_screenToken != null && _screenToken._dictionaryControls != null) 
            {
                var tokenControls = _screenToken._dictionaryControls;
                if(tokenControls.ContainsKey("txtToken1") &&
                    tokenControls.ContainsKey("txtToken2") &&
                    tokenControls.ContainsKey("txtToken3") &&
                    tokenControls.ContainsKey("txtToken4")) 
                {
                    _txtToken1 = tokenControls["txtToken1"] as Guna2TextBox;
                    _txtToken2 = tokenControls["txtToken2"] as Guna2TextBox;
                    _txtToken3 = tokenControls["txtToken3"] as Guna2TextBox;
                    _txtToken4 = tokenControls["txtToken4"] as Guna2TextBox;
                }
                else 
                {
                    MessageBox.Show("Debug: _screenToken._dictionaryControls is null");
                }
            }
            else 
            {
                MessageBox.Show("Debug: dictionarTokenDefinition() not initialize");
            }
        }
        public void deleteTokenControls(object sender, EventArgs e) 
        {
            dictionarTokenDefinition();

            if (_txtToken1 != null) _txtToken1.Clear();
            if(_txtToken2 != null) _txtToken2.Clear();
            if(_txtToken3 != null) _txtToken3.Clear();
            if(_txtToken4 != null) _txtToken4.Clear();
        }
    }
}
