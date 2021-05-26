//Diomedes Alexander Vallejo Perez
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Prueba.Modelo;


namespace Prueba
{
    public partial class Add : Form
    {
        int estado=1;
        public int IDmodificar;
        public string sonido;
        public string foto;
        private string jsonDB = Path.Combine(Application.StartupPath.Replace(@"\bin\Debug",""), @"DB\dbContexto.json");
        public bool MOdificar;
        int posicion = 1;

        public Add(bool Modificar)
        {
            InitializeComponent();
            MOdificar = Modificar;
            interactuar();
         

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void interactuar()
        {
            var v = true;
            var f = false;
            switch (posicion)
            {
                case 1:
                    TXTnombre.Visible = true;
                    LBLnombre.Visible = true;
                    TXTfamilia.Visible = f;
                    LBLfamilia.Visible = f;
                    break;
                case 2:
                    TXTnombre.Visible = f;
                    LBLnombre.Visible = f;
                    TXTfamilia.Visible = true;
                    LBLfamilia.Visible = true;
                    TXTlugar.Visible = f;
                    LBLlugar.Visible = f;
                    break;
                case 3:
                    TXTnombre.Visible = f;
                    LBLnombre.Visible = f;
                    TXTfamilia.Visible = f;
                    LBLfamilia.Visible = f;
                    TXTlugar.Visible = true;
                    LBLlugar.Visible = true;
                    LBLpiel.Visible = f;
                    TXTpiel.Visible = f;
                    break;
                case 4:
                    TXTnombre.Visible = f;
                    LBLnombre.Visible = f;
                    TXTfamilia.Visible = f;
                    LBLfamilia.Visible = f;
                    TXTlugar.Visible = f;
                    LBLlugar.Visible = f;
                    LBLpiel.Visible = true;
                    TXTpiel.Visible = true;
                    TXTojos.Visible = f;
                    LBLcolor.Visible = f;
                    break;
                case 5:
                    TXTnombre.Visible = f;
                    LBLnombre.Visible = f;
                    TXTfamilia.Visible = f;
                    LBLfamilia.Visible = f;
                    TXTlugar.Visible = f;
                    LBLlugar.Visible = f;
                    LBLpiel.Visible = f;
                    TXTpiel.Visible = f;
                    TXTojos.Visible = true;
                    LBLcolor.Visible = true;
                    TXTreproduccion.Visible = f;
                    LBLreproduccion.Visible = f;
                    break;
                case 6:
                    TXTnombre.Visible = f;
                    LBLnombre.Visible = f;
                    TXTfamilia.Visible = f;
                    LBLfamilia.Visible = f;
                    TXTlugar.Visible = f;
                    LBLlugar.Visible = f;
                    LBLpiel.Visible = f;
                    TXTpiel.Visible = f;
                    TXTojos.Visible = f;
                    LBLcolor.Visible = f;
                    TXTreproduccion.Visible = true;
                    LBLreproduccion.Visible = true;
                    Foto.Visible = f;
                    btnImagen.Visible = f;
                    break;
                case 7:
                    TXTreproduccion.Visible = f;
                    LBLreproduccion.Visible = f;
                    Foto.Visible = true;
                    btnImagen.Visible = true;
                    agregar.Visible = f;
                    break;
                case 8:
                    Foto.Visible = f;
                    btnImagen.Visible = f;
                    CargarSonido.Visible = true;
                    SonidoPlay.Visible = true;
                    agregar.Visible = f;
                    BTNModificar.Visible = f;
                    break;
                case 9:
                    if (MOdificar == true)
                    {
                        BTNModificar.Visible = true;
                        CargarSonido.Visible = f;
                        SonidoPlay.Visible = f;
                    }
                    else
                    {
                        agregar.Visible = v;
                        CargarSonido.Visible = f;
                        SonidoPlay.Visible = f;
                    }
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adelante();
        }

        private void button2_Click(object sender, EventArgs e)
        { if (posicion < 2)
            {
                posicion = 1;
            }
            else
            {
                posicion--;
                interactuar();
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            add();
            SoundPlayer correcto = new SoundPlayer(Path.Combine(Application.StartupPath.Replace(@"\bin\Debug", ""), @"Sonidos\respuestaC.wav"));
            correcto.Play();
            MessageBox.Show("Nuevo integrante ha sido añadido","En hora buena!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();
            correcto.Stop();
        }
        public JArray GetData()
        {
            var db = File.ReadAllText(jsonDB);
            var jsonOBJ = JObject.Parse(db);

            return jsonOBJ.GetValue("DB") as JArray;
        }
        private void add()
        {
            var lista = GetData();
            var db = File.ReadAllText(jsonDB);
            var jsonOBJ = JObject.Parse(db);
            int ID;

           if (lista.Count != 0)
                {
                    var ultimoID = lista.Last();
                    var findLastId = Convert.ToInt32(ultimoID.First().Last());
                    ID = findLastId + 1;
                }
                else
                {
                    ID = 1;
                }
            if (foto == "" | foto == null) { foto = Path.Combine(Application.StartupPath.Replace(@"\bin\Debug", ""), @"Imagenes\index.jpg"); }
                if (sonido == "" | sonido == null) { sonido = Path.Combine(Application.StartupPath.Replace(@"\bin\Debug", ""), @"Sonidos\Error.wav"); }
                var registro = "{ 'id': " + ID + ", 'Nombre': '" + TXTnombre.Text + "', 'Color_de_ojos': '" + TXTojos.Text + "','Color_de_piel': '" + TXTpiel.Text + "','Habitat': '" + TXTlugar.Text + "','Familia_animal': '" + TXTfamilia.Text + "','Reproduccion': '" + TXTreproduccion.Text + "','Imagen':'" + foto.Replace("\\", "/") + "','Sonido':'" + sonido.Replace("\\", "/") + "' }";

                var nuevoRegistro = JObject.Parse(registro);
                lista.Add(nuevoRegistro);


                jsonOBJ["DB"] = lista;

                var newData = JsonConvert.SerializeObject(jsonOBJ, Formatting.Indented);
                File.WriteAllText(jsonDB, newData);
          


        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Archivo Jpg(*.jpg)|*.jpg|Archivo Png (*.png)|*.png";

            if (archivo.ShowDialog() == DialogResult.OK) { try { Foto.Load(archivo.FileName); foto = archivo.FileName; } catch { MessageBox.Show("Error en el archivo selecionado, seleccione otro archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); } }
        }

        private void Sonido_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Archivo Wav(*.wav)|*.wav";

            if (archivo.ShowDialog() == DialogResult.OK) { try { sonido = archivo.FileName; } catch { MessageBox.Show("Error en el archivo selecionado, seleccione otro archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);sonido = Path.Combine(Application.StartupPath.Replace(@"\bin\Debug", ""), @"Sonidos\Error.wav"); } }

        }

        private void SonidoPlay_Click(object sender, EventArgs e)
        {
            Sonido(sonido, estado);
            if (estado == 1)
            {
                estado = 0;
            }
            else
            {
                estado = 1;
            }
        }
        public void Sonido(string sonido, int estado)
        {
            if (sonido == null | sonido == "") {
                sonido = Path.Combine(Application.StartupPath.Replace(@"\bin\Debug", ""), @"Sonidos\Error.wav");
                SoundPlayer simpleSound = new SoundPlayer(sonido);
                simpleSound.Play();
                MessageBox.Show("Para reproducir un sonido, debe cargar un archivo.", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              
            }
            else
            {
                SoundPlayer simpleSound = new SoundPlayer(sonido);
                //Ejemplo del sonido
                if (estado == 1)
                {
                    estado = 0;
                    simpleSound.Play();
                   
                }
                else
                {

      
                        estado = 1;
                        simpleSound.Stop();

                   
                }

            }

        }

        private void BTNModificar_Click(object sender, EventArgs e)
        {

            var lista = GetData();
            var db = File.ReadAllText(jsonDB);
            var jsonOBJ = JObject.Parse(db);
            JArray data = (JArray)jsonOBJ["DB"];
            int ID;

            if (lista.Count != 0)
            {
                var ultimoID = lista.Last();
                var findLastId = Convert.ToInt32(ultimoID.First().Last());
                ID = findLastId;
            }
            else
            {
                ID = 1;
            }
            
            
            var registro = "{ 'id': " + IDmodificar + ", 'Nombre': '" + TXTnombre.Text + "', 'Color_de_ojos': '" + TXTojos.Text + "','Color_de_piel': '" + TXTpiel.Text + "','Habitat': '" + TXTlugar.Text + "','Familia_animal': '" + TXTfamilia.Text + "','Reproduccion': '" + TXTreproduccion.Text + "','Imagen':'" + foto.Replace("\\", "/") + "','Sonido':'" + sonido.Replace("\\", "/") + "' }";


            foreach (var Animal in data.Where(obj => obj["id"].Value<int>() == IDmodificar))
            {
                Animal["Nombre"] = !string.IsNullOrEmpty(TXTnombre.Text) ? TXTnombre.Text : "";
                Animal["Color_de_ojos"] = !string.IsNullOrEmpty(TXTnombre.Text) ? TXTojos.Text : "";
                Animal["Color_de_piel"] = !string.IsNullOrEmpty(TXTnombre.Text) ? TXTpiel.Text : "";
                Animal["Habitat"] = !string.IsNullOrEmpty(TXTnombre.Text) ? TXTlugar.Text : "";
                Animal["Familia_animal"] = !string.IsNullOrEmpty(TXTnombre.Text) ? TXTfamilia.Text : "";
                Animal["Reproduccion"] = !string.IsNullOrEmpty(TXTnombre.Text) ? TXTreproduccion.Text : "";
                Animal["Imagen"] = !string.IsNullOrEmpty(TXTnombre.Text) ? foto.Replace("\\", "/") : "";
                Animal["Sonido"] = !string.IsNullOrEmpty(TXTnombre.Text) ? sonido.Replace("\\", "/") : "";
            }

            jsonOBJ["DB"] = data;
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonOBJ, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(jsonDB, output);


            var nuevoRegistro = JObject.Parse(registro);
            lista.Add(nuevoRegistro);


            jsonOBJ["DB"] = lista;

            SoundPlayer correcto = new SoundPlayer(Path.Combine(Application.StartupPath.Replace(@"\bin\Debug", ""), @"Sonidos\respuestaC.wav"));
            correcto.Play();
            MessageBox.Show("Los datos del integrante han sido modificados", "En hora buena!", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Close();
            correcto.Stop();




        }
        private void adelante()
        {
            if (posicion < 9)
            {
                posicion++;
                interactuar();
            }
            else
            {
                posicion = 9;
            }
        }

        private void TXTreproduccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                adelante();
            }
        }

        private void TXTfamilia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                adelante();
                TXTlugar.Focus();
            }
        }

        private void TXTpiel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                adelante();
                TXTojos.Focus();
            }
        }

        private void TXTojos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                adelante();
                TXTreproduccion.Focus();
            }
        }

        private void TXTnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                adelante();
                TXTfamilia.Focus();
            }
        }

        private void TXTlugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                adelante();
                TXTpiel.Focus();
            }
        }
    }
}
