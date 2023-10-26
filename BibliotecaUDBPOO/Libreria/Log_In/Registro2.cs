using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_In
{
    public partial class Registro2 : Form
    {
        //COMANDOS PARA ACCEDER Y MANIPULAR LA BASE DE DATOS
        private SqlConnection conn;
        private string sCn;
        public Registro2()
        {
            InitializeComponent();
            Conexion CnL = new Conexion();
            CnL.Conec();
            sCn = CnL.cadena;

            conn = new SqlConnection(sCn);
        }

        //PROGRAMACION DE BOTONES
        
        private void BtnTypeUser_Admin_Click(object sender, EventArgs e)
        {

            if (TxtGetPassword.Text != "" && TxtConfirmPassword.Text != "")
            {
                if (TxtGetPassword.Text == TxtConfirmPassword.Text)
                {
                    string CodUser = AsignarCodUser("Admin");

                    Usuario_Controlador.UserCode = CodUser;
                    Usuario_Controlador.Password = TxtGetPassword.Text;
                    Usuario_Controlador.Estatus = "Admin";

                    RegistroConfirmacion confirmacion = new RegistroConfirmacion();
                    confirmacion.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
                }
            }
            else
            {
                MessageBox.Show("Tiene que llenar todas las tablas antes de continuar");
            }
        }
        private void BtnTypeUser_Employee_Click(object sender, EventArgs e)
        {
            if (TxtGetPassword.Text != "" && TxtConfirmPassword.Text != "")
            {
                if (TxtGetPassword.Text == TxtConfirmPassword.Text)
                {
                    string CodUser = AsignarCodUser("Empleado");
                    Usuario_Controlador.UserCode = CodUser;
                    Usuario_Controlador.Password = TxtGetPassword.Text;
                    Usuario_Controlador.Estatus = "Empleado";

                    RegistroConfirmacion confirmacion = new RegistroConfirmacion();
                    confirmacion.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");
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
        private void BtnRegresarRg1_Click(object sender, EventArgs e)
        {
            Registro returnReg1 = new Registro();
            returnReg1.Show();
            this.Hide();
        }

        //METODO DE ASIGNAR CODIGO USUARIO
        private string AsignarCodUser(string TipoUser)
        {
            conn.Open();

            string coduser;
            string CodOrigen;
            if(TipoUser == "Admin")
            {
                string Select = "SELECT [usuario_id] FROM [Usuarios] WHERE [usuario_id] LIKE 'AD%' ORDER BY [usuario_id] DESC";
                SqlDataAdapter cmd = new SqlDataAdapter(Select, conn);

                DataTable dt = new DataTable();
                cmd.Fill(dt);

                try
                {
                    CodOrigen = dt.Rows[0][0].ToString();
                    coduser = GenCodUser(CodOrigen);
                }
                catch
                {
                    coduser = "AD0001";
                }
                conn.Close();
            }
            else
            {
                string Select = "SELECT [usuario_id] FROM [Usuarios] WHERE [usuario_id] LIKE 'EM%' ORDER BY [usuario_id] DESC";
                SqlDataAdapter cmd = new SqlDataAdapter(Select, conn);

                DataTable dt = new DataTable();
                cmd.Fill(dt);

                try
                {
                    CodOrigen = dt.Rows[0][0].ToString();
                    coduser = GenCodUser(CodOrigen);
                }
                catch
                {
                    coduser = "EM0001";
                }
                conn.Close();
            }
            return coduser;
        }

        private string GenCodUser(string texto)
        {
            int pA = 2;
            int pB = 3;
            int pC = 4;
            int pD = 5;
            string cambio;

            char[] cadena = texto.ToCharArray();

            if (texto.Length > pD && texto[pD] == '9')
            {
                char textPc = texto[pC];
                int caracterPc = (int)textPc + 1;
                char nuevoCc = (char)caracterPc;


                cadena[pC] = nuevoCc;
                cadena[pD] = '0';

                cambio = new string(cadena);

                if (nuevoCc > '9')
                {
                    char textPb = texto[pB];
                    int caracterPb = (int)textPb + 1;
                    char nuevoCb = (char)caracterPb;

                    cadena[pB] = nuevoCb;
                    cadena[pC] = '0';
                    cadena[pD] = '0';

                    cambio = new string(cadena);

                    if (nuevoCb > '9')
                    {
                        char textPa = texto[pA];
                        int caracterPa = (int)textPa + 1;
                        char nuevoCa = (char)caracterPa;

                        cadena[pA] = nuevoCa;
                        cadena[pB] = '0';
                        cadena[pC] = '0';
                        cadena[pD] = '0';

                        cambio = new string(cadena);
                        if (nuevoCa > '9')
                        {
                            cambio = "Ya se cumplio el limite de usuarios";
                        }
                    }
                }
            }
            else
            {
                char textPd = texto[pD];
                int caracterPd = (int)textPd + 1;
                char nuevoCd = (char)caracterPd;

                cadena[pD] = nuevoCd;

                cambio = new string(cadena);
            }
            return cambio;
        }

       
    }
}
