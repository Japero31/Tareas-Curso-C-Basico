namespace NegocioApp
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
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            btnAgregar = new Button();
            txtcode = new TextBox();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            label9 = new Label();
            txtcorreo = new TextBox();
            label8 = new Label();
            txttelefono = new TextBox();
            label7 = new Label();
            txtdireccion = new TextBox();
            label6 = new Label();
            txtposicion = new TextBox();
            label5 = new Label();
            txtdepa = new TextBox();
            label4 = new Label();
            dtpcontra = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            dgvempleados = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvempleados).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(660, 257);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(115, 51);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Limpiar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtcode);
            groupBox1.Controls.Add(txtnombre);
            groupBox1.Controls.Add(txtapellido);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtcorreo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txttelefono);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtdireccion);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtposicion);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtdepa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpcontra);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("FoxPrint", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(22, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(932, 368);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Empleado";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Arial Narrow", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.Location = new Point(485, 257);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 51);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtcode
            // 
            txtcode.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtcode.Location = new Point(52, 94);
            txtcode.Name = "txtcode";
            txtcode.Size = new Size(84, 27);
            txtcode.TabIndex = 0;
            // 
            // txtnombre
            // 
            txtnombre.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombre.Location = new Point(160, 94);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(148, 27);
            txtnombre.TabIndex = 0;
            // 
            // txtapellido
            // 
            txtapellido.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtapellido.Location = new Point(333, 94);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(148, 27);
            txtapellido.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(284, 149);
            label9.Name = "label9";
            label9.Size = new Size(100, 22);
            label9.TabIndex = 10;
            label9.Text = "Departamento";
            // 
            // txtcorreo
            // 
            txtcorreo.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtcorreo.Location = new Point(506, 94);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(190, 27);
            txtcorreo.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(506, 149);
            label8.Name = "label8";
            label8.Size = new Size(150, 22);
            label8.TabIndex = 9;
            label8.Text = "Fecha de contratacion";
            // 
            // txttelefono
            // 
            txttelefono.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txttelefono.Location = new Point(719, 94);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(148, 27);
            txttelefono.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(52, 149);
            label7.Name = "label7";
            label7.Size = new Size(63, 22);
            label7.TabIndex = 8;
            label7.Text = "Posicion";
            // 
            // txtdireccion
            // 
            txtdireccion.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtdireccion.Location = new Point(52, 240);
            txtdireccion.Multiline = true;
            txtdireccion.Name = "txtdireccion";
            txtdireccion.Size = new Size(348, 80);
            txtdireccion.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(52, 217);
            label6.Name = "label6";
            label6.Size = new Size(69, 22);
            label6.TabIndex = 7;
            label6.Text = "Direccion";
            // 
            // txtposicion
            // 
            txtposicion.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtposicion.Location = new Point(52, 172);
            txtposicion.Name = "txtposicion";
            txtposicion.Size = new Size(188, 27);
            txtposicion.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(719, 71);
            label5.Name = "label5";
            label5.Size = new Size(65, 22);
            label5.TabIndex = 6;
            label5.Text = "Telefono";
            // 
            // txtdepa
            // 
            txtdepa.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtdepa.Location = new Point(282, 172);
            txtdepa.Name = "txtdepa";
            txtdepa.Size = new Size(188, 27);
            txtdepa.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(506, 71);
            label4.Name = "label4";
            label4.Size = new Size(54, 22);
            label4.TabIndex = 5;
            label4.Text = "Correo";
            // 
            // dtpcontra
            // 
            dtpcontra.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpcontra.Location = new Point(506, 172);
            dtpcontra.Name = "dtpcontra";
            dtpcontra.Size = new Size(250, 27);
            dtpcontra.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(333, 71);
            label3.Name = "label3";
            label3.Size = new Size(67, 22);
            label3.TabIndex = 4;
            label3.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(52, 71);
            label1.Name = "label1";
            label1.Size = new Size(55, 22);
            label1.TabIndex = 2;
            label1.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(160, 71);
            label2.Name = "label2";
            label2.Size = new Size(69, 22);
            label2.TabIndex = 3;
            label2.Text = "Nombres";
            // 
            // dgvempleados
            // 
            dgvempleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvempleados.Dock = DockStyle.Bottom;
            dgvempleados.Location = new Point(0, 429);
            dgvempleados.Name = "dgvempleados";
            dgvempleados.RowHeadersWidth = 51;
            dgvempleados.RowTemplate.Height = 29;
            dgvempleados.Size = new Size(991, 228);
            dgvempleados.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 657);
            Controls.Add(groupBox1);
            Controls.Add(dgvempleados);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvempleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelar;
        private GroupBox groupBox1;
        private Button btnAgregar;
        private TextBox txtcode;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private Label label9;
        private TextBox txtcorreo;
        private Label label8;
        private TextBox txttelefono;
        private Label label7;
        private TextBox txtdireccion;
        private Label label6;
        private TextBox txtposicion;
        private Label label5;
        private TextBox txtdepa;
        private Label label4;
        private DateTimePicker dtpcontra;
        private Label label3;
        private Label label1;
        private Label label2;
        private DataGridView dgvempleados;
    }
}