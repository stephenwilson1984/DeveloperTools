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
            grpConvertNumbers = new GroupBox();
            txtDecimalValue = new TextBox();
            lblDestinationType = new Label();
            cmbDestinationType = new ComboBox();
            lblDestinationValue = new Label();
            lblSourceValue = new Label();
            txtSourceValue = new TextBox();
            lblSelectSource = new Label();
            cmbSourceType = new ComboBox();
            tpJWT = new TabPage();
            tbMainNavigation.SuspendLayout();
            tpNumbers.SuspendLayout();
            grpConvertNumbers.SuspendLayout();
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
            tpNumbers.Controls.Add(grpConvertNumbers);
            tpNumbers.Location = new Point(204, 4);
            tpNumbers.Name = "tpNumbers";
            tpNumbers.Padding = new Padding(3);
            tpNumbers.Size = new Size(921, 572);
            tpNumbers.TabIndex = 0;
            tpNumbers.Text = "Numbers";
            // 
            // grpConvertNumbers
            // 
            grpConvertNumbers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpConvertNumbers.Controls.Add(txtDecimalValue);
            grpConvertNumbers.Controls.Add(lblDestinationType);
            grpConvertNumbers.Controls.Add(cmbDestinationType);
            grpConvertNumbers.Controls.Add(lblDestinationValue);
            grpConvertNumbers.Controls.Add(lblSourceValue);
            grpConvertNumbers.Controls.Add(txtSourceValue);
            grpConvertNumbers.Controls.Add(lblSelectSource);
            grpConvertNumbers.Controls.Add(cmbSourceType);
            grpConvertNumbers.Font = new Font("Segoe UI", 10F);
            grpConvertNumbers.Location = new Point(6, 8);
            grpConvertNumbers.Name = "grpConvertNumbers";
            grpConvertNumbers.Size = new Size(907, 177);
            grpConvertNumbers.TabIndex = 0;
            grpConvertNumbers.TabStop = false;
            grpConvertNumbers.Text = "Convert numbers";
            // 
            // txtDecimalValue
            // 
            txtDecimalValue.Location = new Point(502, 125);
            txtDecimalValue.Name = "txtDecimalValue";
            txtDecimalValue.ReadOnly = true;
            txtDecimalValue.Size = new Size(246, 25);
            txtDecimalValue.TabIndex = 5;
            // 
            // lblDestinationType
            // 
            lblDestinationType.AutoSize = true;
            lblDestinationType.Location = new Point(502, 29);
            lblDestinationType.Name = "lblDestinationType";
            lblDestinationType.Size = new Size(147, 19);
            lblDestinationType.TabIndex = 3;
            lblDestinationType.Text = "Select destination type";
            // 
            // cmbDestinationType
            // 
            cmbDestinationType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestinationType.FormattingEnabled = true;
            cmbDestinationType.Items.AddRange(new object[] { "Binary", "Hexadecimal", "Octal" });
            cmbDestinationType.Location = new Point(502, 51);
            cmbDestinationType.Name = "cmbDestinationType";
            cmbDestinationType.Size = new Size(246, 25);
            cmbDestinationType.TabIndex = 2;
            // 
            // lblDestinationValue
            // 
            lblDestinationValue.AutoSize = true;
            lblDestinationValue.Location = new Point(502, 103);
            lblDestinationValue.Name = "lblDestinationValue";
            lblDestinationValue.Size = new Size(115, 19);
            lblDestinationValue.TabIndex = 4;
            lblDestinationValue.Text = "Destination value";
            // 
            // lblSourceValue
            // 
            lblSourceValue.AutoSize = true;
            lblSourceValue.Location = new Point(136, 103);
            lblSourceValue.Name = "lblSourceValue";
            lblSourceValue.Size = new Size(86, 19);
            lblSourceValue.TabIndex = 3;
            lblSourceValue.Text = "Source value";
            // 
            // txtSourceValue
            // 
            txtSourceValue.Location = new Point(136, 125);
            txtSourceValue.Name = "txtSourceValue";
            txtSourceValue.Size = new Size(246, 25);
            txtSourceValue.TabIndex = 2;
            // 
            // lblSelectSource
            // 
            lblSelectSource.AutoSize = true;
            lblSelectSource.Location = new Point(136, 29);
            lblSelectSource.Name = "lblSelectSource";
            lblSelectSource.Size = new Size(119, 19);
            lblSelectSource.TabIndex = 1;
            lblSelectSource.Text = "Select source type";
            // 
            // cmbSourceType
            // 
            cmbSourceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSourceType.FormattingEnabled = true;
            cmbSourceType.Items.AddRange(new object[] { "Decimal", "Binary", "Hexadecimal", "Octal" });
            cmbSourceType.Location = new Point(136, 51);
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
            MaximizeBox = false;
            MaximumSize = new Size(1145, 619);
            MinimumSize = new Size(1145, 619);
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Developer Tools";
            tbMainNavigation.ResumeLayout(false);
            tpNumbers.ResumeLayout(false);
            grpConvertNumbers.ResumeLayout(false);
            grpConvertNumbers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbMainNavigation;
        private TabPage tpNumbers;
        private TabPage tpJWT;
        private GroupBox grpFromDecimal;
        private GroupBox grpConvertNumbers;
        private Label lblSelectSource;
        private ComboBox cmbSourceType;
        private TextBox txtDecimalValue;
        private Label lblDestinationValue;
        private Label lblSourceValue;
        private TextBox txtSourceValue;
        private Label lblDestinationType;
        private ComboBox cmbDestinationType;
        private TextBox txtDestinationValue;
        private TextBox txtSourceDecimal;
        private Label lblSourceDecimal;
    }
}
