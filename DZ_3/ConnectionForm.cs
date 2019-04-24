using System;
using System.Windows.Forms;

namespace DZ_3
{
    public partial class ConnectionForm : Form
    {
        public DataAccessLayer _dataAccessLayer;

        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            _dataAccessLayer = new DataAccessLayer();

            string result = _dataAccessLayer.SetConnection(loginTextBox.Text,passwordTextBox.Text);

            resultLabel.Text = result;
        }
    }
}
