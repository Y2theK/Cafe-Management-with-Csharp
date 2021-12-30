namespace MainForm
{
    partial class cafeOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEmHeader = new System.Windows.Forms.Panel();
            this.btnDBrefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddNewMenu = new System.Windows.Forms.Button();
            this.tbMenuSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userReqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cafeSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coeCafeDataSet6 = new MainForm.CoeCafeDataSet6();
            this.cafeSaleTableAdapter = new MainForm.CoeCafeDataSet6TableAdapters.cafeSaleTableAdapter();
            this.panelEmHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeCafeDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmHeader
            // 
            this.panelEmHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.panelEmHeader.TabIndex = 6;
            this.panelEmHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEmHeader_Paint);
            // 
            // btnDBrefresh
            // 
            this.btnDBrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDBrefresh.BackgroundImage = global::MainForm.Properties.Resources.seo_and_web;
            this.btnDBrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDBrefresh.FlatAppearance.BorderSize = 0;
            this.btnDBrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBrefresh.Location = new System.Drawing.Point(496, 11);
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
            this.button1.Location = new System.Drawing.Point(729, 5);
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
            this.btnAddNewMenu.Location = new System.Drawing.Point(576, 7);
            this.btnAddNewMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewMenu.Name = "btnAddNewMenu";
            this.btnAddNewMenu.Size = new System.Drawing.Size(145, 44);
            this.btnAddNewMenu.TabIndex = 2;
            this.btnAddNewMenu.Text = "Add New Menu";
            this.btnAddNewMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewMenu.UseVisualStyleBackColor = true;
            // 
            // tbMenuSearch
            // 
            this.tbMenuSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbMenuSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMenuSearch.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMenuSearch.Location = new System.Drawing.Point(100, 11);
            this.tbMenuSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbMenuSearch.Multiline = true;
            this.tbMenuSearch.Name = "tbMenuSearch";
            this.tbMenuSearch.Size = new System.Drawing.Size(153, 25);
            this.tbMenuSearch.TabIndex = 1;
            this.tbMenuSearch.TextChanged += new System.EventHandler(this.tbMenuSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(53, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainForm.Properties.Resources.blue_search;
            this.pictureBox1.Location = new System.Drawing.Point(53, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel2.Size = new System.Drawing.Size(838, 404);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TId,
            this.tNameDataGridViewTextBoxColumn,
            this.foodNameDataGridViewTextBoxColumn,
            this.foodCountDataGridViewTextBoxColumn,
            this.foodSizeDataGridViewTextBoxColumn,
            this.userReqDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cafeSaleBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(818, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TId
            // 
            this.TId.DataPropertyName = "TId";
            this.TId.HeaderText = "Table ID";
            this.TId.Name = "TId";
            // 
            // tNameDataGridViewTextBoxColumn
            // 
            this.tNameDataGridViewTextBoxColumn.DataPropertyName = "TName";
            this.tNameDataGridViewTextBoxColumn.HeaderText = "Table";
            this.tNameDataGridViewTextBoxColumn.Name = "tNameDataGridViewTextBoxColumn";
            // 
            // foodNameDataGridViewTextBoxColumn
            // 
            this.foodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName";
            this.foodNameDataGridViewTextBoxColumn.HeaderText = "Menu";
            this.foodNameDataGridViewTextBoxColumn.Name = "foodNameDataGridViewTextBoxColumn";
            // 
            // foodCountDataGridViewTextBoxColumn
            // 
            this.foodCountDataGridViewTextBoxColumn.DataPropertyName = "FoodCount";
            this.foodCountDataGridViewTextBoxColumn.HeaderText = "Count";
            this.foodCountDataGridViewTextBoxColumn.Name = "foodCountDataGridViewTextBoxColumn";
            // 
            // foodSizeDataGridViewTextBoxColumn
            // 
            this.foodSizeDataGridViewTextBoxColumn.DataPropertyName = "FoodSize";
            this.foodSizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.foodSizeDataGridViewTextBoxColumn.Name = "foodSizeDataGridViewTextBoxColumn";
            // 
            // userReqDataGridViewTextBoxColumn
            // 
            this.userReqDataGridViewTextBoxColumn.DataPropertyName = "UserReq";
            this.userReqDataGridViewTextBoxColumn.HeaderText = "UserReq";
            this.userReqDataGridViewTextBoxColumn.Name = "userReqDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // cafeSaleBindingSource
            // 
            this.cafeSaleBindingSource.DataMember = "cafeSale";
            this.cafeSaleBindingSource.DataSource = this.coeCafeDataSet6;
            // 
            // coeCafeDataSet6
            // 
            this.coeCafeDataSet6.DataSetName = "CoeCafeDataSet6";
            this.coeCafeDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cafeSaleTableAdapter
            // 
            this.cafeSaleTableAdapter.ClearBeforeFill = true;
            // 
            // cafeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 463);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelEmHeader);
            this.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cafeOrder";
            this.Text = "cafeOrder";
            this.Load += new System.EventHandler(this.cafeOrder_Load);
            this.panelEmHeader.ResumeLayout(false);
            this.panelEmHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeCafeDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmHeader;
        public System.Windows.Forms.Button btnDBrefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddNewMenu;
        private System.Windows.Forms.TextBox tbMenuSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CoeCafeDataSet6 coeCafeDataSet6;
        private System.Windows.Forms.BindingSource cafeSaleBindingSource;
        private CoeCafeDataSet6TableAdapters.cafeSaleTableAdapter cafeSaleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userReqDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}