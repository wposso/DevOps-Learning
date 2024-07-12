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
        private _ScreenRegister _screenRegister;
        private _ScreenToken _screenToken;
        public _DeleteFieldsControl
            (
            _ScreenLogin screenLogin,
            Dictionary<string, Control> dictionaryControlsLogin,
            _ScreenRegister screenRegister,
            Dictionary<string, Control> dictionaryTokenControls,
            _ScreenToken screenToken,
            Dictionary<string, Control> dictionaryRegisterControls
            ) 
        {
            _screenLogin = screenLogin;
            this._dictionaryLoginControls = dictionaryControlsLogin;
            _screenRegister = screenRegister;
            this._dictionaryRegisterControls = dictionaryRegisterControls;
            _screenToken = screenToken;
            this._dictionaryTokenControls = dictionaryTokenControls;
        }
        private Dictionary<string, Control> _dictionaryLoginControls;
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

        private Dictionary<string, Control> _dictionaryRegisterControls;
        private Guna2TextBox txtSRfirstname;
        private Guna2TextBox txtSRlastname;
        private Guna2TextBox txtSRusername;
        private Guna2TextBox txtSRdocumment;
        private Guna2TextBox txtSRpassword;
        private Guna2TextBox txtSRconfpassword;
        private void dictionaryScreenregisterDefinition() 
        {
            if(_screenRegister != null && _screenRegister._dictionaryControls != null) 
            {
                var srcontrols = _screenRegister._dictionaryControls;
                if (srcontrols.ContainsKey("txtSRfirstname") &&
                    srcontrols.ContainsKey("txtSRlastname") && 
                    srcontrols.ContainsKey("txtSRusername") && 
                    srcontrols.ContainsKey("txtSRdocumment") && 
                    srcontrols.ContainsKey("txtSRpassword") && 
                    srcontrols.ContainsKey("txtSRconfpassword")) 
                {
                    txtSRfirstname = srcontrols["txtSRfirstname"] as Guna2TextBox;
                    txtSRlastname = srcontrols["txtSRlastname"] as Guna2TextBox;
                    txtSRusername = srcontrols["txtSRusername"] as Guna2TextBox;
                    txtSRdocumment = srcontrols["txtSRdocumment"] as Guna2TextBox;
                    txtSRpassword = srcontrols["txtSRpassword"] as Guna2TextBox;
                    txtSRconfpassword = srcontrols["txtSRconfpassword"] as Guna2TextBox;

                }
                else 
                {
                    MessageBox.Show("Debug: _screenRegister._dictionaryControls is null");
                }
            }
            else 
            {
                MessageBox.Show("Debug: dictionaryScreenregisterDefinition() not initialized");
            }
        }
        public void deleteControlsSR(object sender, EventArgs e) 
        {
            dictionaryScreenregisterDefinition();

            if (txtSRconfpassword != null) txtSRconfpassword.Clear();
            if (txtSRdocumment != null) txtSRdocumment.Clear();
            if (txtSRfirstname != null) txtSRfirstname.Clear();
            if (txtSRlastname != null) txtSRlastname.Clear();
            if (txtSRpassword != null) txtSRpassword.Clear();
            if (txtSRusername != null) txtSRusername.Clear();
        }
    }
}
