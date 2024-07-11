using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps_Learning.Class
{
    internal class _TokenValidateControl
    {
        private _ScreenToken _ScreenToken;
        private _DeleteFieldsControl _deleteFieldsControl;
        public _TokenValidateControl(_ScreenToken screenToken, _DeleteFieldsControl deleteFieldsControl,Dictionary<string, Control> dictionaryControls) 
        {
            _ScreenToken = screenToken;
            _deleteFieldsControl = deleteFieldsControl;
            this._dictionaryControls = dictionaryControls;
        }

        private Dictionary<string, Control> _dictionaryControls;
        private string _txtBoxs;
        private void dictionaryControlsDefinition()
        {
            if (_ScreenToken != null && _ScreenToken._dictionaryControls != null)
            {
                var _controls = _ScreenToken._dictionaryControls;
                if (_controls.ContainsKey("txtToken1") &&
                    _controls.ContainsKey("txtToken2") &&
                    _controls.ContainsKey("txtToken3") &&
                    _controls.ContainsKey("txtToken4"))
                {
                    Guna2TextBox txtToken1 = _controls["txtToken1"] as Guna2TextBox;
                    Guna2TextBox txtToken2 = _controls["txtToken2"] as Guna2TextBox;
                    Guna2TextBox txtToken3 = _controls["txtToken3"] as Guna2TextBox;
                    Guna2TextBox txtToken4 = _controls["txtToken4"] as Guna2TextBox;

                    _txtBoxs = txtToken1.Text + txtToken2.Text + txtToken3.Text + txtToken4.Text;
                }

            }
            else
            {
                MessageBox.Show("Debug: _ScreenToken._dictionaryControls not initialized");
            }
        }
        public void tokenValidate(object sender, EventArgs e) 
        {
            dictionaryControlsDefinition();
            if (!string.IsNullOrEmpty(_txtBoxs)) 
            {
                try
                {
                    string code = "select id from Users where id=@id";
                    using (SqlConnection connectionSQL = _DataBaseConnectionControl.GetConnection())
                    {
                        connectionSQL.Open();
                        SqlCommand command = new SqlCommand(code, connectionSQL);
                        command.Parameters.AddWithValue("@id", _txtBoxs);
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("Debug: Token found");
                        }
                        else
                        {
                            MessageBox.Show("Debug: Token not found");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else 
            {
                MessageBox.Show("Debug: Please fill all fields");
            }
            _deleteFieldsControl.deleteTokenControls(sender,e);
        }
    }
}
