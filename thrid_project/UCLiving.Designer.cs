namespace thrid_project
{
    partial class UCLiving
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
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Hotel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Hostel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Rent = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Poh = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Location = new System.Drawing.Point(1037, 511);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 40);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Hotel);
            this.panel1.Location = new System.Drawing.Point(189, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 126);
            this.panel1.TabIndex = 19;
            // 
            // Hotel
            // 
            this.Hotel.AutoSize = true;
            this.Hotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hotel.Location = new System.Drawing.Point(76, 48);
            this.Hotel.Name = "Hotel";
            this.Hotel.Size = new System.Drawing.Size(91, 31);
            this.Hotel.TabIndex = 0;
            this.Hotel.Text = "Отель";
            this.Hotel.Click += new System.EventHandler(this.Hotel_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Hostel);
            this.panel2.Location = new System.Drawing.Point(675, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 126);
            this.panel2.TabIndex = 20;
            // 
            // Hostel
            // 
            this.Hostel.AutoSize = true;
            this.Hostel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hostel.Location = new System.Drawing.Point(76, 48);
            this.Hostel.Name = "Hostel";
            this.Hostel.Size = new System.Drawing.Size(103, 31);
            this.Hostel.TabIndex = 0;
            this.Hostel.Text = "Хостел";
            this.Hostel.Click += new System.EventHandler(this.Hostel_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Rent);
            this.panel3.Location = new System.Drawing.Point(189, 350);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(262, 126);
            this.panel3.TabIndex = 21;
            // 
            // Rent
            // 
            this.Rent.AutoSize = true;
            this.Rent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rent.Location = new System.Drawing.Point(37, 47);
            this.Rent.Name = "Rent";
            this.Rent.Size = new System.Drawing.Size(180, 31);
            this.Rent.TabIndex = 0;
            this.Rent.Text = "Аренда дома";
            this.Rent.Click += new System.EventHandler(this.Rent_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Poh);
            this.panel4.Location = new System.Drawing.Point(675, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(262, 126);
            this.panel4.TabIndex = 22;
            // 
            // Poh
            // 
            this.Poh.AutoSize = true;
            this.Poh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Poh.Location = new System.Drawing.Point(12, 38);
            this.Poh.Name = "Poh";
            this.Poh.Size = new System.Drawing.Size(238, 50);
            this.Poh.TabIndex = 0;
            this.Poh.Text = "Проживание у \r\nдрузей/родственников";
            this.Poh.Click += new System.EventHandler(this.Poh_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Image = global::thrid_project.Properties.Resources.Рисунок1;
            this.btnPrev.Location = new System.Drawing.Point(3, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(30, 30);
            this.btnPrev.TabIndex = 24;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(1032, 435);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 60);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Отменить\r\nвыбор";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UCLiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNext);
            this.Name = "UCLiving";
            this.Size = new System.Drawing.Size(1200, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Hotel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Hostel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Rent;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Poh;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnCancel;
    }
}
