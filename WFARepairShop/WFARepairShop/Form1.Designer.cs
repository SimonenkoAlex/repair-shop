namespace WFARepairShop
{
    partial class MainForm
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
            this.gBDevices = new System.Windows.Forms.GroupBox();
            this.labDate = new System.Windows.Forms.Label();
            this.labProducer = new System.Windows.Forms.Label();
            this.tBProducer = new System.Windows.Forms.TextBox();
            this.tBDate = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labСategory = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.rTBResultAssign = new System.Windows.Forms.RichTextBox();
            this.gBDevices.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBDevices
            // 
            this.gBDevices.BackColor = System.Drawing.SystemColors.Info;
            this.gBDevices.Controls.Add(this.labDate);
            this.gBDevices.Controls.Add(this.labProducer);
            this.gBDevices.Controls.Add(this.tBProducer);
            this.gBDevices.Controls.Add(this.tBDate);
            this.gBDevices.Controls.Add(this.tBName);
            this.gBDevices.Controls.Add(this.labName);
            this.gBDevices.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.gBDevices.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBDevices.Location = new System.Drawing.Point(12, 12);
            this.gBDevices.Name = "gBDevices";
            this.gBDevices.Size = new System.Drawing.Size(668, 107);
            this.gBDevices.TabIndex = 0;
            this.gBDevices.TabStop = false;
            this.gBDevices.Text = "Устройство (бытовая техника и электроника)";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(6, 71);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(138, 23);
            this.labDate.TabIndex = 3;
            this.labDate.Text = "Дата выпуска";
            // 
            // labProducer
            // 
            this.labProducer.AutoSize = true;
            this.labProducer.Location = new System.Drawing.Point(326, 33);
            this.labProducer.Name = "labProducer";
            this.labProducer.Size = new System.Drawing.Size(157, 23);
            this.labProducer.TabIndex = 2;
            this.labProducer.Text = "Производитель";
            // 
            // tBProducer
            // 
            this.tBProducer.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBProducer.Location = new System.Drawing.Point(489, 24);
            this.tBProducer.Name = "tBProducer";
            this.tBProducer.Size = new System.Drawing.Size(170, 32);
            this.tBProducer.TabIndex = 1;
            // 
            // tBDate
            // 
            this.tBDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBDate.Location = new System.Drawing.Point(150, 62);
            this.tBDate.Name = "tBDate";
            this.tBDate.Size = new System.Drawing.Size(170, 32);
            this.tBDate.TabIndex = 1;
            // 
            // tBName
            // 
            this.tBName.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBName.Location = new System.Drawing.Point(112, 24);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(208, 32);
            this.tBName.TabIndex = 1;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(6, 33);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(100, 23);
            this.labName.TabIndex = 0;
            this.labName.Text = "Название";
            // 
            // labСategory
            // 
            this.labСategory.AutoSize = true;
            this.labСategory.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F);
            this.labСategory.Location = new System.Drawing.Point(12, 122);
            this.labСategory.Name = "labСategory";
            this.labСategory.Size = new System.Drawing.Size(194, 23);
            this.labСategory.TabIndex = 1;
            this.labСategory.Text = "Категория ремонта";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 28);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F);
            this.label1.Location = new System.Drawing.Point(338, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стоимость";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F);
            this.textBox1.Location = new System.Drawing.Point(455, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 32);
            this.textBox1.TabIndex = 3;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAssign.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAssign.Location = new System.Drawing.Point(472, 161);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(200, 40);
            this.btnAssign.TabIndex = 4;
            this.btnAssign.Text = "Назначить";
            this.btnAssign.UseVisualStyleBackColor = false;
            // 
            // rTBResultAssign
            // 
            this.rTBResultAssign.Enabled = false;
            this.rTBResultAssign.Location = new System.Drawing.Point(12, 155);
            this.rTBResultAssign.Name = "rTBResultAssign";
            this.rTBResultAssign.Size = new System.Drawing.Size(454, 75);
            this.rTBResultAssign.TabIndex = 5;
            this.rTBResultAssign.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(684, 242);
            this.Controls.Add(this.rTBResultAssign);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labСategory);
            this.Controls.Add(this.gBDevices);
            this.Name = "MainForm";
            this.Text = "Ремонтная мастерская";
            this.gBDevices.ResumeLayout(false);
            this.gBDevices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBDevices;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labProducer;
        private System.Windows.Forms.TextBox tBProducer;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.TextBox tBDate;
        private System.Windows.Forms.Label labСategory;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.RichTextBox rTBResultAssign;
    }
}

