namespace calcCounter
{
    partial class addProductToMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addProductToMeal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.yellowMinimalizeButton = new System.Windows.Forms.Button();
            this.helloTextLabel = new System.Windows.Forms.Label();
            this.exitRedButton = new System.Windows.Forms.Button();
            this.searchedProductInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchProdButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.typeOfMealBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CALORIES_ON_100G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROTEIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CARBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(546, 40);
            this.panel1.TabIndex = 14;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // yellowMinimalizeButton
            // 
            this.yellowMinimalizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.yellowMinimalizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowMinimalizeButton.Location = new System.Drawing.Point(478, 10);
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
            this.helloTextLabel.Size = new System.Drawing.Size(181, 22);
            this.helloTextLabel.TabIndex = 11;
            this.helloTextLabel.Text = "Add product to meal";
            // 
            // exitRedButton
            // 
            this.exitRedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.exitRedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitRedButton.Location = new System.Drawing.Point(514, 10);
            this.exitRedButton.Name = "exitRedButton";
            this.exitRedButton.Size = new System.Drawing.Size(20, 20);
            this.exitRedButton.TabIndex = 14;
            this.exitRedButton.UseVisualStyleBackColor = false;
            this.exitRedButton.Click += new System.EventHandler(this.exitRedButton_Click);
            // 
            // searchedProductInput
            // 
            this.searchedProductInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchedProductInput.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchedProductInput.Location = new System.Drawing.Point(16, 153);
            this.searchedProductInput.Name = "searchedProductInput";
            this.searchedProductInput.Size = new System.Drawing.Size(335, 26);
            this.searchedProductInput.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(14, 179);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 1);
            this.panel2.TabIndex = 16;
            // 
            // searchProdButton
            // 
            this.searchProdButton.BackColor = System.Drawing.Color.White;
            this.searchProdButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchProdButton.BackgroundImage")));
            this.searchProdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchProdButton.Location = new System.Drawing.Point(357, 153);
            this.searchProdButton.Name = "searchProdButton";
            this.searchProdButton.Size = new System.Drawing.Size(30, 30);
            this.searchProdButton.TabIndex = 18;
            this.searchProdButton.UseVisualStyleBackColor = false;
            this.searchProdButton.Click += new System.EventHandler(this.searchProdButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAME,
            this.CALORIES_ON_100G,
            this.PROTEIN,
            this.FAT,
            this.CARBS});
            this.dataGridView1.Location = new System.Drawing.Point(10, 206);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(524, 299);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // typeOfMealBox
            // 
            this.typeOfMealBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeOfMealBox.FormattingEnabled = true;
            this.typeOfMealBox.Location = new System.Drawing.Point(17, 105);
            this.typeOfMealBox.Name = "typeOfMealBox";
            this.typeOfMealBox.Size = new System.Drawing.Size(338, 28);
            this.typeOfMealBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 23;
            this.label1.Text = "Type of meal :";
            // 
            // NAME
            // 
            this.NAME.DataPropertyName = "NAME";
            this.NAME.HeaderText = "Name";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 120;
            // 
            // CALORIES_ON_100G
            // 
            this.CALORIES_ON_100G.DataPropertyName = "CALORIES_ON_100G";
            this.CALORIES_ON_100G.HeaderText = "Calories";
            this.CALORIES_ON_100G.Name = "CALORIES_ON_100G";
            this.CALORIES_ON_100G.ReadOnly = true;
            this.CALORIES_ON_100G.Width = 75;
            // 
            // PROTEIN
            // 
            this.PROTEIN.DataPropertyName = "PROTEIN";
            this.PROTEIN.HeaderText = "Protein";
            this.PROTEIN.Name = "PROTEIN";
            this.PROTEIN.ReadOnly = true;
            // 
            // FAT
            // 
            this.FAT.DataPropertyName = "FAT";
            this.FAT.HeaderText = "Fat";
            this.FAT.Name = "FAT";
            this.FAT.ReadOnly = true;
            // 
            // CARBS
            // 
            this.CARBS.DataPropertyName = "CARBS";
            this.CARBS.HeaderText = "Carbs";
            this.CARBS.Name = "CARBS";
            this.CARBS.ReadOnly = true;
            // 
            // addProductToMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeOfMealBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchProdButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.searchedProductInput);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addProductToMeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addProductToMeal";
            this.Load += new System.EventHandler(this.addProductToMeal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button yellowMinimalizeButton;
        private System.Windows.Forms.Label helloTextLabel;
        private System.Windows.Forms.Button exitRedButton;
        private System.Windows.Forms.TextBox searchedProductInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchProdButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox typeOfMealBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CALORIES_ON_100G;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROTEIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARBS;
    }
}