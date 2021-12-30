namespace MainForm
{
    partial class cafeSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEmHeader = new System.Windows.Forms.Panel();
            this.lbDailyTotal = new System.Windows.Forms.Label();
            this.cbTableLists = new System.Windows.Forms.ComboBox();
            this.cafeSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coeCafeDataSet5 = new MainForm.CoeCafeDataSet5();
            this.cafeSaleTableAdapter = new MainForm.CoeCafeDataSet5TableAdapters.cafeSaleTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userReqDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMakeReceipt = new System.Windows.Forms.Button();
            this.btnDBrefresh = new System.Windows.Forms.Button();
            this.panelEmHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeCafeDataSet5)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmHeader
            // 
            this.panelEmHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelEmHeader.Controls.Add(this.lbDailyTotal);
            this.panelEmHeader.Controls.Add(this.btnMakeReceipt);
            this.panelEmHeader.Controls.Add(this.cbTableLists);
            this.panelEmHeader.Controls.Add(this.btnDBrefresh);
            this.panelEmHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEmHeader.Location = new System.Drawing.Point(0, 0);
            this.panelEmHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelEmHeader.Name = "panelEmHeader";
            this.panelEmHeader.Size = new System.Drawing.Size(838, 59);
            this.panelEmHeader.TabIndex = 7;
            this.panelEmHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEmHeader_Paint);
            // 
            // lbDailyTotal
            // 
            this.lbDailyTotal.AutoSize = true;
            this.lbDailyTotal.Location = new System.Drawing.Point(507, 23);
            this.lbDailyTotal.Name = "lbDailyTotal";
            this.lbDailyTotal.Size = new System.Drawing.Size(78, 16);
            this.lbDailyTotal.TabIndex = 6;
            this.lbDailyTotal.Text = "Daily Total";
            // 
            // cbTableLists
            // 
            this.cbTableLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbTableLists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTableLists.FormattingEnabled = true;
            this.cbTableLists.Location = new System.Drawing.Point(12, 20);
            this.cbTableLists.Name = "cbTableLists";
            this.cbTableLists.Size = new System.Drawing.Size(236, 24);
            this.cbTableLists.TabIndex = 4;
            this.cbTableLists.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cbTableLists.SelectedValueChanged += new System.EventHandler(this.cbTableLists_SelectedValueChanged);
            // 
            // cafeSaleBindingSource
            // 
            this.cafeSaleBindingSource.DataMember = "cafeSale";
            this.cafeSaleBindingSource.DataSource = this.coeCafeDataSet5;
            // 
            // coeCafeDataSet5
            // 
            this.coeCafeDataSet5.DataSetName = "CoeCafeDataSet5";
            this.coeCafeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cafeSaleTableAdapter
            // 
            this.cafeSaleTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(291, 404);
            this.panel3.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(271, 384);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.noDataGridViewTextBoxColumn,
            this.TId,
            this.tNameDataGridViewTextBoxColumn,
            this.foodNameDataGridViewTextBoxColumn,
            this.foodCountDataGridViewTextBoxColumn,
            this.foodSizeDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.userReqDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cafeSaleBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(291, 59);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Size = new System.Drawing.Size(547, 404);
            this.dataGridView1.TabIndex = 10;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.noDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDataGridViewTextBoxColumn.Visible = false;
            // 
            // TId
            // 
            this.TId.DataPropertyName = "TId";
            this.TId.HeaderText = "TId";
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
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // userReqDataGridViewTextBoxColumn
            // 
            this.userReqDataGridViewTextBoxColumn.DataPropertyName = "UserReq";
            this.userReqDataGridViewTextBoxColumn.HeaderText = "UserReq";
            this.userReqDataGridViewTextBoxColumn.Name = "userReqDataGridViewTextBoxColumn";
            // 
            // btnMakeReceipt
            // 
            this.btnMakeReceipt.BackgroundImage = global::MainForm.Properties.Resources.receipt;
            this.btnMakeReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMakeReceipt.FlatAppearance.BorderSize = 0;
            this.btnMakeReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeReceipt.Location = new System.Drawing.Point(262, 15);
            this.btnMakeReceipt.Name = "btnMakeReceipt";
            this.btnMakeReceipt.Size = new System.Drawing.Size(29, 33);
            this.btnMakeReceipt.TabIndex = 5;
            this.btnMakeReceipt.UseVisualStyleBackColor = true;
            this.btnMakeReceipt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDBrefresh
            // 
            this.btnDBrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDBrefresh.BackgroundImage = global::MainForm.Properties.Resources.seo_and_web;
            this.btnDBrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDBrefresh.FlatAppearance.BorderSize = 0;
            this.btnDBrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBrefresh.Location = new System.Drawing.Point(418, 7);
            this.btnDBrefresh.Name = "btnDBrefresh";
            this.btnDBrefresh.Size = new System.Drawing.Size(40, 40);
            this.btnDBrefresh.TabIndex = 2;
            this.btnDBrefresh.UseVisualStyleBackColor = true;
            this.btnDBrefresh.Click += new System.EventHandler(this.btnDBrefresh_Click);
            // 
            // cafeSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelEmHeader);
            this.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cafeSale";
            this.Text = "cafeSale";
            this.Load += new System.EventHandler(this.cafeSale_Load);
            this.panelEmHeader.ResumeLayout(false);
            this.panelEmHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cafeSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeCafeDataSet5)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmHeader;
        public System.Windows.Forms.Button btnDBrefresh;
        private System.Windows.Forms.ComboBox cbTableLists;
        public System.Windows.Forms.Button btnMakeReceipt;
        private CoeCafeDataSet5 coeCafeDataSet5;
        private System.Windows.Forms.BindingSource cafeSaleBindingSource;
        private CoeCafeDataSet5TableAdapters.cafeSaleTableAdapter cafeSaleTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label lbDailyTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userReqDataGridViewTextBoxColumn;
    }
}