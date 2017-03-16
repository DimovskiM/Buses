namespace WindowsFormsApplication1
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
            this.lbBuses = new System.Windows.Forms.ListBox();
            this.lbLines = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.btnRemoveBus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMostExpensiveLine = new System.Windows.Forms.TextBox();
            this.tbAveragePerLine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBuses
            // 
            this.lbBuses.FormattingEnabled = true;
            this.lbBuses.Location = new System.Drawing.Point(6, 23);
            this.lbBuses.Name = "lbBuses";
            this.lbBuses.Size = new System.Drawing.Size(246, 264);
            this.lbBuses.TabIndex = 0;
            this.lbBuses.SelectedIndexChanged += new System.EventHandler(this.lbBuses_SelectedIndexChanged);
            // 
            // lbLines
            // 
            this.lbLines.FormattingEnabled = true;
            this.lbLines.Location = new System.Drawing.Point(258, 23);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(252, 264);
            this.lbLines.TabIndex = 1;
            this.lbLines.SelectedIndexChanged += new System.EventHandler(this.lbLines_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Автобуси";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Линии";
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(6, 311);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(246, 23);
            this.btnAddBus.TabIndex = 4;
            this.btnAddBus.Text = "Додади Автобус";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.Enabled = false;
            this.btnAddLine.Location = new System.Drawing.Point(6, 391);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(246, 23);
            this.btnAddLine.TabIndex = 5;
            this.btnAddLine.Text = "Додади Линија";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRemoveBus
            // 
            this.btnRemoveBus.Location = new System.Drawing.Point(6, 351);
            this.btnRemoveBus.Name = "btnRemoveBus";
            this.btnRemoveBus.Size = new System.Drawing.Size(246, 23);
            this.btnRemoveBus.TabIndex = 6;
            this.btnRemoveBus.Text = "Избриши Автобус";
            this.btnRemoveBus.UseVisualStyleBackColor = true;
            this.btnRemoveBus.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAveragePerLine);
            this.groupBox1.Controls.Add(this.tbMostExpensiveLine);
            this.groupBox1.Location = new System.Drawing.Point(265, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 118);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Линии";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbMostExpensiveLine
            // 
            this.tbMostExpensiveLine.Enabled = false;
            this.tbMostExpensiveLine.Location = new System.Drawing.Point(6, 36);
            this.tbMostExpensiveLine.Name = "tbMostExpensiveLine";
            this.tbMostExpensiveLine.Size = new System.Drawing.Size(232, 20);
            this.tbMostExpensiveLine.TabIndex = 0;
            // 
            // tbAveragePerLine
            // 
            this.tbAveragePerLine.Enabled = false;
            this.tbAveragePerLine.Location = new System.Drawing.Point(6, 82);
            this.tbAveragePerLine.Name = "tbAveragePerLine";
            this.tbAveragePerLine.Size = new System.Drawing.Size(232, 20);
            this.tbAveragePerLine.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Најскапа Линија";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Просечна цена на линиите";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemoveBus);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLines);
            this.Controls.Add(this.lbBuses);
            this.Name = "Form1";
            this.Text = "Автобуси";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbBuses;
        private System.Windows.Forms.ListBox lbLines;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddBus;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.Button btnRemoveBus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAveragePerLine;
        private System.Windows.Forms.TextBox tbMostExpensiveLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

