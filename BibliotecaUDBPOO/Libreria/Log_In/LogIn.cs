using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.CodeDom;

namespace Log_In
{
    public partial class LogIn : Form
    {
        //COMANDOS UTILIZADOS PARA ACCEDER Y MANIPULAR BASE DE DATOS
        private SqlConnection conn;
        private string sCn;

        public LogIn()
        {
            InitializeComponent();

            Conexion CnL = new Conexion();
            CnL.Conec();
            sCn = CnL.cadena;

            conn = new SqlConnection(sCn);
        }

        //INDICACIONES AL INICIAR EL PROGRAMA
        private void Form1_Load(object sender, EventArgs e)
        {
            TimerLogInBackground.Start();
            this.ActiveControl = null;
        }

        //PROGRAMACION DE BOTONES y timer
        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            ProcLogIn(TxtUserCode.Text, TxtPassword.Text);
        }
        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }
        private void BtnRecoverPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aun estamos trabajando en esta parte :)");
        }
        private void BtnCloseProgram_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //PROGRAMACION DE COMPORTAMIENTOS Y EVENTOS DEL FORMS
        private void TxtUserCode_Enter(object sender, EventArgs e)
        {
            if(TxtUserCode.Text == "Ingrese su codigo de usuario")
            {
                TxtUserCode.Text = "";
            }
        }
        private void TxtUserCode_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUserCode.Text))
            {
                TxtUserCode.Text = "Ingrese su codigo de usuario";
            }
        }
        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if(TxtPassword.Text == "Ingrese su contraseña")
            {
                TxtPassword.Text = "";
                TxtPassword.PasswordChar = '*';
            }
        }
        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                TxtPassword.Text = "Ingrese su contraseña";
                TxtPassword.PasswordChar = '\0';
            }
        }
        private int control = 1; 
        private void TimerLogInBackground_Tick(object sender, EventArgs e)
        {
            if (control == 1)
            {
                PicBox_LogIn.Image = Log_In.Properties.Resources.LogIn_2;
                control = 2;
            }
            else if (control == 2)
            {
                PicBox_LogIn.Image = Log_In.Properties.Resources.LogIn_3;
                control = 3;
            }
            else if (control == 3)
            {
                PicBox_LogIn.Image = Log_In.Properties.Resources.LogIn_1;
                control = 1;
            }
        }

        // METODOS DE LOG IN
        private void ProcLogIn(string CodUser, string Contraseña)
        {
            try
            {
                conn.Open();

                string Select = "SELECT [usuario_id], [posicion] FROM [Usuarios] WHERE [usuario_id] = '" + CodUser + "' AND [contraseña] = '" + Contraseña + "'";
                SqlDataAdapter cmd = new SqlDataAdapter(Select, conn);

                DataTable dt = new DataTable();
                cmd.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString() == "Admin")
                    {
                        VentanaAdmin admin = new VentanaAdmin();
                        admin.Show();
                    } 
                    else if (dt.Rows[0][1].ToString() == "Empleado")
                    {
                        VentanaEmpleado empleado = new VentanaEmpleado();
                        empleado.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }


    }
}
