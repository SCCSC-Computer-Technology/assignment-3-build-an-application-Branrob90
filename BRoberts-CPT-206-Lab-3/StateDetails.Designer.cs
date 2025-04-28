namespace BRoberts_CPT_206_Lab_3
{
    partial class StateDetails
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateDetails));
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label populationLabel;
            System.Windows.Forms.Label state_Flag_DescriptionLabel;
            System.Windows.Forms.Label state_FlowerLabel;
            System.Windows.Forms.Label state_BirdLabel;
            System.Windows.Forms.Label colorsLabel;
            System.Windows.Forms.Label largest_CityLabel;
            System.Windows.Forms.Label second_Largest_CityLabel;
            System.Windows.Forms.Label third_Largest_CityLabel;
            System.Windows.Forms.Label state_CapitolLabel;
            System.Windows.Forms.Label median_IncomeLabel;
            System.Windows.Forms.Label percent_of_Computer_JobsLabel;
            this.statesInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.statesInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new BRoberts_CPT_206_Lab_3.Database1DataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statesInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnExitDetails = new System.Windows.Forms.Button();
            this.statesInfoTableAdapter = new BRoberts_CPT_206_Lab_3.Database1DataSetTableAdapters.StatesInfoTableAdapter();
            this.tableAdapterManager = new BRoberts_CPT_206_Lab_3.Database1DataSetTableAdapters.TableAdapterManager();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.state_Flag_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.state_FlowerTextBox = new System.Windows.Forms.TextBox();
            this.state_BirdTextBox = new System.Windows.Forms.TextBox();
            this.colorsTextBox = new System.Windows.Forms.TextBox();
            this.largest_CityTextBox = new System.Windows.Forms.TextBox();
            this.second_Largest_CityTextBox = new System.Windows.Forms.TextBox();
            this.third_Largest_CityTextBox = new System.Windows.Forms.TextBox();
            this.state_CapitolTextBox = new System.Windows.Forms.TextBox();
            this.median_IncomeTextBox = new System.Windows.Forms.TextBox();
            this.percent_of_Computer_JobsTextBox = new System.Windows.Forms.TextBox();
            stateLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            state_Flag_DescriptionLabel = new System.Windows.Forms.Label();
            state_FlowerLabel = new System.Windows.Forms.Label();
            state_BirdLabel = new System.Windows.Forms.Label();
            colorsLabel = new System.Windows.Forms.Label();
            largest_CityLabel = new System.Windows.Forms.Label();
            second_Largest_CityLabel = new System.Windows.Forms.Label();
            third_Largest_CityLabel = new System.Windows.Forms.Label();
            state_CapitolLabel = new System.Windows.Forms.Label();
            median_IncomeLabel = new System.Windows.Forms.Label();
            percent_of_Computer_JobsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statesInfoBindingNavigator)).BeginInit();
            this.statesInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // statesInfoBindingNavigator
            // 
            this.statesInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.statesInfoBindingNavigator.BindingSource = this.statesInfoBindingSource;
            this.statesInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statesInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.statesInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.statesInfoBindingNavigatorSaveItem});
            this.statesInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.statesInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.statesInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.statesInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.statesInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.statesInfoBindingNavigator.Name = "statesInfoBindingNavigator";
            this.statesInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.statesInfoBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.statesInfoBindingNavigator.TabIndex = 0;
            this.statesInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // statesInfoBindingSource
            // 
            this.statesInfoBindingSource.DataMember = "StatesInfo";
            this.statesInfoBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statesInfoBindingNavigatorSaveItem
            // 
            this.statesInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statesInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statesInfoBindingNavigatorSaveItem.Image")));
            this.statesInfoBindingNavigatorSaveItem.Name = "statesInfoBindingNavigatorSaveItem";
            this.statesInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.statesInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.statesInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.statesInfoBindingNavigatorSaveItem_Click);
            // 
            // btnExitDetails
            // 
            this.btnExitDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitDetails.Location = new System.Drawing.Point(330, 328);
            this.btnExitDetails.Name = "btnExitDetails";
            this.btnExitDetails.Size = new System.Drawing.Size(89, 53);
            this.btnExitDetails.TabIndex = 25;
            this.btnExitDetails.Text = "E&xit";
            this.btnExitDetails.UseVisualStyleBackColor = true;
            this.btnExitDetails.Click += new System.EventHandler(this.btnExitDetails_Click);
            // 
            // statesInfoTableAdapter
            // 
            this.statesInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StatesInfoTableAdapter = this.statesInfoTableAdapter;
            this.tableAdapterManager.UpdateOrder = BRoberts_CPT_206_Lab_3.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(23, 34);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(35, 13);
            stateLabel.TabIndex = 25;
            stateLabel.Text = "State:";
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesInfoBindingSource, "State", true));
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(161, 31);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 21);
            this.stateComboBox.TabIndex = 26;
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Location = new System.Drawing.Point(23, 61);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(60, 13);
            populationLabel.TabIndex = 27;
            populationLabel.Text = "Population:";
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesInfoBindingSource, "Population", true));
            this.populationTextBox.Location = new System.Drawing.Point(161, 58);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(121, 20);
            this.populationTextBox.TabIndex = 28;
            // 
            // state_Flag_DescriptionLabel
            // 
            state_Flag_DescriptionLabel.AutoSize = true;
            state_Flag_DescriptionLabel.Location = new System.Drawing.Point(23, 87);
            state_Flag_DescriptionLabel.Name = "state_Flag_DescriptionLabel";
            state_Flag_DescriptionLabel.Size = new System.Drawing.Size(114, 13);
            state_Flag_DescriptionLabel.TabIndex = 29;
            state_Flag_DescriptionLabel.Text = "State Flag Description:";
            // 
            // state_Flag_DescriptionTextBox
            // 
            this.state_Flag_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesInfoBindingSource, "State Flag Description", true));
            this.state_Flag_DescriptionTextBox.Location = new System.Drawing.Point(161, 84);
            this.state_Flag_DescriptionTextBox.Name = "state_Flag_DescriptionTextBox";
            this.state_Flag_DescriptionTextBox.Size = new System.Drawing.Size(121, 20);
            this.state_Flag_DescriptionTextBox.TabIndex = 30;
            // 
            // state_FlowerLabel
            // 
            state_FlowerLabel.AutoSize = true;
            state_FlowerLabel.Location = new System.Drawing.Point(23, 113);
            state_FlowerLabel.Name = "state_FlowerLabel";
            state_FlowerLabel.Size = new System.Drawing.Size(69, 13);
            state_FlowerLabel.TabIndex = 31;
            state_FlowerLabel.Text = "State Flower:";
            // 
            // state_FlowerTextBox
            // 
            this.state_FlowerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesInfoBindingSource, "State Flower", true));
            this.state_FlowerTextBox.Location = new System.Drawing.Point(161, 110);
            this.state_FlowerTextBox.Name = "state_FlowerTextBox";
            this.state_FlowerTextBox.Size = new System.Drawing.Size(121, 20);
            this.state_FlowerTextBox.TabIndex = 32;
            // 
            // state_BirdLabel
            // 
            state_BirdLabel.AutoSize = true;
            state_BirdLabel.Location = new System.Drawing.Point(23, 139);
            state_BirdLabel.Name = "state_BirdLabel";
            state_BirdLabel.Size = new System.Drawing.Size(56, 13);
            state_BirdLabel.TabIndex = 33;
            state_BirdLabel.Text = "State Bird:";
            // 
            // state_BirdTextBox
            // 
            this.state_BirdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesInfoBindingSource, "State Bird", true));
            this.state_BirdTextBox.Location = new System.Drawing.Point(161, 136);
            this.state_BirdTextBox.Name = "state_BirdTextBox";
            this.state_BirdTextBox.Size = new System.Drawing.Size(121, 20);
            this.state_BirdTextBox.TabIndex = 34;
            // 
            // colorsLabel
            // 
            colorsLabel.AutoSize = true;
            colorsLabel.Location = new System.Drawing.Point(23, 165);
            colorsLabel.Name = "colorsLabel";
            colorsLabel.Size = new System.Drawing.Size(39, 13);
            colorsLabel.TabIndex = 35;
            colorsLabel.Text = "Colors:";
            // 
            // colorsTextBox
            // 
            this.colorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesInfoBindingSource, "Colors", true));
            this.colorsTextBox.Location = new System.Drawing.Point(161, 162);
            this.colorsTextBox.Name = "colorsTextBox";
            this.colorsTextBox.Size = new System.Drawing.Size(121, 20);
            this.colorsTextBox.TabIndex = 36;
            // 
            // largest_CityLabel
            // 
            largest_CityLabel.AutoSize = true;
            largest_CityLabel.Location = new System.Drawing.Point(23, 191);
            largest_CityLabel.Name = "largest_CityLabel";
            largest_CityLabel.Size = new System.Drawing.Size(65, 13);
            largest_CityLabel.TabIndex = 37;
            largest_CityLabel.Text = "Largest City:";
            // 
            // largest_CityTextBox
            // 
            this.largest_CityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesInfoBindingSource, "Largest City", true));
            this.largest_CityTextBox.Location = new System.Drawing.Point(161, 188);
            this.largest_CityTextBox.Name = "largest_CityTextBox";
            this.largest_CityTextBox.Size = new System.Drawing.Size(121, 20);
            this.largest_CityTextBox.TabIndex = 38;
            // 
            // second_Largest_CityLabel
            // 
            second_Largest_CityLabel.AutoSize = true;
            second_Largest_CityLabel.Location = new System.Drawing.Point(23, 217);
            second_Largest_CityLabel.Name = "second_Largest_CityLabel";
            second_Largest_CityLabel.Size = new System.Drawing.Size(105, 13);
            second_Largest_CityLabel.TabIndex = 39;
            second_Largest_CityLabel.Text = "Second Largest City:";
            // 
            // second_Largest_CityTextBox
            // 
            this.second_Largest_CityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesInfoBindingSource, "Second Largest City", true));
            this.second_Largest_CityTextBox.Location = new System.Drawing.Point(161, 214);
            this.second_Largest_CityTextBox.Name = "second_Largest_CityTextBox";
            this.second_Largest_CityTextBox.Size = new System.Drawing.Size(121, 20);
            this.second_Largest_CityTextBox.TabIndex = 40;
            // 
            // third_Largest_CityLabel
            // 
            third_Largest_CityLabel.AutoSize = true;
            third_Largest_CityLabel.Location = new System.Drawing.Point(23, 243);
            third_Largest_CityLabel.Name = "third_Largest_CityLabel";
            third_Largest_CityLabel.Size = new System.Drawing.Size(92, 13);
            third_Largest_CityLabel.TabIndex = 41;
            third_Largest_CityLabel.Text = "Third Largest City:";
            // 
            // third_Largest_CityTextBox
            // 
            this.third_Largest_CityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesInfoBindingSource, "Third Largest City", true));
            this.third_Largest_CityTextBox.Location = new System.Drawing.Point(161, 240);
            this.third_Largest_CityTextBox.Name = "third_Largest_CityTextBox";
            this.third_Largest_CityTextBox.Size = new System.Drawing.Size(121, 20);
            this.third_Largest_CityTextBox.TabIndex = 42;
            // 
            // state_CapitolLabel
            // 
            state_CapitolLabel.AutoSize = true;
            state_CapitolLabel.Location = new System.Drawing.Point(23, 269);
            state_CapitolLabel.Name = "state_CapitolLabel";
            state_CapitolLabel.Size = new System.Drawing.Size(70, 13);
            state_CapitolLabel.TabIndex = 43;
            state_CapitolLabel.Text = "State Capitol:";
            // 
            // state_CapitolTextBox
            // 
            this.state_CapitolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesInfoBindingSource, "State Capitol", true));
            this.state_CapitolTextBox.Location = new System.Drawing.Point(161, 266);
            this.state_CapitolTextBox.Name = "state_CapitolTextBox";
            this.state_CapitolTextBox.Size = new System.Drawing.Size(121, 20);
            this.state_CapitolTextBox.TabIndex = 44;
            // 
            // median_IncomeLabel
            // 
            median_IncomeLabel.AutoSize = true;
            median_IncomeLabel.Location = new System.Drawing.Point(23, 295);
            median_IncomeLabel.Name = "median_IncomeLabel";
            median_IncomeLabel.Size = new System.Drawing.Size(83, 13);
            median_IncomeLabel.TabIndex = 45;
            median_IncomeLabel.Text = "Median Income:";
            // 
            // median_IncomeTextBox
            // 
            this.median_IncomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesInfoBindingSource, "Median Income", true));
            this.median_IncomeTextBox.Location = new System.Drawing.Point(161, 292);
            this.median_IncomeTextBox.Name = "median_IncomeTextBox";
            this.median_IncomeTextBox.Size = new System.Drawing.Size(121, 20);
            this.median_IncomeTextBox.TabIndex = 46;
            // 
            // percent_of_Computer_JobsLabel
            // 
            percent_of_Computer_JobsLabel.AutoSize = true;
            percent_of_Computer_JobsLabel.Location = new System.Drawing.Point(23, 321);
            percent_of_Computer_JobsLabel.Name = "percent_of_Computer_JobsLabel";
            percent_of_Computer_JobsLabel.Size = new System.Drawing.Size(132, 13);
            percent_of_Computer_JobsLabel.TabIndex = 47;
            percent_of_Computer_JobsLabel.Text = "Percent of Computer Jobs:";
            // 
            // percent_of_Computer_JobsTextBox
            // 
            this.percent_of_Computer_JobsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesInfoBindingSource, "Percent of Computer Jobs", true));
            this.percent_of_Computer_JobsTextBox.Location = new System.Drawing.Point(161, 318);
            this.percent_of_Computer_JobsTextBox.Name = "percent_of_Computer_JobsTextBox";
            this.percent_of_Computer_JobsTextBox.Size = new System.Drawing.Size(121, 20);
            this.percent_of_Computer_JobsTextBox.TabIndex = 48;
            // 
            // StateDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(populationLabel);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(state_Flag_DescriptionLabel);
            this.Controls.Add(this.state_Flag_DescriptionTextBox);
            this.Controls.Add(state_FlowerLabel);
            this.Controls.Add(this.state_FlowerTextBox);
            this.Controls.Add(state_BirdLabel);
            this.Controls.Add(this.state_BirdTextBox);
            this.Controls.Add(colorsLabel);
            this.Controls.Add(this.colorsTextBox);
            this.Controls.Add(largest_CityLabel);
            this.Controls.Add(this.largest_CityTextBox);
            this.Controls.Add(second_Largest_CityLabel);
            this.Controls.Add(this.second_Largest_CityTextBox);
            this.Controls.Add(third_Largest_CityLabel);
            this.Controls.Add(this.third_Largest_CityTextBox);
            this.Controls.Add(state_CapitolLabel);
            this.Controls.Add(this.state_CapitolTextBox);
            this.Controls.Add(median_IncomeLabel);
            this.Controls.Add(this.median_IncomeTextBox);
            this.Controls.Add(percent_of_Computer_JobsLabel);
            this.Controls.Add(this.percent_of_Computer_JobsTextBox);
            this.Controls.Add(this.btnExitDetails);
            this.Controls.Add(this.statesInfoBindingNavigator);
            this.Name = "StateDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StateDetails";
            this.Load += new System.EventHandler(this.StateDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statesInfoBindingNavigator)).EndInit();
            this.statesInfoBindingNavigator.ResumeLayout(false);
            this.statesInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statesInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource statesInfoBindingSource;
        private Database1DataSetTableAdapters.StatesInfoTableAdapter statesInfoTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator statesInfoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton statesInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnExitDetails;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox state_Flag_DescriptionTextBox;
        private System.Windows.Forms.TextBox state_FlowerTextBox;
        private System.Windows.Forms.TextBox state_BirdTextBox;
        private System.Windows.Forms.TextBox colorsTextBox;
        private System.Windows.Forms.TextBox largest_CityTextBox;
        private System.Windows.Forms.TextBox second_Largest_CityTextBox;
        private System.Windows.Forms.TextBox third_Largest_CityTextBox;
        private System.Windows.Forms.TextBox state_CapitolTextBox;
        private System.Windows.Forms.TextBox median_IncomeTextBox;
        private System.Windows.Forms.TextBox percent_of_Computer_JobsTextBox;
    }
}