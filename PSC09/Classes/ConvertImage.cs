using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace PSC09
{
    internal class ConvertImage
    {
        public static Image ByteArrayToImage(byte[] byteArrayIn) // Convierte el arreglo a imagen para el formulario
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            return Image.FromStream(ms);
        }

        public static byte[] ImageToByteArray(Image imageIn) // Convierte la imagen a arreglo, para que la Base de Datos pueda leer la imagen
        { 
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
