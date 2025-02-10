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
using System.Windows.Forms.VisualStyles;

namespace PSC09
{
    public partial class frmVenProducto : Form
    {
        public string varf1;
        public string varf2;
        public Boolean tf;

        public frmVenProducto()
        {
            InitializeComponent();
            Estilodgv();
        }

        private void frmVenProducto_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void frmVenProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Estilodgv()
        {
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersVisible = true;
            this.dgv.RowHeadersVisible = false;

            this.dgv.Columns.Add("Col00", "Item");
            this.dgv.Columns.Add("Col01", "Descripcion");

            DataGridViewColumn
            column = dgv.Columns[00]; column.Width = 100;
            column = dgv.Columns[01]; column.Width = 470;

            this.dgv.BorderStyle = BorderStyle.FixedSingle;
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            this.dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.DefaultCellStyle.SelectionBackColor = Color.LightYellow;
            this.dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgv.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 6, 0, 6);
            this.dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.CornflowerBlue;
            this.dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void BuscarData(string nomProducto)
        {
            this.dgv.Rows.Clear();
            this.dgv.Refresh();

            tf = false;

            string stQuery = "SELECT ITEM, DESCRIPCION " +
                             "  FROM PRODUCTOS " +
                             " WHERE DESCRIPCION LIKE '%" + nomProducto + "%' AND ESTATUSPRODUCTO = 1 ORDER BY DESCRIPCION ASC";

            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open();
            SqlCommand cmd = new SqlCommand(stQuery, cnx);
            SqlDataReader rcd = cmd.ExecuteReader();

            while (rcd.Read())
            {
                dgv.Rows.Add();
                int xRows = dgv.Rows.Count - 1;

                dgv[0, xRows].Value = rcd["ITEM"].ToString();
                dgv[1, xRows].Value = rcd["DESCRIPCION"].ToString();
            }

            cmd.Dispose();
            cnx.Close();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSeleccion.PerformClick();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarData(txtBuscar.Text);
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            if(dgv.RowCount > 0)
            {
                varf1 = dgv.CurrentRow.Cells[0].Value.ToString();
                varf2 = dgv.CurrentRow.Cells[1].Value.ToString();

                tf = true;

                this.Close();

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;   
                if (txtBuscar.Text.Trim() != string.Empty)
                {
                    btnGuardar.Focus(); 
                }
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            btnGuardar.PerformClick();   
        }
    }
}
