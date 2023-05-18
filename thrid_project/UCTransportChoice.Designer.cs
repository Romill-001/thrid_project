namespace thrid_project
{
    partial class UCTransportChoice
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
            this.label_country = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelpublic = new System.Windows.Forms.Panel();
            this.publictr = new System.Windows.Forms.Label();
            this.taxi = new System.Windows.Forms.Label();
            this.paneltaxi = new System.Windows.Forms.Panel();
            this.walking = new System.Windows.Forms.Label();
            this.panelwalking = new System.Windows.Forms.Panel();
            this.autorent = new System.Windows.Forms.Label();
            this.panelrent = new System.Windows.Forms.Panel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelpublic.SuspendLayout();
            this.paneltaxi.SuspendLayout();
            this.panelwalking.SuspendLayout();
            this.panelrent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Location = new System.Drawing.Point(1054, 489);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 40);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Далее";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_country.Location = new System.Drawing.Point(487, 48);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(106, 33);
            this.label_country.TabIndex = 20;
            this.label_country.Text = "country";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(270, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Как вы доберётесь до места проживания?";
            // 
            // panelpublic
            // 
            this.panelpublic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelpublic.Controls.Add(this.publictr);
            this.panelpublic.Location = new System.Drawing.Point(194, 163);
            this.panelpublic.Name = "panelpublic";
            this.panelpublic.Size = new System.Drawing.Size(278, 100);
            this.panelpublic.TabIndex = 23;
            // 
            // publictr
            // 
            this.publictr.AutoSize = true;
            this.publictr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.publictr.Location = new System.Drawing.Point(13, 36);
            this.publictr.Name = "publictr";
            this.publictr.Size = new System.Drawing.Size(249, 24);
            this.publictr.TabIndex = 0;
            this.publictr.Text = "Обшественный транспорт";
            this.publictr.Click += new System.EventHandler(this.publictr_Click);
            // 
            // taxi
            // 
            this.taxi.AutoSize = true;
            this.taxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taxi.Location = new System.Drawing.Point(106, 36);
            this.taxi.Name = "taxi";
            this.taxi.Size = new System.Drawing.Size(62, 24);
            this.taxi.TabIndex = 0;
            this.taxi.Text = "Такси";
            this.taxi.Click += new System.EventHandler(this.taxi_Click);
            // 
            // paneltaxi
            // 
            this.paneltaxi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneltaxi.Controls.Add(this.taxi);
            this.paneltaxi.Location = new System.Drawing.Point(702, 163);
            this.paneltaxi.Name = "paneltaxi";
            this.paneltaxi.Size = new System.Drawing.Size(278, 100);
            this.paneltaxi.TabIndex = 24;
            // 
            // walking
            // 
            this.walking.AutoSize = true;
            this.walking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.walking.Location = new System.Drawing.Point(96, 39);
            this.walking.Name = "walking";
            this.walking.Size = new System.Drawing.Size(81, 24);
            this.walking.TabIndex = 0;
            this.walking.Text = "Пешком";
            this.walking.Click += new System.EventHandler(this.walking_Click);
            // 
            // panelwalking
            // 
            this.panelwalking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelwalking.Controls.Add(this.walking);
            this.panelwalking.Location = new System.Drawing.Point(194, 361);
            this.panelwalking.Name = "panelwalking";
            this.panelwalking.Size = new System.Drawing.Size(278, 100);
            this.panelwalking.TabIndex = 25;
            // 
            // autorent
            // 
            this.autorent.AutoSize = true;
            this.autorent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autorent.Location = new System.Drawing.Point(75, 36);
            this.autorent.Name = "autorent";
            this.autorent.Size = new System.Drawing.Size(125, 24);
            this.autorent.TabIndex = 0;
            this.autorent.Text = "Аренда авто";
            this.autorent.Click += new System.EventHandler(this.autorent_Click);
            // 
            // panelrent
            // 
            this.panelrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelrent.Controls.Add(this.autorent);
            this.panelrent.Location = new System.Drawing.Point(702, 361);
            this.panelrent.Name = "panelrent";
            this.panelrent.Size = new System.Drawing.Size(278, 100);
            this.panelrent.TabIndex = 25;
            // 
            // btnPrev
            // 
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Image = global::thrid_project.Properties.Resources.Рисунок1;
            this.btnPrev.Location = new System.Drawing.Point(20, 20);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(30, 30);
            this.btnPrev.TabIndex = 26;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(1049, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 63);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Отменить\r\nвыбор";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // UCTransportChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.panelrent);
            this.Controls.Add(this.paneltaxi);
            this.Controls.Add(this.panelwalking);
            this.Controls.Add(this.panelpublic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_country);
            this.Controls.Add(this.btnNext);
            this.Name = "UCTransportChoice";
            this.Size = new System.Drawing.Size(1200, 600);
            this.MouseEnter += new System.EventHandler(this.UCTransportChoice_MouseEnter);
            this.panelpublic.ResumeLayout(false);
            this.panelpublic.PerformLayout();
            this.paneltaxi.ResumeLayout(false);
            this.paneltaxi.PerformLayout();
            this.panelwalking.ResumeLayout(false);
            this.panelwalking.PerformLayout();
            this.panelrent.ResumeLayout(false);
            this.panelrent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label_country;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelpublic;
        private System.Windows.Forms.Label publictr;
        private System.Windows.Forms.Label taxi;
        private System.Windows.Forms.Panel paneltaxi;
        private System.Windows.Forms.Label walking;
        private System.Windows.Forms.Panel panelwalking;
        private System.Windows.Forms.Label autorent;
        private System.Windows.Forms.Panel panelrent;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnCancel;
    }
}
