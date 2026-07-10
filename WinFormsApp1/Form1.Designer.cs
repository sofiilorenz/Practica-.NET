namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblProde = new Label();
            lblSofi = new Label();
            lbl_ingreso_nombre = new Label();
            txt_ingreso_nombre = new TextBox();
            bttn_enviar_nombre = new Button();
            lbl_como_te_enteraste = new Label();
            comboBox_enteraste = new ComboBox();
            btn_aceptar = new Button();
            lbNombres = new ListBox();
            btn_mostrar = new Button();
            SuspendLayout();
            // 
            // lblProde
            // 
            lblProde.AutoSize = true;
            lblProde.Font = new Font("Segoe UI", 20F);
            lblProde.Location = new Point(448, 9);
            lblProde.Name = "lblProde";
            lblProde.Size = new Size(267, 37);
            lblProde.TabIndex = 0;
            lblProde.Text = "PRODE DE PRACTICA";
            // 
            // lblSofi
            // 
            lblSofi.AutoSize = true;
            lblSofi.Location = new Point(529, 59);
            lblSofi.Name = "lblSofi";
            lblSofi.Size = new Size(81, 15);
            lblSofi.TabIndex = 1;
            lblSofi.Text = "by Sofi Lorenz";
            // 
            // lbl_ingreso_nombre
            // 
            lbl_ingreso_nombre.AutoSize = true;
            lbl_ingreso_nombre.Font = new Font("Segoe UI", 16F);
            lbl_ingreso_nombre.Location = new Point(16, 102);
            lbl_ingreso_nombre.Name = "lbl_ingreso_nombre";
            lbl_ingreso_nombre.Size = new Size(195, 30);
            lbl_ingreso_nombre.TabIndex = 2;
            lbl_ingreso_nombre.Text = "Ingrese su nombre";
            // 
            // txt_ingreso_nombre
            // 
            txt_ingreso_nombre.Font = new Font("Segoe UI", 16F);
            txt_ingreso_nombre.Location = new Point(217, 99);
            txt_ingreso_nombre.Name = "txt_ingreso_nombre";
            txt_ingreso_nombre.Size = new Size(266, 36);
            txt_ingreso_nombre.TabIndex = 3;
            // 
            // bttn_enviar_nombre
            // 
            bttn_enviar_nombre.Font = new Font("Segoe UI", 16F);
            bttn_enviar_nombre.Location = new Point(489, 99);
            bttn_enviar_nombre.Name = "bttn_enviar_nombre";
            bttn_enviar_nombre.Size = new Size(143, 37);
            bttn_enviar_nombre.TabIndex = 4;
            bttn_enviar_nombre.Text = "Enviar";
            bttn_enviar_nombre.UseVisualStyleBackColor = true;
            bttn_enviar_nombre.Click += bttn_enviar_nombre_Click;
            // 
            // lbl_como_te_enteraste
            // 
            lbl_como_te_enteraste.AutoSize = true;
            lbl_como_te_enteraste.Font = new Font("Segoe UI", 16F);
            lbl_como_te_enteraste.Location = new Point(7, 329);
            lbl_como_te_enteraste.Name = "lbl_como_te_enteraste";
            lbl_como_te_enteraste.Size = new Size(354, 30);
            lbl_como_te_enteraste.TabIndex = 5;
            lbl_como_te_enteraste.Text = "Como te enteraste de este PRODE?";
            // 
            // comboBox_enteraste
            // 
            comboBox_enteraste.Font = new Font("Segoe UI", 16F);
            comboBox_enteraste.FormattingEnabled = true;
            comboBox_enteraste.Items.AddRange(new object[] { "Amigos", "Instagram", "GitHub", "Sofi" });
            comboBox_enteraste.Location = new Point(367, 326);
            comboBox_enteraste.Name = "comboBox_enteraste";
            comboBox_enteraste.Size = new Size(267, 38);
            comboBox_enteraste.TabIndex = 6;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Font = new Font("Segoe UI", 16F);
            btn_aceptar.Location = new Point(640, 325);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(142, 38);
            btn_aceptar.TabIndex = 7;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // lbNombres
            // 
            lbNombres.FormattingEnabled = true;
            lbNombres.Location = new Point(34, 154);
            lbNombres.Name = "lbNombres";
            lbNombres.SelectionMode = SelectionMode.MultiSimple;
            lbNombres.Size = new Size(403, 109);
            lbNombres.TabIndex = 8;
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(448, 240);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(75, 23);
            btn_mostrar.TabIndex = 9;
            btn_mostrar.Text = "Mostrar Seleccionado";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += btn_mostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 566);
            Controls.Add(btn_mostrar);
            Controls.Add(lbNombres);
            Controls.Add(btn_aceptar);
            Controls.Add(comboBox_enteraste);
            Controls.Add(lbl_como_te_enteraste);
            Controls.Add(bttn_enviar_nombre);
            Controls.Add(txt_ingreso_nombre);
            Controls.Add(lbl_ingreso_nombre);
            Controls.Add(lblSofi);
            Controls.Add(lblProde);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProde;
        private Label lblSofi;
        private Label lbl_ingreso_nombre;
        private TextBox txt_ingreso_nombre;
        private Button bttn_enviar_nombre;
        private Label lbl_como_te_enteraste;
        private ComboBox comboBox_enteraste;
        private Button btn_aceptar;
        private ListBox lbNombres;
        private Button btn_mostrar;
    }
}
