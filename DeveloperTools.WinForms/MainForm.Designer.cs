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
            tpBaseConversion = new TabPage();
            baseConverter1 = new Controls.BaseConverter();
            tpJWT = new TabPage();
            tbMainNavigation.SuspendLayout();
            tpBaseConversion.SuspendLayout();
            SuspendLayout();
            // 
            // tbMainNavigation
            // 
            tbMainNavigation.Alignment = TabAlignment.Left;
            tbMainNavigation.Controls.Add(tpBaseConversion);
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
            // tpBaseConversion
            // 
            tpBaseConversion.BackColor = SystemColors.ControlLightLight;
            tpBaseConversion.Controls.Add(baseConverter1);
            tpBaseConversion.Location = new Point(204, 4);
            tpBaseConversion.Name = "tpBaseConversion";
            tpBaseConversion.Padding = new Padding(3);
            tpBaseConversion.Size = new Size(921, 572);
            tpBaseConversion.TabIndex = 0;
            tpBaseConversion.Text = "Base Conversion";
            // 
            // baseConverter1
            // 
            baseConverter1.Location = new Point(6, 8);
            baseConverter1.Name = "baseConverter1";
            baseConverter1.Size = new Size(907, 230);
            baseConverter1.TabIndex = 0;
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
            tpBaseConversion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbMainNavigation;
        private TabPage tpBaseConversion;
        private TabPage tpJWT;
        private Controls.BaseConverter baseConverter1;
    }
}
