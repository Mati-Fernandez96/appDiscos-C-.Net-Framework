using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using datos;
using System.IO;
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class frmAltaDisco : Form
    {
        private Disco disco = null;
        private OpenFileDialog archivo = null; 
        public frmAltaDisco()
        {
            InitializeComponent();
        }

        public frmAltaDisco(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar Disco"; 
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            DiscoDatos Dato = new DiscoDatos();

            try
            {
                if(disco  == null)
                {
                    disco = new Disco();
                }
                string text = txtTitulo.Text;
                disco.Titulo = text;
                disco.FechaLanzamiento = DateTime.Parse(dtpFechaLanz.Text); 
                disco.CantidadCanciones = int.Parse(nudCantCanciones.Text);
                disco.UrlImagen = txtUrlImagen.Text;
                disco.TiposEdicion = (TiposEdicion)cbEdicion.SelectedItem;
                disco.Genero = (Estilo)cbGenero.SelectedItem;
                    
                if (disco.Id != 0)
                {
                    Dato.modificar(disco);
                    MessageBox.Show("Modificado con exto");
                }
                else
                {
                    Dato.agregar(disco);
                    MessageBox.Show("Agregado con exito");
                }

                //Guardo imagen si la levanto localmente
                if(archivo != null  && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["carpetaImagen"] + archivo.SafeFileName);
                }

                Close();    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
            EstiloDatos nuevoTipo = new EstiloDatos();
            EdicionDatos nuevoEdicion = new EdicionDatos();
            try
            {
                cbEdicion.DataSource = nuevoEdicion.listar();
                cbEdicion.ValueMember = "id";
                cbEdicion.DisplayMember = "tipoEdicion";
                cbGenero.DataSource = nuevoTipo.listar();
                cbGenero.ValueMember = "Id";
                cbGenero.DisplayMember = "genero"; 

                if(disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    dtpFechaLanz.Text = disco.FechaLanzamiento.ToString();
                    nudCantCanciones.Text = disco.CantidadCanciones.ToString();                 
                    txtUrlImagen.Text = disco.UrlImagen;
                    cargarImagen(disco.UrlImagen);
                    cbGenero.SelectedValue = disco.Genero.Id;
                    cbEdicion.SelectedValue = disco.TiposEdicion.id; 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbDisco.Load(imagen);

            }
            catch (Exception ex)
            {

                pbDisco.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;| png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //guardar la imagen
                //
            }
        }
    }
}
