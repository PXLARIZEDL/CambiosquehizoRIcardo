using Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Negocio.Interfaces;
using System.Drawing.Text;
using System.Linq.Expressions;
namespace Capa_Presentacion_Proyecto_Final
{

    public partial class FrmVisualregistrarempleado : Form
    {
        public FrmVisualregistrarempleado()
        {
            InitializeComponent();
        }

        private void BTN_GUARDAR_Click(object sender, EventArgs e)
        {
            CD_Empleados empleados = new CD_Empleados();

            try
            {
                DateTime fechaIngreso;
                if (!DateTime.TryParse(TXT_FECHAINGRESO.Text, out fechaIngreso))
                {
                    MessageBox.Show("Fecha de ingreso no válida");
                    return;
                }

                // Verificar que el ID de la dirección sea válido (número)
              /*  int idDireccion;
                if (!int.TryParse(TXT_ID_DIRECCION.Text, out idDireccion))
                {
                    MessageBox.Show("El ID de dirección no es válido");
                    return;
                }

                // Asegurarse de que el ID_DIRECCION exista en la base de datos
                if (!VerificarDireccionExistente1(idDireccion))
                {
                    MessageBox.Show("La dirección no existe. Debe insertar primero la dirección.");
                    return;
                }*/

                int idGenero;
                if (!int.TryParse(cbGenero.Text, out idGenero))
                {
                    MessageBox.Show("El ID de género no es válido");
                    return;
                }

                // Insertar el empleado con el ID de dirección válido
               /* empleados.Insertar(TXT_NOMBRE.Text, TXT_APELLIDO.Text, TXT_CEDULA.Text,
                                   "", "", cbCargo.Text, TXT_TELEFONO.Text, fechaIngreso.ToString("yyyy-MM-dd"),
                                   "", idDireccion.ToString(), idGenero.ToString());*/

                MessageBox.Show("Empleado registrado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el empleado: " + ex.Message);
            }
        }

        // Método para verificar si la dirección existe
        /* private bool VerificarDireccionExistente(int Direccion)
         {
             // Aquí deberías hacer una consulta SQL para verificar si el ID de dirección existe en la base de datos
             string query = "SELECT COUNT(*) FROM Direccion WHERE ID_DIRECCION = @id_Direccion";

             using (SqlConnection conn = new SqlConnection("Server= RICARDO\\LOSER1; Database=BD_Empleados; Integrated Security=true"))
             {
                 SqlCommand cmd = new SqlCommand(query, conn);
                 cmd.Parameters.AddWithValue("@idDireccion", Direccion);
                 conn.Open();

                 int count = (int)cmd.ExecuteScalar();
                 return count > 0;  // Si count > 0, la dirección existe
             }
         } */
        private void TXT_EDAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmVisualregistrarempleado_Load(object sender, EventArgs e)
        {
            string connectionString = "Server= RICARDO\\LOSER1; Database=BD_Empleados; Integrated Security=true";
            string query = "select id_Direccion from Direccion";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                
                {


                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cb_direccion.DisplayMember = "id_Direccion";
                    cb_direccion.ValueMember = "id_Direccion";
                    cb_direccion.DataSource = dt;
                }

              

            }
        }

        private void cb_direccion_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_direccion.SelectedIndex != null)
            {
                int iddireccion = Convert.ToInt32(cb_direccion.SelectedValue);
             //   MessageBox.Show("El ID de la dirección seleccionada es: " + iddireccion);

            }
            //VerificarDireccionExistente1(1);
        }
            /*  // Método para verificar si la dirección existe
        private bool VerificarDireccionExistente1(int Direccion)
        {
            // Aquí deberías hacer una consulta SQL para verificar si el ID de dirección existe en la base de datos
            string query = "SELECT COUNT(*) FROM Direccion WHERE id_Direccion = @id_Direccion";

            using (SqlConnection conn = new SqlConnection("Server= RICARDO\\LOSER1; Database=BD_Empleados; Integrated Security=true"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idDireccion", Direccion);
                conn.Open();

                int count = (int)cmd.ExecuteScalar();
                return count > 0;  // Si count > 0, la dirección existe
            }
        }*/
    }
    }
