using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CEOEye.Negocio
{
    class Bibliotecario
    {
        public Bibliotecario()
        {

        }

        public void generarInformeAlta(Cliente cliente)
        {
            Document doc = new Document(PageSize.A4.Rotate());

            BaseFont arial = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font f_15_bold = new iTextSharp.text.Font(arial,15,iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font f_12_normal = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.NORMAL);

            Random rnd = new Random();
            int name = rnd.Next(1,1000);

            FileStream os = new FileStream("c:/Reportes/FormularioAlta"+cliente.getDni()+".pdf", FileMode.Create);


            using (os)
            {
                PdfWriter.GetInstance(doc, os);
                doc.Open();

                //Información sobre la empresa
                PdfPTable tabla1 = new PdfPTable(1);
                float[] width = new float[] { 40f, 60f };

                PdfPCell cel1 = new PdfPCell(new Phrase("\n\nEmpresa",f_15_bold));
                PdfPCell cel2 = new PdfPCell(new Phrase("\n\nEslogan", f_15_bold));
                PdfPCell cel3 = new PdfPCell(new Phrase("\n\nSubtitulo", f_15_bold));
                PdfPCell cel4 = new PdfPCell(new Phrase("\n\nPrueba  \nTelefono (+34)600259652", f_15_bold));

                cel1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel4.Border = iTextSharp.text.Rectangle.NO_BORDER;

                cel1.HorizontalAlignment = Element.ALIGN_CENTER;
                cel2.HorizontalAlignment = Element.ALIGN_CENTER;
                cel3.HorizontalAlignment = Element.ALIGN_CENTER;
                cel4.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

                tabla1.WidthPercentage = 40;
                tabla1.HorizontalAlignment = Element.ALIGN_LEFT;
                tabla1.AddCell(cel1);
                tabla1.AddCell(cel2);
                tabla1.AddCell(cel3);
                tabla1.AddCell(cel4);

                tabla1.SpacingAfter = 20;
                tabla1.SpacingBefore = 50;
                doc.Add(tabla1);

                //Cliente;

                tabla1 = new PdfPTable(1);

                cel3 = new PdfPCell(new Phrase("\n\nDNI: "+ cliente.getDni(), f_15_bold));
                cel2 = new PdfPCell(new Phrase("\n\nCliente "+ cliente.getNombre() +' '+cliente.getApellidos(), f_15_bold));

                cel1.HorizontalAlignment = Element.ALIGN_CENTER;
                cel2.HorizontalAlignment = Element.ALIGN_CENTER;

                cel1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                cel2.Border = iTextSharp.text.Rectangle.NO_BORDER;

                tabla1.AddCell(cel1);
                tabla1.AddCell(cel2);

                tabla1.SpacingAfter = 20;
                tabla1.SpacingBefore = 50;

                PdfPTable tabla2 = new PdfPTable(1);
                tabla2.AddCell(tabla1);
                tabla2.HorizontalAlignment = Element.ALIGN_RIGHT;
                tabla2.WidthPercentage = 40;
                doc.Add(tabla2);

                Paragraph parrafo = new Paragraph(new Phrase("Fecha: " + DateTime.Today.ToString("d") + "\n", f_12_normal));
                parrafo.Add(new Phrase("Segunda frase \n\n"));
                parrafo.Add(new Phrase("Factura num: \n\n"));
                parrafo.Alignment = Element.ALIGN_JUSTIFIED;
                doc.Add(parrafo);


                doc.Close();
                //Abrimos el documento automaticamente
                System.Diagnostics.Process.Start(@"c:/Reportes/FormularioAlta" + cliente.getDni() + ".pdf");
            }
        }

    }
}
