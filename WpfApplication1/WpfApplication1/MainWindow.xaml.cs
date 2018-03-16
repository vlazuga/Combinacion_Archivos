using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics; //Para el path
using System.Windows.Forms;
using System.IO;
 


namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string pathArchivo1;
        string pathDestino1;
        string nombreArchivo1;

        string pathArchivo2;
        string pathDestino2;
        string nombreArchivo2;

        string pathArchivo3;
        string pathDestino3;
        string nombreArchivo3;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        //Bloquear texbox para que no se pueda escribir
        //Validar que sean PDF, TXT Y RTF ó DOC, Campo 1 - pdf, campo 2 - txt, campo 3 - Doc Y que sean 3 archivos forzósamente.
        //Crear repo y subir este codigo
        //hacer cambios en el local y subirlo nuevamente
        //Respalda
        //Mandar liga del repo al patron

    //Para archivo 1
        private void botonArchivo1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog findFile1 = new OpenFileDialog();

            findFile1.Filter = "PDF Files (*.pdf)| *.pdf"; //filtrar tipo de archivo (*.pdf)
            if (findFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                texboxArchivo1.Text = findFile1.FileName;
                pathArchivo1 = texboxArchivo1.Text;
                nombreArchivo1 = System.IO.Path.GetFileName(pathArchivo1);
                
            }

        }

        //Para archivo 2
        private void botonArchivo2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog findFile2 = new OpenFileDialog();

            findFile2.Filter = "TXT Files (*.docx)| *.txt"; //filtrar tipo de archivo (*.txt)
            if (findFile2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                texboxArchivo2.Text = findFile2.FileName;
                pathArchivo2 = texboxArchivo2.Text;
                nombreArchivo2 = System.IO.Path.GetFileName(pathArchivo2);

            }

        }

        //Para archivo 3
        private void botonArchivo3_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog findFile3 = new OpenFileDialog();

            findFile3.Filter = "Word Files (*.docx)| *.docx"; //filtrar tipo de archivo (*.docx)
            if (findFile3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                texboxArchivo3.Text = findFile3.FileName;
                pathArchivo3 = texboxArchivo3.Text;
                nombreArchivo3 = System.IO.Path.GetFileName(pathArchivo3);

            }

        }

        private void botonDestino1_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog findFolder1 = new FolderBrowserDialog();

            if (findFolder1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                texboxDestino1.Text = findFolder1.SelectedPath;
                pathDestino1 = texboxDestino1.Text + "\\" + nombreArchivo1;
                pathDestino2 = texboxDestino1.Text + "\\" + nombreArchivo2;
                pathDestino3 = texboxDestino1.Text + "\\" + nombreArchivo3;
            }
        }

         private void botonMover1_Click(object sender, RoutedEventArgs e)
        {
            
                 if (texboxArchivo1.Text == "" || texboxArchivo2.Text == "" || texboxArchivo3.Text == "")
                 {
                     System.Windows.Forms.MessageBox.Show("Falto seleccionar archivo(s) a mover");
                 }
                 else if (texboxDestino1.Text == "")
                 {
                     System.Windows.Forms.MessageBox.Show("Falto seleccionar el destino de los archivos a mover");
                 }
                 else { 
             //try
                File.Move(pathArchivo1, pathDestino1);
                File.Move(pathArchivo2, pathDestino2);
                File.Move(pathArchivo3, pathDestino3);


                System.Windows.Forms.MessageBox.Show("Se han movido los archivos" + " a " + texboxDestino1.Text);
                texboxDestino1.Text = "";
                texboxArchivo1.Text = "";
                texboxArchivo2.Text = "";
                texboxArchivo3.Text = "";
                 }

             //catch
             //pruebas con folder en el que no se tenga acceso para moverlo


            
        }


    

         /*private void botonDestino2_Click(object sender, RoutedEventArgs e)
         {
             FolderBrowserDialog findFolder2 = new FolderBrowserDialog();
             
             if (findFolder2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
             {
                 texboxDestino2.Text = findFolder2.SelectedPath;
                 pathDestino2 = texboxDestino2.Text + "\\" + nombreArchivo2;
             }
         }

         private void botonMover2_Click(object sender, RoutedEventArgs e)
         {
             File.Move(pathArchivo2, pathDestino2);

             System.Windows.Forms.MessageBox.Show("Se ha movido el archivo de " + pathArchivo2 + " a " + pathDestino2);
             texboxDestino2.Text = "";
             texboxArchivo2.Text = "";
         }
        */


      

         /*
          private void botonDestino3_Click(object sender, RoutedEventArgs e)
          {
              FolderBrowserDialog findFolder3 = new FolderBrowserDialog();

              if (findFolder3.ShowDialog() == System.Windows.Forms.DialogResult.OK)
              {
                  texboxDestino3.Text = findFolder3.SelectedPath;
                  pathDestino3 = texboxDestino3.Text + "\\" + nombreArchivo3;
              }
          }


          private void botonMover3_Click(object sender, RoutedEventArgs e)
          {
              File.Move(pathArchivo3, pathDestino3);

              System.Windows.Forms.MessageBox.Show("Se ha movido el archivo de " + pathArchivo3 + " a " + pathDestino3);
              texboxDestino3.Text = "";
              texboxArchivo3.Text = "";
          }
           */






        private void botonSalir_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        










        private void texboxArchivo1_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void texboxDestino1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}
