namespace Laboratorio12_1;

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
        textBoxresultado = new TextBox();
        numtiempo = new TextBox();
        numvelocidad = new TextBox();
        labeldistreco = new Label();
        buttonsalir = new Button();
        buttonlimpiar = new Button();
        buttoncalcular = new Button();
        labeltiempo = new Label();
        labelvelocidad = new Label();
        label1 = new Label();
        SuspendLayout();
        // 
        // textBoxresultado
        // 
        textBoxresultado.Location = new Point(426, 366);
        textBoxresultado.Name = "textBoxresultado";
        textBoxresultado.Size = new Size(125, 27);
        textBoxresultado.TabIndex = 31;
        textBoxresultado.TextChanged += TextBox3_TextChanged_1;
        // 
        // numtiempo
        // 
        numtiempo.Location = new Point(426, 185);
        numtiempo.Name = "numtiempo";
        numtiempo.Size = new Size(125, 27);
        numtiempo.TabIndex = 30;
        // 
        // numvelocidad
        // 
        numvelocidad.Location = new Point(426, 126);
        numvelocidad.Name = "numvelocidad";
        numvelocidad.Size = new Size(125, 27);
        numvelocidad.TabIndex = 29;
        numvelocidad.TextChanged += TextBox1_TextChanged;
        // 
        // labeldistreco
        // 
        labeldistreco.AutoSize = true;
        labeldistreco.Location = new Point(179, 373);
        labeldistreco.Name = "labeldistreco";
        labeldistreco.Size = new Size(172, 20);
        labeldistreco.TabIndex = 28;
        labeldistreco.Text = "Distancia Recorrida (km)";
        // 
        // buttonsalir
        // 
        buttonsalir.Location = new Point(551, 304);
        buttonsalir.Name = "buttonsalir";
        buttonsalir.Size = new Size(94, 29);
        buttonsalir.TabIndex = 27;
        buttonsalir.Text = "Salir";
        buttonsalir.UseVisualStyleBackColor = true;
        buttonsalir.Click += Button3_Click;
        // 
        // buttonlimpiar
        // 
        buttonlimpiar.Location = new Point(358, 304);
        buttonlimpiar.Name = "buttonlimpiar";
        buttonlimpiar.Size = new Size(94, 29);
        buttonlimpiar.TabIndex = 26;
        buttonlimpiar.Text = "Limpiar Contenido";
        buttonlimpiar.UseVisualStyleBackColor = true;
        buttonlimpiar.Click += Button2_Click;
        // 
        // buttoncalcular
        // 
        buttoncalcular.Location = new Point(129, 304);
        buttoncalcular.Name = "buttoncalcular";
        buttoncalcular.Size = new Size(150, 29);
        buttoncalcular.TabIndex = 25;
        buttoncalcular.Text = "Calcular Distancia";
        buttoncalcular.UseVisualStyleBackColor = true;
        buttoncalcular.Click += Button1_Click;
        // 
        // labeltiempo
        // 
        labeltiempo.AutoSize = true;
        labeltiempo.Location = new Point(179, 192);
        labeltiempo.Name = "labeltiempo";
        labeltiempo.Size = new Size(82, 20);
        labeltiempo.TabIndex = 24;
        labeltiempo.Text = "Tiempo (h)";
        // 
        // labelvelocidad
        // 
        labelvelocidad.AutoSize = true;
        labelvelocidad.Location = new Point(179, 133);
        labelvelocidad.Name = "labelvelocidad";
        labelvelocidad.Size = new Size(123, 20);
        labelvelocidad.TabIndex = 23;
        labelvelocidad.Text = "Velocidad (km/h)";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(277, 27);
        label1.Name = "label1";
        label1.Size = new Size(242, 20);
        label1.TabIndex = 22;
        label1.Text = "Calculadora de Distancia Recorrida";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(textBoxresultado);
        Controls.Add(numtiempo);
        Controls.Add(numvelocidad);
        Controls.Add(labeldistreco);
        Controls.Add(buttonsalir);
        Controls.Add(buttonlimpiar);
        Controls.Add(buttoncalcular);
        Controls.Add(labeltiempo);
        Controls.Add(labelvelocidad);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textBoxresultado;
    private TextBox numtiempo;
    private TextBox numvelocidad;
    private Label labeldistreco;
    private Button buttonsalir;
    private Button buttonlimpiar;
    private Button buttoncalcular;
    private Label labeltiempo;
    private Label labelvelocidad;
    private Label label1;
}
