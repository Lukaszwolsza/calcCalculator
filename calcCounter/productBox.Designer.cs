namespace calcCounter
{
    partial class productBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productBox));
            this.mainFormExitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.yellowMinimalizeButton = new System.Windows.Forms.Button();
            this.helloTextLabel = new System.Windows.Forms.Label();
            this.exitRedButton = new System.Windows.Forms.Button();
            this.searchedItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.returnMainboxButton = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.addNewProdBtn = new System.Windows.Forms.Button();
            this.productText = new System.Windows.Forms.TextBox();
            this.caloriesText = new System.Windows.Forms.TextBox();
            this.proteinText = new System.Windows.Forms.TextBox();
            this.fatText = new System.Windows.Forms.TextBox();
            this.carbText = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fatToFitDataSet = new calcCounter.FatToFitDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new calcCounter.FatToFitDataSetTableAdapters.productsTableAdapter();
            this.iDPRODUCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cALORIESON100GDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROTEINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fATDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARBSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatToFitDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormExitButton
            // 
            this.mainFormExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.mainFormExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainFormExitButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainFormExitButton.ForeColor = System.Drawing.Color.White;
            this.mainFormExitButton.Location = new System.Drawing.Point(647, 482);
            this.mainFormExitButton.Name = "mainFormExitButton";
            this.mainFormExitButton.Size = new System.Drawing.Size(87, 35);
            this.mainFormExitButton.TabIndex = 4;
            this.mainFormExitButton.Text = "Exit ";
            this.mainFormExitButton.UseVisualStyleBackColor = false;
            this.mainFormExitButton.Click += new System.EventHandler(this.mainFormExitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.yellowMinimalizeButton);
            this.panel1.Controls.Add(this.helloTextLabel);
            this.panel1.Controls.Add(this.exitRedButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 40);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // yellowMinimalizeButton
            // 
            this.yellowMinimalizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.yellowMinimalizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowMinimalizeButton.Location = new System.Drawing.Point(669, 11);
            this.yellowMinimalizeButton.Name = "yellowMinimalizeButton";
            this.yellowMinimalizeButton.Size = new System.Drawing.Size(20, 20);
            this.yellowMinimalizeButton.TabIndex = 15;
            this.yellowMinimalizeButton.UseVisualStyleBackColor = false;
            this.yellowMinimalizeButton.Click += new System.EventHandler(this.yellowMinimalizeButton_Click);
            // 
            // helloTextLabel
            // 
            this.helloTextLabel.AutoSize = true;
            this.helloTextLabel.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helloTextLabel.ForeColor = System.Drawing.Color.White;
            this.helloTextLabel.Location = new System.Drawing.Point(12, 10);
            this.helloTextLabel.Name = "helloTextLabel";
            this.helloTextLabel.Size = new System.Drawing.Size(161, 22);
            this.helloTextLabel.TabIndex = 11;
            this.helloTextLabel.Text = "Products database";
            // 
            // exitRedButton
            // 
            this.exitRedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.exitRedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitRedButton.Location = new System.Drawing.Point(705, 11);
            this.exitRedButton.Name = "exitRedButton";
            this.exitRedButton.Size = new System.Drawing.Size(20, 20);
            this.exitRedButton.TabIndex = 14;
            this.exitRedButton.UseVisualStyleBackColor = false;
            this.exitRedButton.Click += new System.EventHandler(this.exitRedButton_Click);
            // 
            // searchedItem
            // 
            this.searchedItem.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchedItem.Location = new System.Drawing.Point(160, 53);
            this.searchedItem.Multiline = true;
            this.searchedItem.Name = "searchedItem";
            this.searchedItem.Size = new System.Drawing.Size(214, 33);
            this.searchedItem.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search product";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(383, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // returnMainboxButton
            // 
            this.returnMainboxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.returnMainboxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnMainboxButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.returnMainboxButton.ForeColor = System.Drawing.Color.White;
            this.returnMainboxButton.Location = new System.Drawing.Point(562, 443);
            this.returnMainboxButton.Name = "returnMainboxButton";
            this.returnMainboxButton.Size = new System.Drawing.Size(172, 33);
            this.returnMainboxButton.TabIndex = 19;
            this.returnMainboxButton.Text = "Return to mainbox";
            this.returnMainboxButton.UseVisualStyleBackColor = false;
            this.returnMainboxButton.Click += new System.EventHandler(this.returnMainboxButton_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Black;
            this.panel12.Location = new System.Drawing.Point(552, 107);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(160, 1);
            this.panel12.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(548, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 21);
            this.label15.TabIndex = 49;
            this.label15.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(552, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 1);
            this.panel2.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(548, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Calories / 100g";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(552, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 1);
            this.panel3.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(548, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 21);
            this.label3.TabIndex = 55;
            this.label3.Text = "Fat";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(552, 241);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 1);
            this.panel4.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(548, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 53;
            this.label4.Text = "Protein";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(552, 375);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 1);
            this.panel5.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(548, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 57;
            this.label5.Text = "Carb";
            // 
            // addNewProdBtn
            // 
            this.addNewProdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.addNewProdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewProdBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewProdBtn.ForeColor = System.Drawing.Color.White;
            this.addNewProdBtn.Location = new System.Drawing.Point(655, 380);
            this.addNewProdBtn.Margin = new System.Windows.Forms.Padding(1);
            this.addNewProdBtn.Name = "addNewProdBtn";
            this.addNewProdBtn.Size = new System.Drawing.Size(79, 44);
            this.addNewProdBtn.TabIndex = 59;
            this.addNewProdBtn.Text = "Add + !";
            this.addNewProdBtn.UseVisualStyleBackColor = false;
            this.addNewProdBtn.Click += new System.EventHandler(this.addNewProdBtn_Click);
            // 
            // productText
            // 
            this.productText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.productText.Location = new System.Drawing.Point(552, 85);
            this.productText.Multiline = true;
            this.productText.Name = "productText";
            this.productText.Size = new System.Drawing.Size(160, 20);
            this.productText.TabIndex = 60;
            // 
            // caloriesText
            // 
            this.caloriesText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.caloriesText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.caloriesText.Location = new System.Drawing.Point(552, 151);
            this.caloriesText.Multiline = true;
            this.caloriesText.Name = "caloriesText";
            this.caloriesText.Size = new System.Drawing.Size(160, 20);
            this.caloriesText.TabIndex = 61;
            // 
            // proteinText
            // 
            this.proteinText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proteinText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.proteinText.Location = new System.Drawing.Point(552, 219);
            this.proteinText.Multiline = true;
            this.proteinText.Name = "proteinText";
            this.proteinText.Size = new System.Drawing.Size(160, 20);
            this.proteinText.TabIndex = 62;
            // 
            // fatText
            // 
            this.fatText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fatText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fatText.Location = new System.Drawing.Point(552, 285);
            this.fatText.Multiline = true;
            this.fatText.Name = "fatText";
            this.fatText.Size = new System.Drawing.Size(160, 20);
            this.fatText.TabIndex = 63;
            // 
            // carbText
            // 
            this.carbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.carbText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.carbText.Location = new System.Drawing.Point(552, 353);
            this.carbText.Multiline = true;
            this.carbText.Name = "carbText";
            this.carbText.Size = new System.Drawing.Size(160, 20);
            this.carbText.TabIndex = 64;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(432, 72);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 32);
            this.button2.TabIndex = 65;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUCTDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.cALORIESON100GDataGridViewTextBoxColumn,
            this.pROTEINDataGridViewTextBoxColumn,
            this.fATDataGridViewTextBoxColumn,
            this.cARBSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(522, 408);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fatToFitDataSet
            // 
            this.fatToFitDataSet.DataSetName = "FatToFitDataSet";
            this.fatToFitDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.fatToFitDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // iDPRODUCTDataGridViewTextBoxColumn
            // 
            this.iDPRODUCTDataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUCT";
            this.iDPRODUCTDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDPRODUCTDataGridViewTextBoxColumn.Name = "iDPRODUCTDataGridViewTextBoxColumn";
            this.iDPRODUCTDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPRODUCTDataGridViewTextBoxColumn.Width = 45;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.nAMEDataGridViewTextBoxColumn.Width = 120;
            // 
            // cALORIESON100GDataGridViewTextBoxColumn
            // 
            this.cALORIESON100GDataGridViewTextBoxColumn.DataPropertyName = "CALORIES_ON_100G";
            this.cALORIESON100GDataGridViewTextBoxColumn.HeaderText = "Calories";
            this.cALORIESON100GDataGridViewTextBoxColumn.Name = "cALORIESON100GDataGridViewTextBoxColumn";
            this.cALORIESON100GDataGridViewTextBoxColumn.ReadOnly = true;
            this.cALORIESON100GDataGridViewTextBoxColumn.Width = 75;
            // 
            // pROTEINDataGridViewTextBoxColumn
            // 
            this.pROTEINDataGridViewTextBoxColumn.DataPropertyName = "PROTEIN";
            this.pROTEINDataGridViewTextBoxColumn.HeaderText = "Protein";
            this.pROTEINDataGridViewTextBoxColumn.Name = "pROTEINDataGridViewTextBoxColumn";
            this.pROTEINDataGridViewTextBoxColumn.ReadOnly = true;
            this.pROTEINDataGridViewTextBoxColumn.Width = 75;
            // 
            // fATDataGridViewTextBoxColumn
            // 
            this.fATDataGridViewTextBoxColumn.DataPropertyName = "FAT";
            this.fATDataGridViewTextBoxColumn.HeaderText = "Fat";
            this.fATDataGridViewTextBoxColumn.Name = "fATDataGridViewTextBoxColumn";
            this.fATDataGridViewTextBoxColumn.ReadOnly = true;
            this.fATDataGridViewTextBoxColumn.Width = 75;
            // 
            // cARBSDataGridViewTextBoxColumn
            // 
            this.cARBSDataGridViewTextBoxColumn.DataPropertyName = "CARBS";
            this.cARBSDataGridViewTextBoxColumn.HeaderText = "Carbs";
            this.cARBSDataGridViewTextBoxColumn.Name = "cARBSDataGridViewTextBoxColumn";
            this.cARBSDataGridViewTextBoxColumn.ReadOnly = true;
            this.cARBSDataGridViewTextBoxColumn.Width = 75;
            // 
            // productBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.carbText);
            this.Controls.Add(this.fatText);
            this.Controls.Add(this.proteinText);
            this.Controls.Add(this.caloriesText);
            this.Controls.Add(this.productText);
            this.Controls.Add(this.addNewProdBtn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.returnMainboxButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchedItem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainFormExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "productBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "productBox";
            this.Load += new System.EventHandler(this.productBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fatToFitDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainFormExitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button yellowMinimalizeButton;
        private System.Windows.Forms.Label helloTextLabel;
        private System.Windows.Forms.Button exitRedButton;
        private System.Windows.Forms.TextBox searchedItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button returnMainboxButton;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addNewProdBtn;
        private System.Windows.Forms.TextBox productText;
        private System.Windows.Forms.TextBox caloriesText;
        private System.Windows.Forms.TextBox proteinText;
        private System.Windows.Forms.TextBox fatText;
        private System.Windows.Forms.TextBox carbText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FatToFitDataSet fatToFitDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private FatToFitDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUCTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cALORIESON100GDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pROTEINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fATDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARBSDataGridViewTextBoxColumn;
    }
}