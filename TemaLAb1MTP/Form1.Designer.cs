namespace TemaLAb1MTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnSqrt = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnimpart = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnminus = new Button();
            btnvirgula = new Button();
            btn0 = new Button();
            btnplus = new Button();
            btninmultire = new Button();
            btnplusminus = new Button();
            btnegal = new Button();
            btnexit = new Button();
            btnclear = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(567, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(66, 166);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(374, 424);
            listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(66, 45);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 93);
            textBox1.TabIndex = 2;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btn7
            // 
            btn7.Location = new Point(90, 196);
            btn7.Name = "btn7";
            btn7.Size = new Size(52, 44);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(169, 196);
            btn8.Name = "btn8";
            btn8.Size = new Size(52, 44);
            btn8.TabIndex = 4;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(249, 196);
            btn9.Name = "btn9";
            btn9.Size = new Size(52, 44);
            btn9.TabIndex = 5;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.Location = new Point(342, 196);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(52, 44);
            btnSqrt.TabIndex = 6;
            btnSqrt.Text = "sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            btnSqrt.Click += operation_click;
            // 
            // btn4
            // 
            btn4.Location = new Point(90, 275);
            btn4.Name = "btn4";
            btn4.Size = new Size(52, 44);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(169, 275);
            btn5.Name = "btn5";
            btn5.Size = new Size(52, 44);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(249, 275);
            btn6.Name = "btn6";
            btn6.Size = new Size(52, 44);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button_Click;
            // 
            // btnimpart
            // 
            btnimpart.Location = new Point(342, 275);
            btnimpart.Name = "btnimpart";
            btnimpart.Size = new Size(52, 44);
            btnimpart.TabIndex = 10;
            btnimpart.Text = "/";
            btnimpart.UseVisualStyleBackColor = true;
            btnimpart.Click += operation_click;
            // 
            // btn3
            // 
            btn3.Location = new Point(90, 350);
            btn3.Name = "btn3";
            btn3.Size = new Size(52, 44);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(169, 350);
            btn2.Name = "btn2";
            btn2.Size = new Size(52, 44);
            btn2.TabIndex = 12;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(249, 350);
            btn1.Name = "btn1";
            btn1.Size = new Size(52, 44);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button_Click;
            // 
            // btnminus
            // 
            btnminus.Location = new Point(342, 349);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(52, 44);
            btnminus.TabIndex = 14;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            btnminus.Click += operation_click;
            // 
            // btnvirgula
            // 
            btnvirgula.Location = new Point(90, 421);
            btnvirgula.Name = "btnvirgula";
            btnvirgula.Size = new Size(52, 44);
            btnvirgula.TabIndex = 15;
            btnvirgula.Text = ",";
            btnvirgula.UseVisualStyleBackColor = true;
            btnvirgula.Click += button_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(169, 421);
            btn0.Name = "btn0";
            btn0.Size = new Size(52, 44);
            btn0.TabIndex = 16;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button_Click;
            // 
            // btnplus
            // 
            btnplus.Location = new Point(249, 421);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(52, 44);
            btnplus.TabIndex = 17;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += operation_click;
            // 
            // btninmultire
            // 
            btninmultire.Location = new Point(342, 421);
            btninmultire.Name = "btninmultire";
            btninmultire.Size = new Size(52, 44);
            btninmultire.TabIndex = 18;
            btninmultire.Text = "*";
            btninmultire.UseVisualStyleBackColor = true;
            btninmultire.Click += operation_click;
            // 
            // btnplusminus
            // 
            btnplusminus.Location = new Point(90, 496);
            btnplusminus.Name = "btnplusminus";
            btnplusminus.Size = new Size(131, 44);
            btnplusminus.TabIndex = 19;
            btnplusminus.Text = "+/-";
            btnplusminus.UseVisualStyleBackColor = true;
            // 
            // btnegal
            // 
            btnegal.Location = new Point(249, 496);
            btnegal.Name = "btnegal";
            btnegal.Size = new Size(145, 44);
            btnegal.TabIndex = 20;
            btnegal.Text = "=";
            btnegal.UseVisualStyleBackColor = true;
            btnegal.Click += btnegal_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(90, 609);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(131, 44);
            btnexit.TabIndex = 21;
            btnexit.Text = "exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(249, 609);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(145, 44);
            btnclear.TabIndex = 22;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 665);
            Controls.Add(btnclear);
            Controls.Add(btnexit);
            Controls.Add(btnegal);
            Controls.Add(btnplusminus);
            Controls.Add(btninmultire);
            Controls.Add(btnplus);
            Controls.Add(btn0);
            Controls.Add(btnvirgula);
            Controls.Add(btnminus);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btnimpart);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnSqrt);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ListBox listBox1;
        private TextBox textBox1;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnSqrt;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnimpart;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnminus;
        private Button btnvirgula;
        private Button btn0;
        private Button btnplus;
        private Button btninmultire;
        private Button btnplusminus;
        private Button btnegal;
        private Button btnexit;
        private Button btnclear;
    }
}