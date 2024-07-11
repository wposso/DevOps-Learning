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
    public partial class _ScreenToken : Form
    {
        private _TokenValidateControl _tokenValidateControl;
        private _DeleteFieldsControl _deleteFieldsControl;
        public _ScreenToken()
        {
            InitializeComponent();
            dictionaryControls();
            InitializeClass();

        }
        private void InitializeClass() 
        {
            _tokenValidateControl = new _TokenValidateControl(this,_deleteFieldsControl,_dictionaryControls);
        }

        public Dictionary<string, Control> _dictionaryControls;
        private void dictionaryControls() 
        {
            _dictionaryControls = new Dictionary<string, Control> 
            {
                {"txtToken1",txtToken1 },
                {"txtToken2",txtToken2 },
                {"txtToken3",txtToken3 },
                {"txtToken4",txtToken4 }
            };
        }
    }
}
