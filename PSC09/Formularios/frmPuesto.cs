using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Markup;
using System.Security.Cryptography;

namespace PSC09
{
    public partial class frmPuesto : Form
    {
        Boolean existeData = false;
        public frmPuesto()
        {
            InitializeComponent();
        }

        private void frmPuesto_Load(object sender, EventArgs e)
        {
            this.Text = "Maestro de Puesto de trabajo";  // cambiamos el titulo del formulario
            this.KeyPreview = true; // activamos las teclas de funciones
        }

        private void frmPuesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) // preguntaos que si la tecla que presionaste es igual ESC
            {
                this.Close(); // cierra el formulario
            }
        }

        // TextBox:

        private void txtPosicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtPosicion.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtNombre.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtPosicion_Leave(object sender, EventArgs e)
        {
            if (txtPosicion.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
            {
                BuscarPosicion(txtPosicion.Text);    // viaja hacia el metodo y le envia el valor contenido en el textbox
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
 
        }

        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDepartamento_Leave(object sender, EventArgs e)
        {

        }

        private void txtFabrica_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtFabrica_Leave(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtPosicion.Focus();    
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (existeData == true) 
            {
                BorrarData(txtPosicion.Text);
                LimpiarFormulario();
                txtPosicion.Focus();
            }
        }

        private void BorrarData(string numPos)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();

            string miQuery = "DELETE FROM POSICIONES WHERE IDDEPOSICION = '" + numPos + "'";
            SqlCommand cmd = new SqlCommand(miQuery, cnxn);
            cmd.ExecuteNonQuery();
            cnxn.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }

        // Metodos:

        private void LimpiarFormulario()
        {
            txtDepartamento.Clear();
            txtFabrica.Clear();
            txtNombre.Clear();
            txtPosicion.Clear();

            lblDepartamento.Text = "";
            lblFabrica.Text = "";

            existeData = false;
        }

        private void BuscarPosicion(string numPuesto) 
        {
            existeData = false;
            string miQuery =    "      SELECT  T1.NombreDePosicion, " +
                                "              T1.Fabrica, " +
                                "              T1.Departamento, " +
                                "              T2.NombreDeFabrica, " +
                                "              T3.NombreDepartamento " +
                                "        FROM  POSICIONES T1 " +
                                "  LEFT JOIN  FABRICA T2 ON T1.Fabrica = T2.IDfabrica " +
                                "  LEFT JOIN  DEPARTAMENTO T3 ON T1.Departamento = T3.IDdepartamento " +
                                "       WHERE  T1.IDposicion = '" + numPuesto + "'";

            SqlConnection cnxn = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cnxn.Open();   // abrimos la base de datos

            SqlCommand cmd = new SqlCommand(miQuery, cnxn);  // aqui enviamos el script al motor de SQL
            SqlDataReader rdr = cmd.ExecuteReader();  // ejucatamos el script enviado

            if (rdr.Read())  // aqui va a preguntar si trajo registro // aqui pregunta HasRow = true
            {
                txtNombre.Text = rdr["NombreDePosicion"].ToString();
                txtDepartamento.Text = rdr["Departamento"].ToString();
                txtFabrica.Text = rdr["Fabrica"].ToString();
                lblFabrica.Text = rdr["NombreDeFabrica"].ToString();
                lblDepartamento.Text = rdr["NombreDepartamento"].ToString();
            }
        }

        private void Departamento(string numDepartamento)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cnxn.Open();   // abrimos la base de datos

            string miQuery = "SELECT NombreDepartamento FROM DEPARTAMENTO WHERE IDdepartamento = numDepartamento";

            SqlCommand cmd = new SqlCommand(miQuery, cnxn);  // aqui enviamos el script al motor de SQL
            SqlDataReader rdr = cmd.ExecuteReader();  // ejucatamos el script enviado

            if (rdr.Read()) // aqui pregunta HasRow = true
            {
                lblDepartamento.Text = rdr["NombreDepartamento"].ToString();
            }
        }

        private void Fabrica(string numFabrica)
        {
            SqlConnection cnxn = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cnxn.Open();   // abrimos la base de datos

            string miQuery = "SELECT NombreDeFabrica FROM FABRICA WHERE IDfabrica = numFabrica";

            SqlCommand cmd = new SqlCommand(miQuery, cnxn);  // aqui enviamos el script al motor de SQL
            SqlDataReader rdr = cmd.ExecuteReader();  // ejucatamos el script enviado

            if (rdr.Read()) // aqui pregunta HasRow = true
            {
                lblFabrica.Text = rdr["NombreDeFabrica"].ToString();
            }
        }
        private void InsertData()
        { 

        // Borra si el registro existe

            SqlConnection cnxn = new SqlConnection(cnn.db);
            cnxn.Open();

            string miQuery = "DELETE FROM POSICIONES WHERE IDDEPOSICION = '" + txtPosicion.Text + "'";
            SqlCommand cmd = new SqlCommand( miQuery, cnxn);
            cmd.ExecuteNonQuery();
            cnxn.Close();

        // Inserta la data a la tabla

            SqlConnection cnx = new SqlConnection(cnn.db); // Le indica la conexion a la base de datos por medio de la clase cnxn
            cnx.Open();

            string stQuery = "INSERT INTO POSICIONES (IDPOSICION, NOMBREDEPOSICION, DEPARTAMENTO, FABRICA, ESTATUS" +
                                 " VALUES (@A0, @A1, @A2, @A3, 1)";

            SqlCommand cnd = new SqlCommand(@stQuery, cnxn);
                cnd.Parameters.AddWithValue("@A0", txtPosicion.Text);
                cnd.Parameters.AddWithValue("@A1", txtNombre.Text);
                cnd.Parameters.AddWithValue("@A2", txtDepartamento.Text);
                cnd.Parameters.AddWithValue("@A3", txtFabrica.Text);

                cnd.ExecuteNonQuery(); // Este comando ejecutara el script, debe tomar en cuenta que se utiliza ExecuteNonQuery solo
                                       // para realizar insert, delete y update
        }
    }
}
