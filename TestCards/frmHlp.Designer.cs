namespace TestCards
	{
	partial class frmHlp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHlp));
			this.pnlHlp = new System.Windows.Forms.Panel();
			this.rtbHlp = new System.Windows.Forms.RichTextBox();
			this.btnCanx = new System.Windows.Forms.Button();
			this.pnlHlp.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlHlp
			// 
			this.pnlHlp.Controls.Add(this.rtbHlp);
			this.pnlHlp.Location = new System.Drawing.Point(-3, 0);
			this.pnlHlp.Margin = new System.Windows.Forms.Padding(4);
			this.pnlHlp.Name = "pnlHlp";
			this.pnlHlp.Padding = new System.Windows.Forms.Padding(4);
			this.pnlHlp.Size = new System.Drawing.Size(444, 306);
			this.pnlHlp.TabIndex = 0;
			// 
			// rtbHlp
			// 
			this.rtbHlp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.rtbHlp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbHlp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbHlp.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbHlp.ForeColor = System.Drawing.Color.Navy;
			this.rtbHlp.Location = new System.Drawing.Point(4, 4);
			this.rtbHlp.Name = "rtbHlp";
			this.rtbHlp.Size = new System.Drawing.Size(436, 298);
			this.rtbHlp.TabIndex = 0;
			this.rtbHlp.Text = resources.GetString("rtbHlp.Text");
			this.rtbHlp.TextChanged += new System.EventHandler(this.rtbHlp_TextChanged);
			// 
			// btnCanx
			// 
			this.btnCanx.BackColor = System.Drawing.Color.Navy;
			this.btnCanx.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCanx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCanx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnCanx.Location = new System.Drawing.Point(360, 313);
			this.btnCanx.Name = "btnCanx";
			this.btnCanx.Size = new System.Drawing.Size(70, 35);
			this.btnCanx.TabIndex = 1;
			this.btnCanx.Text = "Cancel";
			this.btnCanx.UseVisualStyleBackColor = false;
			this.btnCanx.Click += new System.EventHandler(this.btnCanx_Click);
			// 
			// frmHlp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(442, 356);
			this.ControlBox = false;
			this.Controls.Add(this.btnCanx);
			this.Controls.Add(this.pnlHlp);
			this.ForeColor = System.Drawing.Color.Navy;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmHlp";
			this.Text = "Running the Test Cases";
			this.pnlHlp.ResumeLayout(false);
			this.ResumeLayout(false);

			}

		#endregion

		private System.Windows.Forms.Panel pnlHlp;
		private System.Windows.Forms.RichTextBox rtbHlp;
		private System.Windows.Forms.Button btnCanx;
		}
	}