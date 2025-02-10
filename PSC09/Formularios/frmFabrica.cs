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

namespace PSC09
{
    public partial class frmFabrica : Form
    {
        Boolean existeData = false;
        public frmFabrica()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmFabrica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // preguntaos que si la tecla que presionaste es igual ESC
            {
                this.Close(); // cierra el formulario
            }
        }

        private void frmFabrica_Load(object sender, EventArgs e)
        {
            this.Text = "Maestro de Puesto de trabajo";  // cambiamos el titulo del formulario
            this.KeyPreview = true; // activamos las teclas de funciones
        }

        private void txtIDfabrica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtIDfabrica.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtNombre.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtIDfabrica_Leave(object sender, EventArgs e)
        {
            if (txtIDfabrica.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
            {
                BuscarFabrica(txtIDfabrica.Text);    // viaja hacia el metodo y le envia el valor contenido en el textbox
            }
        }
        
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLocalidad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtLocalidad_Leave(object sender, EventArgs e)
        {

        }


        private void lblLocalidad_Click(object sender, EventArgs e)
        {

        }

        // Botones:

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtIDfabrica.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (existeData == true)
            {
                BorrarData(txtIDfabrica.Text);
                LimpiarFormulario();
                txtIDfabrica.Focus();
            }
        }

         // Metodos:

        private void LimpiarFormulario()
        {
            txtIDfabrica.Clear();
            txtNombre.Clear();
            txtLocalidad.Clear();

            lblLocalidad.Text = "";
        }

        private void BorrarData(string numFab)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();

            string miQuery = "DELETE FROM FABRICA WHERE IDFABRICA = '" + numFab + "'";
            SqlCommand cmd = new SqlCommand(miQuery, cnxn);
            cmd.ExecuteNonQuery();
            cnxn.Close();
        }

        private void BuscarFabrica(string numFabrica)
        {
            existeData = false;
            string miQuery =    "      SELECT  T1.NombreDeFabrica, " +
                                "              T1.Localidad " +
                                "        FROM  FABRICA T1 " +
                                "   LEFT JOIN  LOCALIDAD T2 ON T1.Localidad = T2.IDLocalidad " + // IDLocalidad no es valido
                                "       WHERE  T1.IDfabrica = '" + numFabrica + "'";

            SqlConnection cnxn = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cnxn.Open();   // abrimos la base de datos

            SqlCommand cmd = new SqlCommand(miQuery, cnxn);  // aqui enviamos el script al motor de SQL
            SqlDataReader rdr = cmd.ExecuteReader();  // ejucatamos el script enviado

            if (rdr.Read())  // aqui va a preguntar si trajo registro // aqui pregunta HasRow = true
            {
                txtNombre.Text = rdr["NombreDeFabrica"].ToString();
                txtLocalidad.Text = rdr["Localidad"].ToString();
                lblLocalidad.Text = rdr["Localidad"].ToString(); // *******CORREGIR********
            }
        }

        private void Localidad(string numLocalidad)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cnxn.Open();   // abrimos la base de datos

            string miQuery = "SELECT NombreDeLocalidad FROM LOCALIDAD WHERE IDLocalidad = numLocalidad";

            SqlCommand cmd = new SqlCommand(miQuery, cnxn);  // aqui enviamos el script al motor de SQL
            SqlDataReader rdr = cmd.ExecuteReader();  // ejucatamos el script enviado

            if (rdr.Read()) // aqui pregunta HasRow = true
            {
                lblLocalidad.Text = rdr["NombreDeLocalidad"].ToString();
            }
        }

        private void InsertData()
        {

        // Borra si el registro existe

            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();

            string miQuery = "DELETE FROM FABRICA WHERE IDfabrica = '" + txtIDfabrica.Text + "'";
            SqlCommand cmd = new SqlCommand(miQuery, cnxn);
            cmd.ExecuteNonQuery();
            cnxn.Close();

        // Inserta la data a la tabla

            SqlConnection cnx = new SqlConnection(cnn.db); // Le indica la conexion a la base de datos por medio de la clase cnxn
            cnx.Open();

            string stQuery = "INSERT INTO FABRICA (IDFABRICA, NOMBREDEFABRICA, LOCALIDAD, ESTATUS" +
                                 " VALUES (@A0, @A1, @A2, 1)";

            SqlCommand cnd = new SqlCommand(@stQuery, cnxn);
            cnd.Parameters.AddWithValue("@A0", txtIDfabrica.Text);
            cnd.Parameters.AddWithValue("@A1", txtNombre.Text);
            cnd.Parameters.AddWithValue("@A2", txtLocalidad.Text);

            cnd.ExecuteNonQuery(); // Este comando ejecutara el script, debe tomar en cuenta que se utiliza ExecuteNonQuery solo
                                   // para realizar insert, delete y update
        }
    }
}
