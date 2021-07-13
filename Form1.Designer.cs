namespace encryptionProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonSHIFR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_in = new System.Windows.Forms.TextBox();
            this.text_out = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRASSHIFR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.copy_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSHIFR
            // 
            this.buttonSHIFR.Location = new System.Drawing.Point(175, 233);
            this.buttonSHIFR.Name = "buttonSHIFR";
            this.buttonSHIFR.Size = new System.Drawing.Size(104, 34);
            this.buttonSHIFR.TabIndex = 0;
            this.buttonSHIFR.Text = "Зашифровать";
            this.buttonSHIFR.UseVisualStyleBackColor = true;
            this.buttonSHIFR.Click += new System.EventHandler(this.buttonSHIFR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Шифрование текста";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text_in
            // 
            this.text_in.Location = new System.Drawing.Point(45, 130);
            this.text_in.Name = "text_in";
            this.text_in.Size = new System.Drawing.Size(234, 20);
            this.text_in.TabIndex = 2;
            // 
            // text_out
            // 
            this.text_out.Location = new System.Drawing.Point(45, 181);
            this.text_out.Name = "text_out";
            this.text_out.Size = new System.Drawing.Size(234, 20);
            this.text_out.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(42, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ввод";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRASSHIFR
            // 
            this.buttonRASSHIFR.Location = new System.Drawing.Point(45, 233);
            this.buttonRASSHIFR.Name = "buttonRASSHIFR";
            this.buttonRASSHIFR.Size = new System.Drawing.Size(104, 34);
            this.buttonRASSHIFR.TabIndex = 5;
            this.buttonRASSHIFR.Text = "Расшифровать";
            this.buttonRASSHIFR.UseVisualStyleBackColor = true;
            this.buttonRASSHIFR.Click += new System.EventHandler(this.buttonRASSHIFR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(42, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Вывод";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(97, 207);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(182, 20);
            this.key.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Location = new System.Drawing.Point(45, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ключ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Шифр Виженера (Русский язык)",
            "Шифр XOR (Английский язык)"});
            this.comboBox1.Location = new System.Drawing.Point(45, 78);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "Выберите нужный тип шифрования.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Location = new System.Drawing.Point(45, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тип шифрования";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copy_button
            // 
            this.copy_button.Location = new System.Drawing.Point(285, 181);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(23, 20);
            this.copy_button.TabIndex = 11;
            this.copy_button.Text = "✂";
            this.copy_button.UseVisualStyleBackColor = true;
            this.copy_button.Click += new System.EventHandler(this.copy_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 295);
            this.Controls.Add(this.copy_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRASSHIFR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_out);
            this.Controls.Add(this.text_in);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSHIFR);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSHIFR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_in;
        private System.Windows.Forms.TextBox text_out;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRASSHIFR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button copy_button;
    }
}

