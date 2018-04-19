namespace Academia
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnAlumnos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnLibro = new System.Windows.Forms.Button();
            this.btnPatente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAlumnos
            // 
            this.BtnAlumnos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlumnos.Location = new System.Drawing.Point(12, 35);
            this.BtnAlumnos.Name = "BtnAlumnos";
            this.BtnAlumnos.Size = new System.Drawing.Size(85, 30);
            this.BtnAlumnos.TabIndex = 0;
            this.BtnAlumnos.Text = "Estudiantes";
            this.BtnAlumnos.UseVisualStyleBackColor = false;
            this.BtnAlumnos.Click += new System.EventHandler(this.BtnAlumnos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(103, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Articulo";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // BtnLibro
            // 
            this.BtnLibro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLibro.Location = new System.Drawing.Point(12, 81);
            this.BtnLibro.Name = "BtnLibro";
            this.BtnLibro.Size = new System.Drawing.Size(85, 30);
            this.BtnLibro.TabIndex = 2;
            this.BtnLibro.Text = "Libro";
            this.BtnLibro.UseVisualStyleBackColor = false;
            this.BtnLibro.Click += new System.EventHandler(this.BtnLibro_Click);
            // 
            // btnPatente
            // 
            this.btnPatente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatente.Location = new System.Drawing.Point(117, 81);
            this.btnPatente.Name = "btnPatente";
            this.btnPatente.Size = new System.Drawing.Size(85, 30);
            this.btnPatente.TabIndex = 3;
            this.btnPatente.Text = "Patente";
            this.btnPatente.UseVisualStyleBackColor = false;
            this.btnPatente.Click += new System.EventHandler(this.btnPatente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(438, 316);
            this.Controls.Add(this.btnPatente);
            this.Controls.Add(this.BtnLibro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAlumnos);
            this.Name = "Form1";
            this.Text = "Producción academica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAlumnos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnLibro;
        private System.Windows.Forms.Button btnPatente;
    }
}

