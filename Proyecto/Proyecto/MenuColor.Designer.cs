namespace Proyecto
{
    partial class MenuColor
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
            this.btn_regresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.Cbox_Banda1 = new System.Windows.Forms.ComboBox();
            this.Cbox_Banda2 = new System.Windows.Forms.ComboBox();
            this.Cbox_multi = new System.Windows.Forms.ComboBox();
            this.Cbox_tolerancia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.Banda1_color = new System.Windows.Forms.TextBox();
            this.Banda2_color = new System.Windows.Forms.TextBox();
            this.multi_color = new System.Windows.Forms.TextBox();
            this.tolerancia_color = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btn_regresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.btn_regresar.FlatAppearance.BorderSize = 3;
            this.btn_regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regresar.Location = new System.Drawing.Point(12, 12);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(40, 40);
            this.btn_regresar.TabIndex = 1;
            this.btn_regresar.Text = "←";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(211, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 92);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cálculo de Resistencia\r\n           por Color";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.btn_exit.FlatAppearance.BorderSize = 3;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(864, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(40, 40);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "X";
            this.btn_exit.UseCompatibleTextRendering = true;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Cbox_Banda1
            // 
            this.Cbox_Banda1.BackColor = System.Drawing.SystemColors.Window;
            this.Cbox_Banda1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Banda1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_Banda1.FormattingEnabled = true;
            this.Cbox_Banda1.Items.AddRange(new object[] {
            "Negro",
            "Café",
            "Rojo",
            "Naranja",
            "Amarillo",
            "Verde",
            "Azul",
            "Violeta",
            "Gris",
            "Blanco"});
            this.Cbox_Banda1.Location = new System.Drawing.Point(103, 170);
            this.Cbox_Banda1.Name = "Cbox_Banda1";
            this.Cbox_Banda1.Size = new System.Drawing.Size(121, 39);
            this.Cbox_Banda1.TabIndex = 4;
            this.Cbox_Banda1.SelectedIndexChanged += new System.EventHandler(this.cambio_color_banda1);
            // 
            // Cbox_Banda2
            // 
            this.Cbox_Banda2.BackColor = System.Drawing.SystemColors.Window;
            this.Cbox_Banda2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Banda2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_Banda2.FormattingEnabled = true;
            this.Cbox_Banda2.Items.AddRange(new object[] {
            "Negro",
            "Café",
            "Rojo",
            "Naranja",
            "Amarillo",
            "Verde",
            "Azul",
            "Violeta",
            "Gris",
            "Blanco"});
            this.Cbox_Banda2.Location = new System.Drawing.Point(283, 170);
            this.Cbox_Banda2.Name = "Cbox_Banda2";
            this.Cbox_Banda2.Size = new System.Drawing.Size(121, 39);
            this.Cbox_Banda2.TabIndex = 5;
            this.Cbox_Banda2.SelectedIndexChanged += new System.EventHandler(this.cambio_color_banda2);
            // 
            // Cbox_multi
            // 
            this.Cbox_multi.BackColor = System.Drawing.SystemColors.Window;
            this.Cbox_multi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_multi.FormattingEnabled = true;
            this.Cbox_multi.Items.AddRange(new object[] {
            "Negro",
            "Café",
            "Rojo",
            "Naranja",
            "Amarillo",
            "Verde",
            "Azul",
            "Dorado",
            "Plateado"});
            this.Cbox_multi.Location = new System.Drawing.Point(466, 170);
            this.Cbox_multi.Name = "Cbox_multi";
            this.Cbox_multi.Size = new System.Drawing.Size(131, 39);
            this.Cbox_multi.TabIndex = 6;
            this.Cbox_multi.SelectedIndexChanged += new System.EventHandler(this.cambio_color_Multi);
            // 
            // Cbox_tolerancia
            // 
            this.Cbox_tolerancia.BackColor = System.Drawing.SystemColors.Window;
            this.Cbox_tolerancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_tolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_tolerancia.FormattingEnabled = true;
            this.Cbox_tolerancia.Items.AddRange(new object[] {
            "Café",
            "Rojo",
            "Dorado",
            "Plateado",
            "Sin banda"});
            this.Cbox_tolerancia.Location = new System.Drawing.Point(651, 170);
            this.Cbox_tolerancia.Name = "Cbox_tolerancia";
            this.Cbox_tolerancia.Size = new System.Drawing.Size(145, 39);
            this.Cbox_tolerancia.TabIndex = 7;
            this.Cbox_tolerancia.SelectedIndexChanged += new System.EventHandler(this.cambio_color_tolerancia);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(103, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Banda 1 ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(283, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Banda 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(438, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Multiplocador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label5.Location = new System.Drawing.Point(645, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tolerancia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources._4959e83378bb1f0908e61e145b72e0c71;
            this.pictureBox1.Location = new System.Drawing.Point(-160, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1192, 524);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.btn_calcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btn_calcular.FlatAppearance.BorderSize = 3;
            this.btn_calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(345, 233);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(198, 78);
            this.btn_calcular.TabIndex = 10;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_resultado.Location = new System.Drawing.Point(323, 635);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(257, 46);
            this.lbl_resultado.TabIndex = 2;
            this.lbl_resultado.Text = "Resultado....";
            // 
            // Banda1_color
            // 
            this.Banda1_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.Banda1_color.Cursor = System.Windows.Forms.Cursors.Default;
            this.Banda1_color.Enabled = false;
            this.Banda1_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banda1_color.Location = new System.Drawing.Point(322, 383);
            this.Banda1_color.Name = "Banda1_color";
            this.Banda1_color.ReadOnly = true;
            this.Banda1_color.Size = new System.Drawing.Size(32, 113);
            this.Banda1_color.TabIndex = 11;
            // 
            // Banda2_color
            // 
            this.Banda2_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.Banda2_color.Cursor = System.Windows.Forms.Cursors.Default;
            this.Banda2_color.Enabled = false;
            this.Banda2_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 57F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banda2_color.Location = new System.Drawing.Point(387, 392);
            this.Banda2_color.Name = "Banda2_color";
            this.Banda2_color.ReadOnly = true;
            this.Banda2_color.Size = new System.Drawing.Size(33, 94);
            this.Banda2_color.TabIndex = 11;
            // 
            // multi_color
            // 
            this.multi_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.multi_color.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.multi_color.Enabled = false;
            this.multi_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 57F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi_color.Location = new System.Drawing.Point(443, 392);
            this.multi_color.Name = "multi_color";
            this.multi_color.ReadOnly = true;
            this.multi_color.Size = new System.Drawing.Size(33, 94);
            this.multi_color.TabIndex = 11;
            // 
            // tolerancia_color
            // 
            this.tolerancia_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tolerancia_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tolerancia_color.Cursor = System.Windows.Forms.Cursors.Default;
            this.tolerancia_color.Enabled = false;
            this.tolerancia_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 74F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolerancia_color.Location = new System.Drawing.Point(545, 383);
            this.tolerancia_color.Name = "tolerancia_color";
            this.tolerancia_color.ReadOnly = true;
            this.tolerancia_color.Size = new System.Drawing.Size(14, 112);
            this.tolerancia_color.TabIndex = 11;
            // 
            // MenuColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(913, 734);
            this.ControlBox = false;
            this.Controls.Add(this.tolerancia_color);
            this.Controls.Add(this.multi_color);
            this.Controls.Add(this.Banda2_color);
            this.Controls.Add(this.Banda1_color);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cbox_tolerancia);
            this.Controls.Add(this.Cbox_multi);
            this.Controls.Add(this.Cbox_Banda2);
            this.Controls.Add(this.Cbox_Banda1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox Cbox_Banda1;
        private System.Windows.Forms.ComboBox Cbox_Banda2;
        private System.Windows.Forms.ComboBox Cbox_multi;
        private System.Windows.Forms.ComboBox Cbox_tolerancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox Banda1_color;
        private System.Windows.Forms.TextBox Banda2_color;
        private System.Windows.Forms.TextBox multi_color;
        private System.Windows.Forms.TextBox tolerancia_color;
    }
}