namespace thrid_project
{
    partial class UCStartPage
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonLicenseYes = new System.Windows.Forms.RadioButton();
            this.radioButtonLicenseNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxFromTown = new System.Windows.Forms.ComboBox();
            this.comboBoxToTown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.place2 = new System.Windows.Forms.ComboBox();
            this.place1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonLicenseYes
            // 
            this.radioButtonLicenseYes.AutoSize = true;
            this.radioButtonLicenseYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonLicenseYes.Location = new System.Drawing.Point(10, 43);
            this.radioButtonLicenseYes.Name = "radioButtonLicenseYes";
            this.radioButtonLicenseYes.Size = new System.Drawing.Size(52, 28);
            this.radioButtonLicenseYes.TabIndex = 0;
            this.radioButtonLicenseYes.TabStop = true;
            this.radioButtonLicenseYes.Text = "Да";
            this.radioButtonLicenseYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonLicenseNo
            // 
            this.radioButtonLicenseNo.AutoSize = true;
            this.radioButtonLicenseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonLicenseNo.Location = new System.Drawing.Point(10, 77);
            this.radioButtonLicenseNo.Name = "radioButtonLicenseNo";
            this.radioButtonLicenseNo.Size = new System.Drawing.Size(62, 28);
            this.radioButtonLicenseNo.TabIndex = 1;
            this.radioButtonLicenseNo.TabStop = true;
            this.radioButtonLicenseNo.Text = "Нет";
            this.radioButtonLicenseNo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Есть водительские права?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonLicenseYes);
            this.groupBox1.Controls.Add(this.radioButtonLicenseNo);
            this.groupBox1.Location = new System.Drawing.Point(238, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxFromTown
            // 
            this.comboBoxFromTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFromTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFromTown.FormattingEnabled = true;
            this.comboBoxFromTown.Items.AddRange(new object[] {
            "Москва",
            "Казань",
            "Санкт-Петербург"});
            this.comboBoxFromTown.Location = new System.Drawing.Point(784, 145);
            this.comboBoxFromTown.Name = "comboBoxFromTown";
            this.comboBoxFromTown.Size = new System.Drawing.Size(203, 32);
            this.comboBoxFromTown.TabIndex = 8;
            this.comboBoxFromTown.SelectedValueChanged += new System.EventHandler(this.TownFromChoice);
            // 
            // comboBoxToTown
            // 
            this.comboBoxToTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxToTown.FormattingEnabled = true;
            this.comboBoxToTown.Items.AddRange(new object[] {
            "Москва",
            "Казань",
            "Санкт-Петербург"});
            this.comboBoxToTown.Location = new System.Drawing.Point(784, 262);
            this.comboBoxToTown.Name = "comboBoxToTown";
            this.comboBoxToTown.Size = new System.Drawing.Size(203, 32);
            this.comboBoxToTown.TabIndex = 9;
            this.comboBoxToTown.SelectedValueChanged += new System.EventHandler(this.TownToChoice);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(808, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Город отбытия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(808, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Город прибытия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(365, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Место 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(51, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Посещаемые города";
            // 
            // place2
            // 
            this.place2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.place2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.place2.FormattingEnabled = true;
            this.place2.Items.AddRange(new object[] {
            "Алма-Ата",
            "Абу-Даби",
            "Анталия",
            "Хургада",
            "Тбилиси",
            "Бангкок",
            "Астана",
            "Дубай",
            "Белек",
            "Батуми",
            "Пхукет"});
            this.place2.Location = new System.Drawing.Point(686, 422);
            this.place2.Name = "place2";
            this.place2.Size = new System.Drawing.Size(203, 32);
            this.place2.TabIndex = 12;
            this.place2.SelectedValueChanged += new System.EventHandler(this.Place2Choice);
            // 
            // place1
            // 
            this.place1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.place1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.place1.FormattingEnabled = true;
            this.place1.Items.AddRange(new object[] {
            "Алма-Ата",
            "Абу-Даби",
            "Анталия",
            "Хургада",
            "Тбилиси",
            "Бангкок",
            "Астана",
            "Дубай",
            "Белек",
            "Батуми",
            "Пхукет"});
            this.place1.Location = new System.Drawing.Point(303, 422);
            this.place1.Name = "place1";
            this.place1.Size = new System.Drawing.Size(203, 32);
            this.place1.TabIndex = 14;
            this.place1.SelectedValueChanged += new System.EventHandler(this.Place1Choice);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(669, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Место 2 (не обязательно)";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNext.Location = new System.Drawing.Point(1070, 636);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 40);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // UCStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.place1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.place2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxToTown);
            this.Controls.Add(this.comboBoxFromTown);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCStartPage";
            this.Size = new System.Drawing.Size(1200, 700);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonLicenseYes;
        private System.Windows.Forms.RadioButton radioButtonLicenseNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxFromTown;
        private System.Windows.Forms.ComboBox comboBoxToTown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox place2;
        private System.Windows.Forms.ComboBox place1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNext;
    }
}
