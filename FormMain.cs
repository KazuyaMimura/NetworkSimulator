using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkSimulator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void MainServer_Click(object sender, EventArgs e)
        {
            FormServer formServer = new FormServer();
            formServer.Show();
        }

        private void MainClient_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient();
            formClient.Show();
        }

        private void MainSetting_Click(object sender, EventArgs e)
        {

        }
    }
    static class Constants
    {
        public const int RESULT_SUCCESS = 0;
        public const int RESULT_NOT_SUCCESS = 1;
    }
}
