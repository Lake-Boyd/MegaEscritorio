namespace Mega_Escritorio
{
    partial class Form
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
            this.deskDepth = new System.Windows.Forms.NumericUpDown();
            this.deskWidth = new System.Windows.Forms.NumericUpDown();
            this.drawerNum = new System.Windows.Forms.NumericUpDown();
            this.deskArea = new System.Windows.Forms.Label();
            this.priceQuote = new System.Windows.Forms.Label();
            this.quoteDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveQuote = new System.Windows.Forms.Button();
            this.oakRadioButton = new System.Windows.Forms.RadioButton();
            this.laminateRadioButton = new System.Windows.Forms.RadioButton();
            this.pineRadioButton = new System.Windows.Forms.RadioButton();
            this.threeDayRadio = new System.Windows.Forms.RadioButton();
            this.fiveDayRadio = new System.Windows.Forms.RadioButton();
            this.sevenDayRadio = new System.Windows.Forms.RadioButton();
            this.deskMaterialGroup = new System.Windows.Forms.GroupBox();
            this.ebonyRadioButton = new System.Windows.Forms.RadioButton();
            this.shippingTermsGroup = new System.Windows.Forms.GroupBox();
            this.standardRadio = new System.Windows.Forms.RadioButton();
            this.deskWidthLabel = new System.Windows.Forms.Label();
            this.deskDepthLabel = new System.Windows.Forms.Label();
            this.calculateQuote = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.loadQuotes = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchMaterial = new System.Windows.Forms.Button();
            this.deleteQuoteNumber = new System.Windows.Forms.NumericUpDown();
            this.deleteQuote = new System.Windows.Forms.Button();
            this.errorMessage = new System.Windows.Forms.Label();
            this.mapleRadioButton = new System.Windows.Forms.RadioButton();
            this.cherryRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNum)).BeginInit();
            this.deskMaterialGroup.SuspendLayout();
            this.shippingTermsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteQuoteNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // deskDepth
            // 
            this.deskDepth.DecimalPlaces = 2;
            this.deskDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepth.Location = new System.Drawing.Point(73, 49);
            this.deskDepth.Name = "deskDepth";
            this.deskDepth.Size = new System.Drawing.Size(75, 22);
            this.deskDepth.TabIndex = 1;
            this.deskDepth.ValueChanged += new System.EventHandler(this.DeskDepth_ValueChanged);
            this.deskDepth.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // deskWidth
            // 
            this.deskWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deskWidth.DecimalPlaces = 2;
            this.deskWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidth.Location = new System.Drawing.Point(73, 77);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(75, 22);
            this.deskWidth.TabIndex = 2;
            this.deskWidth.ValueChanged += new System.EventHandler(this.DeskWidth_ValueChanged);
            this.deskWidth.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // drawerNum
            // 
            this.drawerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerNum.Location = new System.Drawing.Point(73, 131);
            this.drawerNum.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawerNum.Name = "drawerNum";
            this.drawerNum.Size = new System.Drawing.Size(75, 22);
            this.drawerNum.TabIndex = 3;
            this.drawerNum.ValueChanged += new System.EventHandler(this.DrawerNum_ValueChanged);
            this.drawerNum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // deskArea
            // 
            this.deskArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskArea.Location = new System.Drawing.Point(556, 51);
            this.deskArea.Name = "deskArea";
            this.deskArea.Size = new System.Drawing.Size(155, 20);
            this.deskArea.TabIndex = 5;
            this.deskArea.Text = "--";
            // 
            // priceQuote
            // 
            this.priceQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceQuote.Location = new System.Drawing.Point(556, 77);
            this.priceQuote.Name = "priceQuote";
            this.priceQuote.Size = new System.Drawing.Size(155, 22);
            this.priceQuote.TabIndex = 6;
            this.priceQuote.Text = "--";
            // 
            // quoteDate
            // 
            this.quoteDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteDate.Location = new System.Drawing.Point(556, 131);
            this.quoteDate.Name = "quoteDate";
            this.quoteDate.Size = new System.Drawing.Size(155, 22);
            this.quoteDate.TabIndex = 7;
            this.quoteDate.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quote Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(463, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Quote Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Desktop Area (sq inches):";
            // 
            // saveQuote
            // 
            this.saveQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveQuote.Location = new System.Drawing.Point(255, 235);
            this.saveQuote.Name = "saveQuote";
            this.saveQuote.Size = new System.Drawing.Size(234, 38);
            this.saveQuote.TabIndex = 12;
            this.saveQuote.Text = "Save The Quote";
            this.saveQuote.UseVisualStyleBackColor = true;
            this.saveQuote.Click += new System.EventHandler(this.saveQuote_Click);
            // 
            // oakRadioButton
            // 
            this.oakRadioButton.AutoSize = true;
            this.oakRadioButton.Location = new System.Drawing.Point(13, 19);
            this.oakRadioButton.Name = "oakRadioButton";
            this.oakRadioButton.Size = new System.Drawing.Size(45, 17);
            this.oakRadioButton.TabIndex = 13;
            this.oakRadioButton.Text = "Oak";
            this.oakRadioButton.UseVisualStyleBackColor = true;
            this.oakRadioButton.Click += new System.EventHandler(this.answer_Enter);
            // 
            // laminateRadioButton
            // 
            this.laminateRadioButton.AutoSize = true;
            this.laminateRadioButton.Location = new System.Drawing.Point(13, 42);
            this.laminateRadioButton.Name = "laminateRadioButton";
            this.laminateRadioButton.Size = new System.Drawing.Size(68, 17);
            this.laminateRadioButton.TabIndex = 14;
            this.laminateRadioButton.Text = "Laminate";
            this.laminateRadioButton.UseVisualStyleBackColor = true;
            this.laminateRadioButton.Click += new System.EventHandler(this.answer_Enter);
            // 
            // pineRadioButton
            // 
            this.pineRadioButton.AutoSize = true;
            this.pineRadioButton.Checked = true;
            this.pineRadioButton.Location = new System.Drawing.Point(13, 65);
            this.pineRadioButton.Name = "pineRadioButton";
            this.pineRadioButton.Size = new System.Drawing.Size(46, 17);
            this.pineRadioButton.TabIndex = 15;
            this.pineRadioButton.TabStop = true;
            this.pineRadioButton.Text = "Pine";
            this.pineRadioButton.UseVisualStyleBackColor = true;
            this.pineRadioButton.Click += new System.EventHandler(this.answer_Enter);
            // 
            // threeDayRadio
            // 
            this.threeDayRadio.AutoSize = true;
            this.threeDayRadio.Location = new System.Drawing.Point(16, 23);
            this.threeDayRadio.Name = "threeDayRadio";
            this.threeDayRadio.Size = new System.Drawing.Size(58, 17);
            this.threeDayRadio.TabIndex = 16;
            this.threeDayRadio.Text = "3 Days";
            this.threeDayRadio.UseVisualStyleBackColor = true;
            this.threeDayRadio.Click += new System.EventHandler(this.answer_Enter);
            // 
            // fiveDayRadio
            // 
            this.fiveDayRadio.AutoSize = true;
            this.fiveDayRadio.Location = new System.Drawing.Point(16, 46);
            this.fiveDayRadio.Name = "fiveDayRadio";
            this.fiveDayRadio.Size = new System.Drawing.Size(58, 17);
            this.fiveDayRadio.TabIndex = 17;
            this.fiveDayRadio.Text = "5 Days";
            this.fiveDayRadio.UseVisualStyleBackColor = true;
            this.fiveDayRadio.Click += new System.EventHandler(this.answer_Enter);
            // 
            // sevenDayRadio
            // 
            this.sevenDayRadio.AutoSize = true;
            this.sevenDayRadio.Location = new System.Drawing.Point(16, 69);
            this.sevenDayRadio.Name = "sevenDayRadio";
            this.sevenDayRadio.Size = new System.Drawing.Size(58, 17);
            this.sevenDayRadio.TabIndex = 18;
            this.sevenDayRadio.Text = "7 Days";
            this.sevenDayRadio.UseVisualStyleBackColor = true;
            this.sevenDayRadio.Click += new System.EventHandler(this.answer_Enter);
            // 
            // deskMaterialGroup
            // 
            this.deskMaterialGroup.Controls.Add(this.cherryRadioButton);
            this.deskMaterialGroup.Controls.Add(this.mapleRadioButton);
            this.deskMaterialGroup.Controls.Add(this.ebonyRadioButton);
            this.deskMaterialGroup.Controls.Add(this.pineRadioButton);
            this.deskMaterialGroup.Controls.Add(this.oakRadioButton);
            this.deskMaterialGroup.Controls.Add(this.laminateRadioButton);
            this.deskMaterialGroup.Location = new System.Drawing.Point(73, 184);
            this.deskMaterialGroup.Name = "deskMaterialGroup";
            this.deskMaterialGroup.Size = new System.Drawing.Size(121, 177);
            this.deskMaterialGroup.TabIndex = 19;
            this.deskMaterialGroup.TabStop = false;
            this.deskMaterialGroup.Text = "Desk Materials";
            // 
            // ebonyRadioButton
            // 
            this.ebonyRadioButton.AutoSize = true;
            this.ebonyRadioButton.Location = new System.Drawing.Point(13, 88);
            this.ebonyRadioButton.Name = "ebonyRadioButton";
            this.ebonyRadioButton.Size = new System.Drawing.Size(55, 17);
            this.ebonyRadioButton.TabIndex = 16;
            this.ebonyRadioButton.Text = "Ebony";
            this.ebonyRadioButton.UseVisualStyleBackColor = true;
            // 
            // shippingTermsGroup
            // 
            this.shippingTermsGroup.Controls.Add(this.standardRadio);
            this.shippingTermsGroup.Controls.Add(this.sevenDayRadio);
            this.shippingTermsGroup.Controls.Add(this.threeDayRadio);
            this.shippingTermsGroup.Controls.Add(this.fiveDayRadio);
            this.shippingTermsGroup.Location = new System.Drawing.Point(556, 184);
            this.shippingTermsGroup.Name = "shippingTermsGroup";
            this.shippingTermsGroup.Size = new System.Drawing.Size(155, 122);
            this.shippingTermsGroup.TabIndex = 20;
            this.shippingTermsGroup.TabStop = false;
            this.shippingTermsGroup.Text = "Shipping Terms";
            // 
            // standardRadio
            // 
            this.standardRadio.AutoSize = true;
            this.standardRadio.Checked = true;
            this.standardRadio.Location = new System.Drawing.Point(16, 95);
            this.standardRadio.Name = "standardRadio";
            this.standardRadio.Size = new System.Drawing.Size(111, 17);
            this.standardRadio.TabIndex = 19;
            this.standardRadio.TabStop = true;
            this.standardRadio.Text = "Standard (14 Day)";
            this.standardRadio.UseVisualStyleBackColor = true;
            this.standardRadio.Click += new System.EventHandler(this.answer_Enter);
            // 
            // deskWidthLabel
            // 
            this.deskWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskWidthLabel.Location = new System.Drawing.Point(154, 79);
            this.deskWidthLabel.Name = "deskWidthLabel";
            this.deskWidthLabel.Size = new System.Drawing.Size(153, 23);
            this.deskWidthLabel.TabIndex = 21;
            this.deskWidthLabel.Text = "Desk Width (inches)";
            // 
            // deskDepthLabel
            // 
            this.deskDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deskDepthLabel.Location = new System.Drawing.Point(154, 51);
            this.deskDepthLabel.Name = "deskDepthLabel";
            this.deskDepthLabel.Size = new System.Drawing.Size(153, 23);
            this.deskDepthLabel.TabIndex = 22;
            this.deskDepthLabel.Text = "Desk Depth (inches)";
            // 
            // calculateQuote
            // 
            this.calculateQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateQuote.Location = new System.Drawing.Point(255, 191);
            this.calculateQuote.Name = "calculateQuote";
            this.calculateQuote.Size = new System.Drawing.Size(234, 38);
            this.calculateQuote.TabIndex = 23;
            this.calculateQuote.Text = "Calculate The Quote";
            this.calculateQuote.UseVisualStyleBackColor = true;
            this.calculateQuote.Click += new System.EventHandler(this.calcQuote_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Drawer Number";
            // 
            // loadQuotes
            // 
            this.loadQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadQuotes.Location = new System.Drawing.Point(255, 279);
            this.loadQuotes.Name = "loadQuotes";
            this.loadQuotes.Size = new System.Drawing.Size(234, 38);
            this.loadQuotes.TabIndex = 28;
            this.loadQuotes.Text = "Load Quotes";
            this.loadQuotes.UseVisualStyleBackColor = true;
            this.loadQuotes.Click += new System.EventHandler(this.loadQuotes_Click);
            // 
            // searchBox
            // 
            this.searchBox.AcceptsReturn = true;
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchBox.Location = new System.Drawing.Point(73, 437);
            this.searchBox.MinimumSize = new System.Drawing.Size(638, 200);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.searchBox.ShortcutsEnabled = false;
            this.searchBox.Size = new System.Drawing.Size(638, 200);
            this.searchBox.TabIndex = 29;
            // 
            // searchMaterial
            // 
            this.searchMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchMaterial.Location = new System.Drawing.Point(255, 323);
            this.searchMaterial.Name = "searchMaterial";
            this.searchMaterial.Size = new System.Drawing.Size(234, 38);
            this.searchMaterial.TabIndex = 30;
            this.searchMaterial.Text = "Search for Selected Material";
            this.searchMaterial.UseVisualStyleBackColor = true;
            this.searchMaterial.Click += new System.EventHandler(this.searchMaterial_Click);
            // 
            // deleteQuoteNumber
            // 
            this.deleteQuoteNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteQuoteNumber.Location = new System.Drawing.Point(556, 339);
            this.deleteQuoteNumber.Name = "deleteQuoteNumber";
            this.deleteQuoteNumber.Size = new System.Drawing.Size(51, 22);
            this.deleteQuoteNumber.TabIndex = 31;
            // 
            // deleteQuote
            // 
            this.deleteQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteQuote.Location = new System.Drawing.Point(613, 339);
            this.deleteQuote.Name = "deleteQuote";
            this.deleteQuote.Size = new System.Drawing.Size(98, 22);
            this.deleteQuote.TabIndex = 32;
            this.deleteQuote.Text = "Delete Number";
            this.deleteQuote.UseVisualStyleBackColor = true;
            this.deleteQuote.Click += new System.EventHandler(this.deleteQuote_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(73, 381);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(638, 40);
            this.errorMessage.TabIndex = 33;
            // 
            // mapleRadioButton
            // 
            this.mapleRadioButton.AutoSize = true;
            this.mapleRadioButton.Location = new System.Drawing.Point(13, 111);
            this.mapleRadioButton.Name = "mapleRadioButton";
            this.mapleRadioButton.Size = new System.Drawing.Size(54, 17);
            this.mapleRadioButton.TabIndex = 17;
            this.mapleRadioButton.Text = "Maple";
            this.mapleRadioButton.UseVisualStyleBackColor = true;
            // 
            // cherryRadioButton
            // 
            this.cherryRadioButton.AutoSize = true;
            this.cherryRadioButton.Location = new System.Drawing.Point(13, 134);
            this.cherryRadioButton.Name = "cherryRadioButton";
            this.cherryRadioButton.Size = new System.Drawing.Size(55, 17);
            this.cherryRadioButton.TabIndex = 18;
            this.cherryRadioButton.Text = "Cherry";
            this.cherryRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 690);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.deleteQuote);
            this.Controls.Add(this.deleteQuoteNumber);
            this.Controls.Add(this.searchMaterial);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.loadQuotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calculateQuote);
            this.Controls.Add(this.deskDepthLabel);
            this.Controls.Add(this.deskWidthLabel);
            this.Controls.Add(this.shippingTermsGroup);
            this.Controls.Add(this.deskMaterialGroup);
            this.Controls.Add(this.saveQuote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quoteDate);
            this.Controls.Add(this.priceQuote);
            this.Controls.Add(this.deskArea);
            this.Controls.Add(this.drawerNum);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.deskDepth);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form";
            this.Text = "Mega Escritorio Desk Quote";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawerNum)).EndInit();
            this.deskMaterialGroup.ResumeLayout(false);
            this.deskMaterialGroup.PerformLayout();
            this.shippingTermsGroup.ResumeLayout(false);
            this.shippingTermsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteQuoteNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown deskDepth;
        private System.Windows.Forms.NumericUpDown deskWidth;
        private System.Windows.Forms.NumericUpDown drawerNum;
        private System.Windows.Forms.Label deskArea;
        private System.Windows.Forms.Label priceQuote;
        private System.Windows.Forms.Label quoteDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveQuote;
        protected System.Windows.Forms.RadioButton oakRadioButton;
        private System.Windows.Forms.RadioButton laminateRadioButton;
        private System.Windows.Forms.RadioButton pineRadioButton;
        private System.Windows.Forms.RadioButton threeDayRadio;
        private System.Windows.Forms.RadioButton fiveDayRadio;
        private System.Windows.Forms.RadioButton sevenDayRadio;
        private System.Windows.Forms.GroupBox deskMaterialGroup;
        private System.Windows.Forms.GroupBox shippingTermsGroup;
        private System.Windows.Forms.RadioButton standardRadio;
        private System.Windows.Forms.Label deskWidthLabel;
        private System.Windows.Forms.Label deskDepthLabel;
        private System.Windows.Forms.Button calculateQuote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loadQuotes;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchMaterial;
        private System.Windows.Forms.NumericUpDown deleteQuoteNumber;
        private System.Windows.Forms.Button deleteQuote;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.RadioButton ebonyRadioButton;
        private System.Windows.Forms.RadioButton mapleRadioButton;
        private System.Windows.Forms.RadioButton cherryRadioButton;
    }
}

