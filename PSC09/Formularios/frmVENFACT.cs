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

namespace PSC09
{
    public partial class frmVENFACT : Form
    {
        public string var1;
        public string var2;
        public string var3;
        public Boolean existeVar;

        public frmVENFACT()
        {
            InitializeComponent();
            EstiloDataGridView();
        }

        private void EstiloDataGridView()
        {
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersVisible = true;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("Col00", "Documento");
            this.dgv.Columns.Add("Col01", "Fecha");
            this.dgv.Columns.Add("Col02", "Subtotal");
            this.dgv.Columns.Add("Col03", "Impuesto");
            this.dgv.Columns.Add("Col04", "Monto");

            DataGridViewColumn
            column = dgv.Columns[00]; column.Width = 100;
            column = dgv.Columns[01]; column.Width = 100;
            column = dgv.Columns[02]; column.Width = 150;
            column = dgv.Columns[03]; column.Width = 150;
            column = dgv.Columns[04]; column.Width = 150;

            this.dgv.BorderStyle = BorderStyle.None;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            this.dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            this.dgv.BackgroundColor = Color.LightGray;

            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            this.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void BuscarData(string nmCliente)
        {
            existeVar = false;

            this.dgv.Rows.Clear();
            this.dgv.Refresh();

            SqlConnection cnx = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cnx.Open();

            string stQuery = "SELECT FACTURA, FECHA, SUBTOTAL, IMPUESTO, MONTOFACTURADO " +
                             "  FROM HFACTURA " +
                             " WHERE CLIENTE = '" + nmCliente + "' ORDER BY FACTURA, FECHA ASC";
            SqlCommand cmd = new SqlCommand(stQuery, cnx);  // aqui enviamos el script al motor de SQL
            SqlDataReader rcd = cmd.ExecuteReader();  // ejucatamos el script enviado

            while (rcd.Read())
            {
                existeVar = true;
                dgv.Rows.Add();
                int xRows = dgv.Rows.Count - 1;

                dgv[0, xRows].Value = Convert.ToString(rcd["FACTURA"]);
                dgv[1, xRows].Value = Convert.ToString(rcd["FECHA"]);
                dgv[2, xRows].Value = Convert.ToString(rcd["SUBTOTAL"]);
                dgv[3, xRows].Value = Convert.ToString(rcd["IMPUESTO"]);
                dgv[4, xRows].Value = Convert.ToString(rcd["MONTOFACTURADO"]);
            }
        }

        private void btnSelecciona_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount > 0)
            {
                var1 = dgv.CurrentRow.Cells[0].Value.ToString(); // Factura
                var2 = dgv.CurrentRow.Cells[1].Value.ToString(); // Fecha
                var3 = dgv.CurrentRow.Cells[4].Value.ToString(); // Monto

                existeVar = true;
                this.Close();
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelecciona.PerformClick();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarData(txtBuscar.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) // preguntaos que si la tecla que presionaste es igual ESC
            {
                this.Close(); // cierra el formulario
            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtBuscar.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    btnBuscar.Focus();  // movera el cursor hacia el textbox A
                }
            }
        }
    }
}
