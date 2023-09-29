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
    public partial class RegistroConfirmacion : Form
    {
        private SqlConnection conn;
        private SqlCommand insert;
        private string sCn;
        public RegistroConfirmacion()
        {
            InitializeComponent();
            Conexion CnL = new Conexion();
            CnL.Conec();
            sCn = CnL.cadena;

            conn = new SqlConnection(sCn);
        }
        private void RegistroConfirmacion_Load(object sender, EventArgs e)
        {
            if (Usuario_Controlador.Estatus == "Admin")
            {
                LbTipoUsuario.Text = "Su usuario es de tipo administrador";
            }
            else if (Usuario_Controlador.Estatus == "Empleado")
            {
                LbTipoUsuario.Text = "Su usuario es de tipo empleado";
            }
        }
        private void BtnRegister_Click(object sender, EventArgs e)
        {            
            ProcRegistro(Usuario_Controlador.UserCode, Usuario_Controlador.UserName, Usuario_Controlador.Password, Usuario_Controlador.Mail, Usuario_Controlador.Phone, Usuario_Controlador.Dui, Usuario_Controlador.Estatus);  
        }

        private void BtnCloseWindow_Click(object sender, EventArgs e)
        {
            Registro2 regresar = new Registro2();
            regresar.Show();
            this.Close();
        }
        private void ProcRegistro(string UserCode, string UserName, string Password, string Mail, string Phone, string Dui, string Status)
        {
            try
            {
                conn.Open();

                string Insert;
                Insert = "INSERT INTO Usuarios([usuario_id],[nombre_usuario],[contraseña],[correo],[telefono],[DUI],[posicion])";
                Insert += "VALUES(@CodUser,@NombreUser,@Pass,@Gmail,@Phone,@Dui,@Posic)";
                insert = new SqlCommand(Insert, conn);

                insert.Parameters.Add(new SqlParameter("@CodUser", SqlDbType.NVarChar));
                insert.Parameters["@CodUser"].Value = UserCode;
                insert.Parameters.Add(new SqlParameter("@NombreUser", SqlDbType.NVarChar));
                insert.Parameters["@NombreUser"].Value = UserName;
                insert.Parameters.Add(new SqlParameter("@Pass", SqlDbType.NVarChar));
                insert.Parameters["@Pass"].Value = Password;
                insert.Parameters.Add(new SqlParameter("@Gmail", SqlDbType.NVarChar));
                insert.Parameters["@Gmail"].Value = Mail;
                insert.Parameters.Add(new SqlParameter("@Phone", SqlDbType.NVarChar));
                insert.Parameters["@Phone"].Value = Phone;
                insert.Parameters.Add(new SqlParameter("@Dui", SqlDbType.NVarChar));
                insert.Parameters["@Dui"].Value = Dui;
                insert.Parameters.Add(new SqlParameter("@Posic", SqlDbType.NVarChar));
                insert.Parameters["@Posic"].Value = Status;

                insert.ExecuteNonQuery();

                MessageBox.Show("Registro agregado, tu codigo de usuario es " + UserCode + ", Guardar este codigo para acceder nuevamente");

                if(Status == "Admin")
                {
                    VentanaAdmin mostrar = new VentanaAdmin();
                    mostrar.Show();
                }
                else if(Status == "Empleado")
                {
                    VentanaEmpleado mostrar = new VentanaEmpleado();
                    mostrar.Show();
                }
                this.Close();
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
