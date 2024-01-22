namespace loginForm
{
    partial class FormMain
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
            this.listBox_Autok = new System.Windows.Forms.ListBox();
            this.groupBox_Kivalasztott = new System.Windows.Forms.GroupBox();
            this.textBox_teljesitmeny = new System.Windows.Forms.TextBox();
            this.textBox_tomeg = new System.Windows.Forms.TextBox();
            this.textBox_henger = new System.Windows.Forms.TextBox();
            this.textBox_km = new System.Windows.Forms.TextBox();
            this.textBox_vetelar = new System.Windows.Forms.TextBox();
            this.textBox_gyartas = new System.Windows.Forms.TextBox();
            this.textBox_modell = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_forgalmi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_marka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_rendszam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_New = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.groupBox_Kivalasztott.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Autok
            // 
            this.listBox_Autok.FormattingEnabled = true;
            this.listBox_Autok.Location = new System.Drawing.Point(13, 7);
            this.listBox_Autok.Name = "listBox_Autok";
            this.listBox_Autok.Size = new System.Drawing.Size(152, 381);
            this.listBox_Autok.TabIndex = 2;
            this.listBox_Autok.SelectedIndexChanged += new System.EventHandler(this.listBox_Autok_SelectedIndexChanged);
            // 
            // groupBox_Kivalasztott
            // 
            this.groupBox_Kivalasztott.Controls.Add(this.textBox_teljesitmeny);
            this.groupBox_Kivalasztott.Controls.Add(this.textBox_tomeg);
            this.groupBox_Kivalasztott.Controls.Add(this.textBox_henger);
            this.groupBox_Kivalasztott.Controls.Add(this.textBox_km);
            this.groupBox_Kivalasztott.Controls.Add(this.textBox_vetelar);
            this.groupBox_Kivalasztott.Controls.Add(this.textBox_gyartas);
            this.groupBox_Kivalasztott.Controls.Add(this.textBox_modell);
            this.groupBox_Kivalasztott.Controls.Add(this.label10);
            this.groupBox_Kivalasztott.Controls.Add(this.label9);
            this.groupBox_Kivalasztott.Controls.Add(this.label8);
            this.groupBox_Kivalasztott.Controls.Add(this.label7);
            this.groupBox_Kivalasztott.Controls.Add(this.label6);
            this.groupBox_Kivalasztott.Controls.Add(this.label5);
            this.groupBox_Kivalasztott.Controls.Add(this.label4);
            this.groupBox_Kivalasztott.Controls.Add(this.dateTimePicker_forgalmi);
            this.groupBox_Kivalasztott.Controls.Add(this.label3);
            this.groupBox_Kivalasztott.Controls.Add(this.textBox_marka);
            this.groupBox_Kivalasztott.Controls.Add(this.label2);
            this.groupBox_Kivalasztott.Controls.Add(this.textBox_rendszam);
            this.groupBox_Kivalasztott.Controls.Add(this.label1);
            this.groupBox_Kivalasztott.Location = new System.Drawing.Point(171, 7);
            this.groupBox_Kivalasztott.Name = "groupBox_Kivalasztott";
            this.groupBox_Kivalasztott.Size = new System.Drawing.Size(243, 342);
            this.groupBox_Kivalasztott.TabIndex = 3;
            this.groupBox_Kivalasztott.TabStop = false;
            this.groupBox_Kivalasztott.Text = "Kiválasztott autó";
            // 
            // textBox_teljesitmeny
            // 
            this.textBox_teljesitmeny.Location = new System.Drawing.Point(80, 312);
            this.textBox_teljesitmeny.Name = "textBox_teljesitmeny";
            this.textBox_teljesitmeny.Size = new System.Drawing.Size(149, 20);
            this.textBox_teljesitmeny.TabIndex = 19;
            // 
            // textBox_tomeg
            // 
            this.textBox_tomeg.Location = new System.Drawing.Point(81, 280);
            this.textBox_tomeg.Name = "textBox_tomeg";
            this.textBox_tomeg.Size = new System.Drawing.Size(148, 20);
            this.textBox_tomeg.TabIndex = 18;
            // 
            // textBox_henger
            // 
            this.textBox_henger.Location = new System.Drawing.Point(82, 248);
            this.textBox_henger.Name = "textBox_henger";
            this.textBox_henger.Size = new System.Drawing.Size(147, 20);
            this.textBox_henger.TabIndex = 17;
            // 
            // textBox_km
            // 
            this.textBox_km.Location = new System.Drawing.Point(81, 216);
            this.textBox_km.Name = "textBox_km";
            this.textBox_km.Size = new System.Drawing.Size(148, 20);
            this.textBox_km.TabIndex = 16;
            // 
            // textBox_vetelar
            // 
            this.textBox_vetelar.Location = new System.Drawing.Point(82, 184);
            this.textBox_vetelar.Name = "textBox_vetelar";
            this.textBox_vetelar.Size = new System.Drawing.Size(147, 20);
            this.textBox_vetelar.TabIndex = 15;
            // 
            // textBox_gyartas
            // 
            this.textBox_gyartas.Location = new System.Drawing.Point(82, 120);
            this.textBox_gyartas.Name = "textBox_gyartas";
            this.textBox_gyartas.Size = new System.Drawing.Size(147, 20);
            this.textBox_gyartas.TabIndex = 14;
            // 
            // textBox_modell
            // 
            this.textBox_modell.Location = new System.Drawing.Point(81, 88);
            this.textBox_modell.Name = "textBox_modell";
            this.textBox_modell.Size = new System.Drawing.Size(148, 20);
            this.textBox_modell.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Teljesítmény";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tömeg";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Hengerűrtar.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Km állás";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vételár";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Forgalmi érv.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gyártási év";
            // 
            // dateTimePicker_forgalmi
            // 
            this.dateTimePicker_forgalmi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_forgalmi.Location = new System.Drawing.Point(82, 152);
            this.dateTimePicker_forgalmi.Name = "dateTimePicker_forgalmi";
            this.dateTimePicker_forgalmi.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker_forgalmi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modell";
            // 
            // textBox_marka
            // 
            this.textBox_marka.Location = new System.Drawing.Point(81, 56);
            this.textBox_marka.Name = "textBox_marka";
            this.textBox_marka.Size = new System.Drawing.Size(148, 20);
            this.textBox_marka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Márka";
            // 
            // textBox_rendszam
            // 
            this.textBox_rendszam.Location = new System.Drawing.Point(82, 24);
            this.textBox_rendszam.Name = "textBox_rendszam";
            this.textBox_rendszam.Size = new System.Drawing.Size(147, 20);
            this.textBox_rendszam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rendszám";
            // 
            // button_New
            // 
            this.button_New.Location = new System.Drawing.Point(171, 366);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(75, 23);
            this.button_New.TabIndex = 4;
            this.button_New.Text = "Új";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(258, 365);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(75, 23);
            this.button_Edit.TabIndex = 5;
            this.button_Edit.Text = "Módosít";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(345, 365);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Töröl";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 398);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.groupBox_Kivalasztott);
            this.Controls.Add(this.listBox_Autok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "Adatbázis";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox_Kivalasztott.ResumeLayout(false);
            this.groupBox_Kivalasztott.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Autok;
        private System.Windows.Forms.GroupBox groupBox_Kivalasztott;
        private System.Windows.Forms.DateTimePicker dateTimePicker_forgalmi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_marka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_rendszam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_modell;
        private System.Windows.Forms.TextBox textBox_gyartas;
        private System.Windows.Forms.TextBox textBox_teljesitmeny;
        private System.Windows.Forms.TextBox textBox_tomeg;
        private System.Windows.Forms.TextBox textBox_henger;
        private System.Windows.Forms.TextBox textBox_km;
        private System.Windows.Forms.TextBox textBox_vetelar;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Button button_Delete;

    }
}