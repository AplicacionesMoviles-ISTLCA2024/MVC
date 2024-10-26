namespace Clase5.Vista
{
    partial class frmEstudianteModal
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
            txtCedula = new TextBox();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtDireccion = new TextBox();
            dtpFecha = new DateTimePicker();
            ddlEstado = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtContrasena = new TextBox();
            btnGrabar = new Button();
            SuspendLayout();
            // 
            // txtCedula
            // 
            txtCedula.Location = new Point(144, 16);
            txtCedula.Name = "txtCedula";
            txtCedula.Size = new Size(155, 23);
            txtCedula.TabIndex = 0;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(144, 45);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(155, 23);
            txtNombres.TabIndex = 1;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(144, 74);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(155, 23);
            txtApellidos.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(144, 103);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(155, 23);
            txtDireccion.TabIndex = 3;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(144, 132);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(155, 23);
            dtpFecha.TabIndex = 4;
            // 
            // ddlEstado
            // 
            ddlEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlEstado.FormattingEnabled = true;
            ddlEstado.Items.AddRange(new object[] { "ACTIVO", "INACTIVO" });
            ddlEstado.Location = new Point(144, 189);
            ddlEstado.Name = "ddlEstado";
            ddlEstado.Size = new Size(155, 23);
            ddlEstado.TabIndex = 5;
            // 
            // label1
            // 
            label1.Location = new Point(38, 19);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 6;
            label1.Text = "Cédula";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Location = new Point(38, 45);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            label2.Text = "Nombres";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Location = new Point(38, 73);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 8;
            label3.Text = "Apellidos";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(38, 102);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 9;
            label4.Text = "Dirección";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(-31, 132);
            label5.Name = "label5";
            label5.Size = new Size(169, 23);
            label5.TabIndex = 10;
            label5.Text = "Fecha Nacimiento";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(-31, 160);
            label6.Name = "label6";
            label6.Size = new Size(169, 23);
            label6.TabIndex = 11;
            label6.Text = "Contraseña";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(-31, 188);
            label7.Name = "label7";
            label7.Size = new Size(169, 23);
            label7.TabIndex = 12;
            label7.Text = "Estado";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(144, 160);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(155, 23);
            txtContrasena.TabIndex = 13;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(287, 218);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 14;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // frmEstudianteModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 251);
            Controls.Add(btnGrabar);
            Controls.Add(txtContrasena);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ddlEstado);
            Controls.Add(dtpFecha);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(txtCedula);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEstudianteModal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estudiante";
            Load += frmEstudianteModal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCedula;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private TextBox txtDireccion;
        private DateTimePicker dtpFecha;
        private ComboBox ddlEstado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtContrasena;
        private Button btnGrabar;
    }
}