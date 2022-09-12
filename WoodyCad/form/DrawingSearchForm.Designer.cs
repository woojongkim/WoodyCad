using System;

namespace WoodyCad.form
{
    partial class DrawingSearchForm
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
            this.searchView = new MaterialSkin.Controls.MaterialListView();
            this.btnCheckOut = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDrawingNo = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDrawingName = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDrafter = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.NavPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.MainContentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchView
            // 
            this.searchView.AutoSizeTable = false;
            this.searchView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.searchView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchView.Depth = 0;
            this.searchView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchView.FullRowSelect = true;
            this.searchView.HideSelection = false;
            this.searchView.Location = new System.Drawing.Point(5, 5);
            this.searchView.MinimumSize = new System.Drawing.Size(200, 100);
            this.searchView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.searchView.MouseState = MaterialSkin.MouseState.OUT;
            this.searchView.Name = "searchView";
            this.searchView.OwnerDraw = true;
            this.searchView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchView.Size = new System.Drawing.Size(652, 600);
            this.searchView.TabIndex = 7;
            this.searchView.UseCompatibleStateImageBehavior = false;
            this.searchView.View = System.Windows.Forms.View.List;
            this.searchView.ItemActivate += new System.EventHandler(this.searchView_ItemActive);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCheckOut.Depth = 0;
            this.btnCheckOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckOut.HighEmphasis = true;
            this.btnCheckOut.Icon = null;
            this.btnCheckOut.Location = new System.Drawing.Point(5, 5);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheckOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCheckOut.Size = new System.Drawing.Size(652, 29);
            this.btnCheckOut.TabIndex = 8;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCheckOut.UseAccentColor = false;
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDrawingNo);
            this.groupBox1.Location = new System.Drawing.Point(22, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drawing No";
            // 
            // txtDrawingNo
            // 
            this.txtDrawingNo.AnimateReadOnly = false;
            this.txtDrawingNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDrawingNo.Depth = 0;
            this.txtDrawingNo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDrawingNo.LeadingIcon = null;
            this.txtDrawingNo.Location = new System.Drawing.Point(6, 25);
            this.txtDrawingNo.MaxLength = 50;
            this.txtDrawingNo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDrawingNo.Multiline = false;
            this.txtDrawingNo.Name = "txtDrawingNo";
            this.txtDrawingNo.Size = new System.Drawing.Size(206, 50);
            this.txtDrawingNo.TabIndex = 1;
            this.txtDrawingNo.Text = "";
            this.txtDrawingNo.TrailingIcon = null;
            this.txtDrawingNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDrawingName);
            this.groupBox2.Location = new System.Drawing.Point(22, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 86);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drawing Name";
            // 
            // txtDrawingName
            // 
            this.txtDrawingName.AnimateReadOnly = false;
            this.txtDrawingName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDrawingName.Depth = 0;
            this.txtDrawingName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDrawingName.LeadingIcon = null;
            this.txtDrawingName.Location = new System.Drawing.Point(6, 25);
            this.txtDrawingName.MaxLength = 50;
            this.txtDrawingName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDrawingName.Multiline = false;
            this.txtDrawingName.Name = "txtDrawingName";
            this.txtDrawingName.Size = new System.Drawing.Size(206, 50);
            this.txtDrawingName.TabIndex = 2;
            this.txtDrawingName.Text = "";
            this.txtDrawingName.TrailingIcon = null;
            this.txtDrawingName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDrafter);
            this.groupBox3.Location = new System.Drawing.Point(22, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 86);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drafter";
            // 
            // txtDrafter
            // 
            this.txtDrafter.AnimateReadOnly = false;
            this.txtDrafter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDrafter.Depth = 0;
            this.txtDrafter.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDrafter.LeadingIcon = null;
            this.txtDrafter.Location = new System.Drawing.Point(6, 25);
            this.txtDrafter.MaxLength = 50;
            this.txtDrafter.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDrafter.Multiline = false;
            this.txtDrafter.Name = "txtDrafter";
            this.txtDrafter.Size = new System.Drawing.Size(206, 50);
            this.txtDrafter.TabIndex = 3;
            this.txtDrafter.Text = "";
            this.txtDrafter.TrailingIcon = null;
            this.txtDrafter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateStart);
            this.groupBox4.Location = new System.Drawing.Point(22, 302);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 86);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Start Date";
            // 
            // dateStart
            // 
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateStart.Location = new System.Drawing.Point(12, 37);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 29);
            this.dateStart.TabIndex = 4;
            this.dateStart.Value = new System.DateTime(2022, 9, 6, 1, 28, 32, 651);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateEnd);
            this.groupBox5.Location = new System.Drawing.Point(22, 394);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(218, 86);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "End Date";
            // 
            // dateEnd
            // 
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEnd.Location = new System.Drawing.Point(12, 37);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 29);
            this.dateEnd.TabIndex = 5;
            this.dateEnd.Value = new System.DateTime(2022, 9, 13, 1, 28, 32, 653);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(5, 5);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(252, 29);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // NavPanel
            // 
            this.NavPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NavPanel.Controls.Add(this.panel1);
            this.NavPanel.Controls.Add(this.groupBox1);
            this.NavPanel.Controls.Add(this.groupBox2);
            this.NavPanel.Controls.Add(this.groupBox3);
            this.NavPanel.Controls.Add(this.groupBox5);
            this.NavPanel.Controls.Add(this.groupBox4);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavPanel.Location = new System.Drawing.Point(3, 64);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(264, 612);
            this.NavPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 571);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(262, 39);
            this.panel1.TabIndex = 7;
            // 
            // SidePanel
            // 
            this.SidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.SidePanel.Location = new System.Drawing.Point(931, 64);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(447, 612);
            this.SidePanel.TabIndex = 9;
            this.SidePanel.Visible = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.panel4);
            this.MainPanel.Controls.Add(this.MainContentPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(267, 64);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainPanel.Size = new System.Drawing.Size(664, 612);
            this.MainPanel.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCheckOut);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 571);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(662, 39);
            this.panel4.TabIndex = 10;
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Controls.Add(this.searchView);
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Location = new System.Drawing.Point(0, 0);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Padding = new System.Windows.Forms.Padding(5);
            this.MainContentPanel.Size = new System.Drawing.Size(662, 610);
            this.MainContentPanel.TabIndex = 9;
            // 
            // DrawingSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1381, 679);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.NavPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "DrawingSearchForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Drawing Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.NavPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.MainContentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private MaterialSkin.Controls.MaterialListView searchView;
        private MaterialSkin.Controls.MaterialButton btnCheckOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox txtDrawingNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTextBox txtDrawingName;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialTextBox txtDrafter;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel MainContentPanel;
        private System.Windows.Forms.Panel panel1;
    }
}