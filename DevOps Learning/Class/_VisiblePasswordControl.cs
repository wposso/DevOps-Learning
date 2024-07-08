using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps_Learning.Class
{
    internal class _VisiblePasswordControl
    {
        private ScreenLogin _screenLogin;
        
        public _VisiblePasswordControl(ScreenLogin screenlogin, Dictionary<string, Control> dictionaryControls) 
        {
            _screenLogin = screenlogin;
            this.dictionaryControls = dictionaryControls;
        }

        private Dictionary<string, Control> dictionaryControls;
        private string _values;
        private void dictionaryControlsDefinition() 
        { 
            if(_screenLogin != null && _screenLogin.dictionaryControls != null) 
            {
                var controls = _screenLogin.dictionaryControls;
                if (controls.ContainsKey("btnShowPassword")) 
                {
                    _values = controls["btnShowPassword"].Text;
                }
            }
            else 
            {
                MessageBox.Show("Debug: _screenLogin.dictionaryControls not initialized");
            }
        }
        public void showPassword(object sender, EventArgs e) 
        {
            dictionaryControlsDefinition();
            
        }
    }
}
