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

namespace PSC09
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            this.Text = "Maestro de usuario";      // cambiamos el titulo del formulario
            this.KeyPreview = true;   // activamos las teclas de funciones

            LlenarEstatus();
        }

        private void frmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)  // preguntaos que si la tecla que presionaste es igual ESC
            {
                this.Close();  // cierra el formulario
            }
        }

        // ------------------------------------------------------
        // BOTONES
        // ------------------------------------------------------
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtUsuario.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // CIERRA FORMULARIO
        }

        // ------------------------------------------------------
        // TEXTBOX
        // ------------------------------------------------------

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtUsuario.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtNombre.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
            {
                BuscarUsuario(txtUsuario.Text);    // viaja hacia el metodo y le envia el valor contenido en el textbox
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtNombre.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtCorreo.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtCorreo.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtPassword.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtPassword.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtPuesto.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtPuesto.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    btnGuardar.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtPuesto_Leave(object sender, EventArgs e)
        {
            if (txtPuesto.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
            {
                BuscarPuestoDeTrabajo(txtPuesto.Text);  // viaja hacia el metodo y le envia el valor contenido en el textbox
            }
        }

        // ------------------------------------------------------
        // METODOS
        // ------------------------------------------------------
        private void LlenarEstatus()
        {
            List<Item> lista = new List<Item>();
            lista.Add(new Item("True", 1));
            lista.Add(new Item("False", 2));

            cboEstatus.DisplayMember = "Name";
            cboEstatus.ValueMember = "Value";
            cboEstatus.DataSource = lista;

            //cboEstatus.Text = "Activo";
        }

        private void LimpiarFormulario()
        {
            txtUsuario.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtPassword.Clear();
            txtPuesto.Clear();
            lblPuesto.Text = "";
        }

        private void BuscarUsuario(string nmUsuario)
        {
            string miQuery = "    SELECT T1.NUMEROEMPLEADO, " +
                             "           T1.NOMBRECORTO, " +
                             "           T1.POSICION, " +
                             "           T1.CORREO, " +
                             "           T1.FOTO, " +
                             "           T1.NOMBRECOMPLETO, " +
                             "           T1.ACTIVO, " +
                             "           T1.CLAVE, " +
                             "           T2.NOMBREDEPOSICION " +
                             "      FROM USUARIO T1 " +
                             " LEFT JOIN POSICIONES T2 ON T1.POSICION = T2.IDPOSICION" +
                             "     WHERE NOMBRECORTO ='" + nmUsuario + "'";

            SqlConnection cnxn = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cnxn.Open();   // abrimos la base de datos

            SqlCommand cmd = new SqlCommand(miQuery, cnxn);  // aqui enviamos el script al motor de SQL
            SqlDataReader rdr = cmd.ExecuteReader();  // ejucatamos el script enviado

            if (rdr.Read())  // aqui va a preguntar si trajo registro
            {
                txtNombre.Text = rdr["NOMBRECOMPLETO"].ToString();
                txtCorreo.Text = rdr["CORREO"].ToString();
                txtPuesto.Text = rdr["POSICION"].ToString();
                txtPassword.Text = rdr["CLAVE"].ToString();
                cboEstatus.Text = rdr["ACTIVO"].ToString();
                lblPuesto.Text = rdr["NOMBREDEPOSICION"].ToString();
            }
        }

        private void BuscarPuestoDeTrabajo(string nmPuesto)
        {

        }
    }
}
