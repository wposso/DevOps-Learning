using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DevOps_Learning.Class
{
    internal class _LoginMethodControl
    {
        private _ScreenLogin _screenLogin;
        private _DeleteFieldsControl _deleteFieldsControl;
        public _LoginMethodControl(_ScreenLogin screenLogin, _DeleteFieldsControl deleteFieldsControl, Dictionary<string, Control> dictionaryControls) 
        {
            _screenLogin = screenLogin;
            _deleteFieldsControl = deleteFieldsControl;
            this._dictionaryControls = dictionaryControls;
            
        }
        private Dictionary<string, Control> _dictionaryControls;
        private string txtUsername;
        private string txtPassword;
        private void dictionaryControlsDefinition() 
        {
            if (_screenLogin != null && _screenLogin.dictionaryControls != null) 
            {
                var _txtUsername = _screenLogin.dictionaryControls;
                var _txtPassword = _screenLogin.dictionaryControls;

                if(_txtUsername.ContainsKey("txtUsername") &&
                    _txtPassword.ContainsKey("txtPassword")) 
                {
                    txtUsername = _txtUsername["txtUsername"].Text;
                    txtPassword = _txtPassword["txtPassword"].Text;
                }
            }
            else 
            {
                MessageBox.Show("Debug: " + _screenLogin.dictionaryControls);
            }
        }

        public void _loginMethod(object sender, EventArgs e)
        {
            dictionaryControlsDefinition();
            try 
            {
                string code = "select Username,Password from Users where Username=@username and Password=@password";
                using (SqlConnection connectionSQL = _DataBaseConnectionControl.GetConnection()) 
                {
                    connectionSQL.Open();
                    SqlCommand command = new SqlCommand(code,connectionSQL);
                    command.Parameters.AddWithValue("username",txtUsername);
                    command.Parameters.AddWithValue("password",txtPassword);
                    SqlDataReader reader = command.ExecuteReader();

                    if(reader.Read()) 
                    {
                        _deleteFieldsControl.deleteFields(sender, e);
                        MessageBox.Show("Message: user found success");
                    }
                    else 
                    {
                        _deleteFieldsControl.deleteFields(sender, e);
                        MessageBox.Show("Message: user not found");
                    }
                }
            }
            catch(Exception ex) 
            {
                _deleteFieldsControl.deleteFields(sender, e);
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
