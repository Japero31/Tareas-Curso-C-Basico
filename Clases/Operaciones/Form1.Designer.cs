namespace Operaciones
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
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            btnSuma = new Button();
            btnProducto = new Button();
            btnResta = new Button();
            btnDivision = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(25, 105);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(83, 27);
            txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(114, 105);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(83, 27);
            txtValor2.TabIndex = 1;
            // 
            // btnSuma
            // 
            btnSuma.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSuma.Location = new Point(25, 160);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(83, 62);
            btnSuma.TabIndex = 2;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnProducto
            // 
            btnProducto.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProducto.Location = new Point(25, 234);
            btnProducto.Name = "btnProducto";
            btnProducto.Size = new Size(83, 62);
            btnProducto.TabIndex = 2;
            btnProducto.Text = "X";
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnResta
            // 
            btnResta.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnResta.Location = new Point(114, 160);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(83, 62);
            btnResta.TabIndex = 2;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivision.Location = new Point(114, 234);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(83, 62);
            btnDivision.TabIndex = 2;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 82);
            label1.Name = "label1";
            label1.Size = new Size(58, 22);
            label1.TabIndex = 3;
            label1.Text = "Valor 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(128, 82);
            label2.Name = "label2";
            label2.Size = new Size(58, 22);
            label2.TabIndex = 3;
            label2.Text = "Valor 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial monospaced for SAP", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(52, 25);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 4;
            label3.Text = "Operaciones";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 346);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDivision);
            Controls.Add(btnResta);
            Controls.Add(btnProducto);
            Controls.Add(btnSuma);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor1;
        private TextBox txtValor2;
        private Button btnSuma;
        private Button btnProducto;
        private Button btnResta;
        private Button btnDivision;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}