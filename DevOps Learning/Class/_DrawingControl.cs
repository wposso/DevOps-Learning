using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;
using Guna.UI2.WinForms.Suite;


namespace DevOps_Learning.Class
{
    internal class _DrawingControl
    {
        public static Label labelSignature() 
        {
            Label lblSignature = new Label();
            lblSignature.Text = "@by DobleU";
            lblSignature.Location = new Point(1,730);
            lblSignature.Size = new Size(150,30);
            lblSignature.ForeColor = Color.Black;
            lblSignature.Font = new Font("Arial",7);
            lblSignature.Visible = true;
            lblSignature.BringToFront();
            return lblSignature;
        }
        public static Button buttonLogin()
        {
            Button btnLogin = new Button();
            btnLogin.Text = "Token Login";
            btnLogin.Location = new Point(10,50);
            btnLogin.Size = new Size(370,50);
            btnLogin.ForeColor = Color.White;
            btnLogin.BackColor = Color.Black;
            btnLogin.Font = new Font("Segoe UI",12);
            btnLogin.Visible = true;
            btnLogin.BringToFront();
            return btnLogin;
        }

        public static Guna2Button buttonLogout() 
        {
            Guna2Button buttonLogout = new Guna2Button();
            buttonLogout.Text = "Token Login";
            buttonLogout.Location = new Point(28, 645);
            buttonLogout.Size = new Size(363, 56);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.BackColor = SystemColors.Control;
            buttonLogout.Font = new Font("Segoe UI", 12);
            buttonLogout.BorderRadius = 25;
            buttonLogout.DisabledState.BorderColor = Color.DarkGray;
            buttonLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            buttonLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            buttonLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            buttonLogout.FillColor = Color.FromArgb(99, 94, 242);
            buttonLogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Visible = true;
            buttonLogout.BringToFront();
            buttonLogout.TabIndex = 0;
            return buttonLogout;
        }
    }
    
}
