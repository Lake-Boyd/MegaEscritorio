namespace Mega_Escritorio
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
            this.deskMaterial = new System.Windows.Forms.ComboBox();
            this.deskDepth = new System.Windows.Forms.NumericUpDown();
            this.deskWidth = new System.Windows.Forms.NumericUpDown();
            this.drawerNum = new System.Windows.Forms.NumericUpDown();
            this.rushOrderNum = new System.Windows.Forms.ComboBox();
            this.deskArea = new System.Windows.Forms.Label();
            this.priceQuote = new System.Windows.Forms.Label();
            this.quoteDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateQuote = new System.Windows.Forms.Button();
            this.saveQuote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNum)).BeginInit();
            this.SuspendLayout();
            // 
            // deskMaterial
            // 
            this.deskMaterial.AllowDrop = true;
            this.deskMaterial.FormattingEnabled = true;
            this.deskMaterial.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine"});
            this.deskMaterial.Location = new System.Drawing.Point(51, 264);
            this.deskMaterial.Name = "deskMaterial";
            this.deskMaterial.Size = new System.Drawing.Size(215, 21);
            this.deskMaterial.TabIndex = 0;
            this.deskMaterial.Text = "Materials";
            this.deskMaterial.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // deskDepth
            // 
            this.deskDepth.DecimalPlaces = 2;
            this.deskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepth.Location = new System.Drawing.Point(51, 121);
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(215, 22);
            this.deskDepth.TabIndex = 1;
            this.deskDepth.ValueChanged += new System.EventHandler(this.DeskDepth_ValueChanged);
            // 
            // deskWidth
            // 
            this.deskWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deskWidth.DecimalPlaces = 2;
            this.deskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidth.Location = new System.Drawing.Point(51, 149);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(215, 22);
            this.deskWidth.TabIndex = 2;
            this.deskWidth.ValueChanged += new System.EventHandler(this.DeskWidth_ValueChanged);
            // 
            // drawerNum
            // 
            this.drawerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerNum.Location = new System.Drawing.Point(51, 193);
            this.drawerNum.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerNum.Name = "drawerNum";
            this.drawerNum.Size = new System.Drawing.Size(215, 22);
            this.drawerNum.TabIndex = 3;
            this.drawerNum.ValueChanged += new System.EventHandler(this.DrawerNum_ValueChanged);
            // 
            // rushOrderNum
            // 
            this.rushOrderNum.FormattingEnabled = true;
            this.rushOrderNum.Items.AddRange(new object[] {
            "3-Days",
            "5-Days",
            "7-Days",
            "None"});
            this.rushOrderNum.Location = new System.Drawing.Point(51, 313);
            this.rushOrderNum.Name = "rushOrderNum";
            this.rushOrderNum.Size = new System.Drawing.Size(215, 21);
            this.rushOrderNum.TabIndex = 4;
            this.rushOrderNum.Text = "Rush Order (In Days)";
            this.rushOrderNum.SelectedIndexChanged += new System.EventHandler(this.RushOrderNum_SelectedIndexChanged);
            // 
            // deskArea
            // 
            this.deskArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deskArea.Location = new System.Drawing.Point(564, 121);
            this.deskArea.Name = "deskArea";
            this.deskArea.Size = new System.Drawing.Size(100, 22);
            this.deskArea.TabIndex = 5;
            this.deskArea.Text = "--";
            // 
            // priceQuote
            // 
            this.priceQuote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceQuote.Location = new System.Drawing.Point(564, 160);
            this.priceQuote.Name = "priceQuote";
            this.priceQuote.Size = new System.Drawing.Size(100, 22);
            this.priceQuote.TabIndex = 6;
            this.priceQuote.Text = "--";
            // 
            // quoteDate
            // 
            this.quoteDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quoteDate.Location = new System.Drawing.Point(564, 200);
            this.quoteDate.Name = "quoteDate";
            this.quoteDate.Size = new System.Drawing.Size(155, 22);
            this.quoteDate.TabIndex = 7;
            this.quoteDate.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quote Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(452, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quote Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Desktop Area:";
            // 
            // calculateQuote
            // 
            this.calculateQuote.Location = new System.Drawing.Point(206, 389);
            this.calculateQuote.Name = "calculateQuote";
            this.calculateQuote.Size = new System.Drawing.Size(147, 23);
            this.calculateQuote.TabIndex = 11;
            this.calculateQuote.Text = "Calculate The Quote";
            this.calculateQuote.UseVisualStyleBackColor = true;
            // 
            // saveQuote
            // 
            this.saveQuote.Location = new System.Drawing.Point(404, 389);
            this.saveQuote.Name = "saveQuote";
            this.saveQuote.Size = new System.Drawing.Size(147, 23);
            this.saveQuote.TabIndex = 12;
            this.saveQuote.Text = "Save The Quote";
            this.saveQuote.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.saveQuote);
            this.Controls.Add(this.calculateQuote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quoteDate);
            this.Controls.Add(this.priceQuote);
            this.Controls.Add(this.deskArea);
            this.Controls.Add(this.rushOrderNum);
            this.Controls.Add(this.drawerNum);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.deskDepth);
            this.Controls.Add(this.deskMaterial);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Mega Escritorio Desk Quote";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox deskMaterial;
        private System.Windows.Forms.NumericUpDown deskDepth;
        private System.Windows.Forms.NumericUpDown deskWidth;
        private System.Windows.Forms.NumericUpDown drawerNum;
        private System.Windows.Forms.ComboBox rushOrderNum;
        private System.Windows.Forms.Label deskArea;
        private System.Windows.Forms.Label priceQuote;
        private System.Windows.Forms.Label quoteDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateQuote;
        private System.Windows.Forms.Button saveQuote;
    }
}

