using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BRoberts_CPT_206_Lab_3
{
    public partial class StateDetails : Form
    {

        public StateDetails(string selectedState)
        {
            InitializeComponent();
            // Filter the BindingSource to show only the selected state
            statesInfoBindingSource.Filter = $"State = '{selectedState}'";

        }


        private void statesInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void StateDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.StatesInfo' table. You can move, or remove it, as needed.
            this.statesInfoTableAdapter.Fill(this.database1DataSet.StatesInfo);

        }

        private void btnExitDetails_Click(object sender, EventArgs e)
        {
            // close the form
            this.Close();
        }
    }
}
