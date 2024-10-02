namespace DeveloperTools.WinForms.Controls
{
    partial class BaseConverter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpConvertNumbers = new GroupBox();
            btnReset = new Button();
            txtDestinationValue = new TextBox();
            lblDestinationType = new Label();
            cmbDestinationType = new ComboBox();
            lblDestinationValue = new Label();
            lblSourceValue = new Label();
            txtSourceValue = new TextBox();
            lblSelectSource = new Label();
            cmbSourceType = new ComboBox();
            lnklblCopy = new LinkLabel();
            grpConvertNumbers.SuspendLayout();
            SuspendLayout();
            // 
            // grpConvertNumbers
            // 
            grpConvertNumbers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpConvertNumbers.Controls.Add(lnklblCopy);
            grpConvertNumbers.Controls.Add(btnReset);
            grpConvertNumbers.Controls.Add(txtDestinationValue);
            grpConvertNumbers.Controls.Add(lblDestinationType);
            grpConvertNumbers.Controls.Add(cmbDestinationType);
            grpConvertNumbers.Controls.Add(lblDestinationValue);
            grpConvertNumbers.Controls.Add(lblSourceValue);
            grpConvertNumbers.Controls.Add(txtSourceValue);
            grpConvertNumbers.Controls.Add(lblSelectSource);
            grpConvertNumbers.Controls.Add(cmbSourceType);
            grpConvertNumbers.Font = new Font("Segoe UI", 10F);
            grpConvertNumbers.Location = new Point(3, 3);
            grpConvertNumbers.Name = "grpConvertNumbers";
            grpConvertNumbers.Size = new Size(834, 218);
            grpConvertNumbers.TabIndex = 1;
            grpConvertNumbers.TabStop = false;
            grpConvertNumbers.Text = "Convert numbers";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(106, 181);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // txtDestinationValue
            // 
            txtDestinationValue.Location = new Point(472, 129);
            txtDestinationValue.Name = "txtDestinationValue";
            txtDestinationValue.ReadOnly = true;
            txtDestinationValue.Size = new Size(246, 25);
            txtDestinationValue.TabIndex = 5;
            // 
            // lblDestinationType
            // 
            lblDestinationType.AutoSize = true;
            lblDestinationType.Location = new Point(472, 33);
            lblDestinationType.Name = "lblDestinationType";
            lblDestinationType.Size = new Size(147, 19);
            lblDestinationType.TabIndex = 3;
            lblDestinationType.Text = "Select destination type";
            // 
            // cmbDestinationType
            // 
            cmbDestinationType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestinationType.FormattingEnabled = true;
            cmbDestinationType.Items.AddRange(new object[] { "Decimal", "Binary", "Octal", "Hexadecimal" });
            cmbDestinationType.Location = new Point(472, 55);
            cmbDestinationType.Name = "cmbDestinationType";
            cmbDestinationType.Size = new Size(246, 25);
            cmbDestinationType.TabIndex = 2;
            // 
            // lblDestinationValue
            // 
            lblDestinationValue.AutoSize = true;
            lblDestinationValue.Location = new Point(472, 107);
            lblDestinationValue.Name = "lblDestinationValue";
            lblDestinationValue.Size = new Size(115, 19);
            lblDestinationValue.TabIndex = 4;
            lblDestinationValue.Text = "Destination value";
            // 
            // lblSourceValue
            // 
            lblSourceValue.AutoSize = true;
            lblSourceValue.Location = new Point(106, 107);
            lblSourceValue.Name = "lblSourceValue";
            lblSourceValue.Size = new Size(86, 19);
            lblSourceValue.TabIndex = 3;
            lblSourceValue.Text = "Source value";
            // 
            // txtSourceValue
            // 
            txtSourceValue.Location = new Point(106, 129);
            txtSourceValue.Name = "txtSourceValue";
            txtSourceValue.Size = new Size(246, 25);
            txtSourceValue.TabIndex = 2;
            // 
            // lblSelectSource
            // 
            lblSelectSource.AutoSize = true;
            lblSelectSource.Location = new Point(106, 33);
            lblSelectSource.Name = "lblSelectSource";
            lblSelectSource.Size = new Size(119, 19);
            lblSelectSource.TabIndex = 1;
            lblSelectSource.Text = "Select source type";
            // 
            // cmbSourceType
            // 
            cmbSourceType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSourceType.FormattingEnabled = true;
            cmbSourceType.Items.AddRange(new object[] { "Decimal", "Binary", "Octal", "Hexadecimal" });
            cmbSourceType.Location = new Point(106, 55);
            cmbSourceType.Name = "cmbSourceType";
            cmbSourceType.Size = new Size(246, 25);
            cmbSourceType.TabIndex = 0;
            // 
            // lnklblCopy
            // 
            lnklblCopy.AutoSize = true;
            lnklblCopy.Location = new Point(724, 135);
            lnklblCopy.Name = "lnklblCopy";
            lnklblCopy.Size = new Size(41, 19);
            lnklblCopy.TabIndex = 7;
            lnklblCopy.TabStop = true;
            lnklblCopy.Text = "Copy";
            // 
            // BaseConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpConvertNumbers);
            Name = "BaseConverter";
            Size = new Size(840, 224);
            grpConvertNumbers.ResumeLayout(false);
            grpConvertNumbers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpConvertNumbers;
        private TextBox txtDestinationValue;
        private Label lblDestinationType;
        private ComboBox cmbDestinationType;
        private Label lblDestinationValue;
        private Label lblSourceValue;
        private TextBox txtSourceValue;
        private Label lblSelectSource;
        private ComboBox cmbSourceType;
        private Button btnReset;
        private LinkLabel lnklblCopy;
    }
}
