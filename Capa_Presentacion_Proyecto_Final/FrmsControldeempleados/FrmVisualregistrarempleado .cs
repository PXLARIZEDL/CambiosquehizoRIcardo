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
            MessageBox.Show("HOLA MENOL");
            CD_Empleados empleados = new CD_Empleados();
            try
            {
                empleados.Insertar(TXT_NOMBRE.Text, TXT_APELLIDO.Text, TXT_CEDULA.Text, "", "", cbCargo.Text, TXT_TELEFONO.Text, TXT_FECHAINGRESO.Text, "", TXT_ID_DIRECCION.Text, cbGenero.Text);
                MessageBox.Show("Empleado registrado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el empleado" + ex);
            }
        }

        private void TXT_EDAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmVisualregistrarempleado_Load(object sender, EventArgs e)
        {

        }
    }
}