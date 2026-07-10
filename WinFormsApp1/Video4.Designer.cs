namespace WinFormsApp1
{
    partial class Video4
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
            lbl_video4 = new Label();
            btn_volver_inicio = new Button();
            SuspendLayout();
            // 
            // lbl_video4
            // 
            lbl_video4.AutoSize = true;
            lbl_video4.Font = new Font("Segoe UI", 20F);
            lbl_video4.Location = new Point(27, 17);
            lbl_video4.Name = "lbl_video4";
            lbl_video4.Size = new Size(328, 37);
            lbl_video4.TabIndex = 0;
            lbl_video4.Text = "VIDEO 4 - FORMULARIOS ";
            // 
            // btn_volver_inicio
            // 
            btn_volver_inicio.Font = new Font("Segoe UI", 9F);
            btn_volver_inicio.Location = new Point(692, 379);
            btn_volver_inicio.Name = "btn_volver_inicio";
            btn_volver_inicio.Size = new Size(63, 43);
            btn_volver_inicio.TabIndex = 1;
            btn_volver_inicio.Text = "Volver";
            btn_volver_inicio.UseVisualStyleBackColor = true;
            btn_volver_inicio.Click += btn_volver_inicio_Click;
            // 
            // Video4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_volver_inicio);
            Controls.Add(lbl_video4);
            Name = "Video4";
            Text = "Video4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_video4;
        private Button btn_volver_inicio;
    }
}
