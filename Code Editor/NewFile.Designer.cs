namespace Code_Editor
{
    partial class NewFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewFile));
            this.label1 = new System.Windows.Forms.Label();
            this.projectNameTxt = new Code_Editor.Controls.RoundedEntryBox();
            this.createBtn = new Code_Editor.Controls.RoundButton();
            this.closeBtn = new Code_Editor.Controls.RoundButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create New File";
            // 
            // projectNameTxt
            // 
            this.projectNameTxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.projectNameTxt.Animated = true;
            this.projectNameTxt.BackColor = System.Drawing.SystemColors.Window;
            this.projectNameTxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.projectNameTxt.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.projectNameTxt.BorderRadius = 0;
            this.projectNameTxt.BorderSize = 3;
            this.projectNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameTxt.ForeColor = System.Drawing.Color.DimGray;
            this.projectNameTxt.Location = new System.Drawing.Point(66, 81);
            this.projectNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.projectNameTxt.Multiline = false;
            this.projectNameTxt.Name = "projectNameTxt";
            this.projectNameTxt.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.projectNameTxt.PasswordCharacters = false;
            this.projectNameTxt.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.projectNameTxt.PlaceHolderText = "File Name";
            this.projectNameTxt.Size = new System.Drawing.Size(295, 31);
            this.projectNameTxt.TabIndex = 0;
            this.projectNameTxt.Texts = "";
            this.projectNameTxt.UnderlinedStyle = false;
            // 
            // createBtn
            // 
            this.createBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.createBtn.Animated = true;
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.createBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.createBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.createBtn.BorderRadius = 35;
            this.createBtn.BorderSize = 0;
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.Location = new System.Drawing.Point(127, 163);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(175, 43);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create";
            this.createBtn.TextColor = System.Drawing.Color.White;
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeBtn.Animated = true;
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.closeBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.closeBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.closeBtn.BorderRadius = 20;
            this.closeBtn.BorderSize = 0;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(112, 212);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(202, 55);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Cancel";
            this.closeBtn.TextColor = System.Drawing.Color.White;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // NewFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(422, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projectNameTxt);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Controls.RoundedEntryBox projectNameTxt;
        private Controls.RoundButton createBtn;
        private Controls.RoundButton closeBtn;
    }
}