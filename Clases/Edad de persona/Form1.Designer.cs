namespace Edad_de_persona
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
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnIngresar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombre.Location = new Point(63, 140);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 30);
            txtNombre.TabIndex = 0;
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEdad.Location = new Point(98, 216);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(85, 30);
            txtEdad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 117);
            label1.Name = "label1";
            label1.Size = new Size(69, 24);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(118, 189);
            label2.Name = "label2";
            label2.Size = new Size(48, 24);
            label2.TabIndex = 3;
            label2.Text = "Edad";
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnIngresar.Location = new Point(82, 280);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(122, 52);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 53);
            label3.Name = "label3";
            label3.Size = new Size(229, 22);
            label3.TabIndex = 5;
            label3.Text = "Nombre y Edad de una persona";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 378);
            Controls.Add(label3);
            Controls.Add(btnIngresar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtEdad;
        private Label label1;
        private Label label2;
        private Button btnIngresar;
        private Label label3;
    }
}