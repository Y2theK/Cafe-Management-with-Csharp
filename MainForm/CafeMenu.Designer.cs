namespace MainForm
{
    partial class CafeMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cafeMenuItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coeCafeDataSet4 = new MainForm.CoeCafeDataSet4();
            this.cafeMenuItemTableAdapter = new MainForm.CoeCafeDataSet4TableAdapters.cafeMenuItemTableAdapter();
            this.panelEmHeader = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMenus = new System.Windows.Forms.Label();
            this.btnDBrefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddNewMenu = new System.Windows.Forms.Button();
            this.tbMenuSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.pBFoodPic = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodPicDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cafeMenuItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeCafeDataSet4)).BeginInit();
            this.panelEmHeader.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBFoodPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cafeMenuItemBindingSource
            // 
            this.cafeMenuItemBindingSource.DataMember = "cafeMenuItem";
            this.cafeMenuItemBindingSource.DataSource = this.coeCafeDataSet4;
            // 
            // coeCafeDataSet4
            // 
            this.coeCafeDataSet4.DataSetName = "CoeCafeDataSet4";
            this.coeCafeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cafeMenuItemTableAdapter
            // 
            this.cafeMenuItemTableAdapter.ClearBeforeFill = true;
            // 
            // panelEmHeader
            // 
            this.panelEmHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelEmHeader.Controls.Add(this.panel4);
            this.panelEmHeader.Controls.Add(this.btnDBrefresh);
            this.panelEmHeader.Controls.Add(this.button1);
            this.panelEmHeader.Controls.Add(this.btnAddNewMenu);
            this.panelEmHeader.Controls.Add(this.tbMenuSearch);
            this.panelEmHeader.Controls.Add(this.panel1);
            this.panelEmHeader.Controls.Add(this.pictureBox1);
            this.panelEmHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmHeader.Location = new System.Drawing.Point(0, 0);
            this.panelEmHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelEmHeader.Name = "panelEmHeader";
            this.panelEmHeader.Size = new System.Drawing.Size(838, 59);
            this.panelEmHeader.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.lbMenus);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(709, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 51);
            this.panel4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(10, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Menus";
            // 
            // lbMenus
            // 
            this.lbMenus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMenus.AutoSize = true;
            this.lbMenus.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenus.ForeColor = System.Drawing.Color.Blue;
            this.lbMenus.Location = new System.Drawing.Point(37, 4);
            this.lbMenus.Name = "lbMenus";
            this.lbMenus.Size = new System.Drawing.Size(22, 23);
            this.lbMenus.TabIndex = 2;
            this.lbMenus.Text = "0";
            // 
            // btnDBrefresh
            // 
            this.btnDBrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDBrefresh.BackgroundImage = global::MainForm.Properties.Resources.seo_and_web;
            this.btnDBrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDBrefresh.FlatAppearance.BorderSize = 0;
            this.btnDBrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBrefresh.Location = new System.Drawing.Point(632, 11);
            this.btnDBrefresh.Name = "btnDBrefresh";
            this.btnDBrefresh.Size = new System.Drawing.Size(40, 40);
            this.btnDBrefresh.TabIndex = 2;
            this.btnDBrefresh.UseVisualStyleBackColor = true;
            this.btnDBrefresh.Click += new System.EventHandler(this.btnDBrefresh_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::MainForm.Properties.Resources.plus;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(503, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Upload ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAddNewMenu
            // 
            this.btnAddNewMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewMenu.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMenu.Image = global::MainForm.Properties.Resources.plus;
            this.btnAddNewMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewMenu.Location = new System.Drawing.Point(350, 7);
            this.btnAddNewMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewMenu.Name = "btnAddNewMenu";
            this.btnAddNewMenu.Size = new System.Drawing.Size(145, 44);
            this.btnAddNewMenu.TabIndex = 2;
            this.btnAddNewMenu.Text = "Add New Menu";
            this.btnAddNewMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewMenu.UseVisualStyleBackColor = true;
            this.btnAddNewMenu.Click += new System.EventHandler(this.btnAddNewEmployee_Click_1);
            // 
            // tbMenuSearch
            // 
            this.tbMenuSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbMenuSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMenuSearch.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMenuSearch.Location = new System.Drawing.Point(84, 16);
            this.tbMenuSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbMenuSearch.Multiline = true;
            this.tbMenuSearch.Name = "tbMenuSearch";
            this.tbMenuSearch.Size = new System.Drawing.Size(153, 25);
            this.tbMenuSearch.TabIndex = 1;
            this.tbMenuSearch.TextChanged += new System.EventHandler(this.tbMenuSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(44, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainForm.Properties.Resources.blue_search;
            this.pictureBox1.Location = new System.Drawing.Point(43, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.tbPrice);
            this.panel3.Controls.Add(this.pBFoodPic);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.tbFname);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(608, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 404);
            this.panel3.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(24, 310);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(186, 2);
            this.panel5.TabIndex = 164;
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.White;
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(57, 288);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(110, 16);
            this.tbPrice.TabIndex = 155;
            this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pBFoodPic
            // 
            this.pBFoodPic.Image = global::MainForm.Properties.Resources.menu;
            this.pBFoodPic.Location = new System.Drawing.Point(24, 42);
            this.pBFoodPic.Name = "pBFoodPic";
            this.pBFoodPic.Size = new System.Drawing.Size(177, 177);
            this.pBFoodPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBFoodPic.TabIndex = 161;
            this.pBFoodPic.TabStop = false;
            this.pBFoodPic.Click += new System.EventHandler(this.pBFoodPic_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(24, 259);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(186, 2);
            this.panel7.TabIndex = 159;
            // 
            // tbFname
            // 
            this.tbFname.BackColor = System.Drawing.Color.White;
            this.tbFname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbFname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFname.Location = new System.Drawing.Point(24, 237);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(186, 16);
            this.tbFname.TabIndex = 154;
            this.tbFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.foodPicDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cafeMenuItemBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(0, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 70;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(608, 404);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foodPicDataGridViewImageColumn
            // 
            this.foodPicDataGridViewImageColumn.DataPropertyName = "FoodPic";
            this.foodPicDataGridViewImageColumn.HeaderText = "FoodPic";
            this.foodPicDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.foodPicDataGridViewImageColumn.Name = "foodPicDataGridViewImageColumn";
            this.foodPicDataGridViewImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // CafeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelEmHeader);
            this.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CafeMenu";
            this.Text = "CafeMenu";
            this.Load += new System.EventHandler(this.CafeMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cafeMenuItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeCafeDataSet4)).EndInit();
            this.panelEmHeader.ResumeLayout(false);
            this.panelEmHeader.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBFoodPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CoeCafeDataSet4 coeCafeDataSet4;
        private System.Windows.Forms.BindingSource cafeMenuItemBindingSource;
        private CoeCafeDataSet4TableAdapters.cafeMenuItemTableAdapter cafeMenuItemTableAdapter;
        private System.Windows.Forms.Panel panelEmHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddNewMenu;
        private System.Windows.Forms.TextBox tbMenuSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnDBrefresh;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.TextBox tbPrice;
        public System.Windows.Forms.PictureBox pBFoodPic;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.TextBox tbFname;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMenus;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn foodPicDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
    }
}