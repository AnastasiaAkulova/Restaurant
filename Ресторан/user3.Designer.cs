namespace Ресторан
{
    partial class user3
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.удобренияBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поливBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ресторанDataSet = new Ресторан.РесторанDataSet();
            this.соответствиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.соответствиеTableAdapter = new Ресторан.РесторанDataSetTableAdapters.СоответствиеTableAdapter();
            this.ресторанDataSet1 = new Ресторан.РесторанDataSet1();
            this.соответствиеBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.соответствиеTableAdapter1 = new Ресторан.РесторанDataSet1TableAdapters.СоответствиеTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.удобренияBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поливBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ресторанDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.соответствиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ресторанDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.соответствиеBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(412, 136);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1, 0);
            this.dataGridView1.TabIndex = 179;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(402, 17);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 40);
            this.button4.TabIndex = 178;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(85, 237);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 39);
            this.button3.TabIndex = 177;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(23, 237);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 39);
            this.button2.TabIndex = 176;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 24);
            this.label2.TabIndex = 175;
            this.label2.Text = "Дата ухода от поставщика:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 174;
            this.label1.Text = "Название:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(14, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 51);
            this.label6.TabIndex = 173;
            this.label6.Text = "Продукты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 24);
            this.label3.TabIndex = 180;
            this.label3.Text = "Дата поставки в ресторан:";
            // 
            // удобренияBindingSource
            // 
            this.удобренияBindingSource.DataMember = "Удобрения";
            // 
            // поливBindingSource
            // 
            this.поливBindingSource.DataMember = "Полив";
            // 
            // ресторанDataSet
            // 
            this.ресторанDataSet.DataSetName = "РесторанDataSet";
            this.ресторанDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // соответствиеBindingSource
            // 
            this.соответствиеBindingSource.DataMember = "Соответствие";
            this.соответствиеBindingSource.DataSource = this.ресторанDataSet;
            // 
            // соответствиеTableAdapter
            // 
            this.соответствиеTableAdapter.ClearBeforeFill = true;
            // 
            // ресторанDataSet1
            // 
            this.ресторанDataSet1.DataSetName = "РесторанDataSet1";
            this.ресторанDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // соответствиеBindingSource1
            // 
            this.соответствиеBindingSource1.DataMember = "Соответствие";
            this.соответствиеBindingSource1.DataSource = this.ресторанDataSet1;
            // 
            // соответствиеTableAdapter1
            // 
            this.соответствиеTableAdapter1.ClearBeforeFill = true;
            // 
            // user3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "user3";
            this.Text = "user3";
            this.Load += new System.EventHandler(this.user3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.удобренияBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поливBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ресторанDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.соответствиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ресторанDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.соответствиеBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource удобренияBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource поливBindingSource;
        private РесторанDataSet ресторанDataSet;
        private System.Windows.Forms.BindingSource соответствиеBindingSource;
        private РесторанDataSetTableAdapters.СоответствиеTableAdapter соответствиеTableAdapter;
        private РесторанDataSet1 ресторанDataSet1;
        private System.Windows.Forms.BindingSource соответствиеBindingSource1;
        private РесторанDataSet1TableAdapters.СоответствиеTableAdapter соответствиеTableAdapter1;
    }
}