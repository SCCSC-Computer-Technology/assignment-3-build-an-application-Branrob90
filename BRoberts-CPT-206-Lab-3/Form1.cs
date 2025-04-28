using BRoberts_CPT_206_Lab_3.Database1DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Brandon Roberts
 * CPT-206
 * Lab-3
 */

namespace BRoberts_CPT_206_Lab_3
{
    public partial class Form1 : Form
    {
        private StatesDataDataContext data;

        public Form1()
        {
            InitializeComponent();
            data = new StatesDataDataContext(); // initialize LINQ DataContext
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            // try/catch to make sure that the combo box is populated
            try
            {
                // Use LINQ to load state names
                var stateNames = from state in data.StatesInfos
                                 select state.State;
                // clear the combobox in case the method is called again
                stateComboBox.Items.Clear();

                // Add state names to the ComboBox
                foreach (var name in stateNames)
                {
                    stateComboBox.Items.Add(name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            if (stateComboBox.SelectedItem == null)
            {
                // if no selection is made display a message letting the user know to select a state
                MessageBox.Show("Please select a state before viewing details.", "Error");
                return;
            }

            // set variable equal to the users selection from the combo box
            string selectedState = stateComboBox.SelectedItem.ToString().Trim();

            // Open the StateDetails form and pass the selected state
            StateDetails stateDetails = new StateDetails(selectedState);
            stateDetails.ShowDialog();

        }

        private void statesInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statesInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.StatesInfo' table. You can move, or remove it, as needed.
            this.statesInfoTableAdapter.Fill(this.database1DataSet.StatesInfo);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close the program
            this.Close();
        }
    }
}
