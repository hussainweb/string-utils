namespace StringUtils
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.txtString = new System.Windows.Forms.RichTextBox();
			this.grpText = new System.Windows.Forms.GroupBox();
			this.btnRefreshAll = new System.Windows.Forms.Button();
			this.btnLoadFile = new System.Windows.Forms.Button();
			this.grpGeneral = new System.Windows.Forms.GroupBox();
			this.btnRefreshGeneral = new System.Windows.Forms.Button();
			this.btnCopyLengthBytes = new System.Windows.Forms.Button();
			this.btnRefreshLengthBytes = new System.Windows.Forms.Button();
			this.txtLengthBytes = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnCopyLength = new System.Windows.Forms.Button();
			this.btnRefreshLength = new System.Windows.Forms.Button();
			this.txtLength = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grpText.SuspendLayout();
			this.grpGeneral.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtString
			// 
			this.txtString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtString.Location = new System.Drawing.Point(6, 19);
			this.txtString.Name = "txtString";
			this.txtString.Size = new System.Drawing.Size(305, 379);
			this.txtString.TabIndex = 0;
			this.txtString.Text = "";
			this.txtString.TextChanged += new System.EventHandler(this.txtString_TextChanged);
			// 
			// grpText
			// 
			this.grpText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grpText.Controls.Add(this.btnRefreshAll);
			this.grpText.Controls.Add(this.btnLoadFile);
			this.grpText.Controls.Add(this.txtString);
			this.grpText.Location = new System.Drawing.Point(12, 12);
			this.grpText.Name = "grpText";
			this.grpText.Size = new System.Drawing.Size(317, 434);
			this.grpText.TabIndex = 0;
			this.grpText.TabStop = false;
			this.grpText.Text = "String";
			// 
			// btnRefreshAll
			// 
			this.btnRefreshAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefreshAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefreshAll.Image = global::StringUtils.Properties.Resources.refresh;
			this.btnRefreshAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRefreshAll.Location = new System.Drawing.Point(215, 404);
			this.btnRefreshAll.Name = "btnRefreshAll";
			this.btnRefreshAll.Size = new System.Drawing.Size(96, 24);
			this.btnRefreshAll.TabIndex = 2;
			this.btnRefreshAll.Text = "&Refresh All";
			this.btnRefreshAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRefreshAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRefreshAll.UseVisualStyleBackColor = true;
			this.btnRefreshAll.Click += new System.EventHandler(this.btnRefreshAll_Click);
			// 
			// btnLoadFile
			// 
			this.btnLoadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnLoadFile.Location = new System.Drawing.Point(6, 404);
			this.btnLoadFile.Name = "btnLoadFile";
			this.btnLoadFile.Size = new System.Drawing.Size(75, 24);
			this.btnLoadFile.TabIndex = 1;
			this.btnLoadFile.Text = "L&oad File";
			this.btnLoadFile.UseVisualStyleBackColor = true;
			// 
			// grpGeneral
			// 
			this.grpGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.grpGeneral.Controls.Add(this.btnRefreshGeneral);
			this.grpGeneral.Controls.Add(this.btnCopyLengthBytes);
			this.grpGeneral.Controls.Add(this.btnRefreshLengthBytes);
			this.grpGeneral.Controls.Add(this.txtLengthBytes);
			this.grpGeneral.Controls.Add(this.label2);
			this.grpGeneral.Controls.Add(this.btnCopyLength);
			this.grpGeneral.Controls.Add(this.btnRefreshLength);
			this.grpGeneral.Controls.Add(this.txtLength);
			this.grpGeneral.Controls.Add(this.label1);
			this.grpGeneral.Location = new System.Drawing.Point(335, 12);
			this.grpGeneral.Name = "grpGeneral";
			this.grpGeneral.Size = new System.Drawing.Size(273, 145);
			this.grpGeneral.TabIndex = 1;
			this.grpGeneral.TabStop = false;
			this.grpGeneral.Text = "General";
			// 
			// btnRefreshGeneral
			// 
			this.btnRefreshGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnRefreshGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRefreshGeneral.Image = global::StringUtils.Properties.Resources.refresh;
			this.btnRefreshGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRefreshGeneral.Location = new System.Drawing.Point(142, 115);
			this.btnRefreshGeneral.Name = "btnRefreshGeneral";
			this.btnRefreshGeneral.Size = new System.Drawing.Size(128, 24);
			this.btnRefreshGeneral.TabIndex = 3;
			this.btnRefreshGeneral.Text = "Refresh Section";
			this.btnRefreshGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRefreshGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRefreshGeneral.UseVisualStyleBackColor = true;
			this.btnRefreshGeneral.Click += new System.EventHandler(this.btnRefreshGeneral_Click);
			// 
			// btnCopyLengthBytes
			// 
			this.btnCopyLengthBytes.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyLengthBytes.Image")));
			this.btnCopyLengthBytes.Location = new System.Drawing.Point(246, 42);
			this.btnCopyLengthBytes.Margin = new System.Windows.Forms.Padding(0);
			this.btnCopyLengthBytes.Name = "btnCopyLengthBytes";
			this.btnCopyLengthBytes.Size = new System.Drawing.Size(24, 24);
			this.btnCopyLengthBytes.TabIndex = 7;
			this.btnCopyLengthBytes.UseVisualStyleBackColor = true;
			// 
			// btnRefreshLengthBytes
			// 
			this.btnRefreshLengthBytes.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshLengthBytes.Image")));
			this.btnRefreshLengthBytes.Location = new System.Drawing.Point(222, 42);
			this.btnRefreshLengthBytes.Margin = new System.Windows.Forms.Padding(0);
			this.btnRefreshLengthBytes.Name = "btnRefreshLengthBytes";
			this.btnRefreshLengthBytes.Size = new System.Drawing.Size(24, 24);
			this.btnRefreshLengthBytes.TabIndex = 6;
			this.btnRefreshLengthBytes.UseVisualStyleBackColor = true;
			this.btnRefreshLengthBytes.Click += new System.EventHandler(this.btnRefreshLengthBytes_Click);
			// 
			// txtLengthBytes
			// 
			this.txtLengthBytes.BackColor = System.Drawing.SystemColors.Window;
			this.txtLengthBytes.Location = new System.Drawing.Point(119, 45);
			this.txtLengthBytes.Name = "txtLengthBytes";
			this.txtLengthBytes.ReadOnly = true;
			this.txtLengthBytes.Size = new System.Drawing.Size(100, 20);
			this.txtLengthBytes.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "&Length (in bytes):";
			// 
			// btnCopyLength
			// 
			this.btnCopyLength.Image = ((System.Drawing.Image)(resources.GetObject("btnCopyLength.Image")));
			this.btnCopyLength.Location = new System.Drawing.Point(246, 16);
			this.btnCopyLength.Margin = new System.Windows.Forms.Padding(0);
			this.btnCopyLength.Name = "btnCopyLength";
			this.btnCopyLength.Size = new System.Drawing.Size(24, 24);
			this.btnCopyLength.TabIndex = 3;
			this.btnCopyLength.UseVisualStyleBackColor = true;
			// 
			// btnRefreshLength
			// 
			this.btnRefreshLength.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshLength.Image")));
			this.btnRefreshLength.Location = new System.Drawing.Point(222, 16);
			this.btnRefreshLength.Margin = new System.Windows.Forms.Padding(0);
			this.btnRefreshLength.Name = "btnRefreshLength";
			this.btnRefreshLength.Size = new System.Drawing.Size(24, 24);
			this.btnRefreshLength.TabIndex = 2;
			this.btnRefreshLength.UseVisualStyleBackColor = true;
			this.btnRefreshLength.Click += new System.EventHandler(this.btnRefreshLength_Click);
			// 
			// txtLength
			// 
			this.txtLength.BackColor = System.Drawing.SystemColors.Window;
			this.txtLength.Location = new System.Drawing.Point(119, 19);
			this.txtLength.Name = "txtLength";
			this.txtLength.ReadOnly = true;
			this.txtLength.Size = new System.Drawing.Size(100, 20);
			this.txtLength.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Length:";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(620, 458);
			this.Controls.Add(this.grpGeneral);
			this.Controls.Add(this.grpText);
			this.Name = "frmMain";
			this.Text = "String Utils";
			this.grpText.ResumeLayout(false);
			this.grpGeneral.ResumeLayout(false);
			this.grpGeneral.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox txtString;
		private System.Windows.Forms.GroupBox grpText;
		private System.Windows.Forms.Button btnRefreshAll;
		private System.Windows.Forms.Button btnLoadFile;
		private System.Windows.Forms.GroupBox grpGeneral;
		private System.Windows.Forms.TextBox txtLength;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRefreshLength;
		private System.Windows.Forms.Button btnCopyLength;
		private System.Windows.Forms.Button btnCopyLengthBytes;
		private System.Windows.Forms.Button btnRefreshLengthBytes;
		private System.Windows.Forms.TextBox txtLengthBytes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnRefreshGeneral;
	}
}

