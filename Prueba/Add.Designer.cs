namespace Prueba
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTNModificar = new System.Windows.Forms.Button();
            this.CargarSonido = new System.Windows.Forms.Button();
            this.SonidoPlay = new System.Windows.Forms.Button();
            this.btnImagen = new System.Windows.Forms.Button();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.agregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Titulo = new System.Windows.Forms.Label();
            this.TXTreproduccion = new System.Windows.Forms.TextBox();
            this.TXTfamilia = new System.Windows.Forms.TextBox();
            this.TXTlugar = new System.Windows.Forms.TextBox();
            this.TXTpiel = new System.Windows.Forms.TextBox();
            this.TXTojos = new System.Windows.Forms.TextBox();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.LBLreproduccion = new System.Windows.Forms.Label();
            this.LBLfamilia = new System.Windows.Forms.Label();
            this.LBLlugar = new System.Windows.Forms.Label();
            this.LBLpiel = new System.Windows.Forms.Label();
            this.LBLcolor = new System.Windows.Forms.Label();
            this.LBLnombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BTNModificar);
            this.panel1.Controls.Add(this.CargarSonido);
            this.panel1.Controls.Add(this.SonidoPlay);
            this.panel1.Controls.Add(this.btnImagen);
            this.panel1.Controls.Add(this.Foto);
            this.panel1.Controls.Add(this.agregar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Titulo);
            this.panel1.Controls.Add(this.TXTreproduccion);
            this.panel1.Controls.Add(this.TXTfamilia);
            this.panel1.Controls.Add(this.TXTlugar);
            this.panel1.Controls.Add(this.TXTpiel);
            this.panel1.Controls.Add(this.TXTojos);
            this.panel1.Controls.Add(this.TXTnombre);
            this.panel1.Controls.Add(this.LBLreproduccion);
            this.panel1.Controls.Add(this.LBLfamilia);
            this.panel1.Controls.Add(this.LBLlugar);
            this.panel1.Controls.Add(this.LBLpiel);
            this.panel1.Controls.Add(this.LBLcolor);
            this.panel1.Controls.Add(this.LBLnombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BTNModificar
            // 
            this.BTNModificar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BTNModificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BTNModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNModificar.Location = new System.Drawing.Point(307, 227);
            this.BTNModificar.Name = "BTNModificar";
            this.BTNModificar.Size = new System.Drawing.Size(132, 54);
            this.BTNModificar.TabIndex = 21;
            this.BTNModificar.Text = "Modificar";
            this.BTNModificar.UseVisualStyleBackColor = false;
            this.BTNModificar.Visible = false;
            this.BTNModificar.Click += new System.EventHandler(this.BTNModificar_Click);
            // 
            // CargarSonido
            // 
            this.CargarSonido.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CargarSonido.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CargarSonido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CargarSonido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarSonido.Location = new System.Drawing.Point(413, 263);
            this.CargarSonido.Name = "CargarSonido";
            this.CargarSonido.Size = new System.Drawing.Size(154, 54);
            this.CargarSonido.TabIndex = 20;
            this.CargarSonido.Text = "Cargar sonido";
            this.CargarSonido.UseVisualStyleBackColor = false;
            this.CargarSonido.Visible = false;
            this.CargarSonido.Click += new System.EventHandler(this.Sonido_Click);
            // 
            // SonidoPlay
            // 
            this.SonidoPlay.BackColor = System.Drawing.Color.Transparent;
            this.SonidoPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SonidoPlay.BackgroundImage")));
            this.SonidoPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SonidoPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SonidoPlay.Location = new System.Drawing.Point(284, 255);
            this.SonidoPlay.Name = "SonidoPlay";
            this.SonidoPlay.Size = new System.Drawing.Size(92, 77);
            this.SonidoPlay.TabIndex = 19;
            this.SonidoPlay.UseVisualStyleBackColor = false;
            this.SonidoPlay.Visible = false;
            this.SonidoPlay.Click += new System.EventHandler(this.SonidoPlay_Click);
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnImagen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.Location = new System.Drawing.Point(413, 263);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(154, 54);
            this.btnImagen.TabIndex = 17;
            this.btnImagen.Text = "Cargar Imagen";
            this.btnImagen.UseVisualStyleBackColor = false;
            this.btnImagen.Visible = false;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // Foto
            // 
            this.Foto.Location = new System.Drawing.Point(228, 206);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(179, 195);
            this.Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Foto.TabIndex = 16;
            this.Foto.TabStop = false;
            this.Foto.Visible = false;
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.agregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.Location = new System.Drawing.Point(307, 227);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(132, 54);
            this.agregar.TabIndex = 15;
            this.agregar.Text = "Añadir";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Visible = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 92);
            this.button2.TabIndex = 14;
            this.button2.Text = "Anterior";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(620, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 92);
            this.button1.TabIndex = 13;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.AliceBlue;
            this.Titulo.Font = new System.Drawing.Font("Segoe Script", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Black;
            this.Titulo.Location = new System.Drawing.Point(239, 88);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(313, 98);
            this.Titulo.TabIndex = 12;
            this.Titulo.Text = "AÑADIR";
            // 
            // TXTreproduccion
            // 
            this.TXTreproduccion.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTreproduccion.Location = new System.Drawing.Point(353, 229);
            this.TXTreproduccion.Name = "TXTreproduccion";
            this.TXTreproduccion.Size = new System.Drawing.Size(260, 48);
            this.TXTreproduccion.TabIndex = 11;
            this.TXTreproduccion.Visible = false;
            this.TXTreproduccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTreproduccion_KeyPress);
            // 
            // TXTfamilia
            // 
            this.TXTfamilia.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTfamilia.Location = new System.Drawing.Point(353, 227);
            this.TXTfamilia.Name = "TXTfamilia";
            this.TXTfamilia.Size = new System.Drawing.Size(260, 52);
            this.TXTfamilia.TabIndex = 10;
            this.TXTfamilia.Visible = false;
            this.TXTfamilia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTfamilia_KeyPress);
            // 
            // TXTlugar
            // 
            this.TXTlugar.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTlugar.Location = new System.Drawing.Point(353, 226);
            this.TXTlugar.Name = "TXTlugar";
            this.TXTlugar.Size = new System.Drawing.Size(260, 48);
            this.TXTlugar.TabIndex = 9;
            this.TXTlugar.Visible = false;
            this.TXTlugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTlugar_KeyPress);
            // 
            // TXTpiel
            // 
            this.TXTpiel.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTpiel.Location = new System.Drawing.Point(353, 226);
            this.TXTpiel.Name = "TXTpiel";
            this.TXTpiel.Size = new System.Drawing.Size(260, 52);
            this.TXTpiel.TabIndex = 8;
            this.TXTpiel.Visible = false;
            this.TXTpiel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTpiel_KeyPress);
            // 
            // TXTojos
            // 
            this.TXTojos.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTojos.Location = new System.Drawing.Point(353, 226);
            this.TXTojos.Name = "TXTojos";
            this.TXTojos.Size = new System.Drawing.Size(260, 52);
            this.TXTojos.TabIndex = 7;
            this.TXTojos.Visible = false;
            this.TXTojos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTojos_KeyPress);
            // 
            // TXTnombre
            // 
            this.TXTnombre.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTnombre.Location = new System.Drawing.Point(353, 227);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(260, 52);
            this.TXTnombre.TabIndex = 6;
            this.TXTnombre.Visible = false;
            this.TXTnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTnombre_KeyPress);
            // 
            // LBLreproduccion
            // 
            this.LBLreproduccion.AutoSize = true;
            this.LBLreproduccion.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLreproduccion.Location = new System.Drawing.Point(17, 230);
            this.LBLreproduccion.Name = "LBLreproduccion";
            this.LBLreproduccion.Size = new System.Drawing.Size(330, 44);
            this.LBLreproduccion.TabIndex = 5;
            this.LBLreproduccion.Text = "Manera de reproduccion";
            this.LBLreproduccion.Visible = false;
            // 
            // LBLfamilia
            // 
            this.LBLfamilia.AutoSize = true;
            this.LBLfamilia.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLfamilia.Location = new System.Drawing.Point(140, 230);
            this.LBLfamilia.Name = "LBLfamilia";
            this.LBLfamilia.Size = new System.Drawing.Size(207, 44);
            this.LBLfamilia.TabIndex = 4;
            this.LBLfamilia.Text = "Familia animal";
            this.LBLfamilia.Visible = false;
            // 
            // LBLlugar
            // 
            this.LBLlugar.AutoSize = true;
            this.LBLlugar.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLlugar.Location = new System.Drawing.Point(49, 230);
            this.LBLlugar.Name = "LBLlugar";
            this.LBLlugar.Size = new System.Drawing.Size(298, 44);
            this.LBLlugar.TabIndex = 3;
            this.LBLlugar.Text = "Donde puede ser visto";
            this.LBLlugar.Visible = false;
            // 
            // LBLpiel
            // 
            this.LBLpiel.AutoSize = true;
            this.LBLpiel.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLpiel.Location = new System.Drawing.Point(170, 230);
            this.LBLpiel.Name = "LBLpiel";
            this.LBLpiel.Size = new System.Drawing.Size(177, 44);
            this.LBLpiel.TabIndex = 2;
            this.LBLpiel.Text = "Color de piel";
            this.LBLpiel.Visible = false;
            // 
            // LBLcolor
            // 
            this.LBLcolor.AutoSize = true;
            this.LBLcolor.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLcolor.Location = new System.Drawing.Point(159, 230);
            this.LBLcolor.Name = "LBLcolor";
            this.LBLcolor.Size = new System.Drawing.Size(188, 44);
            this.LBLcolor.TabIndex = 1;
            this.LBLcolor.Text = "Color de ojos:";
            this.LBLcolor.Visible = false;
            // 
            // LBLnombre
            // 
            this.LBLnombre.AutoSize = true;
            this.LBLnombre.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLnombre.Location = new System.Drawing.Point(220, 230);
            this.LBLnombre.Name = "LBLnombre";
            this.LBLnombre.Size = new System.Drawing.Size(127, 43);
            this.LBLnombre.TabIndex = 0;
            this.LBLnombre.Text = "Nombre:";
            this.LBLnombre.Visible = false;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox TXTreproduccion;
        public System.Windows.Forms.TextBox TXTfamilia;
        public System.Windows.Forms.TextBox TXTlugar;
        public System.Windows.Forms.TextBox TXTpiel;
        public System.Windows.Forms.TextBox TXTojos;
        public System.Windows.Forms.TextBox TXTnombre;
        public System.Windows.Forms.Label LBLreproduccion;
        public System.Windows.Forms.Label LBLfamilia;
        public System.Windows.Forms.Label LBLlugar;
        public System.Windows.Forms.Label LBLpiel;
        public System.Windows.Forms.Label LBLcolor;
        public System.Windows.Forms.Label LBLnombre;
        public System.Windows.Forms.Button agregar;
        public System.Windows.Forms.Button btnImagen;
        public System.Windows.Forms.PictureBox Foto;
        public System.Windows.Forms.Button CargarSonido;
        public System.Windows.Forms.Button SonidoPlay;
        public System.Windows.Forms.Button BTNModificar;
        public System.Windows.Forms.Label Titulo;
    }
}