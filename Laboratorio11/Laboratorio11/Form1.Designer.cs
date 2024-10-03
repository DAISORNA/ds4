namespace Laboratorio11
{
    partial class btnClickThis
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
            button1 = new Button();
            lblHelloWorld = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(148, 158);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Click this";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblHelloWorld
            // 
            lblHelloWorld.AutoSize = true;
            lblHelloWorld.Location = new Point(167, 254);
            lblHelloWorld.Name = "lblHelloWorld";
            lblHelloWorld.Size = new Size(50, 20);
            lblHelloWorld.TabIndex = 1;
            lblHelloWorld.Text = "label1";
            lblHelloWorld.Click += lblHelloWorld_Click;
            // 
            // btnClickThis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHelloWorld);
            Controls.Add(button1);
            Name = "btnClickThis";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblHelloWorld;
    }
}
