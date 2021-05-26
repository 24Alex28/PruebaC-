//Diomedes Alexander Vallejo Perez
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using Prueba.Modelo;

namespace Prueba
{
    public partial class Form1 : Form
    {
        Animales animal = new Animales();
        private string jsonDB = Path.Combine(Application.StartupPath.Replace(@"\bin\Debug", ""), @"DB\dbContexto.json");

        public Form1()
        {
            InitializeComponent();
            CargarRegistros();
        }

        private JArray GetData()
        {
            var db = File.ReadAllText(jsonDB);
            var jsonOBJ = JObject.Parse(db);

            return jsonOBJ.GetValue("DB") as JArray;
        }

        private void CargarRegistros()
        {
            if (GetData().Count > 0)
            {
                dataGridView1.DataSource = GetData();
                dataGridView1.Columns["Imagen"].Visible = false;
                dataGridView1.Columns["Sonido"].Visible = false;
                dataGridView1.Columns["Color_de_ojos"].HeaderText = "Ojos";
                dataGridView1.Columns["Color_de_piel"].HeaderText = "Piel";
                dataGridView1.Columns["Familia_animal"].HeaderText = "Familia";
                dataGridView1.Columns["Familia_animal"].HeaderText = "Familia";


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add add = new Add(false);
            add.Foto.Load(Path.Combine(Application.StartupPath.Replace(@"\bin\Debug", ""), @"Imagenes\index.jpg"));
            add.ShowDialog();
           CargarRegistros();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea regalar a este integrante?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                var db = File.ReadAllText(jsonDB);
                var jsonOBJ = JObject.Parse(db);
                if (textBox1.Text == "") {  CargarRegistros(); }
                else
                {
                    JArray Granja = (JArray)jsonOBJ["DB"];
                    var FiltroAnimal = Granja.FirstOrDefault(obj => obj["id"].Value<string>() == Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value));
                    Granja.Remove(FiltroAnimal);

                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonOBJ, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(jsonDB, output);
                    dataGridView1.DataSource = Granja;
                   
                }
                
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { CargarRegistros();
            }
            else
            {
                var db = File.ReadAllText(jsonDB);
                var jsonOBJ = JObject.Parse(db);

                JArray detalles = new JArray();

                var FiltroAnimal = GetData().Where(obj => obj["Nombre"].Value<string>().StartsWith( textBox1.Text)).ToList();
                detalles.Add(FiltroAnimal);

                dataGridView1.DataSource = detalles;
                if (detalles.Count>0)
                {
                    dataGridView1.Columns["Imagen"].Visible = false;
                    dataGridView1.Columns["Sonido"].Visible = false;
                }
             
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                Add Animal = new Add(true);
                Recolectar();
                Animal.IDmodificar = animal.id;
                Animal.TXTnombre.Text = animal.Nombre;
                Animal.TXTfamilia.Text = animal.Familia_animal;
                Animal.TXTlugar.Text = animal.Habitat;
                Animal.TXTreproduccion.Text = animal.Reproduccion;
                Animal.TXTpiel.Text = animal.Color_de_piel;
                Animal.TXTojos.Text = animal.Color_de_ojos;
                Animal.foto = animal.Imagen;
                Animal.Foto.Load(animal.Imagen);
                Animal.sonido = animal.Sonido;
                Animal.Titulo.Text = "MODIFICAR";
                Animal.Titulo.Location = new Point(150, 88);
                Animal.ShowDialog();
                CargarRegistros();
                Animal.Titulo.Text = "ÄÑADIR";
            
          

        }
        public void visualizar()
        {
           
            Visual vista_de_datos = new Visual(animal.Sonido);

            vista_de_datos.LBLNombrelbl.Text = animal.Nombre;
            vista_de_datos.Lblhabitatlbl.Text = animal.Habitat;

            vista_de_datos.LblColorojoslbl.Text = animal.Color_de_ojos;
            vista_de_datos.LBLcolorpiellbl.Text = animal.Color_de_piel;

            vista_de_datos.LBLFamilialbl.Text = animal.Familia_animal;

            vista_de_datos.LBLreproduccionlbl.Text = animal.Reproduccion;
            vista_de_datos.Imagen.Load(animal.Imagen);
            vista_de_datos.Imagen.SizeMode = PictureBoxSizeMode.StretchImage;

            vista_de_datos.ShowDialog();
        }
        public void Recolectar()
        {
            animal.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
            animal.Nombre = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            animal.Habitat = dataGridView1.CurrentRow.Cells["Habitat"].Value.ToString();

            animal.Color_de_ojos = dataGridView1.CurrentRow.Cells["Color_de_ojos"].Value.ToString();
            animal.Color_de_piel = dataGridView1.CurrentRow.Cells["Color_de_piel"].Value.ToString();

            animal.Familia_animal = dataGridView1.CurrentRow.Cells["Familia_animal"].Value.ToString();

            animal.Reproduccion = dataGridView1.CurrentRow.Cells["Reproduccion"].Value.ToString();
            animal.Imagen = dataGridView1.CurrentRow.Cells["Imagen"].Value.ToString();
           
            animal.Sonido = dataGridView1.CurrentRow.Cells["Sonido"].Value.ToString();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Visual vista_de_datos = new Visual(dataGridView1.CurrentRow.Cells["Sonido"].Value.ToString());
            Recolectar();
            vista_de_datos.Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            visualizar();
        }

    }
}
