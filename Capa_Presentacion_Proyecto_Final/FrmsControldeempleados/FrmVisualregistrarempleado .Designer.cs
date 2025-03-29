namespace Capa_Presentacion_Proyecto_Final
{
    partial class FrmVisualregistrarempleado
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
            LBL_TITULO = new Label();
            BTN_ELIMINAR = new Button();
            BTN_GUARDAR = new Button();
            LBL_CARGO = new Label();
            cbCargo = new ComboBox();
            TXT_EDAD = new TextBox();
            TXT_APELLIDO = new TextBox();
            TXT_SUELDO = new TextBox();
            TXT_NOMBRE = new TextBox();
            LBL_SUELDO = new Label();
            LBL_APELLIDO = new Label();
            LBL_NOMBRE = new Label();
            LBL_EDAD = new Label();
            TXT_FECHAINGRESO = new TextBox();
            cbGenero = new ComboBox();
            textBox1 = new TextBox();
            TXT_CEDULA = new TextBox();
            TXT_TELEFONO = new TextBox();
            TXT_ID_DIRECCION = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            TXT_ID_GENERO = new TextBox();
            label7 = new Label();
            cb_direccion = new ComboBox();
            cb_genero = new ComboBox();
            SuspendLayout();
            // 
            // LBL_TITULO
            // 
            LBL_TITULO.AutoSize = true;
            LBL_TITULO.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LBL_TITULO.Location = new Point(208, 68);
            LBL_TITULO.Name = "LBL_TITULO";
            LBL_TITULO.RightToLeft = RightToLeft.Yes;
            LBL_TITULO.Size = new Size(422, 45);
            LBL_TITULO.TabIndex = 39;
            LBL_TITULO.Text = "REGISTRO DE EMPLEADOS";
            // 
            // BTN_ELIMINAR
            // 
            BTN_ELIMINAR.BackColor = Color.Crimson;
            BTN_ELIMINAR.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            BTN_ELIMINAR.Location = new Point(460, 460);
            BTN_ELIMINAR.Name = "BTN_ELIMINAR";
            BTN_ELIMINAR.Size = new Size(170, 75);
            BTN_ELIMINAR.TabIndex = 38;
            BTN_ELIMINAR.Text = "CANCELAR";
            BTN_ELIMINAR.UseVisualStyleBackColor = false;
            // 
            // BTN_GUARDAR
            // 
            BTN_GUARDAR.BackColor = SystemColors.HotTrack;
            BTN_GUARDAR.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            BTN_GUARDAR.Location = new Point(208, 460);
            BTN_GUARDAR.Name = "BTN_GUARDAR";
            BTN_GUARDAR.Size = new Size(178, 75);
            BTN_GUARDAR.TabIndex = 37;
            BTN_GUARDAR.Text = "REGISTRAR";
            BTN_GUARDAR.UseVisualStyleBackColor = false;
            BTN_GUARDAR.Click += BTN_GUARDAR_Click;
            // 
            // LBL_CARGO
            // 
            LBL_CARGO.AutoSize = true;
            LBL_CARGO.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            LBL_CARGO.Location = new Point(207, 392);
            LBL_CARGO.Name = "LBL_CARGO";
            LBL_CARGO.Size = new Size(61, 20);
            LBL_CARGO.TabIndex = 35;
            LBL_CARGO.Text = "CARGO";
            // 
            // cbCargo
            // 
            cbCargo.FormattingEnabled = true;
            cbCargo.Location = new Point(310, 393);
            cbCargo.Name = "cbCargo";
            cbCargo.Size = new Size(141, 23);
            cbCargo.TabIndex = 34;
            // 
            // TXT_EDAD
            // 
            TXT_EDAD.Location = new Point(310, 214);
            TXT_EDAD.Name = "TXT_EDAD";
            TXT_EDAD.Size = new Size(141, 23);
            TXT_EDAD.TabIndex = 33;
            TXT_EDAD.TextChanged += TXT_EDAD_TextChanged;
            // 
            // TXT_APELLIDO
            // 
            TXT_APELLIDO.Location = new Point(310, 165);
            TXT_APELLIDO.Name = "TXT_APELLIDO";
            TXT_APELLIDO.Size = new Size(141, 23);
            TXT_APELLIDO.TabIndex = 32;
            // 
            // TXT_SUELDO
            // 
            TXT_SUELDO.Location = new Point(310, 256);
            TXT_SUELDO.Name = "TXT_SUELDO";
            TXT_SUELDO.Size = new Size(141, 23);
            TXT_SUELDO.TabIndex = 31;
            // 
            // TXT_NOMBRE
            // 
            TXT_NOMBRE.Location = new Point(310, 130);
            TXT_NOMBRE.Name = "TXT_NOMBRE";
            TXT_NOMBRE.Size = new Size(141, 23);
            TXT_NOMBRE.TabIndex = 30;
            // 
            // LBL_SUELDO
            // 
            LBL_SUELDO.AutoSize = true;
            LBL_SUELDO.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            LBL_SUELDO.Location = new Point(181, 256);
            LBL_SUELDO.Name = "LBL_SUELDO";
            LBL_SUELDO.Size = new Size(66, 20);
            LBL_SUELDO.TabIndex = 29;
            LBL_SUELDO.Text = "SUELDO";
            // 
            // LBL_APELLIDO
            // 
            LBL_APELLIDO.AutoSize = true;
            LBL_APELLIDO.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            LBL_APELLIDO.Location = new Point(181, 168);
            LBL_APELLIDO.Name = "LBL_APELLIDO";
            LBL_APELLIDO.Size = new Size(80, 20);
            LBL_APELLIDO.TabIndex = 28;
            LBL_APELLIDO.Text = "APELLIDO";
            // 
            // LBL_NOMBRE
            // 
            LBL_NOMBRE.AutoSize = true;
            LBL_NOMBRE.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            LBL_NOMBRE.Location = new Point(187, 134);
            LBL_NOMBRE.Name = "LBL_NOMBRE";
            LBL_NOMBRE.RightToLeft = RightToLeft.Yes;
            LBL_NOMBRE.Size = new Size(74, 20);
            LBL_NOMBRE.TabIndex = 27;
            LBL_NOMBRE.Text = "NOMBRE";
            // 
            // LBL_EDAD
            // 
            LBL_EDAD.AutoSize = true;
            LBL_EDAD.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            LBL_EDAD.Location = new Point(181, 214);
            LBL_EDAD.Name = "LBL_EDAD";
            LBL_EDAD.Size = new Size(50, 20);
            LBL_EDAD.TabIndex = 40;
            LBL_EDAD.Text = "EDAD";
            // 
            // TXT_FECHAINGRESO
            // 
            TXT_FECHAINGRESO.Location = new Point(310, 303);
            TXT_FECHAINGRESO.Name = "TXT_FECHAINGRESO";
            TXT_FECHAINGRESO.Size = new Size(141, 23);
            TXT_FECHAINGRESO.TabIndex = 41;
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(310, 345);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(141, 23);
            cbGenero.TabIndex = 42;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(622, 249);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 43;
            // 
            // TXT_CEDULA
            // 
            TXT_CEDULA.Location = new Point(622, 183);
            TXT_CEDULA.Name = "TXT_CEDULA";
            TXT_CEDULA.Size = new Size(141, 23);
            TXT_CEDULA.TabIndex = 44;
            // 
            // TXT_TELEFONO
            // 
            TXT_TELEFONO.Location = new Point(622, 130);
            TXT_TELEFONO.Name = "TXT_TELEFONO";
            TXT_TELEFONO.Size = new Size(141, 23);
            TXT_TELEFONO.TabIndex = 45;
            // 
            // TXT_ID_DIRECCION
            // 
            TXT_ID_DIRECCION.Location = new Point(23, 45);
            TXT_ID_DIRECCION.Name = "TXT_ID_DIRECCION";
            TXT_ID_DIRECCION.Size = new Size(141, 23);
            TXT_ID_DIRECCION.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(493, 129);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(84, 20);
            label1.TabIndex = 49;
            label1.Text = "TELEFONO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(493, 186);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(67, 20);
            label2.TabIndex = 50;
            label2.Text = "CEDULA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label4.Location = new Point(493, 363);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(89, 20);
            label4.TabIndex = 52;
            label4.Text = "DIRECCION";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label5.Location = new Point(493, 252);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(84, 20);
            label5.TabIndex = 53;
            label5.Text = "TELEFONO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label6.Location = new Point(493, 396);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(89, 20);
            label6.TabIndex = 54;
            label6.Text = "ID GENERO";
            // 
            // TXT_ID_GENERO
            // 
            TXT_ID_GENERO.Location = new Point(23, 82);
            TXT_ID_GENERO.Name = "TXT_ID_GENERO";
            TXT_ID_GENERO.Size = new Size(141, 23);
            TXT_ID_GENERO.TabIndex = 55;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label7.Location = new Point(181, 306);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 56;
            label7.Text = "Fecha Ingreso";
            // 
            // cb_direccion
            // 
            cb_direccion.FormattingEnabled = true;
            cb_direccion.Location = new Point(631, 360);
            cb_direccion.Name = "cb_direccion";
            cb_direccion.Size = new Size(141, 23);
            cb_direccion.TabIndex = 57;
            cb_direccion.SelectedIndexChanged += cb_direccion_SelectedIndexChanged;
            // 
            // cb_genero
            // 
            cb_genero.FormattingEnabled = true;
            cb_genero.Location = new Point(631, 397);
            cb_genero.Name = "cb_genero";
            cb_genero.Size = new Size(141, 23);
            cb_genero.TabIndex = 58;
            // 
            // FrmVisualregistrarempleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 630);
            Controls.Add(cb_genero);
            Controls.Add(cb_direccion);
            Controls.Add(label7);
            Controls.Add(TXT_ID_GENERO);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TXT_ID_DIRECCION);
            Controls.Add(TXT_TELEFONO);
            Controls.Add(TXT_CEDULA);
            Controls.Add(textBox1);
            Controls.Add(cbGenero);
            Controls.Add(TXT_FECHAINGRESO);
            Controls.Add(LBL_EDAD);
            Controls.Add(LBL_TITULO);
            Controls.Add(BTN_ELIMINAR);
            Controls.Add(BTN_GUARDAR);
            Controls.Add(LBL_CARGO);
            Controls.Add(cbCargo);
            Controls.Add(TXT_EDAD);
            Controls.Add(TXT_APELLIDO);
            Controls.Add(TXT_SUELDO);
            Controls.Add(TXT_NOMBRE);
            Controls.Add(LBL_SUELDO);
            Controls.Add(LBL_APELLIDO);
            Controls.Add(LBL_NOMBRE);
            Name = "FrmVisualregistrarempleado";
            Text = "FrmVisualregistrarempleado";
            Load += FrmVisualregistrarempleado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LBL_TITULO;
        private Button BTN_ELIMINAR;
        private Button BTN_GUARDAR;
        private Label LBL_CARGO;
        private ComboBox cbCargo;
        private TextBox TXT_EDAD;
        private TextBox TXT_APELLIDO;
        private TextBox TXT_SUELDO;
        private TextBox TXT_NOMBRE;
        private Label LBL_SUELDO;
        private Label LBL_APELLIDO;
        private Label LBL_NOMBRE;
        private Label LBL_EDAD;
        private TextBox TXT_FECHAINGRESO;
        private ComboBox cbGenero;
        private TextBox textBox1;
        private TextBox TXT_CEDULA;
        private TextBox TXT_TELEFONO;
        private TextBox TXT_ID_DIRECCION;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox TXT_ID_GENERO;
        private Label label7;
        private ComboBox cb_direccion;
        private ComboBox cb_genero;
    }
}