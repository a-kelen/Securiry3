namespace Securiry3
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.encryptRightText = new System.Windows.Forms.RichTextBox();
            this.encryptLeftText = new System.Windows.Forms.RichTextBox();
            this.saveEncrypt = new System.Windows.Forms.Button();
            this.encrypt = new System.Windows.Forms.Button();
            this.openFree = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.decryptRightText = new System.Windows.Forms.RichTextBox();
            this.decryptLeftText = new System.Windows.Forms.RichTextBox();
            this.openEncrypt = new System.Windows.Forms.Button();
            this.decrypt = new System.Windows.Forms.Button();
            this.import = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A});
            this.dataGrid.Location = new System.Drawing.Point(12, 107);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(776, 66);
            this.dataGrid.TabIndex = 0;
            // 
            // A
            // 
            this.A.HeaderText = "Column1";
            this.A.Name = "A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(659, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметри";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(55, 42);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown2.TabIndex = 2;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(55, 18);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "a";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 180);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 258);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.encryptRightText);
            this.tabPage1.Controls.Add(this.encryptLeftText);
            this.tabPage1.Controls.Add(this.saveEncrypt);
            this.tabPage1.Controls.Add(this.encrypt);
            this.tabPage1.Controls.Add(this.openFree);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 232);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Шифрування";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // encryptRightText
            // 
            this.encryptRightText.Location = new System.Drawing.Point(384, 37);
            this.encryptRightText.Name = "encryptRightText";
            this.encryptRightText.Size = new System.Drawing.Size(370, 189);
            this.encryptRightText.TabIndex = 4;
            this.encryptRightText.Text = "";
            // 
            // encryptLeftText
            // 
            this.encryptLeftText.Location = new System.Drawing.Point(7, 37);
            this.encryptLeftText.Name = "encryptLeftText";
            this.encryptLeftText.Size = new System.Drawing.Size(370, 189);
            this.encryptLeftText.TabIndex = 3;
            this.encryptLeftText.Text = "";
            this.encryptLeftText.TextChanged += new System.EventHandler(this.encryptLeftText_TextChanged);
            // 
            // saveEncrypt
            // 
            this.saveEncrypt.Enabled = false;
            this.saveEncrypt.Location = new System.Drawing.Point(171, 6);
            this.saveEncrypt.Name = "saveEncrypt";
            this.saveEncrypt.Size = new System.Drawing.Size(75, 23);
            this.saveEncrypt.TabIndex = 2;
            this.saveEncrypt.Text = "Зберегти";
            this.saveEncrypt.UseVisualStyleBackColor = true;
            this.saveEncrypt.Click += new System.EventHandler(this.saveEncrypt_Click);
            // 
            // encrypt
            // 
            this.encrypt.Enabled = false;
            this.encrypt.Location = new System.Drawing.Point(89, 7);
            this.encrypt.Name = "encrypt";
            this.encrypt.Size = new System.Drawing.Size(75, 23);
            this.encrypt.TabIndex = 1;
            this.encrypt.Text = "Шифрувати";
            this.encrypt.UseVisualStyleBackColor = true;
            this.encrypt.Click += new System.EventHandler(this.encrypt_Click);
            // 
            // openFree
            // 
            this.openFree.Location = new System.Drawing.Point(7, 7);
            this.openFree.Name = "openFree";
            this.openFree.Size = new System.Drawing.Size(75, 23);
            this.openFree.TabIndex = 0;
            this.openFree.Text = "Відкрити";
            this.openFree.UseVisualStyleBackColor = true;
            this.openFree.Click += new System.EventHandler(this.openFree_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.decryptRightText);
            this.tabPage2.Controls.Add(this.decryptLeftText);
            this.tabPage2.Controls.Add(this.openEncrypt);
            this.tabPage2.Controls.Add(this.decrypt);
            this.tabPage2.Controls.Add(this.import);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 232);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Розшифрування";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // decryptRightText
            // 
            this.decryptRightText.Location = new System.Drawing.Point(391, 37);
            this.decryptRightText.Name = "decryptRightText";
            this.decryptRightText.Size = new System.Drawing.Size(370, 189);
            this.decryptRightText.TabIndex = 4;
            this.decryptRightText.Text = "";
            // 
            // decryptLeftText
            // 
            this.decryptLeftText.Location = new System.Drawing.Point(7, 37);
            this.decryptLeftText.Name = "decryptLeftText";
            this.decryptLeftText.Size = new System.Drawing.Size(370, 189);
            this.decryptLeftText.TabIndex = 3;
            this.decryptLeftText.Text = "";
            this.decryptLeftText.TextChanged += new System.EventHandler(this.decryptLeftText_TextChanged);
            // 
            // openEncrypt
            // 
            this.openEncrypt.Location = new System.Drawing.Point(99, 7);
            this.openEncrypt.Name = "openEncrypt";
            this.openEncrypt.Size = new System.Drawing.Size(75, 23);
            this.openEncrypt.TabIndex = 2;
            this.openEncrypt.Text = "Відкрити";
            this.openEncrypt.UseVisualStyleBackColor = true;
            this.openEncrypt.Click += new System.EventHandler(this.openEncrypt_Click);
            // 
            // decrypt
            // 
            this.decrypt.Enabled = false;
            this.decrypt.Location = new System.Drawing.Point(180, 7);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(110, 23);
            this.decrypt.TabIndex = 1;
            this.decrypt.Text = "Розшифрувати";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(7, 7);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(86, 23);
            this.import.TabIndex = 0;
            this.import.Text = "Імпортувати";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Шифр Цезаря";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn A;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox encryptRightText;
        private System.Windows.Forms.RichTextBox encryptLeftText;
        private System.Windows.Forms.Button saveEncrypt;
        private System.Windows.Forms.Button encrypt;
        private System.Windows.Forms.Button openFree;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox decryptRightText;
        private System.Windows.Forms.RichTextBox decryptLeftText;
        private System.Windows.Forms.Button openEncrypt;
        private System.Windows.Forms.Button decrypt;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}

