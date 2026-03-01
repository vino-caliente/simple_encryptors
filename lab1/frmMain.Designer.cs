
namespace lab1
{
    partial class frmMain
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
            this.comboBoxAlg = new System.Windows.Forms.ComboBox();
            this.labelAlg = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAlg
            // 
            this.comboBoxAlg.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxAlg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlg.FormattingEnabled = true;
            this.comboBoxAlg.Items.AddRange(new object[] {
            "Метод децимаций",
            "Шифр Виженера"});
            this.comboBoxAlg.Location = new System.Drawing.Point(255, 27);
            this.comboBoxAlg.Name = "comboBoxAlg";
            this.comboBoxAlg.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAlg.TabIndex = 0;
            // 
            // labelAlg
            // 
            this.labelAlg.AutoSize = true;
            this.labelAlg.Location = new System.Drawing.Point(61, 27);
            this.labelAlg.Name = "labelAlg";
            this.labelAlg.Size = new System.Drawing.Size(178, 13);
            this.labelAlg.TabIndex = 1;
            this.labelAlg.Text = "Выберите алгоритм шифрования:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(64, 141);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(312, 115);
            this.textBoxInput.TabIndex = 2;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(64, 116);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(92, 13);
            this.labelInput.TabIndex = 3;
            this.labelInput.Text = "Исходный текст:";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(64, 68);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(36, 13);
            this.labelKey.TabIndex = 4;
            this.labelKey.Text = "Ключ:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(129, 68);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(247, 20);
            this.textBoxKey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Результирующий текст:";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(67, 308);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(309, 112);
            this.textBoxOutput.TabIndex = 7;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(255, 106);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(121, 23);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "Читать из файла";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(255, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить в файл";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(67, 448);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(125, 23);
            this.btnEncrypt.TabIndex = 10;
            this.btnEncrypt.Text = "Шифровать";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(67, 477);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(125, 23);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Дешифровать";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(299, 448);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(448, 545);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelAlg);
            this.Controls.Add(this.comboBoxAlg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAlg;
        private System.Windows.Forms.Label labelAlg;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnClear;
    }
}

