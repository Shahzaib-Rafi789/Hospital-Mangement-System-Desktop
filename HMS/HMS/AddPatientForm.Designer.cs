
namespace HMS
{
    partial class AddPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtbxRoom = new System.Windows.Forms.TextBox();
            this.lblRoom = new System.Windows.Forms.Label();
            this.cmbbxGender = new System.Windows.Forms.ComboBox();
            this.txtbxAge = new System.Windows.Forms.TextBox();
            this.txtbxBill = new System.Windows.Forms.TextBox();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.kblBill = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbbxdoc = new System.Windows.Forms.ComboBox();
            this.lblConsultDoc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.cmbbxdoc);
            this.panel1.Controls.Add(this.lblConsultDoc);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtbxRoom);
            this.panel1.Controls.Add(this.lblRoom);
            this.panel1.Controls.Add(this.cmbbxGender);
            this.panel1.Controls.Add(this.txtbxAge);
            this.panel1.Controls.Add(this.txtbxBill);
            this.panel1.Controls.Add(this.txtbxName);
            this.panel1.Controls.Add(this.lblAge);
            this.panel1.Controls.Add(this.lblgender);
            this.panel1.Controls.Add(this.kblBill);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtbxRoom
            // 
            resources.ApplyResources(this.txtbxRoom, "txtbxRoom");
            this.txtbxRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxRoom.Name = "txtbxRoom";
            // 
            // lblRoom
            // 
            resources.ApplyResources(this.lblRoom, "lblRoom");
            this.lblRoom.Name = "lblRoom";
            // 
            // cmbbxGender
            // 
            resources.ApplyResources(this.cmbbxGender, "cmbbxGender");
            this.cmbbxGender.BackColor = System.Drawing.Color.White;
            this.cmbbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxGender.FormattingEnabled = true;
            this.cmbbxGender.Items.AddRange(new object[] {
            resources.GetString("cmbbxGender.Items"),
            resources.GetString("cmbbxGender.Items1")});
            this.cmbbxGender.Name = "cmbbxGender";
            // 
            // txtbxAge
            // 
            resources.ApplyResources(this.txtbxAge, "txtbxAge");
            this.txtbxAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxAge.Name = "txtbxAge";
            this.txtbxAge.TextChanged += new System.EventHandler(this.txtbxAge_TextChanged);
            // 
            // txtbxBill
            // 
            resources.ApplyResources(this.txtbxBill, "txtbxBill");
            this.txtbxBill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxBill.Name = "txtbxBill";
            this.txtbxBill.TextChanged += new System.EventHandler(this.txtbxBill_TextChanged);
            // 
            // txtbxName
            // 
            resources.ApplyResources(this.txtbxName, "txtbxName");
            this.txtbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxName.Name = "txtbxName";
            // 
            // lblAge
            // 
            resources.ApplyResources(this.lblAge, "lblAge");
            this.lblAge.Name = "lblAge";
            // 
            // lblgender
            // 
            resources.ApplyResources(this.lblgender, "lblgender");
            this.lblgender.Name = "lblgender";
            // 
            // kblBill
            // 
            resources.ApplyResources(this.kblBill, "kblBill");
            this.kblBill.Name = "kblBill";
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // cmbbxdoc
            // 
            resources.ApplyResources(this.cmbbxdoc, "cmbbxdoc");
            this.cmbbxdoc.BackColor = System.Drawing.Color.White;
            this.cmbbxdoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbxdoc.FormattingEnabled = true;
            this.cmbbxdoc.Items.AddRange(new object[] {
            resources.GetString("cmbbxdoc.Items"),
            resources.GetString("cmbbxdoc.Items1")});
            this.cmbbxdoc.Name = "cmbbxdoc";
            this.cmbbxdoc.SelectedIndexChanged += new System.EventHandler(this.cmbbxdoc_SelectedIndexChanged);
            // 
            // lblConsultDoc
            // 
            resources.ApplyResources(this.lblConsultDoc, "lblConsultDoc");
            this.lblConsultDoc.Name = "lblConsultDoc";
            this.lblConsultDoc.Click += new System.EventHandler(this.lblConsultDoc_Click);
            // 
            // AddPatientForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPatientForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtbxRoom;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.ComboBox cmbbxGender;
        private System.Windows.Forms.TextBox txtbxAge;
        private System.Windows.Forms.TextBox txtbxBill;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label kblBill;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbbxdoc;
        private System.Windows.Forms.Label lblConsultDoc;
    }
}