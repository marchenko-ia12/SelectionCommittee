namespace KursBD
{
    partial class InfoList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marchenkokursovayaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marchenko_kursovayaDataSet = new KursBD.marchenko_kursovayaDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.marchenko_kursovayaDataSet1 = new KursBD.marchenko_kursovayaDataSet();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.specialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialtyTableAdapter = new KursBD.marchenko_kursovayaDataSetTableAdapters.specialtyTableAdapter();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultyTableAdapter = new KursBD.marchenko_kursovayaDataSetTableAdapters.facultyTableAdapter();
            this.enrolleeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrolleeTableAdapter = new KursBD.marchenko_kursovayaDataSetTableAdapters.enrolleeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchenkokursovayaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchenko_kursovayaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchenko_kursovayaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrolleeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(595, 222);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Кол-во бюджетных мест";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // marchenko_kursovayaDataSet1
            // 
            this.marchenko_kursovayaDataSet1.DataSetName = "marchenko_kursovayaDataSet";
            this.marchenko_kursovayaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(270, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectionChangeCommitted += new System.EventHandler(this.comboBox2_SelectionChangeCommitted);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(291, 25);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(319, 21);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Фак";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Направление";
            // 
            // specialtyBindingSource
            // 
            this.specialtyBindingSource.DataMember = "specialty";
            this.specialtyBindingSource.DataSource = this.marchenkokursovayaDataSetBindingSource;
            // 
            // specialtyTableAdapter
            // 
            this.specialtyTableAdapter.ClearBeforeFill = true;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "faculty";
            this.facultyBindingSource.DataSource = this.marchenkokursovayaDataSetBindingSource;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // enrolleeBindingSource
            // 
            this.enrolleeBindingSource.DataMember = "enrollee";
            this.enrolleeBindingSource.DataSource = this.marchenkokursovayaDataSetBindingSource;
            // 
            // enrolleeTableAdapter
            // 
            this.enrolleeTableAdapter.ClearBeforeFill = true;
            // 
            // InfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 335);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InfoList";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.InfoList_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchenkokursovayaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchenko_kursovayaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marchenko_kursovayaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrolleeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource marchenkokursovayaDataSetBindingSource;
        private marchenko_kursovayaDataSet marchenko_kursovayaDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private marchenko_kursovayaDataSet marchenko_kursovayaDataSet1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource specialtyBindingSource;
        private marchenko_kursovayaDataSetTableAdapters.specialtyTableAdapter specialtyTableAdapter;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private marchenko_kursovayaDataSetTableAdapters.facultyTableAdapter facultyTableAdapter;
        private System.Windows.Forms.BindingSource enrolleeBindingSource;
        private marchenko_kursovayaDataSetTableAdapters.enrolleeTableAdapter enrolleeTableAdapter;
    }
}