namespace Aline.Interface
{
    partial class Consulta
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
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cpf_filter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new Aline.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alineEventsDataSet = new Aline.AlineEventsDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Aline.AlineEventsDataSetTableAdapters.usersTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usercpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exclusiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_filter = new System.Windows.Forms.TextBox();
            this.name_filter_check = new System.Windows.Forms.CheckBox();
            this.cpf_filter_check = new System.Windows.Forms.CheckBox();
            this.creation_date_filter_check = new System.Windows.Forms.CheckBox();
            this.birthday_filter_check = new System.Windows.Forms.CheckBox();
            this.birthday_filter = new System.Windows.Forms.DateTimePicker();
            this.creation_date_filter = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alineEventsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(12, 271);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(117, 44);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnVoltar.Location = new System.Drawing.Point(650, 271);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(106, 44);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Retornar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.usercpfDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.creationdateDataGridViewTextBoxColumn,
            this.exclusiondateDataGridViewTextBoxColumn,
            this.userphoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // cpf_filter
            // 
            this.cpf_filter.Enabled = false;
            this.cpf_filter.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cpf_filter.Location = new System.Drawing.Point(33, 79);
            this.cpf_filter.MaxLength = 11;
            this.cpf_filter.Name = "cpf_filter";
            this.cpf_filter.Size = new System.Drawing.Size(309, 20);
            this.cpf_filter.TabIndex = 3;
            this.cpf_filter.Text = "Digite o CPF do cliente (apenas números)";
            this.cpf_filter.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consultar clientes";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1BindingSource1
            // 
            this.dataSet1BindingSource1.DataSource = this.dataSet1;
            this.dataSet1BindingSource1.Position = 0;
            // 
            // alineEventsDataSet
            // 
            this.alineEventsDataSet.DataSetName = "AlineEventsDataSet";
            this.alineEventsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.alineEventsDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "user_name";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "user_name";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // usercpfDataGridViewTextBoxColumn
            // 
            this.usercpfDataGridViewTextBoxColumn.DataPropertyName = "user_cpf";
            this.usercpfDataGridViewTextBoxColumn.HeaderText = "user_cpf";
            this.usercpfDataGridViewTextBoxColumn.Name = "usercpfDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // creationdateDataGridViewTextBoxColumn
            // 
            this.creationdateDataGridViewTextBoxColumn.DataPropertyName = "creation_date";
            this.creationdateDataGridViewTextBoxColumn.HeaderText = "creation_date";
            this.creationdateDataGridViewTextBoxColumn.Name = "creationdateDataGridViewTextBoxColumn";
            // 
            // exclusiondateDataGridViewTextBoxColumn
            // 
            this.exclusiondateDataGridViewTextBoxColumn.DataPropertyName = "exclusion_date";
            this.exclusiondateDataGridViewTextBoxColumn.HeaderText = "exclusion_date";
            this.exclusiondateDataGridViewTextBoxColumn.Name = "exclusiondateDataGridViewTextBoxColumn";
            // 
            // userphoneDataGridViewTextBoxColumn
            // 
            this.userphoneDataGridViewTextBoxColumn.DataPropertyName = "user_phone";
            this.userphoneDataGridViewTextBoxColumn.HeaderText = "user_phone";
            this.userphoneDataGridViewTextBoxColumn.Name = "userphoneDataGridViewTextBoxColumn";
            // 
            // name_filter
            // 
            this.name_filter.Enabled = false;
            this.name_filter.Location = new System.Drawing.Point(33, 53);
            this.name_filter.Name = "name_filter";
            this.name_filter.Size = new System.Drawing.Size(309, 20);
            this.name_filter.TabIndex = 5;
            this.name_filter.Text = "Digite o Nome do cliente.";
            // 
            // name_filter_check
            // 
            this.name_filter_check.AutoSize = true;
            this.name_filter_check.Location = new System.Drawing.Point(12, 56);
            this.name_filter_check.Name = "name_filter_check";
            this.name_filter_check.Size = new System.Drawing.Size(15, 14);
            this.name_filter_check.TabIndex = 6;
            this.name_filter_check.UseVisualStyleBackColor = true;
            this.name_filter_check.CheckedChanged += new System.EventHandler(this.name_filter_check_CheckedChanged);
            // 
            // cpf_filter_check
            // 
            this.cpf_filter_check.AutoSize = true;
            this.cpf_filter_check.Location = new System.Drawing.Point(12, 82);
            this.cpf_filter_check.Name = "cpf_filter_check";
            this.cpf_filter_check.Size = new System.Drawing.Size(15, 14);
            this.cpf_filter_check.TabIndex = 7;
            this.cpf_filter_check.UseVisualStyleBackColor = true;
            this.cpf_filter_check.CheckedChanged += new System.EventHandler(this.cpf_filter_check_CheckedChanged);
            // 
            // creation_date_filter_check
            // 
            this.creation_date_filter_check.AutoSize = true;
            this.creation_date_filter_check.Location = new System.Drawing.Point(426, 82);
            this.creation_date_filter_check.Name = "creation_date_filter_check";
            this.creation_date_filter_check.Size = new System.Drawing.Size(15, 14);
            this.creation_date_filter_check.TabIndex = 11;
            this.creation_date_filter_check.UseVisualStyleBackColor = true;
            this.creation_date_filter_check.CheckedChanged += new System.EventHandler(this.creation_date_filter_check_CheckedChanged);
            // 
            // birthday_filter_check
            // 
            this.birthday_filter_check.AutoSize = true;
            this.birthday_filter_check.Location = new System.Drawing.Point(426, 56);
            this.birthday_filter_check.Name = "birthday_filter_check";
            this.birthday_filter_check.Size = new System.Drawing.Size(15, 14);
            this.birthday_filter_check.TabIndex = 10;
            this.birthday_filter_check.UseVisualStyleBackColor = true;
            this.birthday_filter_check.CheckedChanged += new System.EventHandler(this.birthday_filter_check_CheckedChanged);
            // 
            // birthday_filter
            // 
            this.birthday_filter.Enabled = false;
            this.birthday_filter.Location = new System.Drawing.Point(448, 52);
            this.birthday_filter.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.birthday_filter.Name = "birthday_filter";
            this.birthday_filter.Size = new System.Drawing.Size(308, 20);
            this.birthday_filter.TabIndex = 12;
            // 
            // creation_date_filter
            // 
            this.creation_date_filter.Enabled = false;
            this.creation_date_filter.Location = new System.Drawing.Point(447, 79);
            this.creation_date_filter.MinDate = new System.DateTime(1940, 1, 1, 0, 0, 0, 0);
            this.creation_date_filter.Name = "creation_date_filter";
            this.creation_date_filter.Size = new System.Drawing.Size(308, 20);
            this.creation_date_filter.TabIndex = 13;
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 327);
            this.Controls.Add(this.creation_date_filter);
            this.Controls.Add(this.birthday_filter);
            this.Controls.Add(this.creation_date_filter_check);
            this.Controls.Add(this.birthday_filter_check);
            this.Controls.Add(this.cpf_filter_check);
            this.Controls.Add(this.name_filter_check);
            this.Controls.Add(this.name_filter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpf_filter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnConsultar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consulta";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alineEventsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox cpf_filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private AlineEventsDataSet alineEventsDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private AlineEventsDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usercpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exclusiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox name_filter;
        private System.Windows.Forms.CheckBox name_filter_check;
        private System.Windows.Forms.CheckBox cpf_filter_check;
        private System.Windows.Forms.CheckBox creation_date_filter_check;
        private System.Windows.Forms.CheckBox birthday_filter_check;
        private System.Windows.Forms.DateTimePicker birthday_filter;
        private System.Windows.Forms.DateTimePicker creation_date_filter;
    }
}