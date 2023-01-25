
namespace HMS
{
    partial class MakeAppointment
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
            this.cmbbxdoc = new System.Windows.Forms.ComboBox();
            this.lblConsultDoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbxDaay = new System.Windows.Forms.TextBox();
            this.txtbxMonth = new System.Windows.Forms.TextBox();
            this.txtbxYear = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbbxdoc
            // 
            this.cmbbxdoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbbxdoc.BackColor = System.Drawing.Color.White;
            this.cmbbxdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxdoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbbxdoc.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.cmbbxdoc.FormattingEnabled = true;
            this.cmbbxdoc.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbbxdoc.Location = new System.Drawing.Point(254, 134);
            this.cmbbxdoc.Name = "cmbbxdoc";
            this.cmbbxdoc.Size = new System.Drawing.Size(358, 29);
            this.cmbbxdoc.TabIndex = 25;
            this.cmbbxdoc.SelectedIndexChanged += new System.EventHandler(this.cmbbxdoc_SelectedIndexChanged);
            // 
            // lblConsultDoc
            // 
            this.lblConsultDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConsultDoc.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.lblConsultDoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConsultDoc.Location = new System.Drawing.Point(99, 136);
            this.lblConsultDoc.Name = "lblConsultDoc";
            this.lblConsultDoc.Size = new System.Drawing.Size(149, 23);
            this.lblConsultDoc.TabIndex = 24;
            this.lblConsultDoc.Text = "Enter Doc Name :  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Enter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(553, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Year";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtbxDaay
            // 
            this.txtbxDaay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxDaay.Location = new System.Drawing.Point(217, 238);
            this.txtbxDaay.Name = "txtbxDaay";
            this.txtbxDaay.Size = new System.Drawing.Size(100, 29);
            this.txtbxDaay.TabIndex = 30;
            // 
            // txtbxMonth
            // 
            this.txtbxMonth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMonth.Location = new System.Drawing.Point(380, 238);
            this.txtbxMonth.Name = "txtbxMonth";
            this.txtbxMonth.Size = new System.Drawing.Size(100, 29);
            this.txtbxMonth.TabIndex = 31;
            // 
            // txtbxYear
            // 
            this.txtbxYear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxYear.Location = new System.Drawing.Point(557, 238);
            this.txtbxYear.Name = "txtbxYear";
            this.txtbxYear.Size = new System.Drawing.Size(100, 29);
            this.txtbxYear.TabIndex = 32;
            // 
            // btnSubmit
            // 
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(537, 383);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 33;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // MakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 536);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtbxYear);
            this.Controls.Add(this.txtbxMonth);
            this.Controls.Add(this.txtbxDaay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbxdoc);
            this.Controls.Add(this.lblConsultDoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MakeAppointment";
            this.Text = "MakeAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbxdoc;
        private System.Windows.Forms.Label lblConsultDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbxDaay;
        private System.Windows.Forms.TextBox txtbxMonth;
        private System.Windows.Forms.TextBox txtbxYear;
        private System.Windows.Forms.Button btnSubmit;
    }
}