namespace PATrilhasAtiv10_D
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            btnPress = new Button();
            btnSair = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 10);
            label1.Name = "label1";
            label1.Size = new Size(266, 20);
            label1.TabIndex = 0;
            label1.Text = "Escolha uma das Opções para ser Exibida!";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Amar", "Odiar", "Entender", "Invejar", "Amigar" });
            comboBox1.Location = new Point(124, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(419, 23);
            comboBox1.TabIndex = 1;
            // 
            // btnPress
            // 
            btnPress.Location = new Point(297, 121);
            btnPress.Name = "btnPress";
            btnPress.Size = new Size(83, 23);
            btnPress.TabIndex = 2;
            btnPress.Text = "Press Button";
            btnPress.UseVisualStyleBackColor = true;
            btnPress.Click += btnPress_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(536, 272);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 180);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(419, 23);
            textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 316);
            Controls.Add(textBox1);
            Controls.Add(btnSair);
            Controls.Add(btnPress);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button btnPress;
        private Button btnSair;
        private TextBox textBox1;
    }
}
