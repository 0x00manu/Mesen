﻿namespace Mesen.GUI.Debugger.Controls
{
	partial class ctrlHexViewer
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
			if(disposing && (components != null)) {
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
			this.components = new System.ComponentModel.Container();
			this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.lblNumberOfColumns = new System.Windows.Forms.Label();
			this.cboNumberColumns = new System.Windows.Forms.ComboBox();
			this.panelSearch = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.picCloseSearch = new System.Windows.Forms.PictureBox();
			this.picSearchNext = new System.Windows.Forms.PictureBox();
			this.picSearchPrevious = new System.Windows.Forms.PictureBox();
			this.cboSearch = new System.Windows.Forms.ComboBox();
			this.lblSearchWarning = new System.Windows.Forms.Label();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.chkTextSearch = new System.Windows.Forms.CheckBox();
			this.chkMatchCase = new System.Windows.Forms.CheckBox();
			this.ctrlHexBox = new Be.Windows.Forms.HexBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.tlpMain.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panelSearch.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCloseSearch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picSearchNext)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picSearchPrevious)).BeginInit();
			this.flowLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlpMain
			// 
			this.tlpMain.ColumnCount = 1;
			this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpMain.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tlpMain.Controls.Add(this.panelSearch, 0, 2);
			this.tlpMain.Controls.Add(this.ctrlHexBox, 0, 1);
			this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlpMain.Location = new System.Drawing.Point(0, 0);
			this.tlpMain.Name = "tlpMain";
			this.tlpMain.RowCount = 3;
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tlpMain.Size = new System.Drawing.Size(543, 309);
			this.tlpMain.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.lblNumberOfColumns);
			this.flowLayoutPanel1.Controls.Add(this.cboNumberColumns);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(379, 0);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(164, 27);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// lblNumberOfColumns
			// 
			this.lblNumberOfColumns.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblNumberOfColumns.AutoSize = true;
			this.lblNumberOfColumns.Location = new System.Drawing.Point(3, 7);
			this.lblNumberOfColumns.Name = "lblNumberOfColumns";
			this.lblNumberOfColumns.Size = new System.Drawing.Size(102, 13);
			this.lblNumberOfColumns.TabIndex = 0;
			this.lblNumberOfColumns.Text = "Number of Columns:";
			// 
			// cboNumberColumns
			// 
			this.cboNumberColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboNumberColumns.FormattingEnabled = true;
			this.cboNumberColumns.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32",
            "64"});
			this.cboNumberColumns.Location = new System.Drawing.Point(111, 3);
			this.cboNumberColumns.Name = "cboNumberColumns";
			this.cboNumberColumns.Size = new System.Drawing.Size(50, 21);
			this.cboNumberColumns.TabIndex = 1;
			this.cboNumberColumns.SelectedIndexChanged += new System.EventHandler(this.cboNumberColumns_SelectedIndexChanged);
			// 
			// panelSearch
			// 
			this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelSearch.Controls.Add(this.tableLayoutPanel2);
			this.panelSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelSearch.Location = new System.Drawing.Point(3, 281);
			this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Size = new System.Drawing.Size(537, 28);
			this.panelSearch.TabIndex = 3;
			this.panelSearch.Visible = false;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 6;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.picCloseSearch, 3, 0);
			this.tableLayoutPanel2.Controls.Add(this.picSearchNext, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.picSearchPrevious, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.cboSearch, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.lblSearchWarning, 4, 0);
			this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 5, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(535, 26);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// picCloseSearch
			// 
			this.picCloseSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.picCloseSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picCloseSearch.Image = global::Mesen.GUI.Properties.Resources.Close;
			this.picCloseSearch.Location = new System.Drawing.Point(297, 5);
			this.picCloseSearch.Name = "picCloseSearch";
			this.picCloseSearch.Size = new System.Drawing.Size(16, 16);
			this.picCloseSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picCloseSearch.TabIndex = 3;
			this.picCloseSearch.TabStop = false;
			this.picCloseSearch.Click += new System.EventHandler(this.picCloseSearch_Click);
			// 
			// picSearchNext
			// 
			this.picSearchNext.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.picSearchNext.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picSearchNext.Image = global::Mesen.GUI.Properties.Resources.NextArrow;
			this.picSearchNext.Location = new System.Drawing.Point(275, 5);
			this.picSearchNext.Name = "picSearchNext";
			this.picSearchNext.Size = new System.Drawing.Size(16, 16);
			this.picSearchNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picSearchNext.TabIndex = 2;
			this.picSearchNext.TabStop = false;
			this.picSearchNext.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picSearchNext_MouseUp);
			// 
			// picSearchPrevious
			// 
			this.picSearchPrevious.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.picSearchPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
			this.picSearchPrevious.Image = global::Mesen.GUI.Properties.Resources.PreviousArrow;
			this.picSearchPrevious.Location = new System.Drawing.Point(253, 5);
			this.picSearchPrevious.Name = "picSearchPrevious";
			this.picSearchPrevious.Size = new System.Drawing.Size(16, 16);
			this.picSearchPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picSearchPrevious.TabIndex = 1;
			this.picSearchPrevious.TabStop = false;
			this.picSearchPrevious.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picSearchPrevious_MouseUp);
			// 
			// cboSearch
			// 
			this.cboSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboSearch.FormattingEnabled = true;
			this.cboSearch.Location = new System.Drawing.Point(3, 3);
			this.cboSearch.Name = "cboSearch";
			this.cboSearch.Size = new System.Drawing.Size(244, 21);
			this.cboSearch.TabIndex = 4;
			this.cboSearch.TextUpdate += new System.EventHandler(this.cboSearch_TextUpdate);
			this.cboSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboSearch_KeyDown);
			// 
			// lblSearchWarning
			// 
			this.lblSearchWarning.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSearchWarning.AutoSize = true;
			this.lblSearchWarning.ForeColor = System.Drawing.Color.Red;
			this.lblSearchWarning.Location = new System.Drawing.Point(319, 7);
			this.lblSearchWarning.Name = "lblSearchWarning";
			this.lblSearchWarning.Size = new System.Drawing.Size(0, 13);
			this.lblSearchWarning.TabIndex = 6;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.chkTextSearch);
			this.flowLayoutPanel2.Controls.Add(this.chkMatchCase);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(322, 2);
			this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(213, 25);
			this.flowLayoutPanel2.TabIndex = 7;
			// 
			// chkTextSearch
			// 
			this.chkTextSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.chkTextSearch.AutoSize = true;
			this.chkTextSearch.Location = new System.Drawing.Point(128, 3);
			this.chkTextSearch.Name = "chkTextSearch";
			this.chkTextSearch.Size = new System.Drawing.Size(82, 17);
			this.chkTextSearch.TabIndex = 5;
			this.chkTextSearch.Text = "Text search";
			this.chkTextSearch.UseVisualStyleBackColor = true;
			this.chkTextSearch.CheckedChanged += new System.EventHandler(this.chkTextSearch_CheckedChanged);
			// 
			// chkMatchCase
			// 
			this.chkMatchCase.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.chkMatchCase.AutoSize = true;
			this.chkMatchCase.Location = new System.Drawing.Point(39, 3);
			this.chkMatchCase.Name = "chkMatchCase";
			this.chkMatchCase.Size = new System.Drawing.Size(83, 17);
			this.chkMatchCase.TabIndex = 6;
			this.chkMatchCase.Text = "Match Case";
			this.chkMatchCase.UseVisualStyleBackColor = true;
			// 
			// ctrlHexBox
			// 
			this.ctrlHexBox.ColumnInfoVisible = true;
			this.ctrlHexBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ctrlHexBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ctrlHexBox.InfoBackColor = System.Drawing.Color.DarkGray;
			this.ctrlHexBox.LineInfoVisible = true;
			this.ctrlHexBox.Location = new System.Drawing.Point(3, 30);
			this.ctrlHexBox.Name = "ctrlHexBox";
			this.ctrlHexBox.SelectionBackColor = System.Drawing.Color.RoyalBlue;
			this.ctrlHexBox.ShadowSelectionColor = System.Drawing.Color.Orange;
			this.ctrlHexBox.Size = new System.Drawing.Size(537, 248);
			this.ctrlHexBox.StringViewVisible = true;
			this.ctrlHexBox.TabIndex = 2;
			this.ctrlHexBox.UseFixedBytesPerLine = true;
			this.ctrlHexBox.VScrollBarVisible = true;
			// 
			// ctrlHexViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tlpMain);
			this.Name = "ctrlHexViewer";
			this.Size = new System.Drawing.Size(543, 309);
			this.tlpMain.ResumeLayout(false);
			this.tlpMain.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panelSearch.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picCloseSearch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picSearchNext)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picSearchPrevious)).EndInit();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tlpMain;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label lblNumberOfColumns;
		private System.Windows.Forms.ComboBox cboNumberColumns;
		private System.Windows.Forms.ToolTip toolTip;
		private Be.Windows.Forms.HexBox ctrlHexBox;
		private System.Windows.Forms.Panel panelSearch;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.PictureBox picCloseSearch;
		private System.Windows.Forms.PictureBox picSearchNext;
		private System.Windows.Forms.PictureBox picSearchPrevious;
		private System.Windows.Forms.ComboBox cboSearch;
		private System.Windows.Forms.CheckBox chkTextSearch;
		private System.Windows.Forms.Label lblSearchWarning;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.CheckBox chkMatchCase;
	}
}
