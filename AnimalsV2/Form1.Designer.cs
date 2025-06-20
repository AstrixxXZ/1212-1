using System;

namespace AnimalsV2
{
    partial class Form1
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
<<<<<<< HEAD
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
=======
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            this.lblid = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmboxBreed = new System.Windows.Forms.ComboBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listItems = new System.Windows.Forms.ListBox();
<<<<<<< HEAD
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.animaltypecombox = new System.Windows.Forms.ComboBox();
            this.AnimalTypeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
=======
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.animalsContextDataSet = new AnimalsV2.AnimalsContextDataSet();
            this.animalsContextDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalsTableAdapter = new AnimalsV2.AnimalsContextDataSetTableAdapters.AnimalsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.breedTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsContextDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).BeginInit();
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
<<<<<<< HEAD
            this.lblid.Location = new System.Drawing.Point(109, 128);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(128, 16);
=======
            this.lblid.Location = new System.Drawing.Point(136, 128);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(18, 16);
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Номер на животно";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(136, 176);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
<<<<<<< HEAD
            this.lblName.Size = new System.Drawing.Size(34, 16);
=======
            this.lblName.Size = new System.Drawing.Size(44, 16);
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Име";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(136, 225);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
<<<<<<< HEAD
            this.lblAge.Size = new System.Drawing.Size(54, 16);
=======
            this.lblAge.Size = new System.Drawing.Size(32, 16);
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Години";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
<<<<<<< HEAD
            this.lblBreed.Location = new System.Drawing.Point(133, 315);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(57, 16);
=======
            this.lblBreed.Location = new System.Drawing.Point(136, 273);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(44, 16);
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            this.lblBreed.TabIndex = 3;
            this.lblBreed.Text = "Порода";
            this.lblBreed.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(269, 128);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 4;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(269, 176);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(269, 225);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(132, 22);
            this.txtAge.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 357);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Добави";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmboxBreed
            // 
            this.cmboxBreed.FormattingEnabled = true;
<<<<<<< HEAD
            this.cmboxBreed.Location = new System.Drawing.Point(269, 312);
=======
            this.cmboxBreed.Location = new System.Drawing.Point(269, 273);
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            this.cmboxBreed.Margin = new System.Windows.Forms.Padding(4);
            this.cmboxBreed.Name = "cmboxBreed";
            this.cmboxBreed.Size = new System.Drawing.Size(132, 24);
            this.cmboxBreed.TabIndex = 9;
            this.cmboxBreed.SelectedIndexChanged += new System.EventHandler(this.cmboxBreed_SelectedIndexChanged);
            // 
            // btnSelectAll
            // 
<<<<<<< HEAD
            this.btnSelectAll.Location = new System.Drawing.Point(219, 393);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(124, 28);
            this.btnSelectAll.TabIndex = 10;
            this.btnSelectAll.Text = "Избери всички";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
=======
            this.btnSellectAll.Location = new System.Drawing.Point(219, 393);
            this.btnSellectAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSellectAll.Name = "btnSellectAll";
            this.btnSellectAll.Size = new System.Drawing.Size(124, 28);
            this.btnSellectAll.TabIndex = 10;
            this.btnSellectAll.Text = "SELECT ALL";
            this.btnSellectAll.UseVisualStyleBackColor = true;
            this.btnSellectAll.Click += new System.EventHandler(this.btnSellectAll_Click);
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(327, 357);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(121, 28);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Намери";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(351, 393);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 28);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Актуализирай";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
<<<<<<< HEAD
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(456, 357);
=======
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 357);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(564, 357);
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listItems
            // 
            this.listItems.FormattingEnabled = true;
            this.listItems.ItemHeight = 16;
            this.listItems.Location = new System.Drawing.Point(503, 15);
            this.listItems.Margin = new System.Windows.Forms.Padding(4);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(475, 292);
            this.listItems.TabIndex = 16;
            this.listItems.SelectedIndexChanged += new System.EventHandler(this.listItems_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cat-symbol-icon-256x256-jqp15brc.png");
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnimalsV2.Properties.Resources.cat_symbol_icon_256x256_jqp15brc;
            this.pictureBox1.Location = new System.Drawing.Point(769, 315);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // animaltypecombox
            // 
            this.animaltypecombox.FormattingEnabled = true;
            this.animaltypecombox.Location = new System.Drawing.Point(269, 273);
            this.animaltypecombox.Margin = new System.Windows.Forms.Padding(4);
            this.animaltypecombox.Name = "animaltypecombox";
            this.animaltypecombox.Size = new System.Drawing.Size(132, 24);
            this.animaltypecombox.TabIndex = 18;
            // 
            // AnimalTypeLbl
            // 
            this.AnimalTypeLbl.AutoSize = true;
            this.AnimalTypeLbl.Location = new System.Drawing.Point(124, 276);
            this.AnimalTypeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnimalTypeLbl.Name = "AnimalTypeLbl";
            this.AnimalTypeLbl.Size = new System.Drawing.Size(95, 16);
            this.AnimalTypeLbl.TabIndex = 19;
            this.AnimalTypeLbl.Text = "Тип Животно";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.breedTypeIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.animalsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(503, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(475, 292);
            this.dataGridView1.TabIndex = 17;
            // 
            // animalsContextDataSet
            // 
            this.animalsContextDataSet.DataSetName = "AnimalsContextDataSet";
            this.animalsContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalsContextDataSetBindingSource
            // 
            this.animalsContextDataSetBindingSource.DataSource = this.animalsContextDataSet;
            this.animalsContextDataSetBindingSource.Position = 0;
            // 
            // animalsBindingSource
            // 
            this.animalsBindingSource.DataMember = "Animals";
            this.animalsBindingSource.DataSource = this.animalsContextDataSetBindingSource;
            // 
            // animalsTableAdapter
            // 
            this.animalsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // breedTypeIdDataGridViewTextBoxColumn
            // 
            this.breedTypeIdDataGridViewTextBoxColumn.DataPropertyName = "BreedTypeId";
            this.breedTypeIdDataGridViewTextBoxColumn.HeaderText = "BreedTypeId";
            this.breedTypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.breedTypeIdDataGridViewTextBoxColumn.Name = "breedTypeIdDataGridViewTextBoxColumn";
            this.breedTypeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.AnimalTypeLbl);
            this.Controls.Add(this.animaltypecombox);
            this.Controls.Add(this.pictureBox1);
=======
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            this.Controls.Add(this.listItems);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.cmboxBreed);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblBreed);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblid);
<<<<<<< HEAD
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
=======
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Клиника за Животни \"Сопот Animals\"";
            this.Load += new System.EventHandler(this.Form1_Load);
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsContextDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalsBindingSource)).EndInit();
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmboxBreed;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox listItems;
<<<<<<< HEAD
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox animaltypecombox;
        private System.Windows.Forms.Label AnimalTypeLbl;
=======
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource animalsContextDataSetBindingSource;
        private AnimalsContextDataSet animalsContextDataSet;
        private System.Windows.Forms.BindingSource animalsBindingSource;
        private AnimalsContextDataSetTableAdapters.AnimalsTableAdapter animalsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn breedTypeIdDataGridViewTextBoxColumn;
>>>>>>> 56015b79bbdf45d2cab9f456e0b690738385ef29
    }
}

