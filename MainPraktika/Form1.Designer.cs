
namespace MainPraktika
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idZachetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioStudentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioPrepodovatelyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ochenkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dischiplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zachetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zachetDataSet = new MainPraktika.ZachetDataSet();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.RedakBtn = new System.Windows.Forms.Button();
            this.zachetTableAdapter = new MainPraktika.ZachetDataSetTableAdapters.ZachetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zachetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zachetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZachetaDataGridViewTextBoxColumn,
            this.fioStudentaDataGridViewTextBoxColumn,
            this.fioPrepodovatelyaDataGridViewTextBoxColumn,
            this.ochenkaDataGridViewTextBoxColumn,
            this.dischiplinaDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zachetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // idZachetaDataGridViewTextBoxColumn
            // 
            this.idZachetaDataGridViewTextBoxColumn.DataPropertyName = "IdZacheta";
            this.idZachetaDataGridViewTextBoxColumn.HeaderText = "IdZacheta";
            this.idZachetaDataGridViewTextBoxColumn.Name = "idZachetaDataGridViewTextBoxColumn";
            this.idZachetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fioStudentaDataGridViewTextBoxColumn
            // 
            this.fioStudentaDataGridViewTextBoxColumn.DataPropertyName = "FioStudenta";
            this.fioStudentaDataGridViewTextBoxColumn.HeaderText = "FioStudenta";
            this.fioStudentaDataGridViewTextBoxColumn.Name = "fioStudentaDataGridViewTextBoxColumn";
            // 
            // fioPrepodovatelyaDataGridViewTextBoxColumn
            // 
            this.fioPrepodovatelyaDataGridViewTextBoxColumn.DataPropertyName = "FioPrepodovatelya";
            this.fioPrepodovatelyaDataGridViewTextBoxColumn.HeaderText = "FioPrepodovatelya";
            this.fioPrepodovatelyaDataGridViewTextBoxColumn.Name = "fioPrepodovatelyaDataGridViewTextBoxColumn";
            // 
            // ochenkaDataGridViewTextBoxColumn
            // 
            this.ochenkaDataGridViewTextBoxColumn.DataPropertyName = "Ochenka";
            this.ochenkaDataGridViewTextBoxColumn.HeaderText = "Ochenka";
            this.ochenkaDataGridViewTextBoxColumn.Name = "ochenkaDataGridViewTextBoxColumn";
            // 
            // dischiplinaDataGridViewTextBoxColumn
            // 
            this.dischiplinaDataGridViewTextBoxColumn.DataPropertyName = "Dischiplina";
            this.dischiplinaDataGridViewTextBoxColumn.HeaderText = "Dischiplina";
            this.dischiplinaDataGridViewTextBoxColumn.Name = "dischiplinaDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // zachetBindingSource
            // 
            this.zachetBindingSource.DataMember = "Zachet";
            this.zachetBindingSource.DataSource = this.zachetDataSet;
            // 
            // zachetDataSet
            // 
            this.zachetDataSet.DataSetName = "ZachetDataSet";
            this.zachetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(12, 329);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(264, 27);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(282, 329);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(102, 27);
            this.DelBtn.TabIndex = 2;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // RedakBtn
            // 
            this.RedakBtn.Location = new System.Drawing.Point(390, 329);
            this.RedakBtn.Name = "RedakBtn";
            this.RedakBtn.Size = new System.Drawing.Size(263, 27);
            this.RedakBtn.TabIndex = 3;
            this.RedakBtn.Text = "Редактировать";
            this.RedakBtn.UseVisualStyleBackColor = true;
            this.RedakBtn.Click += new System.EventHandler(this.RedakBtn_Click);
            // 
            // zachetTableAdapter
            // 
            this.zachetTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 368);
            this.Controls.Add(this.RedakBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Зачет";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zachetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zachetDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button RedakBtn;
        private ZachetDataSet zachetDataSet;
        private System.Windows.Forms.BindingSource zachetBindingSource;
        private ZachetDataSetTableAdapters.ZachetTableAdapter zachetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZachetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioStudentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioPrepodovatelyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ochenkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dischiplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
    }
}

