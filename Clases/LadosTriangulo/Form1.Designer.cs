namespace LadosTriangulo
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
            txtLado1 = new TextBox();
            txtLado2 = new TextBox();
            txtLado3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btonIngresar = new Button();
            SuspendLayout();
            // 
            // txtLado1
            // 
            txtLado1.Location = new Point(74, 101);
            txtLado1.Name = "txtLado1";
            txtLado1.Size = new Size(125, 27);
            txtLado1.TabIndex = 0;
            // 
            // txtLado2
            // 
            txtLado2.Location = new Point(223, 101);
            txtLado2.Name = "txtLado2";
            txtLado2.Size = new Size(125, 27);
            txtLado2.TabIndex = 1;
            // 
            // txtLado3
            // 
            txtLado3.Location = new Point(374, 101);
            txtLado3.Name = "txtLado3";
            txtLado3.Size = new Size(125, 27);
            txtLado3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial monospaced for SAP", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(133, 9);
            label1.Name = "label1";
            label1.Size = new Size(306, 27);
            label1.TabIndex = 3;
            label1.Text = "Lados de un triangulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(106, 71);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 4;
            label2.Text = "Lado 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(255, 71);
            label3.Name = "label3";
            label3.Size = new Size(59, 19);
            label3.TabIndex = 4;
            label3.Text = "Lado 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(409, 71);
            label4.Name = "label4";
            label4.Size = new Size(59, 19);
            label4.TabIndex = 4;
            label4.Text = "Lado 3";
            // 
            // btonIngresar
            // 
            btonIngresar.Font = new Font("Arial monospaced for SAP", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btonIngresar.Location = new Point(223, 171);
            btonIngresar.Name = "btonIngresar";
            btonIngresar.Size = new Size(125, 52);
            btonIngresar.TabIndex = 5;
            btonIngresar.Text = "INGRESAR";
            btonIngresar.UseVisualStyleBackColor = true;
            btonIngresar.Click += btonIngresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 266);
            Controls.Add(btonIngresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLado3);
            Controls.Add(txtLado2);
            Controls.Add(txtLado1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLado1;
        private TextBox txtLado2;
        private TextBox txtLado3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btonIngresar;
    }
}