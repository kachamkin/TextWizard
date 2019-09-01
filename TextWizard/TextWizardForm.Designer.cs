namespace TextWizard
{
    partial class TextWizardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextWizardForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.conversion = new System.Windows.Forms.ComboBox();
            this.Invert = new System.Windows.Forms.ToolStripButton();
            this.EncodingSelection = new System.Windows.Forms.ToolStripDropDownButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(10, 63);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.input);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.output);
            this.splitContainer1.Size = new System.Drawing.Size(780, 374);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.TabIndex = 0;
            // 
            // input
            // 
            this.input.AcceptsReturn = true;
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input.Location = new System.Drawing.Point(4, 0);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(776, 176);
            this.input.TabIndex = 0;
            this.input.TextChanged += new System.EventHandler(this.inputTextChanged);
            // 
            // output
            // 
            this.output.AcceptsReturn = true;
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.output.Location = new System.Drawing.Point(4, 4);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(773, 184);
            this.output.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Invert,
            this.toolStripSeparator1,
            this.Save,
            this.toolStripSeparator2,
            this.EncodingSelection});
            this.toolStrip1.Location = new System.Drawing.Point(10, 10);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(780, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conversion type:";
            // 
            // conversion
            // 
            this.conversion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conversion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.conversion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.conversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conversion.FormattingEnabled = true;
            this.conversion.Items.AddRange(new object[] {
            "From Base64",
            "From deflated SAML",
            "From Hex",
            "From JS string",
            "From UTF-7",
            "HTML decode",
            "HTML encode",
            "To Base64",
            "To deflated SAML",
            "To Hex",
            "To JS string",
            "To MD5",
            "To SHA1",
            "To SHA256",
            "To SHA384",
            "To SHA512",
            "To UTF-7",
            "URL decode",
            "URL encode"});
            this.conversion.Location = new System.Drawing.Point(107, 39);
            this.conversion.Name = "conversion";
            this.conversion.Size = new System.Drawing.Size(683, 21);
            this.conversion.Sorted = true;
            this.conversion.TabIndex = 4;
            this.conversion.TextChanged += new System.EventHandler(this.conversionTextChanged);
            // 
            // Invert
            // 
            this.Invert.Image = global::TextWizard.Properties.Resources.Invert;
            this.Invert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Invert.Name = "Invert";
            this.Invert.Size = new System.Drawing.Size(57, 22);
            this.Invert.Text = "Invert";
            this.Invert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InvertMouseDown);
            // 
            // EncodingSelection
            // 
            this.EncodingSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.EncodingSelection.Image = ((System.Drawing.Image)(resources.GetObject("EncodingSelection.Image")));
            this.EncodingSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EncodingSelection.Name = "EncodingSelection";
            this.EncodingSelection.Size = new System.Drawing.Size(70, 22);
            this.EncodingSelection.Text = "Encoding";
            this.EncodingSelection.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.EncodingSelected);
            // 
            // Save
            // 
            this.Save.Image = global::TextWizard.Properties.Resources.Save;
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(51, 22);
            this.Save.Text = "Save";
            this.Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SaveMouseDown);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // TextWizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.conversion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextWizardForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Text Wizard";
            this.Load += new System.EventHandler(this.TextWizardFormOnLoad);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Invert;
        private System.Windows.Forms.ToolStripDropDownButton EncodingSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox conversion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

