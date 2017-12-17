namespace KursBD
{
    partial class Admin
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
            this.dataGridViewAbit = new System.Windows.Forms.DataGridView();
            this.marchenkokursovayaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marchenko_kursovayaDataSet = new KursBD.marchenko_kursovayaDataSet();
            this.AddAbitButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchenkokursovayaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchenko_kursovayaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAbit
            // 
            this.dataGridViewAbit.AutoGenerateColumns = false;
            this.dataGridViewAbit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbit.DataSource = this.marchenkokursovayaDataSetBindingSource;
            this.dataGridViewAbit.Location = new System.Drawing.Point(240, 12);
            this.dataGridViewAbit.Name = "dataGridViewAbit";
            this.dataGridViewAbit.Size = new System.Drawing.Size(383, 196);
            this.dataGridViewAbit.TabIndex = 0;
            this.dataGridViewAbit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // marchenkokursovayaDataSetBindingSource
            // 
            this.marchenkokursovayaDataSetBindingSource.DataSource = this.marchenko_kursovayaDataSet;
            this.marchenkokursovayaDataSetBindingSource.Position = 0;
            // 
            // marchenko_kursovayaDataSet
            // 
            this.marchenko_kursovayaDataSet.DataSetName = "marchenko_kursovayaDataSet";
            this.marchenko_kursovayaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddAbitButton
            // 
            this.AddAbitButton.Location = new System.Drawing.Point(475, 230);
            this.AddAbitButton.Name = "AddAbitButton";
            this.AddAbitButton.Size = new System.Drawing.Size(148, 53);
            this.AddAbitButton.TabIndex = 1;
            this.AddAbitButton.Text = "Добавить абитуриента";
            this.AddAbitButton.UseVisualStyleBackColor = true;
            this.AddAbitButton.Click += new System.EventHandler(this.AddAbitButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(209, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(209, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Факультет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Специальность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество бюджетных мест";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(186, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 295);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddAbitButton);
            this.Controls.Add(this.dataGridViewAbit);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchenkokursovayaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchenko_kursovayaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAbit;
        private System.Windows.Forms.BindingSource marchenkokursovayaDataSetBindingSource;
        private marchenko_kursovayaDataSet marchenko_kursovayaDataSet;
        private System.Windows.Forms.Button AddAbitButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}