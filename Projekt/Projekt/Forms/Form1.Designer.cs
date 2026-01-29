namespace Projekt.Forms
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.przedmiotComboBox = new System.Windows.Forms.ComboBox();
            this.przedmiotLabel = new System.Windows.Forms.Label();
            this.klasaComboBox = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.NauczycielRadio = new System.Windows.Forms.RadioButton();
            this.uczenRadio = new System.Windows.Forms.RadioButton();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.dodajButton = new System.Windows.Forms.Button();
            this.klasaLabel = new System.Windows.Forms.Label();
            this.rolaLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.nazwiskoLabel = new System.Windows.Forms.Label();
            this.imieLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.usunButton = new System.Windows.Forms.Button();
            this.nauczycielRadio2 = new System.Windows.Forms.RadioButton();
            this.uczenRadio2 = new System.Windows.Forms.RadioButton();
            this.rolaLabel2 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.listaUczniowButton = new System.Windows.Forms.Button();
            this.listaNauczycieliButton = new System.Windows.Forms.Button();
            this.errorLabel1 = new System.Windows.Forms.Label();
            this.errorLabel2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.errorLabel1);
            this.groupBox1.Controls.Add(this.przedmiotComboBox);
            this.groupBox1.Controls.Add(this.przedmiotLabel);
            this.groupBox1.Controls.Add(this.klasaComboBox);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.NauczycielRadio);
            this.groupBox1.Controls.Add(this.uczenRadio);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.nazwiskoTextBox);
            this.groupBox1.Controls.Add(this.imieTextBox);
            this.groupBox1.Controls.Add(this.dodajButton);
            this.groupBox1.Controls.Add(this.klasaLabel);
            this.groupBox1.Controls.Add(this.rolaLabel);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.dataLabel);
            this.groupBox1.Controls.Add(this.nazwiskoLabel);
            this.groupBox1.Controls.Add(this.imieLabel);
            this.groupBox1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(244, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 213);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie";
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
            this.przedmiotComboBox.Location = new System.Drawing.Point(119, 131);
            this.przedmiotComboBox.Name = "przedmiotComboBox";
            this.przedmiotComboBox.Size = new System.Drawing.Size(112, 21);
            this.przedmiotComboBox.TabIndex = 15;
            this.przedmiotComboBox.Visible = false;
            // 
            // przedmiotLabel
            // 
            this.przedmiotLabel.AutoSize = true;
            this.przedmiotLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.przedmiotLabel.Location = new System.Drawing.Point(22, 130);
            this.przedmiotLabel.Name = "przedmiotLabel";
            this.przedmiotLabel.Size = new System.Drawing.Size(91, 23);
            this.przedmiotLabel.TabIndex = 14;
            this.przedmiotLabel.Text = "Przedmiot:";
            this.przedmiotLabel.Visible = false;
            // 
            // klasaComboBox
            // 
            this.klasaComboBox.FormattingEnabled = true;
            this.klasaComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.klasaComboBox.Location = new System.Drawing.Point(81, 132);
            this.klasaComboBox.Name = "klasaComboBox";
            this.klasaComboBox.Size = new System.Drawing.Size(48, 21);
            this.klasaComboBox.TabIndex = 13;
            this.klasaComboBox.Visible = false;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(158, 53);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(96, 22);
            this.datePicker.TabIndex = 12;
            this.datePicker.Value = new System.DateTime(2026, 1, 29, 0, 0, 0, 0);
            // 
            // NauczycielRadio
            // 
            this.NauczycielRadio.AutoSize = true;
            this.NauczycielRadio.Location = new System.Drawing.Point(135, 109);
            this.NauczycielRadio.Name = "NauczycielRadio";
            this.NauczycielRadio.Size = new System.Drawing.Size(75, 17);
            this.NauczycielRadio.TabIndex = 11;
            this.NauczycielRadio.TabStop = true;
            this.NauczycielRadio.Text = "Nauczyciel";
            this.NauczycielRadio.UseVisualStyleBackColor = true;
            this.NauczycielRadio.CheckedChanged += new System.EventHandler(this.NauczycielRadio_CheckedChanged);
            // 
            // uczenRadio
            // 
            this.uczenRadio.AutoSize = true;
            this.uczenRadio.Location = new System.Drawing.Point(75, 109);
            this.uczenRadio.Name = "uczenRadio";
            this.uczenRadio.Size = new System.Drawing.Size(54, 17);
            this.uczenRadio.TabIndex = 10;
            this.uczenRadio.TabStop = true;
            this.uczenRadio.Text = "Uczeń";
            this.uczenRadio.UseVisualStyleBackColor = true;
            this.uczenRadio.CheckedChanged += new System.EventHandler(this.uczenRadio_CheckedChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(83, 81);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 22);
            this.emailTextBox.TabIndex = 9;
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(289, 25);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(118, 22);
            this.nazwiskoTextBox.TabIndex = 8;
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(74, 24);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(118, 22);
            this.imieTextBox.TabIndex = 0;
            // 
            // dodajButton
            // 
            this.dodajButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.dodajButton.Location = new System.Drawing.Point(26, 159);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(381, 33);
            this.dodajButton.TabIndex = 6;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // klasaLabel
            // 
            this.klasaLabel.AutoSize = true;
            this.klasaLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.klasaLabel.Location = new System.Drawing.Point(22, 130);
            this.klasaLabel.Name = "klasaLabel";
            this.klasaLabel.Size = new System.Drawing.Size(53, 23);
            this.klasaLabel.TabIndex = 5;
            this.klasaLabel.Text = "Klasa:";
            this.klasaLabel.Visible = false;
            // 
            // rolaLabel
            // 
            this.rolaLabel.AutoSize = true;
            this.rolaLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.rolaLabel.Location = new System.Drawing.Point(22, 104);
            this.rolaLabel.Name = "rolaLabel";
            this.rolaLabel.Size = new System.Drawing.Size(47, 23);
            this.rolaLabel.TabIndex = 4;
            this.rolaLabel.Text = "Rola:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.emailLabel.Location = new System.Drawing.Point(22, 80);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(55, 23);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email:";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.dataLabel.Location = new System.Drawing.Point(22, 52);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(130, 23);
            this.dataLabel.TabIndex = 2;
            this.dataLabel.Text = "Data urodzenia:";
            // 
            // nazwiskoLabel
            // 
            this.nazwiskoLabel.AutoSize = true;
            this.nazwiskoLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.nazwiskoLabel.Location = new System.Drawing.Point(198, 23);
            this.nazwiskoLabel.Name = "nazwiskoLabel";
            this.nazwiskoLabel.Size = new System.Drawing.Size(85, 23);
            this.nazwiskoLabel.TabIndex = 1;
            this.nazwiskoLabel.Text = "Nazwisko:";
            // 
            // imieLabel
            // 
            this.imieLabel.AutoSize = true;
            this.imieLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.imieLabel.Location = new System.Drawing.Point(22, 24);
            this.imieLabel.Name = "imieLabel";
            this.imieLabel.Size = new System.Drawing.Size(46, 23);
            this.imieLabel.TabIndex = 0;
            this.imieLabel.Text = "Imie:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.errorLabel2);
            this.groupBox2.Controls.Add(this.usunButton);
            this.groupBox2.Controls.Add(this.nauczycielRadio2);
            this.groupBox2.Controls.Add(this.uczenRadio2);
            this.groupBox2.Controls.Add(this.rolaLabel2);
            this.groupBox2.Controls.Add(this.idTextBox);
            this.groupBox2.Controls.Add(this.idLabel);
            this.groupBox2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(244, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 136);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuwanie";
            // 
            // usunButton
            // 
            this.usunButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.usunButton.Location = new System.Drawing.Point(26, 82);
            this.usunButton.Name = "usunButton";
            this.usunButton.Size = new System.Drawing.Size(381, 33);
            this.usunButton.TabIndex = 16;
            this.usunButton.Text = "Usuń";
            this.usunButton.UseVisualStyleBackColor = true;
            this.usunButton.Click += new System.EventHandler(this.usunButton_Click);
            // 
            // nauczycielRadio2
            // 
            this.nauczycielRadio2.AutoSize = true;
            this.nauczycielRadio2.Location = new System.Drawing.Point(134, 59);
            this.nauczycielRadio2.Name = "nauczycielRadio2";
            this.nauczycielRadio2.Size = new System.Drawing.Size(75, 17);
            this.nauczycielRadio2.TabIndex = 16;
            this.nauczycielRadio2.TabStop = true;
            this.nauczycielRadio2.Text = "Nauczyciel";
            this.nauczycielRadio2.UseVisualStyleBackColor = true;
            // 
            // uczenRadio2
            // 
            this.uczenRadio2.AutoSize = true;
            this.uczenRadio2.Location = new System.Drawing.Point(74, 59);
            this.uczenRadio2.Name = "uczenRadio2";
            this.uczenRadio2.Size = new System.Drawing.Size(54, 17);
            this.uczenRadio2.TabIndex = 16;
            this.uczenRadio2.TabStop = true;
            this.uczenRadio2.Text = "Uczeń";
            this.uczenRadio2.UseVisualStyleBackColor = true;
            // 
            // rolaLabel2
            // 
            this.rolaLabel2.AutoSize = true;
            this.rolaLabel2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.rolaLabel2.Location = new System.Drawing.Point(22, 54);
            this.rolaLabel2.Name = "rolaLabel2";
            this.rolaLabel2.Size = new System.Drawing.Size(47, 23);
            this.rolaLabel2.TabIndex = 16;
            this.rolaLabel2.Text = "Rola:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(58, 29);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(94, 22);
            this.idTextBox.TabIndex = 16;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.idLabel.Location = new System.Drawing.Point(22, 28);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(30, 23);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "ID:";
            // 
            // listaUczniowButton
            // 
            this.listaUczniowButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.listaUczniowButton.Location = new System.Drawing.Point(258, 369);
            this.listaUczniowButton.Name = "listaUczniowButton";
            this.listaUczniowButton.Size = new System.Drawing.Size(184, 33);
            this.listaUczniowButton.TabIndex = 14;
            this.listaUczniowButton.Text = "Lista uczniów";
            this.listaUczniowButton.UseVisualStyleBackColor = true;
            this.listaUczniowButton.Click += new System.EventHandler(this.listaUczniowButton_Click);
            // 
            // listaNauczycieliButton
            // 
            this.listaNauczycieliButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 12.25F);
            this.listaNauczycieliButton.Location = new System.Drawing.Point(467, 369);
            this.listaNauczycieliButton.Name = "listaNauczycieliButton";
            this.listaNauczycieliButton.Size = new System.Drawing.Size(184, 33);
            this.listaNauczycieliButton.TabIndex = 15;
            this.listaNauczycieliButton.Text = "Lista nauczycieli";
            this.listaNauczycieliButton.UseVisualStyleBackColor = true;
            this.listaNauczycieliButton.Click += new System.EventHandler(this.listaNauczycieliButton_Click);
            // 
            // errorLabel1
            // 
            this.errorLabel1.AutoSize = true;
            this.errorLabel1.Location = new System.Drawing.Point(23, 195);
            this.errorLabel1.Name = "errorLabel1";
            this.errorLabel1.Size = new System.Drawing.Size(0, 13);
            this.errorLabel1.TabIndex = 16;
            this.errorLabel1.Visible = false;
            // 
            // errorLabel2
            // 
            this.errorLabel2.AutoSize = true;
            this.errorLabel2.Location = new System.Drawing.Point(23, 120);
            this.errorLabel2.Name = "errorLabel2";
            this.errorLabel2.Size = new System.Drawing.Size(0, 13);
            this.errorLabel2.TabIndex = 17;
            this.errorLabel2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(670, 450);
            this.Controls.Add(this.listaNauczycieliButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listaUczniowButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Label klasaLabel;
        private System.Windows.Forms.Label rolaLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label nazwiskoLabel;
        private System.Windows.Forms.Label imieLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.ComboBox klasaComboBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.RadioButton NauczycielRadio;
        private System.Windows.Forms.RadioButton uczenRadio;
        private System.Windows.Forms.Button listaNauczycieliButton;
        private System.Windows.Forms.Button listaUczniowButton;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button usunButton;
        private System.Windows.Forms.RadioButton nauczycielRadio2;
        private System.Windows.Forms.RadioButton uczenRadio2;
        private System.Windows.Forms.Label rolaLabel2;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox przedmiotComboBox;
        private System.Windows.Forms.Label przedmiotLabel;
        private System.Windows.Forms.Label errorLabel1;
        private System.Windows.Forms.Label errorLabel2;
    }
}