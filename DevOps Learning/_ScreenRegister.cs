using DevOps_Learning.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevOps_Learning
{
    public partial class _ScreenRegister : Form
    {
        private _RegisterControl _registerControl;
        private _DeleteFieldsControl _deleteFieldsControl;
        private _ScreenToken _screenToken;

        public _ScreenRegister()
        {
            InitializeComponent();
            InitializeClass();
            dictionaryDefinition();
            InitializeEvents();
        }
        private void InitializeClass()
        {
            _registerControl = new _RegisterControl
                (
                this,
                _deleteFieldsControl,
                _dictionaryControls
                
                );
            
        }
        private void InitializeEvents() 
        {
            txtSRdocumment.KeyPress += new KeyPressEventHandler(txtDocummentInt_KeyPress);
        }
        public Dictionary<string, Control> _dictionaryControls;
        private void dictionaryDefinition()
        {
            _dictionaryControls = new Dictionary<string, Control>
            {
                {"txtSRfirstname",txtSRfirstname },
                {"txtSRlastname",txtSRlastname },
                {"txtSRusername",txtSRusername },
                {"txtSRdocumment",txtSRdocumment },
                {"txtSRpassword",txtSRpassword },
                {"txtSRconfpassword", txtSRconfpassword}
            };
        }

        private void btnSRlogin_Click(object sender, EventArgs e)
        {
            _registerControl.userRegister(sender,e);
        }
        private void txtDocummentInt_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }
    }
}
