using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps_Learning.Class
{
    internal class _RegisterControl
    {
        private _ScreenRegister _screenRegister;
        private _DeleteFieldsControl _deleteFieldsControl;
        public _RegisterControl
            (
            _ScreenRegister screenregister,
            _DeleteFieldsControl deleteFieldsControl,
            Dictionary<string, Control> dictionaryRegisterControls
            
            ) 
        { 
            _screenRegister = screenregister;
            this._dictionaryRegisterControls = dictionaryRegisterControls;
            _deleteFieldsControl = deleteFieldsControl;
        }

        private Dictionary<string, Control> _dictionaryRegisterControls;
        private Guna2TextBox txtSRusername;
        private Guna2TextBox txtSRfirstname;
        private Guna2TextBox txtSRlastname;
        private Guna2TextBox txtSRdocumment;
        private Guna2TextBox txtSRpassword;
        private Guna2TextBox txtSRconfpassword;
        
        private void dictionaryDefinition() 
        {
            if(_screenRegister != null && _screenRegister._dictionaryControls != null) 
            {
                var controls = _screenRegister._dictionaryControls;

                if(controls.ContainsKey("txtSRusername") &&
                    controls.ContainsKey("txtSRfirstname") &&
                    controls.ContainsKey("txtSRlastname") &&
                    controls.ContainsKey("txtSRdocumment") &&
                    controls.ContainsKey("txtSRpassword") &&
                    controls.ContainsKey("txtSRconfpassword"))
                {
                    txtSRusername = controls["txtSRusername"] as Guna2TextBox;
                    txtSRfirstname = controls["txtSRfirstname"] as Guna2TextBox;
                    txtSRlastname = controls["txtSRlastname"] as Guna2TextBox;
                    txtSRdocumment = controls["txtSRdocumment"] as Guna2TextBox;
                    txtSRpassword = controls["txtSRpassword"] as Guna2TextBox;
                    txtSRconfpassword = controls["txtSRconfpassword"] as Guna2TextBox;
                    
                }
                else 
                {
                    MessageBox.Show("Debug: _screenRegister._dictionaryControls is null");
                }
            }
            else 
            {
                MessageBox.Show("Debug: dictionaryDefinition() not initialized");
            }
        }
        public void userRegister(object sender, EventArgs e) 
        {
            dictionaryDefinition();

            try
            {
                string code = "insert into Users(firstname, lastname, username, documment, password) values(@firstname,@lastname,@username,@documment,@password)";
                using (SqlConnection connection = _DataBaseConnectionControl.GetConnection())
                {
                    connection.Open();
                    try
                    {
                        SqlCommand command = new SqlCommand(code, connection);
                        command.Parameters.AddWithValue("@firstname", txtSRfirstname.Text);
                        command.Parameters.AddWithValue("@lastname", txtSRlastname.Text);
                        command.Parameters.AddWithValue("@username", txtSRusername.Text);
                        command.Parameters.AddWithValue("@documment", txtSRdocumment.Text);
                        command.Parameters.AddWithValue("@password", txtSRpassword.Text);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Debug: User registered success");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Debug: " + ex.Message);
                    }
                    finally 
                    {
                        connection.Close();
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            if (_deleteFieldsControl != null) 
            {
                _deleteFieldsControl.deleteControlsSR(sender, e);
            }
        }
    }
}
