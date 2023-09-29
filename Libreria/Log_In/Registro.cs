using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_In
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        //PROGRAMACION DE BOTONES
        private void BtnContinueRg_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text != "" && TxtUserGmail.Text != "" && TxtUserDUI.Text != "" && TxtUserPhoneNumber.Text != "")
            {
                Usuario_Controlador.UserName = TxtUserName.Text;
                Usuario_Controlador.Mail = TxtUserGmail.Text;
                Usuario_Controlador.Phone = TxtUserPhoneNumber.Text;
                Usuario_Controlador.Dui = TxtUserDUI.Text;

                Registro2 registro = new Registro2();
                registro.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tiene que llenar todas las tablas antes de continuar");
            }            
        }
        private void BtnCloseWindow_Click(object sender, EventArgs e)
        {
            LogIn returnLogIn = new LogIn();
            returnLogIn.Show();
            this.Close();
        }
    }
}
