namespace WoodyCad.form
{
    partial class DrawingCheckInForm
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
            this.txtDrawingNo = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDrawingName = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDrafter = new MaterialSkin.Controls.MaterialTextBox();
            this.btnCheckIn = new MaterialSkin.Controls.MaterialButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtComment = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDrawingNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(24, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing No";
            // 
            // txtDrawingNo
            // 
            this.txtDrawingNo.AnimateReadOnly = false;
            this.txtDrawingNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDrawingNo.Depth = 0;
            this.txtDrawingNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDrawingNo.LeadingIcon = null;
            this.txtDrawingNo.Location = new System.Drawing.Point(6, 25);
            this.txtDrawingNo.MaxLength = 50;
            this.txtDrawingNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDrawingNo.Multiline = false;
            this.txtDrawingNo.Name = "txtDrawingNo";
            this.txtDrawingNo.Size = new System.Drawing.Size(312, 50);
            this.txtDrawingNo.TabIndex = 1;
            this.txtDrawingNo.Text = "";
            this.txtDrawingNo.TrailingIcon = null;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDrawingName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox2.Location = new System.Drawing.Point(24, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 86);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drawing Name";
            // 
            // txtDrawingName
            // 
            this.txtDrawingName.AnimateReadOnly = false;
            this.txtDrawingName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDrawingName.Depth = 0;
            this.txtDrawingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDrawingName.LeadingIcon = null;
            this.txtDrawingName.Location = new System.Drawing.Point(6, 25);
            this.txtDrawingName.MaxLength = 50;
            this.txtDrawingName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDrawingName.Multiline = false;
            this.txtDrawingName.Name = "txtDrawingName";
            this.txtDrawingName.Size = new System.Drawing.Size(312, 50);
            this.txtDrawingName.TabIndex = 2;
            this.txtDrawingName.Text = "";
            this.txtDrawingName.TrailingIcon = null;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDrafter);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox3.Location = new System.Drawing.Point(24, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 86);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drafter";
            // 
            // txtDrafter
            // 
            this.txtDrafter.AnimateReadOnly = false;
            this.txtDrafter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDrafter.Depth = 0;
            this.txtDrafter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDrafter.LeadingIcon = null;
            this.txtDrafter.Location = new System.Drawing.Point(6, 25);
            this.txtDrafter.MaxLength = 50;
            this.txtDrafter.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDrafter.Multiline = false;
            this.txtDrafter.Name = "txtDrafter";
            this.txtDrafter.Size = new System.Drawing.Size(312, 50);
            this.txtDrafter.TabIndex = 3;
            this.txtDrafter.Text = "";
            this.txtDrafter.TrailingIcon = null;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCheckIn.Depth = 0;
            this.btnCheckIn.HighEmphasis = true;
            this.btnCheckIn.Icon = null;
            this.btnCheckIn.Location = new System.Drawing.Point(133, 530);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheckIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCheckIn.Size = new System.Drawing.Size(87, 36);
            this.btnCheckIn.TabIndex = 6;
            this.btnCheckIn.Text = "CHECK IN";
            this.btnCheckIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCheckIn.UseAccentColor = false;
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtComment);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox4.Location = new System.Drawing.Point(24, 364);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 157);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Comment";
            // 
            // txtComment
            // 
            this.txtComment.AnimateReadOnly = false;
            this.txtComment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtComment.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.Depth = 0;
            this.txtComment.HideSelection = true;
            this.txtComment.Location = new System.Drawing.Point(6, 28);
            this.txtComment.MaxLength = 32767;
            this.txtComment.MouseState = MaterialSkin.MouseState.OUT;
            this.txtComment.Name = "txtComment";
            this.txtComment.PasswordChar = '\0';
            this.txtComment.ReadOnly = false;
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComment.SelectedText = "";
            this.txtComment.SelectionLength = 0;
            this.txtComment.SelectionStart = 0;
            this.txtComment.ShortcutsEnabled = true;
            this.txtComment.Size = new System.Drawing.Size(312, 123);
            this.txtComment.TabIndex = 0;
            this.txtComment.TabStop = false;
            this.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComment.UseSystemPasswordChar = false;
            // 
            // DrawingCheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 575);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "DrawingCheckInForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check In Form";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox txtDrawingNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTextBox txtDrawingName;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialTextBox txtDrafter;
        private MaterialSkin.Controls.MaterialButton btnCheckIn;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtComment;
    }
}