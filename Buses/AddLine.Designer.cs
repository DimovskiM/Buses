namespace WindowsFormsApplication1
{
    partial class AddLine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nUDTime = new System.Windows.Forms.NumericUpDown();
            this.nUDMinute = new System.Windows.Forms.NumericUpDown();
            this.nUDPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nUDPrice);
            this.groupBox1.Controls.Add(this.nUDMinute);
            this.groupBox1.Controls.Add(this.nUDTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbDestination);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади Линија";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(6, 43);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(235, 20);
            this.tbDestination.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дестинација:";
            // 
            // nUDTime
            // 
            this.nUDTime.Location = new System.Drawing.Point(6, 98);
            this.nUDTime.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nUDTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDTime.Name = "nUDTime";
            this.nUDTime.Size = new System.Drawing.Size(88, 20);
            this.nUDTime.TabIndex = 3;
            this.nUDTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUDMinute
            // 
            this.nUDMinute.Location = new System.Drawing.Point(100, 98);
            this.nUDMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nUDMinute.Name = "nUDMinute";
            this.nUDMinute.Size = new System.Drawing.Size(75, 20);
            this.nUDMinute.TabIndex = 4;
            // 
            // nUDPrice
            // 
            this.nUDPrice.Location = new System.Drawing.Point(6, 148);
            this.nUDPrice.Maximum = new decimal(new int[] {
            250000,
            0,
            0,
            0});
            this.nUDPrice.Name = "nUDPrice";
            this.nUDPrice.Size = new System.Drawing.Size(120, 20);
            this.nUDPrice.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Минута";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Час";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Додади";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(142, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 234);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddLine";
            this.Text = "Нова Линија";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUDPrice;
        private System.Windows.Forms.NumericUpDown nUDMinute;
        private System.Windows.Forms.NumericUpDown nUDTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}