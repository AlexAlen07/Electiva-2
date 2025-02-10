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
using System.IO;
using iTextSharp.text.pdf;

namespace PSC09
{
    public partial class frmProducto : Form
    {
        string path = @"C:\Users\Iamlilalex\OneDrive\Escritorio\DOBLE AA\P1\Practicas\PSC09\PSC09\Resources\ITLA.PNG";
        string ruta = @"C:\Users\Iamlilalex\OneDrive\Escritorio\DOBLE AA\P1\Practicas\PSC09\PSC09\Resources";
        private Image imgOriginal;
        Bitmap bmp;
        PictureBox pb;

        Boolean existeData;
        public frmProducto()
        {
            InitializeComponent();
        }

        // EVENTOS:

        private void frmProducto_Load(object sender, EventArgs e)
        {
            this.Text = "Maestro de Productos";
            this.KeyPreview = true;   // Activa las teclas de funciones

            existeData = false;
        }

        private void frmProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)  // pregunta si la tecla que presionaste es igual ESC
            {
                this.Close();  // cierra el formulario
            }
        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtProducto.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtNombre.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtProducto_Leave(object sender, EventArgs e)
        {
            if (txtProducto.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
            {
                BuscarData(txtProducto.Text);    // viaja hacia el metodo y le envia el valor contenido en el textbox
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtNombre.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtCantidad.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtCantidad.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtCosto.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtCosto.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtPrecio.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtPrecio.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtImpuesto.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtImpuesto.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtBarra.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)  // pregunta que si presionaste la tecla Enter
            {
                e.Handled = true;   // indica que se ejecuto enter

                if (txtBarra.Text.Trim() != string.Empty)  // pregunta que si el textbox es diferente de vacio
                {
                    txtTieneImpuesto.Focus();  // movera el cursor hacia el textbox Nombre
                }
            }
        }

        private void txtTieneImpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        // BOTONES:

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text.Trim() != string.Empty)
            {
                if (txtNombre.Text.Trim() != string.Empty)
                {
                    if (txtCantidad.Text.Trim() != string.Empty)
                    {
                        if (txtCosto.Text.Trim() != string.Empty)
                        {
                            if (txtPrecio.Text.Trim() != string.Empty)
                            {
                                if (txtImpuesto.Text.Trim() != string.Empty)
                                {
                                    if (txtTieneImpuesto.Text.Trim() != string.Empty)
                                    {
                                        if (txtBarra.Text.Trim() != string.Empty)
                                        {
                                            if (existeData == true) 
                                            {
                                                ActualizaData();
                                                ActualizarImagenProducto(txtProducto.Text);
                                            }

                                            else 
                                            {
                                                InsertData();
                                                ActualizarImagenProducto(txtProducto.Text);
                                            }
                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            txtProducto.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (existeData == true)
            {
                DialogResult = DialogResult = MessageBox.Show("Estas seguro/a que quieres borrar el registro: (", "ITLA", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    BorrarData(txtProducto.Text);
                    LimpiarFormulario();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario
        }

        // METODOS:

        private void BuscarData(string nProducto)
        {
            existeData = false;

            SqlConnection cnx = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cnx.Open();   // abrimos la base de datos

            string stQuery = "      SELECT ITEM, DESCRIPCION, CANTIDADENEXISTENCIA, COSTO, PRECIODEVENTA, IMPUESTO, BARCODE, TIENEIMPUESTO " +
                             "        FROM PRODUCTOS " +
                             "       WHERE EstatusProducto = 1 " +
                             "         AND ITEM = '" + nProducto + "'";

            SqlCommand cmd = new SqlCommand(stQuery, cnx);  // aqui enviamos el script al motor de SQL
            SqlDataReader rdr = cmd.ExecuteReader();  // ejucatamos el script enviado

            if (rdr.Read())  // aqui va a preguntar si trajo registro // aqui pregunta HasRow = true
            {
                txtNombre.Text = Convert.ToString(rdr["DESCRIPCION"]);
                txtCantidad.Text = Convert.ToString(rdr["CANTIDADENEXISTENCIA"]);
                txtCosto.Text = Convert.ToString(rdr["COSTO"]);
                txtPrecio.Text = Convert.ToString(rdr["PRECIODEVENTA"]);
                txtImpuesto.Text = Convert.ToString(rdr["IMPUESTO"]);
                txtBarra.Text = Convert.ToString(rdr["BARCODE"]);
                txtTieneImpuesto.Text = Convert.ToString(rdr["TIENEIMPUESTO"]);

                MostrarImagenProducto(txtProducto.Text);
            }
        }

        private void BorrarData(string numProducto)
        {
            SqlConnection cnx = new SqlConnection(cnn.db);  // indicamos la conexion a la base de datos
            cnx.Open();   // abrimos la base de datos 

            string tsQuery = "UPDATE PRODUCTOS SET ESTATUSPRODUCTOS = 3 FROM PRODUCTOS WHERE ITEM ='" + numProducto;
            SqlCommand cmd = new SqlCommand(tsQuery, cnx);  // aqui enviamos el script al motor de SQL
            cmd.ExecuteReader();  // ejucatamos el script enviado
        }

        private void InsertData()
        {

            // Borra si el registro existe

            SqlConnection cnx = new SqlConnection(cnn.db);
            cnx.Open();

            string miQuery = "DELETE FROM PRODUCTOS WHERE ITEM = '" + txtProducto.Text + "'";
            SqlCommand cmd = new SqlCommand(miQuery, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();

            // Inserta la data a la tabla

            SqlConnection cxn = new SqlConnection(cnn.db); // Le indica la conexion a la base de datos por medio de la clase cnxn
            cxn.Open();

            string stQuery = "INSERT INTO PRODUCTOS (ITEM, DESCRIPCION, CANTIDADENEXISTENCIA, COSTO, PRECIODEVENTA, IMPUESTO, BARCODE, ESTATUSPRODUCTO" +
                                 " VALUES (@A0, @A1, @A2, @A3, @A4, @A5, @A6, @A7, 1)";

            SqlCommand cnd = new SqlCommand(@stQuery, cxn);
            cnd.Parameters.AddWithValue("@A0", txtProducto.Text);
            cnd.Parameters.AddWithValue("@A1", txtNombre.Text);
            cnd.Parameters.AddWithValue("@A2", txtCantidad.Text);
            cnd.Parameters.AddWithValue("@A3", txtCosto.Text);
            cnd.Parameters.AddWithValue("@A5", txtPrecio.Text);
            cnd.Parameters.AddWithValue("@A6", txtImpuesto.Text);
            cnd.Parameters.AddWithValue("@A6", txtBarra.Text);

            cnd.ExecuteNonQuery(); // Este comando ejecutara el script, debe tomar en cuenta que se utiliza ExecuteNonQuery solo
                                   // para realizar insert, delete y update
        }

        private void ActualizaData()
        {
            string tQuery = "UPDATE PRODUCTOS " +
                            "   SET DESCRIPCION          = @A2, " +
                            "       CANTIDADENEXISTENCIA = @A3, " +
                            "       COSTO                = @A4, " +
                            "       PRECIODEVENTA        = @A5, " +
                            "       IMPUESTO             = @A6, " +
                            "       BARCODE              = @A7  " +
                            "  FROM PRODUCTOS " +
                            " WHERE ITEM = @A1";

            SqlConnection cxn = new SqlConnection(cnn.db); cxn.Open();
            SqlCommand cdm = new SqlCommand(tQuery, cxn);

            cdm.Parameters.AddWithValue("@A1", txtProducto.Text);
            cdm.Parameters.AddWithValue("@A2", txtNombre.Text);
            cdm.Parameters.AddWithValue("@A3", txtCantidad.Text);
            cdm.Parameters.AddWithValue("@A4", txtCosto.Text);
            cdm.Parameters.AddWithValue("@A5", txtPrecio.Text);
            cdm.Parameters.AddWithValue("@A6", txtImpuesto.Text);
            cdm.Parameters.AddWithValue("@A7", txtBarra.Text);

            cdm.ExecuteNonQuery();

            cdm.Dispose();
            cxn.Close();
        }

        private void LimpiarFormulario()
        {
            txtProducto.Clear();
            txtNombre.Clear();
            txtCantidad.Clear();
            txtCosto.Clear();
            txtPrecio.Clear();
            txtImpuesto.Clear();
            txtBarra.Clear();
            txtTieneImpuesto.Clear();

            existeData = false;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();  
            openFileDialog1.Filter = "jpg[*.jpg*]|*.jpg|png[*.png]|[*.png]|Todos los archivos[*.*]|*.*";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != null)
            {
                string imagen = openFileDialog1.FileName; // Aqui asigna a la variable imagen el archivo buscado o elegido por nosotros
                if (imagen == string.Empty || imagen == null) // Aqui pregunta si la variable imagen es diferente de vacio o null
                {
                    imagen = path;
                }

                lblRuta.Text = imagen;

                try
                {
                    System.IO.File.Copy(lblRuta.Text, ruta, true); // Realiza una copia de la imagen en otra ruta
                }

                catch 
                {
                
                }

                // Asignamos los atributos al pictureBox (picImagen)
                bmp = new Bitmap(imagen);
                imgOriginal = Image.FromFile(imagen);

                pictureBox.Image = imgOriginal; //Coloca la imagen el pictureBox
            }      
        }

        private void MostrarImagenProducto(string numProducto) 
        {
            pictureBox1.Image = null;
            SqlConnection cxn = new SqlConnection(cnn.db); 
            cxn.Open();

            SqlCommand cmd = new SqlCommand("SELECT IMAGEN FROM PRODUCTOS WHERE ITEM ='" + numProducto + "'", cxn);
            SqlDataReader rdr = cmd.ExecuteReader();    
            
            if (rdr.Read())
            {
                try
                {
                    pictureBox.Image = ConvertImage.ByteArrayToImage((byte[])rdr["IMAGEN"]);
                }
                catch
                {

                }
            }
        }

        private void ActualizarImagenProducto(string numProducto)
        {
            byte[] byteArrayImagen = ConvertImage.ImageToByteArray(pictureBox.Image);

            SqlConnection cxn = new SqlConnection(cnn.db);
            cxn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE PRODUCTOS SET IMAGEN = @A1 WHERE ITEM ='" + numProducto + "'", cxn);
            cmd.Parameters.AddWithValue("@A1", byteArrayImagen);    

            cmd.ExecuteNonQuery();
            cxn.Close();    
        }

        public enum Code128SubTypes
        {
            CODE128 = iTextSharp.text.pdf.Barcode.CODE128,
            CODE128_RAW = iTextSharp.text.pdf.Barcode.CODE128_RAW,
            CODE128_UCC = iTextSharp.text.pdf.Barcode.CODE128_UCC,  
        }

        public static Bitmap Code128(string _code, Code128SubTypes codeType = Code128SubTypes.CODE128, bool PrintTextInCode = false, float Height = 0, bool GenerateChecksum = true, bool ChecksumText = true)
        {
            if (_code.Trim() == "")
            {
                return null;
            }
            else
            {
                Barcode128 barcode = new Barcode128();

                barcode.CodeType = (int)codeType;
                barcode.StartStopText = true;
                barcode.GenerateChecksum = GenerateChecksum;
                barcode.ChecksumText = ChecksumText;
                if (Height != 0) barcode.BarHeight = Height;
                barcode.Code = _code;
                try
                {
                    System.Drawing.Bitmap bm = new System.Drawing.Bitmap(barcode.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White));
                    if (PrintTextInCode == false)
                    {
                        return bm;
                    }
                    else
                    {
                        Bitmap bmt;
                        bmt = new Bitmap(bm.Width, bm.Height + 14);
                        Graphics g = Graphics.FromImage(bmt);
                        g.FillRectangle(new SolidBrush(Color.White), 0, 0, bm.Width, bm.Height + 14);

                        Font drawFont = new Font("Arial", 8);
                        SolidBrush drawBrush = new SolidBrush(Color.Black);

                        SizeF stringSize = new SizeF();
                        stringSize = g.MeasureString(_code, drawFont);
                        float xCenter = (bm.Width - stringSize.Width) / 2;
                        float x = xCenter;
                        float y = bm.Height;

                        StringFormat drawFormat = new StringFormat();
                        drawFormat.FormatFlags = StringFormatFlags.NoWrap;

                        g.DrawImage(bm, 0, 0);
                        g.DrawString(_code, drawFont, drawBrush, x, y, drawFormat);

                        return bmt;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error codigo de barra Code128. Desc:" + ex.Message);
                }
            }
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmVenProducto frm = new frmVenProducto();
            DialogResult res = frm.ShowDialog();    

            if (frm.tf == true)
            {
                txtProducto.Text = frm.varf1;

                BuscarData(txtProducto.Text);   
            }
        }
    }
}
