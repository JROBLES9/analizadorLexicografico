using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace analizadorLexicografico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Analizador Lexicográfico KeithJos";
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filtrar por tipos de archivo (puedes ajustar esto según tus necesidades)
            openFileDialog.Filter = "Archivos Lua (*.lua)|*.lua";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                lblRutaArchivo.Text = rutaArchivo;
            }
        }

        private void btnMostarReporte1_Click(object sender, EventArgs e)
        {
            string rutaArchivo = lblRutaArchivo.Text;

            if (!string.IsNullOrEmpty(rutaArchivo))
            {
                string rutaExterna = "..\\..\\programa.exe";

                // Preparar el proceso para ejecutar el archivo externo y redirigir la salida estándar
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = rutaExterna;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardInput = true;
                startInfo.CreateNoWindow = true; // Evitar que se muestre la ventana de la consola

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    using (StreamWriter writer = process.StandardInput)
                    {
                        if (writer.BaseStream.CanWrite)
                        {
                            // Leer el contenido del archivo y escribirlo en la entrada estándar del proceso
                            string contenidoArchivo = File.ReadAllText(rutaArchivo);
                            writer.WriteLine(contenidoArchivo);
                        }
                    }

                    // Leer la salida estándar del proceso externo
                    string resultado = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    // Crear y escribir en el archivo PDF
                    string rutaArchivoPDF = "resultado.pdf"; // Ruta del archivo PDF
                    using (FileStream fs = new FileStream(rutaArchivoPDF, FileMode.Create))
                    {
                        Document doc = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                        doc.Open();
                        doc.Add(new Paragraph(resultado));
                        doc.Close();
                    }

                    // Abrir el archivo PDF automáticamente
                    Process.Start(rutaArchivoPDF);
                }
            }
            else
            {
                MessageBox.Show("Por favor, carga un archivo primero.");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarReporte2_Click(object sender, EventArgs e)
        {
            string rutaArchivo = lblRutaArchivo.Text;

            if (!string.IsNullOrEmpty(rutaArchivo))
            {
                string rutaExterna = "..\\..\\programa2.exe"; // Reemplaza con la ruta correcta

                // Preparar el proceso para ejecutar el archivo externo y redirigir la salida estándar
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = rutaExterna;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardInput = true;
                startInfo.CreateNoWindow = true; // Evitar que se muestre la ventana de la consola

                using (Process process = new Process())
                {
                    process.StartInfo = startInfo;
                    process.Start();

                    using (StreamWriter writer = process.StandardInput)
                    {
                        if (writer.BaseStream.CanWrite)
                        {
                            // Leer el contenido del archivo y escribirlo en la entrada estándar del proceso
                            string contenidoArchivo = File.ReadAllText(rutaArchivo);
                            writer.WriteLine(contenidoArchivo);
                        }
                    }

                    // Leer la salida estándar del proceso externo
                    string resultado = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    // Crear y escribir en el archivo PDF
                    string rutaArchivoPDF = "resultado2.pdf"; // Ruta del archivo PDF
                    using (FileStream fs = new FileStream(rutaArchivoPDF, FileMode.Create))
                    {
                        Document doc = new Document();
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                        doc.Open();
                        doc.Add(new Paragraph(resultado));
                        doc.Close();
                    }

                    // Abrir el archivo PDF automáticamente
                    Process.Start(rutaArchivoPDF);
                }
            }
            else
            {
                MessageBox.Show("Por favor, carga un archivo primero.");
            }
        }
    }
}
