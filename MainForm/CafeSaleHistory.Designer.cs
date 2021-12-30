namespace MainForm
{
    partial class CafeSaleHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CafeSaleHistory));
            this.panelEmHeader = new System.Windows.Forms.Panel();
            this.btnDBrefresh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddNewMenu = new System.Windows.Forms.Button();
            this.tbMenuSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelEmHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panelEmHeader.TabIndex = 7;
            // 
            // btnDBrefresh
            // 
            this.btnDBrefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDBrefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDBrefresh.BackgroundImage")));
            this.btnDBrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDBrefresh.FlatAppearance.BorderSize = 0;
            this.btnDBrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBrefresh.Location = new System.Drawing.Point(496, 11);
            this.btnDBrefresh.Name = "btnDBrefresh";
            this.btnDBrefresh.Size = new System.Drawing.Size(40, 40);
            this.btnDBrefresh.TabIndex = 2;
            this.btnDBrefresh.UseVisualStyleBackColor = true;
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
            // 
            // CafeSaleHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 463);
            this.Controls.Add(this.panelEmHeader);
            this.Name = "CafeSaleHistory";
            this.Text = "CafeSaleHistory";
            this.panelEmHeader.ResumeLayout(false);
            this.panelEmHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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

    }
}