using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace StringUtils
{
	public partial class frmMain : Form
	{
		private bool txtDirty = false;

		public frmMain()
		{
			InitializeComponent();
		}

		private void txtString_TextChanged(object sender, EventArgs e)
		{
			txtDirty = true;
			if (txtString.Text.Length < Properties.Settings.Default.AutoRefreshLengthLimit)
			{
				btnRefreshAll_Click(txtString, EventArgs.Empty);
			}
		}

		#region Multiple refresh button click handlers

		private void btnRefreshAll_Click(object sender, EventArgs e)
		{
			if (txtDirty)
			{
				btnRefreshGeneral_Click(sender, e);
				txtDirty = false;
			}
		}

		private void btnRefreshGeneral_Click(object sender, EventArgs e)
		{
			if (txtDirty)
			{
				btnRefreshLength_Click(sender, e);
				btnRefreshLengthBytes_Click(sender, e);
				btnRefreshWordCount_Click(sender, e);
			}
		}

		#endregion

		#region Individual refresh button click handlers

		#region General section refresh button click handlers

		private void btnRefreshLength_Click(object sender, EventArgs e)
		{
			if (txtDirty)
			{
				txtLength.Text = txtString.Text.Length.ToString();
			}
		}

		private void btnRefreshLengthBytes_Click(object sender, EventArgs e)
		{
			if (txtDirty)
			{
				txtLengthBytes.Text = Encoding.ASCII.GetByteCount(txtString.Text).ToString();
			}
		}

		private void btnRefreshWordCount_Click(object sender, EventArgs e)
		{
			if (txtDirty)
			{
				var filteredString = GetWords(txtString.Text);
				txtWordCount.Text = filteredString.Length.ToString();
			}
		}

		#endregion

		#endregion

		#region Utility methods

		private static string[] GetWords(string text)
		{
			if (text.Length == 0)
			{
				return new string[] { };
			}

			var pattern = new Regex("[^a-zA-Z0-9-]+");
			var filteredString = pattern.Replace(text, " ");
			return filteredString.Trim().Split(' ');
		}

		#endregion
	}
}