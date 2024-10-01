namespace DeveloperTools.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbMainNavigation = new TabControl();
            tpNumbers = new TabPage();
            grpFromDecimal = new GroupBox();
            grpToDecimal = new GroupBox();
            txtDecimalValue = new TextBox();
            lblDecimalValue = new Label();
            lblSourceValue = new Label();
            txtSourceValue = new TextBox();
            lblSelectSource = new Label();
            cmbSourceType = new ComboBox();
            tpJWT = new TabPage();
            tbMainNavigation.SuspendLayout();
            tpNumbers.SuspendLayout();
            grpToDecimal.SuspendLayout();
            SuspendLayout();
            // 
            // tbMainNavigation
            // 
            tbMainNavigation.Alignment = TabAlignment.Left;
            tbMainNavigation.Controls.Add(tpNumbers);
            tbMainNavigation.Controls.Add(tpJWT);
            tbMainNavigation.Dock = DockStyle.Fill;
            tbMainNavigation.DrawMode = TabDrawMode.OwnerDrawFixed;
            tbMainNavigation.ItemSize = new Size(40, 200);
            tbMainNavigation.Location = new Point(0, 0);
            tbMainNavigation.Multiline = true;
            tbMainNavigation.Name = "tbMainNavigation";
            tbMainNavigation.SelectedIndex = 0;
            tbMainNavigation.Size = new Size(1129, 580);
            tbMainNavigation.SizeMode = TabSizeMode.Fixed;
            tbMainNavigation.TabIndex = 0;
            // 
            // tpNumbers
            // 
            tpNumbers.BackColor = SystemColors.ControlLightLight;
            tpNumbers.Controls.Add(grpFromDecimal);
            tpNumbers.Controls.Add(grpToDecimal);
            tpNumbers.Location = new Point(204, 4);
            tpNumbers.Name = "tpNumbers";
            tpNumbers.Padding = new Padding(3);
            tpNumbers.Size = new Size(921, 572);
            tpNumbers.TabIndex = 0;
            tpNumbers.Text = "Numbers";
            // 
            // grpFromDecimal
            // 
            grpFromDecimal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFromDecimal.Location = new Point(6, 191);
            grpFromDecimal.Name = "grpFromDecimal";
            grpFromDecimal.Size = new Size(907, 177);
            grpFromDecimal.TabIndex = 1;
            grpFromDecimal.TabStop = false;
            grpFromDecimal.Text = "Convert from decimal";
            // 
            // grpToDecimal
            // 
            grpToDecimal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpToDecimal.Controls.Add(txtDecimalValue);
            grpToDecimal.Controls.Add(lblDecimalValue);
            grpToDecimal.Controls.Add(lblSourceValue);
            grpToDecimal.Controls.Add(txtSourceValue);
            grpToDecimal.Controls.Add(lblSelectSource);
            grpToDecimal.Controls.Add(cmbSourceType);
            grpToDecimal.Font = new Font("Segoe UI", 10F);
            grpToDecimal.Location = new Point(6, 8);
            grpToDecimal.Name = "grpToDecimal";
            grpToDecimal.Size = new Size(907, 177);
            grpToDecimal.TabIndex = 0;
            grpToDecimal.TabStop = false;
            grpToDecimal.Text = "Convert to decimal";
            // 
            // txtDecimalValue
            // 
            txtDecimalValue.Location = new Point(381, 43);
            txtDecimalValue.Name = "txtDecimalValue";
            txtDecimalValue.ReadOnly = true;
            txtDecimalValue.Size = new Size(246, 25);
            txtDecimalValue.TabIndex = 5;
            // 
            // lblDecimalValue
            // 
            lblDecimalValue.AutoSize = true;
            lblDecimalValue.Location = new Point(381, 21);
            lblDecimalValue.Name = "lblDecimalValue";
            lblDecimalValue.Size = new Size(93, 19);
            lblDecimalValue.TabIndex = 4;
            lblDecimalValue.Text = "Decimal value";
            // 
            // lblSourceValue
            // 
            lblSourceValue.AutoSize = true;
            lblSourceValue.Location = new Point(6, 95);
            lblSourceValue.Name = "lblSourceValue";
            lblSourceValue.Size = new Size(86, 19);
            lblSourceValue.TabIndex = 3;
            lblSourceValue.Text = "Source value";
            // 
            // txtSourceValue
            // 
            txtSourceValue.Location = new Point(6, 117);
            txtSourceValue.Name = "txtSourceValue";
            txtSourceValue.Size = new Size(246, 25);
            txtSourceValue.TabIndex = 2;
            // 
            // lblSelectSource
            // 
            lblSelectSource.AutoSize = true;
            lblSelectSource.Location = new Point(6, 21);
            lblSelectSource.Name = "lblSelectSource";
            lblSelectSource.Size = new Size(88, 19);
            lblSelectSource.TabIndex = 1;
            lblSelectSource.Text = "Select source";
            // 
            // cmbSourceType
            // 
            cmbSourceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSourceType.FormattingEnabled = true;
            cmbSourceType.Items.AddRange(new object[] { "Binary", "Hexadecimal", "Octal" });
            cmbSourceType.Location = new Point(6, 43);
            cmbSourceType.Name = "cmbSourceType";
            cmbSourceType.Size = new Size(246, 25);
            cmbSourceType.TabIndex = 0;
            // 
            // tpJWT
            // 
            tpJWT.Location = new Point(204, 4);
            tpJWT.Name = "tpJWT";
            tpJWT.Padding = new Padding(3);
            tpJWT.Size = new Size(921, 572);
            tpJWT.TabIndex = 1;
            tpJWT.Text = "JWT";
            tpJWT.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 580);
            Controls.Add(tbMainNavigation);
            Name = "MainForm";
            Text = "Developer Tools";
            tbMainNavigation.ResumeLayout(false);
            tpNumbers.ResumeLayout(false);
            grpToDecimal.ResumeLayout(false);
            grpToDecimal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbMainNavigation;
        private TabPage tpNumbers;
        private TabPage tpJWT;
        private GroupBox grpFromDecimal;
        private GroupBox grpToDecimal;
        private Label lblSelectSource;
        private ComboBox cmbSourceType;
        private TextBox txtDecimalValue;
        private Label lblDecimalValue;
        private Label lblSourceValue;
        private TextBox txtSourceValue;
    }
}
