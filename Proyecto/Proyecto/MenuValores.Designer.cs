namespace Proyecto
{
    partial class MenuValores
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.tolerancia_color = new System.Windows.Forms.TextBox();
            this.multi_color = new System.Windows.Forms.TextBox();
            this.Banda2_color = new System.Windows.Forms.TextBox();
            this.Banda1_color = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cbox_tolerancia = new System.Windows.Forms.ComboBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "X";
            this.btn_exit.UseCompatibleTextRendering = true;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(220, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 92);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cálculo de Resistencia\r\n           por Valor";
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
            this.btn_regresar.TabIndex = 4;
            this.btn_regresar.Text = "←";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // tolerancia_color
            // 
            this.tolerancia_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.tolerancia_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tolerancia_color.Cursor = System.Windows.Forms.Cursors.Default;
            this.tolerancia_color.Enabled = false;
            this.tolerancia_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 74F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tolerancia_color.Location = new System.Drawing.Point(565, 394);
            this.tolerancia_color.Name = "tolerancia_color";
            this.tolerancia_color.ReadOnly = true;
            this.tolerancia_color.Size = new System.Drawing.Size(14, 112);
            this.tolerancia_color.TabIndex = 15;
            // 
            // multi_color
            // 
            this.multi_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.multi_color.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.multi_color.Enabled = false;
            this.multi_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 57F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi_color.Location = new System.Drawing.Point(463, 403);
            this.multi_color.Name = "multi_color";
            this.multi_color.ReadOnly = true;
            this.multi_color.Size = new System.Drawing.Size(33, 94);
            this.multi_color.TabIndex = 16;
            // 
            // Banda2_color
            // 
            this.Banda2_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.Banda2_color.Cursor = System.Windows.Forms.Cursors.Default;
            this.Banda2_color.Enabled = false;
            this.Banda2_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 57F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banda2_color.Location = new System.Drawing.Point(407, 403);
            this.Banda2_color.Name = "Banda2_color";
            this.Banda2_color.ReadOnly = true;
            this.Banda2_color.Size = new System.Drawing.Size(33, 94);
            this.Banda2_color.TabIndex = 17;
            // 
            // Banda1_color
            // 
            this.Banda1_color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.Banda1_color.Cursor = System.Windows.Forms.Cursors.Default;
            this.Banda1_color.Enabled = false;
            this.Banda1_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Banda1_color.Location = new System.Drawing.Point(342, 394);
            this.Banda1_color.Name = "Banda1_color";
            this.Banda1_color.ReadOnly = true;
            this.Banda1_color.Size = new System.Drawing.Size(32, 113);
            this.Banda1_color.TabIndex = 18;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lbl_resultado.Location = new System.Drawing.Point(322, 632);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(257, 46);
            this.lbl_resultado.TabIndex = 12;
            this.lbl_resultado.Text = "Resultado....";
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.btn_calcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btn_calcular.FlatAppearance.BorderSize = 3;
            this.btn_calcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(46)))), ((int)(((byte)(99)))));
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(351, 244);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(198, 78);
            this.btn_calcular.TabIndex = 14;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.calcular_valor);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources._4959e83378bb1f0908e61e145b72e0c71;
            this.pictureBox1.Location = new System.Drawing.Point(-140, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1192, 524);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(217)))), ((int)(((byte)(214)))));
            this.label5.Location = new System.Drawing.Point(540, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tolerancia";
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
            this.Cbox_tolerancia.Location = new System.Drawing.Point(546, 165);
            this.Cbox_tolerancia.Name = "Cbox_tolerancia";
            this.Cbox_tolerancia.Size = new System.Drawing.Size(145, 39);
            this.Cbox_tolerancia.TabIndex = 19;
            this.Cbox_tolerancia.SelectedIndexChanged += new System.EventHandler(this.cambiar_bandaT);
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(161, 165);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(370, 38);
            this.txt_valor.TabIndex = 21;
            // 
            // MenuValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(913, 715);
            this.ControlBox = false;
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cbox_tolerancia);
            this.Controls.Add(this.tolerancia_color);
            this.Controls.Add(this.multi_color);
            this.Controls.Add(this.Banda2_color);
            this.Controls.Add(this.Banda1_color);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuValores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.TextBox tolerancia_color;
        private System.Windows.Forms.TextBox multi_color;
        private System.Windows.Forms.TextBox Banda2_color;
        private System.Windows.Forms.TextBox Banda1_color;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cbox_tolerancia;
        private System.Windows.Forms.TextBox txt_valor;
    }
}