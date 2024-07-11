using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

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
        private Guna2TextBox txtUsername;
        private Guna2TextBox txtPassword;
        private void dictionaryControlsDefinition() 
        {
            if (_screenLogin != null && _screenLogin.dictionaryControls != null) 
            {
                var _txtUsername = _screenLogin.dictionaryControls;
                var _txtPassword = _screenLogin.dictionaryControls;

                if(_txtUsername.ContainsKey("txtUsername") &&
                    _txtPassword.ContainsKey("txtPassword")) 
                {
                    txtUsername = _txtUsername["txtUsername"] as Guna2TextBox;
                    txtPassword = _txtPassword["txtPassword"] as Guna2TextBox;
                }
                else 
                {
                    MessageBox.Show("Debug: dictionaryControlsDefinition() no initialize");
                }
            }
            else 
            {
                MessageBox.Show("Debug: _screenLogin.dictionaryControls is null");
            }
        }

        public void _loginMethod(object sender, EventArgs e)
        {
            dictionaryControlsDefinition();

            if(string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtUsername.Text)) 
            {
                MessageBox.Show("Debug: Please fill all fields");
            }
            else 
            {
                try
                {
                    string code = "select Username,Password from Users where Username=@username and Password=@password";
                    using (SqlConnection connectionSQL = _DataBaseConnectionControl.GetConnection())
                    {
                        connectionSQL.Open();
                        SqlCommand command = new SqlCommand(code, connectionSQL);
                        command.Parameters.AddWithValue("username", txtUsername.Text);
                        command.Parameters.AddWithValue("password", txtPassword.Text);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Message: user found success");
                        }
                        else
                        {
                            MessageBox.Show("Message: user not found");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            if (_deleteFieldsControl != null)
            {
                _deleteFieldsControl.deleteFields(sender, e);
            }
            else
            {
                MessageBox.Show("Error: _deleteFieldsControl es null");
            }
        }
    }
}
