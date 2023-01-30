namespace Ресторан
{
    partial class autorizacia
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
            this.Group = new System.Windows.Forms.ComboBox();
            this.пользователиBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.ресторанDataSet = new Ресторан.РесторанDataSet();
            this.пользователиBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Password = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.пользователиTableAdapter = new Ресторан.РесторанDataSetTableAdapters.ПользователиTableAdapter();
            this.ресторанDataSet1 = new Ресторан.РесторанDataSet1();
            this.пользователиBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.пользователиTableAdapter1 = new Ресторан.РесторанDataSet1TableAdapters.ПользователиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ресторанDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ресторанDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // Group
            // 
            this.Group.DataSource = this.пользователиBindingSource5;
            this.Group.DisplayMember = "userGroup";
            this.Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Group.FormattingEnabled = true;
            this.Group.Location = new System.Drawing.Point(230, 108);
            this.Group.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(161, 33);
            this.Group.TabIndex = 62;
            // 
            // пользователиBindingSource4
            // 
            this.пользователиBindingSource4.DataMember = "Пользователи";
            this.пользователиBindingSource4.DataSource = this.ресторанDataSet;
            // 
            // ресторанDataSet
            // 
            this.ресторанDataSet.DataSetName = "РесторанDataSet";
            this.ресторанDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользователиBindingSource3
            // 
            this.пользователиBindingSource3.DataMember = "Пользователи";
            // 
            // пользователиBindingSource2
            // 
            this.пользователиBindingSource2.DataMember = "Пользователи";
            // 
            // пользователиBindingSource1
            // 
            this.пользователиBindingSource1.DataMember = "Пользователи";
            // 
            // пользователиBindingSource
            // 
            this.пользователиBindingSource.DataMember = "Пользователи";
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Password.Location = new System.Drawing.Point(230, 174);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(161, 32);
            this.Password.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(60, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(415, 51);
            this.label6.TabIndex = 60;
            this.label6.Text = "Добро пожаловать!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(110, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 26);
            this.label5.TabIndex = 59;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(110, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 58;
            this.label4.Text = "Логин";
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ok.Location = new System.Drawing.Point(110, 230);
            this.ok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(67, 32);
            this.ok.TabIndex = 57;
            this.ok.Text = "ОК";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(287, 230);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 32);
            this.button1.TabIndex = 63;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // пользователиTableAdapter
            // 
            this.пользователиTableAdapter.ClearBeforeFill = true;
            // 
            // ресторанDataSet1
            // 
            this.ресторанDataSet1.DataSetName = "РесторанDataSet1";
            this.ресторанDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользователиBindingSource5
            // 
            this.пользователиBindingSource5.DataMember = "Пользователи";
            this.пользователиBindingSource5.DataSource = this.ресторанDataSet1;
            // 
            // пользователиTableAdapter1
            // 
            this.пользователиTableAdapter1.ClearBeforeFill = true;
            // 
            // autorizacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "autorizacia";
            this.Text = "autorizacia";
            this.Load += new System.EventHandler(this.autorizacia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ресторанDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ресторанDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользователиBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Group;
        private System.Windows.Forms.BindingSource пользователиBindingSource3;
        private System.Windows.Forms.BindingSource пользователиBindingSource2;
        private System.Windows.Forms.BindingSource пользователиBindingSource1;
        private System.Windows.Forms.BindingSource пользователиBindingSource;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button button1;
        private РесторанDataSet ресторанDataSet;
        private System.Windows.Forms.BindingSource пользователиBindingSource4;
        private РесторанDataSetTableAdapters.ПользователиTableAdapter пользователиTableAdapter;
        private РесторанDataSet1 ресторанDataSet1;
        private System.Windows.Forms.BindingSource пользователиBindingSource5;
        private РесторанDataSet1TableAdapters.ПользователиTableAdapter пользователиTableAdapter1;
    }
}