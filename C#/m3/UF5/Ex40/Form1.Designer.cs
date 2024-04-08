namespace Ex40
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
            components = new System.ComponentModel.Container();
            header = new Label();
            alumno = new Label();
            textAlumno = new TextBox();
            calcular = new Button();
            limpiar = new Button();
            registroNotas = new Label();
            nota1 = new TextBox();
            nota2 = new TextBox();
            nota3 = new TextBox();
            nota4 = new TextBox();
            textNota1 = new Label();
            textNota2 = new Label();
            textNota3 = new Label();
            textNota4 = new Label();
            promedioNotas = new Label();
            notaMasBaja = new Label();
            condicion = new Label();
            resultPromedio = new Label();
            resultMasBaja = new Label();
            resultCondicion = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            header.Location = new Point(148, 9);
            header.Name = "header";
            header.Size = new Size(265, 23);
            header.TabIndex = 0;
            header.Text = "CONTROL PROMEDIO DE NOTAS";
            // 
            // alumno
            // 
            alumno.AutoSize = true;
            alumno.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            alumno.Location = new Point(12, 65);
            alumno.Name = "alumno";
            alumno.Size = new Size(55, 15);
            alumno.TabIndex = 1;
            alumno.Text = "ALUMNO\r\n";
            // 
            // textAlumno
            // 
            textAlumno.BackColor = SystemColors.InactiveBorder;
            textAlumno.Location = new Point(12, 83);
            textAlumno.Name = "textAlumno";
            textAlumno.Size = new Size(215, 22);
            textAlumno.TabIndex = 2;
            // 
            // calcular
            // 
            calcular.BackColor = SystemColors.Control;
            calcular.Location = new Point(12, 110);
            calcular.Name = "calcular";
            calcular.Size = new Size(88, 23);
            calcular.TabIndex = 3;
            calcular.Text = "CALCULAR";
            calcular.UseVisualStyleBackColor = false;
            calcular.Click += calcular_Click;
            // 
            // limpiar
            // 
            limpiar.BackColor = SystemColors.Control;
            limpiar.Location = new Point(139, 111);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(88, 23);
            limpiar.TabIndex = 4;
            limpiar.Text = "LIMPIAR";
            limpiar.UseVisualStyleBackColor = false;
            limpiar.Click += limpiar_Click;
            // 
            // registroNotas
            // 
            registroNotas.AutoSize = true;
            registroNotas.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registroNotas.Location = new Point(315, 64);
            registroNotas.Name = "registroNotas";
            registroNotas.Size = new Size(115, 15);
            registroNotas.TabIndex = 5;
            registroNotas.Text = "REGISTRO DE NOTAS";
            // 
            // nota1
            // 
            nota1.BackColor = SystemColors.InactiveBorder;
            nota1.Location = new Point(315, 110);
            nota1.Name = "nota1";
            nota1.Size = new Size(46, 22);
            nota1.TabIndex = 6;
            // 
            // nota2
            // 
            nota2.BackColor = SystemColors.InactiveBorder;
            nota2.Location = new Point(367, 111);
            nota2.Name = "nota2";
            nota2.Size = new Size(46, 22);
            nota2.TabIndex = 7;
            // 
            // nota3
            // 
            nota3.BackColor = SystemColors.InactiveBorder;
            nota3.Location = new Point(419, 112);
            nota3.Name = "nota3";
            nota3.Size = new Size(46, 22);
            nota3.TabIndex = 8;
            // 
            // nota4
            // 
            nota4.BackColor = SystemColors.InactiveBorder;
            nota4.Location = new Point(471, 112);
            nota4.Name = "nota4";
            nota4.Size = new Size(46, 22);
            nota4.TabIndex = 9;
            // 
            // textNota1
            // 
            textNota1.AutoSize = true;
            textNota1.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNota1.Location = new Point(315, 92);
            textNota1.Name = "textNota1";
            textNota1.Size = new Size(46, 15);
            textNota1.TabIndex = 10;
            textNota1.Text = "NOTA 1";
            // 
            // textNota2
            // 
            textNota2.AutoSize = true;
            textNota2.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNota2.Location = new Point(367, 93);
            textNota2.Name = "textNota2";
            textNota2.Size = new Size(46, 15);
            textNota2.TabIndex = 11;
            textNota2.Text = "NOTA 2";
            // 
            // textNota3
            // 
            textNota3.AutoSize = true;
            textNota3.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNota3.Location = new Point(419, 94);
            textNota3.Name = "textNota3";
            textNota3.Size = new Size(46, 15);
            textNota3.TabIndex = 12;
            textNota3.Text = "NOTA 3";
            // 
            // textNota4
            // 
            textNota4.AutoSize = true;
            textNota4.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNota4.Location = new Point(471, 94);
            textNota4.Name = "textNota4";
            textNota4.Size = new Size(46, 15);
            textNota4.TabIndex = 13;
            textNota4.Text = "NOTA 4";
            // 
            // promedioNotas
            // 
            promedioNotas.AutoSize = true;
            promedioNotas.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            promedioNotas.Location = new Point(74, 149);
            promedioNotas.Name = "promedioNotas";
            promedioNotas.Size = new Size(106, 15);
            promedioNotas.TabIndex = 14;
            promedioNotas.Text = "PROMEDIO NOTAS";
            // 
            // notaMasBaja
            // 
            notaMasBaja.AutoSize = true;
            notaMasBaja.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notaMasBaja.Location = new Point(89, 178);
            notaMasBaja.Name = "notaMasBaja";
            notaMasBaja.Size = new Size(91, 15);
            notaMasBaja.TabIndex = 15;
            notaMasBaja.Text = "NOTA MAS BAJA";
            // 
            // condicion
            // 
            condicion.AutoSize = true;
            condicion.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            condicion.Location = new Point(109, 210);
            condicion.Name = "condicion";
            condicion.Size = new Size(71, 15);
            condicion.TabIndex = 16;
            condicion.Text = "CONDICION";
            // 
            // resultPromedio
            // 
            resultPromedio.AutoSize = true;
            resultPromedio.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultPromedio.Location = new Point(189, 149);
            resultPromedio.Name = "resultPromedio";
            resultPromedio.Size = new Size(38, 15);
            resultPromedio.TabIndex = 17;
            resultPromedio.Text = "00,00";
            // 
            // resultMasBaja
            // 
            resultMasBaja.AutoSize = true;
            resultMasBaja.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultMasBaja.Location = new Point(189, 178);
            resultMasBaja.Name = "resultMasBaja";
            resultMasBaja.Size = new Size(38, 15);
            resultMasBaja.TabIndex = 18;
            resultMasBaja.Text = "00,00";
            // 
            // resultCondicion
            // 
            resultCondicion.AutoSize = true;
            resultCondicion.Font = new Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultCondicion.Location = new Point(189, 210);
            resultCondicion.Name = "resultCondicion";
            resultCondicion.Size = new Size(39, 15);
            resultCondicion.TabIndex = 19;
            resultCondicion.Text = "--------";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(538, 261);
            Controls.Add(resultCondicion);
            Controls.Add(resultMasBaja);
            Controls.Add(resultPromedio);
            Controls.Add(condicion);
            Controls.Add(notaMasBaja);
            Controls.Add(promedioNotas);
            Controls.Add(textNota4);
            Controls.Add(textNota3);
            Controls.Add(textNota2);
            Controls.Add(textNota1);
            Controls.Add(nota4);
            Controls.Add(nota3);
            Controls.Add(nota2);
            Controls.Add(nota1);
            Controls.Add(registroNotas);
            Controls.Add(limpiar);
            Controls.Add(calcular);
            Controls.Add(textAlumno);
            Controls.Add(alumno);
            Controls.Add(header);
            Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label header;
        private Label alumno;
        private TextBox textAlumno;
        private Button calcular;
        private Button limpiar;
        private Label registroNotas;
        private TextBox nota1;
        private TextBox nota2;
        private TextBox nota3;
        private TextBox nota4;
        private Label textNota1;
        private Label textNota2;
        private Label textNota3;
        private Label textNota4;
        private Label promedioNotas;
        private Label notaMasBaja;
        private Label condicion;
        private Label resultPromedio;
        private Label resultMasBaja;
        private Label resultCondicion;
        private ErrorProvider errorProvider;
    }
}
