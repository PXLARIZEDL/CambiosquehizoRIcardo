namespace Capa_Presentacion_Proyecto_Final
{
    partial class FrmVisualcontroldeempleados
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
            btnVisualregistrarempleado = new Button();
            btnVisualeditarempleado = new Button();
            btnEliminarempleado = new Button();
            btnVolveralmenuprincipal = new Button();
            SuspendLayout();
            // 
            // btnVisualregistrarempleado
            // 
            btnVisualregistrarempleado.Location = new Point(98, 244);
            btnVisualregistrarempleado.Margin = new Padding(3, 2, 3, 2);
            btnVisualregistrarempleado.Name = "btnVisualregistrarempleado";
            btnVisualregistrarempleado.Size = new Size(82, 22);
            btnVisualregistrarempleado.TabIndex = 0;
            btnVisualregistrarempleado.Text = "Registrar";
            btnVisualregistrarempleado.UseVisualStyleBackColor = true;
            btnVisualregistrarempleado.Click += btnVisualregistrarempleado_Click;
            // 
            // btnVisualeditarempleado
            // 
            btnVisualeditarempleado.Location = new Point(298, 244);
            btnVisualeditarempleado.Margin = new Padding(3, 2, 3, 2);
            btnVisualeditarempleado.Name = "btnVisualeditarempleado";
            btnVisualeditarempleado.Size = new Size(82, 22);
            btnVisualeditarempleado.TabIndex = 1;
            btnVisualeditarempleado.Text = "Editar";
            btnVisualeditarempleado.UseVisualStyleBackColor = true;
            // 
            // btnEliminarempleado
            // 
            btnEliminarempleado.Location = new Point(502, 244);
            btnEliminarempleado.Margin = new Padding(3, 2, 3, 2);
            btnEliminarempleado.Name = "btnEliminarempleado";
            btnEliminarempleado.Size = new Size(82, 22);
            btnEliminarempleado.TabIndex = 2;
            btnEliminarempleado.Text = "Eliminar";
            btnEliminarempleado.UseVisualStyleBackColor = true;
            // 
            // btnVolveralmenuprincipal
            // 
            btnVolveralmenuprincipal.Location = new Point(10, 9);
            btnVolveralmenuprincipal.Margin = new Padding(3, 2, 3, 2);
            btnVolveralmenuprincipal.Name = "btnVolveralmenuprincipal";
            btnVolveralmenuprincipal.Size = new Size(82, 22);
            btnVolveralmenuprincipal.TabIndex = 3;
            btnVolveralmenuprincipal.Text = "Volver";
            btnVolveralmenuprincipal.UseVisualStyleBackColor = true;
            btnVolveralmenuprincipal.Click += btnVolveralmenuprincipal_Click;
            // 
            // FrmVisualcontroldeempleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnVolveralmenuprincipal);
            Controls.Add(btnEliminarempleado);
            Controls.Add(btnVisualeditarempleado);
            Controls.Add(btnVisualregistrarempleado);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmVisualcontroldeempleados";
            Text = "FrmVisualcontroldeempleados";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVisualregistrarempleado;
        private Button btnVisualeditarempleado;
        private Button btnEliminarempleado;
        private Button btnVolveralmenuprincipal;
    }
}