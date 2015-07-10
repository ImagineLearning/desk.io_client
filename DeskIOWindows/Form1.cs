using System.Net;
using System.Windows.Forms;
using DeskIOLib;

namespace DeskIOWindows
{
	public partial class DeskForm : Form
	{

		private Desk _desk;

		public DeskForm()
		{
			InitializeComponent();
		}

		private void UpButton_MouseDown(object sender, MouseEventArgs e)
		{
			_desk.Raise();
		}

		private void UpButton_MouseUp(object sender, MouseEventArgs e)
		{
			_desk.Stop();
		}

		private void DownArrow_MouseDown(object sender, MouseEventArgs e)
		{
			_desk.Lower();
		}

		private void DownArrow_MouseUp(object sender, MouseEventArgs e)
		{
			_desk.Stop();
		}

		private void ConnectButton_MouseClick(object sender, MouseEventArgs e)
		{
			IPAddress deskAddress;

			if (!IPAddress.TryParse(IPAddressTextBox.Text, out deskAddress))
			{
				MessageBox.Show("Invalid IP address entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_desk = new Desk(deskAddress);
			DownArrow.Enabled = true;
			UpButton.Enabled = true;
		}

		private void DeskForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if(_desk != null)
				_desk.Disconnect();
		}
	}
}
