namespace Projekt.Forms
{
    partial class Form2
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorLabel1 = new System.Windows.Forms.Label();
            this.ocenaComboBox = new System.Windows.Forms.ComboBox();
            this.ocenaLabel = new System.Windows.Forms.Label();
            this.idNauczycielaTextBox = new System.Windows.Forms.TextBox();
            this.idNauczycielaLabel = new System.Windows.Forms.Label();
            this.wystawButton = new System.Windows.Forms.Button();
            this.idUczniaTextBox = new System.Windows.Forms.TextBox();
            this.idUczniaLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usunRadio = new System.Windows.Forms.RadioButton();
            this.edytujRadio = new System.Windows.Forms.RadioButton();
            this.nowaComboBox = new System.Windows.Forms.ComboBox();
            this.nowaLabel = new System.Windows.Forms.Label();
            this.edytujUsunButton = new System.Windows.Forms.Button();
            this.idOcenyTextBox = new System.Windows.Forms.TextBox();
            this.idOcenyLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wynikLabel = new System.Windows.Forms.Label();
            this.przedmiotComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sredniaButton = new System.Windows.Forms.Button();
            this.sredniaIDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listaOcenButton = new System.Windows.Forms.Button();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 8);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(231, 433);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 30F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "E-Dziennik";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F);
            this.button1.Location = new System.Drawing.Point(3, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zarządzanie uczniami i nauczycielami";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 10F);
            this.button2.Location = new System.Drawing.Point(3, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zarządzanie ocenami";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 11.25F);
            this.label2.Location = new System.Drawing.Point(3, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 63);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autor: Robin Verbist\r\nIndeks: 31888\r\nInformatyka Online";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.errorLabel1);
            this.groupBox2.Controls.Add(this.ocenaComboBox);
            this.groupBox2.Controls.Add(this.ocenaLabel);
            this.groupBox2.Controls.Add(this.idNauczycielaTextBox);
            this.groupBox2.Controls.Add(this.idNauczycielaLabel);
            this.groupBox2.Controls.Add(this.wystawButton);
            this.groupBox2.Controls.Add(this.idUczniaTextBox);
            this.groupBox2.Controls.Add(this.idUczniaLabel);
            this.groupBox2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(243, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 152);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wystawianie ocen";
            // 
            // errorLabel1
            // 
            this.errorLabel1.AutoSize = true;
            this.errorLabel1.Location = new System.Drawing.Point(23, 130);
            this.errorLabel1.Name = "errorLabel1";
            this.errorLabel1.Size = new System.Drawing.Size(0, 13);
            this.errorLabel1.TabIndex = 21;
            this.errorLabel1.Visible = false;
            // 
            // ocenaComboBox
            // 
            this.ocenaComboBox.FormattingEnabled = true;
            this.ocenaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.ocenaComboBox.Location = new System.Drawing.Point(91, 58);
            this.ocenaComboBox.Name = "ocenaComboBox";
            this.ocenaComboBox.Size = new System.Drawing.Size(43, 21);
            this.ocenaComboBox.TabIndex = 20;
            // 
            // ocenaLabel
            // 
            this.ocenaLabel.AutoSize = true;
            this.ocenaLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.ocenaLabel.Location = new System.Drawing.Point(22, 56);
            this.ocenaLabel.Name = "ocenaLabel";
            this.ocenaLabel.Size = new System.Drawing.Size(63, 23);
            this.ocenaLabel.TabIndex = 19;
            this.ocenaLabel.Text = "Ocena:";
            // 
            // idNauczycielaTextBox
            // 
            this.idNauczycielaTextBox.Location = new System.Drawing.Point(311, 28);
            this.idNauczycielaTextBox.Name = "idNauczycielaTextBox";
            this.idNauczycielaTextBox.Size = new System.Drawing.Size(65, 22);
            this.idNauczycielaTextBox.TabIndex = 18;
            // 
            // idNauczycielaLabel
            // 
            this.idNauczycielaLabel.AutoSize = true;
            this.idNauczycielaLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.idNauczycielaLabel.Location = new System.Drawing.Point(183, 28);
            this.idNauczycielaLabel.Name = "idNauczycielaLabel";
            this.idNauczycielaLabel.Size = new System.Drawing.Size(122, 23);
            this.idNauczycielaLabel.TabIndex = 17;
            this.idNauczycielaLabel.Text = "ID nauczyciela:";
            // 
            // wystawButton
            // 
            this.wystawButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.wystawButton.Location = new System.Drawing.Point(26, 94);
            this.wystawButton.Name = "wystawButton";
            this.wystawButton.Size = new System.Drawing.Size(381, 33);
            this.wystawButton.TabIndex = 16;
            this.wystawButton.Text = "Wystaw ocenę";
            this.wystawButton.UseVisualStyleBackColor = true;
            this.wystawButton.Click += new System.EventHandler(this.wystawButton_Click);
            // 
            // idUczniaTextBox
            // 
            this.idUczniaTextBox.Location = new System.Drawing.Point(112, 28);
            this.idUczniaTextBox.Name = "idUczniaTextBox";
            this.idUczniaTextBox.Size = new System.Drawing.Size(65, 22);
            this.idUczniaTextBox.TabIndex = 16;
            // 
            // idUczniaLabel
            // 
            this.idUczniaLabel.AutoSize = true;
            this.idUczniaLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.idUczniaLabel.Location = new System.Drawing.Point(22, 28);
            this.idUczniaLabel.Name = "idUczniaLabel";
            this.idUczniaLabel.Size = new System.Drawing.Size(84, 23);
            this.idUczniaLabel.TabIndex = 16;
            this.idUczniaLabel.Text = "ID ucznia:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.usunRadio);
            this.groupBox1.Controls.Add(this.edytujRadio);
            this.groupBox1.Controls.Add(this.nowaComboBox);
            this.groupBox1.Controls.Add(this.nowaLabel);
            this.groupBox1.Controls.Add(this.edytujUsunButton);
            this.groupBox1.Controls.Add(this.idOcenyTextBox);
            this.groupBox1.Controls.Add(this.idOcenyLabel);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(243, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 119);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edycja/Usuwanie ocen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "label3";
            // 
            // usunRadio
            // 
            this.usunRadio.AutoSize = true;
            this.usunRadio.Location = new System.Drawing.Point(91, 21);
            this.usunRadio.Name = "usunRadio";
            this.usunRadio.Size = new System.Drawing.Size(49, 17);
            this.usunRadio.TabIndex = 22;
            this.usunRadio.TabStop = true;
            this.usunRadio.Text = "Usuń";
            this.usunRadio.UseVisualStyleBackColor = true;
            // 
            // edytujRadio
            // 
            this.edytujRadio.AutoSize = true;
            this.edytujRadio.Location = new System.Drawing.Point(26, 21);
            this.edytujRadio.Name = "edytujRadio";
            this.edytujRadio.Size = new System.Drawing.Size(54, 17);
            this.edytujRadio.TabIndex = 21;
            this.edytujRadio.TabStop = true;
            this.edytujRadio.Text = "Edytuj";
            this.edytujRadio.UseVisualStyleBackColor = true;
            this.edytujRadio.CheckedChanged += new System.EventHandler(this.edytujRadio_CheckedChanged);
            // 
            // nowaComboBox
            // 
            this.nowaComboBox.FormattingEnabled = true;
            this.nowaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.nowaComboBox.Location = new System.Drawing.Point(294, 44);
            this.nowaComboBox.Name = "nowaComboBox";
            this.nowaComboBox.Size = new System.Drawing.Size(43, 21);
            this.nowaComboBox.TabIndex = 20;
            this.nowaComboBox.Visible = false;
            // 
            // nowaLabel
            // 
            this.nowaLabel.AutoSize = true;
            this.nowaLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.nowaLabel.Location = new System.Drawing.Point(179, 42);
            this.nowaLabel.Name = "nowaLabel";
            this.nowaLabel.Size = new System.Drawing.Size(109, 23);
            this.nowaLabel.TabIndex = 19;
            this.nowaLabel.Text = "Nowa ocena:";
            this.nowaLabel.Visible = false;
            // 
            // edytujUsunButton
            // 
            this.edytujUsunButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.edytujUsunButton.Location = new System.Drawing.Point(26, 70);
            this.edytujUsunButton.Name = "edytujUsunButton";
            this.edytujUsunButton.Size = new System.Drawing.Size(381, 33);
            this.edytujUsunButton.TabIndex = 16;
            this.edytujUsunButton.Text = "Edytuj/Usuń ocenę";
            this.edytujUsunButton.UseVisualStyleBackColor = true;
            this.edytujUsunButton.Click += new System.EventHandler(this.edytujUsunButton_Click);
            // 
            // idOcenyTextBox
            // 
            this.idOcenyTextBox.Location = new System.Drawing.Point(108, 46);
            this.idOcenyTextBox.Name = "idOcenyTextBox";
            this.idOcenyTextBox.Size = new System.Drawing.Size(65, 22);
            this.idOcenyTextBox.TabIndex = 16;
            // 
            // idOcenyLabel
            // 
            this.idOcenyLabel.AutoSize = true;
            this.idOcenyLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.idOcenyLabel.Location = new System.Drawing.Point(22, 42);
            this.idOcenyLabel.Name = "idOcenyLabel";
            this.idOcenyLabel.Size = new System.Drawing.Size(80, 23);
            this.idOcenyLabel.TabIndex = 16;
            this.idOcenyLabel.Text = "ID oceny:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wynikLabel);
            this.groupBox3.Controls.Add(this.przedmiotComboBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.sredniaButton);
            this.groupBox3.Controls.Add(this.sredniaIDTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(243, 291);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 111);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Oblicz średnią";
            // 
            // wynikLabel
            // 
            this.wynikLabel.AutoSize = true;
            this.wynikLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F);
            this.wynikLabel.Location = new System.Drawing.Point(23, 92);
            this.wynikLabel.Name = "wynikLabel";
            this.wynikLabel.Size = new System.Drawing.Size(0, 13);
            this.wynikLabel.TabIndex = 22;
            // 
            // przedmiotComboBox
            // 
            this.przedmiotComboBox.FormattingEnabled = true;
            this.przedmiotComboBox.Items.AddRange(new object[] {
            "j. polski",
            "matematyka",
            "j. angielski",
            "informatyka",
            "wf"});
            this.przedmiotComboBox.Location = new System.Drawing.Point(280, 28);
            this.przedmiotComboBox.Name = "przedmiotComboBox";
            this.przedmiotComboBox.Size = new System.Drawing.Size(112, 21);
            this.przedmiotComboBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.label4.Location = new System.Drawing.Point(183, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Przedmiot:";
            // 
            // sredniaButton
            // 
            this.sredniaButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.sredniaButton.Location = new System.Drawing.Point(26, 56);
            this.sredniaButton.Name = "sredniaButton";
            this.sredniaButton.Size = new System.Drawing.Size(381, 33);
            this.sredniaButton.TabIndex = 16;
            this.sredniaButton.Text = "Oblicz średnią";
            this.sredniaButton.UseVisualStyleBackColor = true;
            this.sredniaButton.Click += new System.EventHandler(this.sredniaButton_Click);
            // 
            // sredniaIDTextBox
            // 
            this.sredniaIDTextBox.Location = new System.Drawing.Point(112, 28);
            this.sredniaIDTextBox.Name = "sredniaIDTextBox";
            this.sredniaIDTextBox.Size = new System.Drawing.Size(65, 22);
            this.sredniaIDTextBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.label5.Location = new System.Drawing.Point(22, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "ID ucznia:";
            // 
            // listaOcenButton
            // 
            this.listaOcenButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.listaOcenButton.Location = new System.Drawing.Point(269, 408);
            this.listaOcenButton.Name = "listaOcenButton";
            this.listaOcenButton.Size = new System.Drawing.Size(381, 33);
            this.listaOcenButton.TabIndex = 23;
            this.listaOcenButton.Text = "Lista ocen";
            this.listaOcenButton.UseVisualStyleBackColor = true;
            this.listaOcenButton.Click += new System.EventHandler(this.listaOcenButton_Click);
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.Location = new System.Drawing.Point(266, 272);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(0, 13);
            this.errorLabel2.TabIndex = 23;
            this.errorLabel2.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.errorLabel2);
            this.Controls.Add(this.listaOcenButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button wystawButton;
        private System.Windows.Forms.TextBox idUczniaTextBox;
        private System.Windows.Forms.Label idUczniaLabel;
        private System.Windows.Forms.TextBox idNauczycielaTextBox;
        private System.Windows.Forms.Label idNauczycielaLabel;
        private System.Windows.Forms.ComboBox ocenaComboBox;
        private System.Windows.Forms.Label ocenaLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton usunRadio;
        private System.Windows.Forms.RadioButton edytujRadio;
        private System.Windows.Forms.ComboBox nowaComboBox;
        private System.Windows.Forms.Label nowaLabel;
        private System.Windows.Forms.Button edytujUsunButton;
        private System.Windows.Forms.TextBox idOcenyTextBox;
        private System.Windows.Forms.Label idOcenyLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button sredniaButton;
        private System.Windows.Forms.TextBox sredniaIDTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label wynikLabel;
        private System.Windows.Forms.ComboBox przedmiotComboBox;
        private System.Windows.Forms.Button listaOcenButton;
        private System.Windows.Forms.Label errorLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label errorLabel2;
    }
}