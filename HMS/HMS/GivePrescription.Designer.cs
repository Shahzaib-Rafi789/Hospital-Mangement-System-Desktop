
namespace HMS
{
    partial class GivePrescription
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGivePrescript = new System.Windows.Forms.Button();
            this.txtbxPatId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblMedName = new System.Windows.Forms.Label();
            this.lblMedQ = new System.Windows.Forms.Label();
            this.lblPattern = new System.Windows.Forms.Label();
            this.cmbbxMedName = new System.Windows.Forms.ComboBox();
            this.cmbbxPattern = new System.Windows.Forms.ComboBox();
            this.txtbxQuatity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ColMedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMedQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGivePrescript);
            this.panel1.Controls.Add(this.txtbxPatId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 148);
            this.panel1.TabIndex = 45;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnGivePrescript
            // 
            this.btnGivePrescript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGivePrescript.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGivePrescript.Location = new System.Drawing.Point(585, 89);
            this.btnGivePrescript.Name = "btnGivePrescript";
            this.btnGivePrescript.Size = new System.Drawing.Size(75, 23);
            this.btnGivePrescript.TabIndex = 45;
            this.btnGivePrescript.Text = "Prescribe";
            this.btnGivePrescript.UseVisualStyleBackColor = true;
            this.btnGivePrescript.Click += new System.EventHandler(this.btnGivePrescript_Click);
            // 
            // txtbxPatId
            // 
            this.txtbxPatId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxPatId.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtbxPatId.Location = new System.Drawing.Point(231, 35);
            this.txtbxPatId.Name = "txtbxPatId";
            this.txtbxPatId.Size = new System.Drawing.Size(429, 29);
            this.txtbxPatId.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Provide Patient id :";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtbxQuatity);
            this.panel2.Controls.Add(this.cmbbxPattern);
            this.panel2.Controls.Add(this.cmbbxMedName);
            this.panel2.Controls.Add(this.lblPattern);
            this.panel2.Controls.Add(this.lblMedQ);
            this.panel2.Controls.Add(this.lblMedName);
            this.panel2.Controls.Add(this.btnConfirm);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(0, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 433);
            this.panel2.TabIndex = 46;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMedName,
            this.ColMedQuantity,
            this.ColPattern});
            this.dataGridView1.Location = new System.Drawing.Point(212, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(531, 299);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnConfirm.Location = new System.Drawing.Point(636, 347);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 47;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblMedName
            // 
            this.lblMedName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMedName.Location = new System.Drawing.Point(12, 42);
            this.lblMedName.Name = "lblMedName";
            this.lblMedName.Size = new System.Drawing.Size(173, 23);
            this.lblMedName.TabIndex = 46;
            this.lblMedName.Text = "Select Medicine : ";
            // 
            // lblMedQ
            // 
            this.lblMedQ.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedQ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMedQ.Location = new System.Drawing.Point(12, 139);
            this.lblMedQ.Name = "lblMedQ";
            this.lblMedQ.Size = new System.Drawing.Size(173, 23);
            this.lblMedQ.TabIndex = 48;
            this.lblMedQ.Text = "Enter Quantity : ";
            // 
            // lblPattern
            // 
            this.lblPattern.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPattern.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPattern.Location = new System.Drawing.Point(12, 239);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(173, 23);
            this.lblPattern.TabIndex = 49;
            this.lblPattern.Text = "Select Pattern : ";
            // 
            // cmbbxMedName
            // 
            this.cmbbxMedName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxMedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxMedName.FormattingEnabled = true;
            this.cmbbxMedName.Location = new System.Drawing.Point(16, 69);
            this.cmbbxMedName.Name = "cmbbxMedName";
            this.cmbbxMedName.Size = new System.Drawing.Size(178, 28);
            this.cmbbxMedName.TabIndex = 50;
            // 
            // cmbbxPattern
            // 
            this.cmbbxPattern.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxPattern.FormattingEnabled = true;
            this.cmbbxPattern.Items.AddRange(new object[] {
            "1-0-1",
            "1-0-0",
            "0-0-1",
            "1-1-1"});
            this.cmbbxPattern.Location = new System.Drawing.Point(16, 274);
            this.cmbbxPattern.Name = "cmbbxPattern";
            this.cmbbxPattern.Size = new System.Drawing.Size(178, 28);
            this.cmbbxPattern.TabIndex = 51;
            // 
            // txtbxQuatity
            // 
            this.txtbxQuatity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxQuatity.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtbxQuatity.Location = new System.Drawing.Point(12, 174);
            this.txtbxQuatity.Name = "txtbxQuatity";
            this.txtbxQuatity.Size = new System.Drawing.Size(182, 29);
            this.txtbxQuatity.TabIndex = 46;
            this.txtbxQuatity.TextChanged += new System.EventHandler(this.txtbxQuatity_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAdd.Location = new System.Drawing.Point(119, 318);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Add..";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ColMedName
            // 
            this.ColMedName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMedName.HeaderText = "Medicine";
            this.ColMedName.MinimumWidth = 100;
            this.ColMedName.Name = "ColMedName";
            this.ColMedName.ReadOnly = true;
            // 
            // ColMedQuantity
            // 
            this.ColMedQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColMedQuantity.HeaderText = "Quantity";
            this.ColMedQuantity.Name = "ColMedQuantity";
            this.ColMedQuantity.ReadOnly = true;
            // 
            // ColPattern
            // 
            this.ColPattern.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPattern.HeaderText = "Pattern";
            this.ColPattern.MinimumWidth = 100;
            this.ColPattern.Name = "ColPattern";
            this.ColPattern.ReadOnly = true;
            this.ColPattern.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColPattern.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // GivePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GivePrescription";
            this.Text = "GivePrescription";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGivePrescript;
        private System.Windows.Forms.TextBox txtbxPatId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtbxQuatity;
        private System.Windows.Forms.ComboBox cmbbxPattern;
        private System.Windows.Forms.ComboBox cmbbxMedName;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.Label lblMedQ;
        private System.Windows.Forms.Label lblMedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMedName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMedQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPattern;
    }
}