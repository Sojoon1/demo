
namespace Demo2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainImagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.manufacturerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPhotoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.mainImagePathDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.manufacturerIDDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.productPhotoesDataGridViewTextBoxColumn,
            this.productSalesDataGridViewTextBoxColumn,
            this.product1DataGridViewTextBoxColumn,
            this.productsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // mainImagePathDataGridViewTextBoxColumn
            // 
            this.mainImagePathDataGridViewTextBoxColumn.DataPropertyName = "MainImagePath";
            this.mainImagePathDataGridViewTextBoxColumn.HeaderText = "MainImagePath";
            this.mainImagePathDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mainImagePathDataGridViewTextBoxColumn.Name = "mainImagePathDataGridViewTextBoxColumn";
            this.mainImagePathDataGridViewTextBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // manufacturerIDDataGridViewTextBoxColumn
            // 
            this.manufacturerIDDataGridViewTextBoxColumn.DataPropertyName = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn.HeaderText = "ManufacturerID";
            this.manufacturerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerIDDataGridViewTextBoxColumn.Name = "manufacturerIDDataGridViewTextBoxColumn";
            this.manufacturerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.Width = 125;
            // 
            // productPhotoesDataGridViewTextBoxColumn
            // 
            this.productPhotoesDataGridViewTextBoxColumn.DataPropertyName = "ProductPhotoes";
            this.productPhotoesDataGridViewTextBoxColumn.HeaderText = "ProductPhotoes";
            this.productPhotoesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPhotoesDataGridViewTextBoxColumn.Name = "productPhotoesDataGridViewTextBoxColumn";
            this.productPhotoesDataGridViewTextBoxColumn.Width = 125;
            // 
            // productSalesDataGridViewTextBoxColumn
            // 
            this.productSalesDataGridViewTextBoxColumn.DataPropertyName = "ProductSales";
            this.productSalesDataGridViewTextBoxColumn.HeaderText = "ProductSales";
            this.productSalesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productSalesDataGridViewTextBoxColumn.Name = "productSalesDataGridViewTextBoxColumn";
            this.productSalesDataGridViewTextBoxColumn.Width = 125;
            // 
            // product1DataGridViewTextBoxColumn
            // 
            this.product1DataGridViewTextBoxColumn.DataPropertyName = "Product1";
            this.product1DataGridViewTextBoxColumn.HeaderText = "Product1";
            this.product1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.product1DataGridViewTextBoxColumn.Name = "product1DataGridViewTextBoxColumn";
            this.product1DataGridViewTextBoxColumn.Width = 125;
            // 
            // productsDataGridViewTextBoxColumn
            // 
            this.productsDataGridViewTextBoxColumn.DataPropertyName = "Products";
            this.productsDataGridViewTextBoxColumn.HeaderText = "Products";
            this.productsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productsDataGridViewTextBoxColumn.Name = "productsDataGridViewTextBoxColumn";
            this.productsDataGridViewTextBoxColumn.Width = 125;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Demo2.Product);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(562, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(Demo2.Product);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "beauty_logo.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 112);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Косметический салон красоты";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainImagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPhotoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn product1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}