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
                Usuario_Controlador U = new Usuario_Controlador();

                //Validar nombre
                if(U.ValidarNombre(TxtUserName.Text).Count == 0 && U.ValidarMail(TxtUserGmail.Text).Count == 0 && U.ValidarTelefono(TxtUserPhoneNumber.Text).Count == 0 && U.ValidarDUI(TxtUserDUI.Text).Count == 0)
                {
                    Usuario_Controlador.UserName = TxtUserName.Text;
                    Usuario_Controlador.Mail = TxtUserGmail.Text;
                    Usuario_Controlador.Phone = TxtUserPhoneNumber.Text;
                    Usuario_Controlador.Dui = TxtUserDUI.Text;

                    MostrarRegistro2();
                }
                else
                {
                    if(U.ValidarNombre(TxtUserName.Text).Count != 0)
                    {
                        MessageBox.Show(U.ValidarNombre(TxtUserName.Text)[0], "Error nombre:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(U.ValidarMail(TxtUserGmail.Text).Count != 0)
                    {
                        MessageBox.Show(U.ValidarMail(TxtUserGmail.Text)[0], "Error mail:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(U.ValidarTelefono(TxtUserPhoneNumber.Text).Count != 0)
                    {
                        MessageBox.Show(U.ValidarTelefono(TxtUserPhoneNumber.Text)[0], "Error telefono:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (U.ValidarDUI(TxtUserDUI.Text).Count != 0)
                    {
                        MessageBox.Show(U.ValidarDUI(TxtUserDUI.Text)[0], "Error dui:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                  
                }                
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

        //PROGRAMACION DE COMPORTAMIENTOS Y EVENTOS DEL PROGRAMA
        private void TxtUserDUI_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            if(text.Length == 8)
            {
                textBox.Text = text.Insert(8, "-");
                textBox.SelectionStart = 10;
            }
        }

        private void TxtUserPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;

            if (text.Length == 4)
            {
                textBox.Text = text.Insert(4, "-");
                textBox.SelectionStart = 6;
            }
        }

        //METODOS UTILIZADOS EN EL PROGRAMA
        private void MostrarRegistro2()
        {
            Registro2 registro = new Registro2();
            registro.ShowDialog();
            this.Close();
        }
    }
}
