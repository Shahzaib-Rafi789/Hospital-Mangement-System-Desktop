
namespace HMS
{
    partial class ReceptionistForm
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
            this.subPanelPatient = new System.Windows.Forms.Panel();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnUpdatDel = new System.Windows.Forms.Button();
            this.btnAddPat = new System.Windows.Forms.Button();
            this.btPatient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelAppoitment = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPatient = new System.Windows.Forms.Button();
            this.childPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.subPanelPatient.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAppoitment.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.subPanelPatient);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelAppoitment);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 536);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // subPanelPatient
            // 
            this.subPanelPatient.BackColor = System.Drawing.Color.DarkCyan;
            this.subPanelPatient.Controls.Add(this.btnDisplay);
            this.subPanelPatient.Controls.Add(this.btnUpdatDel);
            this.subPanelPatient.Controls.Add(this.btnAddPat);
            this.subPanelPatient.Location = new System.Drawing.Point(6, 280);
            this.subPanelPatient.Name = "subPanelPatient";
            this.subPanelPatient.Size = new System.Drawing.Size(243, 151);
            this.subPanelPatient.TabIndex = 7;
            this.subPanelPatient.Visible = false;
            // 
            // btnDisplay
            // 
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Location = new System.Drawing.Point(3, 100);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(234, 51);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnUpdatDel
            // 
            this.btnUpdatDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatDel.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatDel.ForeColor = System.Drawing.Color.White;
            this.btnUpdatDel.Location = new System.Drawing.Point(3, 49);
            this.btnUpdatDel.Name = "btnUpdatDel";
            this.btnUpdatDel.Size = new System.Drawing.Size(234, 54);
            this.btnUpdatDel.TabIndex = 3;
            this.btnUpdatDel.Text = "Update/Delete";
            this.btnUpdatDel.UseVisualStyleBackColor = true;
            this.btnUpdatDel.Click += new System.EventHandler(this.btnUpdatDel_Click);
            // 
            // btnAddPat
            // 
            this.btnAddPat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPat.Font = new System.Drawing.Font("Californian FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPat.ForeColor = System.Drawing.Color.White;
            this.btnAddPat.Location = new System.Drawing.Point(3, 0);
            this.btnAddPat.Name = "btnAddPat";
            this.btnAddPat.Size = new System.Drawing.Size(234, 52);
            this.btnAddPat.TabIndex = 2;
            this.btnAddPat.Text = "Add";
            this.btnAddPat.UseVisualStyleBackColor = true;
            this.btnAddPat.Click += new System.EventHandler(this.btnAddPat_Click);
            // 
            // btPatient
            // 
            this.btPatient.BackColor = System.Drawing.Color.Transparent;
            this.btPatient.FlatAppearance.BorderSize = 0;
            this.btPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPatient.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPatient.ForeColor = System.Drawing.Color.White;
            this.btPatient.Location = new System.Drawing.Point(0, 9);
            this.btPatient.Name = "btPatient";
            this.btPatient.Size = new System.Drawing.Size(240, 51);
            this.btPatient.TabIndex = 8;
            this.btPatient.Text = "Patient";
            this.btPatient.UseVisualStyleBackColor = false;
            this.btPatient.Click += new System.EventHandler(this.btPatient_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDoctor);
            this.panel2.Font = new System.Drawing.Font("Footlight MT Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 54);
            this.panel2.TabIndex = 5;
            // 
            // panelAppoitment
            // 
            this.panelAppoitment.Controls.Add(this.panel4);
            this.panelAppoitment.Controls.Add(this.btPatient);
            this.panelAppoitment.Controls.Add(this.panel3);
            this.panelAppoitment.Font = new System.Drawing.Font("Footlight MT Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAppoitment.Location = new System.Drawing.Point(0, 229);
            this.panelAppoitment.Name = "panelAppoitment";
            this.panelAppoitment.Size = new System.Drawing.Size(240, 54);
            this.panelAppoitment.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 46);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPatient);
            this.panel3.Font = new System.Drawing.Font("Footlight MT Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(3, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 199);
            this.panel3.TabIndex = 8;
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.Transparent;
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.Location = new System.Drawing.Point(0, 3);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(240, 57);
            this.btnPatient.TabIndex = 6;
            this.btnPatient.Text = "Patient";
            this.btnPatient.UseVisualStyleBackColor = false;
            // 
            // childPanel
            // 
            this.childPanel.Location = new System.Drawing.Point(238, 0);
            this.childPanel.Name = "childPanel";
            this.childPanel.Size = new System.Drawing.Size(750, 533);
            this.childPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HMS.Properties.Resources.Recept;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackColor = System.Drawing.Color.Transparent;
            this.btnDoctor.FlatAppearance.BorderSize = 0;
            this.btnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctor.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.ForeColor = System.Drawing.Color.White;
            this.btnDoctor.Location = new System.Drawing.Point(-6, 0);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(240, 51);
            this.btnDoctor.TabIndex = 2;
            this.btnDoctor.Text = "Doctor Timetable";
            this.btnDoctor.UseVisualStyleBackColor = false;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.childPanel);
            this.Location = new System.Drawing.Point(2, 0);
            this.MinimumSize = new System.Drawing.Size(1000, 575);
            this.Name = "ReceptionistForm";
            this.Text = "Receptionist";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReceptionistForm_FormClosed);
            this.Load += new System.EventHandler(this.Receptionist_Load);
            this.panel1.ResumeLayout(false);
            this.subPanelPatient.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelAppoitment.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelAppoitment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnPatient;
        private System.Windows.Forms.Panel subPanelPatient;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnUpdatDel;
        private System.Windows.Forms.Button btnAddPat;
        private System.Windows.Forms.Button btPatient;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel childPanel;
        private System.Windows.Forms.Button btnDoctor;
    }
}