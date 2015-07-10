namespace DeskIOWindows
{
	partial class DeskForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeskForm));
			this.UpButton = new System.Windows.Forms.Button();
			this.DownArrow = new System.Windows.Forms.Button();
			this.IPAddressTextBox = new System.Windows.Forms.TextBox();
			this.IPAddressLabel = new System.Windows.Forms.Label();
			this.ConnectButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UpButton
			// 
			this.UpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpButton.BackgroundImage")));
			this.UpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.UpButton.Enabled = false;
			this.UpButton.Location = new System.Drawing.Point(12, 52);
			this.UpButton.Name = "UpButton";
			this.UpButton.Size = new System.Drawing.Size(150, 150);
			this.UpButton.TabIndex = 0;
			this.UpButton.UseVisualStyleBackColor = true;
			this.UpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpButton_MouseDown);
			this.UpButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpButton_MouseUp);
			// 
			// DownArrow
			// 
			this.DownArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DownArrow.BackgroundImage")));
			this.DownArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.DownArrow.Enabled = false;
			this.DownArrow.Location = new System.Drawing.Point(12, 208);
			this.DownArrow.Name = "DownArrow";
			this.DownArrow.Size = new System.Drawing.Size(150, 150);
			this.DownArrow.TabIndex = 1;
			this.DownArrow.UseVisualStyleBackColor = true;
			this.DownArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DownArrow_MouseDown);
			this.DownArrow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DownArrow_MouseUp);
			// 
			// IPAddressTextBox
			// 
			this.IPAddressTextBox.Location = new System.Drawing.Point(12, 26);
			this.IPAddressTextBox.Name = "IPAddressTextBox";
			this.IPAddressTextBox.Size = new System.Drawing.Size(88, 20);
			this.IPAddressTextBox.TabIndex = 2;
			// 
			// IPAddressLabel
			// 
			this.IPAddressLabel.AutoSize = true;
			this.IPAddressLabel.Location = new System.Drawing.Point(9, 9);
			this.IPAddressLabel.Name = "IPAddressLabel";
			this.IPAddressLabel.Size = new System.Drawing.Size(48, 13);
			this.IPAddressLabel.TabIndex = 3;
			this.IPAddressLabel.Text = "Desk IP:";
			// 
			// ConnectButton
			// 
			this.ConnectButton.Location = new System.Drawing.Point(106, 24);
			this.ConnectButton.Name = "ConnectButton";
			this.ConnectButton.Size = new System.Drawing.Size(56, 23);
			this.ConnectButton.TabIndex = 4;
			this.ConnectButton.Text = "Connect";
			this.ConnectButton.UseVisualStyleBackColor = true;
			this.ConnectButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConnectButton_MouseClick);
			// 
			// DeskForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(175, 366);
			this.Controls.Add(this.ConnectButton);
			this.Controls.Add(this.IPAddressLabel);
			this.Controls.Add(this.IPAddressTextBox);
			this.Controls.Add(this.DownArrow);
			this.Controls.Add(this.UpButton);
			this.Name = "DeskForm";
			this.Text = "Desk";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeskForm_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button UpButton;
		private System.Windows.Forms.Button DownArrow;
		private System.Windows.Forms.TextBox IPAddressTextBox;
		private System.Windows.Forms.Label IPAddressLabel;
		private System.Windows.Forms.Button ConnectButton;
	}
}

