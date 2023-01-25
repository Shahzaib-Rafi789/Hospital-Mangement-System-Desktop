
namespace HMS
{
    partial class DocTimeTable
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
            this.lblRed = new System.Windows.Forms.Label();
            this.lblblue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblclrRed = new System.Windows.Forms.Label();
            this.lblclrGreen = new System.Windows.Forms.Label();
            this.lblClrBlue = new System.Windows.Forms.Label();
            this.DGWtimetable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGWtimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(40, 49);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(74, 18);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "Morning : ";
            // 
            // lblblue
            // 
            this.lblblue.AutoSize = true;
            this.lblblue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblblue.Location = new System.Drawing.Point(504, 49);
            this.lblblue.Name = "lblblue";
            this.lblblue.Size = new System.Drawing.Size(54, 18);
            this.lblblue.TabIndex = 1;
            this.lblblue.Text = "Night : ";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(278, 49);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(72, 18);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.Text = "Evening : ";
            this.lblGreen.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblclrRed
            // 
            this.lblclrRed.BackColor = System.Drawing.Color.Red;
            this.lblclrRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclrRed.Location = new System.Drawing.Point(120, 49);
            this.lblclrRed.Name = "lblclrRed";
            this.lblclrRed.Size = new System.Drawing.Size(122, 18);
            this.lblclrRed.TabIndex = 3;
            // 
            // lblclrGreen
            // 
            this.lblclrGreen.BackColor = System.Drawing.Color.Green;
            this.lblclrGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclrGreen.Location = new System.Drawing.Point(356, 49);
            this.lblclrGreen.Name = "lblclrGreen";
            this.lblclrGreen.Size = new System.Drawing.Size(122, 18);
            this.lblclrGreen.TabIndex = 4;
            // 
            // lblClrBlue
            // 
            this.lblClrBlue.BackColor = System.Drawing.Color.Blue;
            this.lblClrBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClrBlue.Location = new System.Drawing.Point(564, 49);
            this.lblClrBlue.Name = "lblClrBlue";
            this.lblClrBlue.Size = new System.Drawing.Size(122, 18);
            this.lblClrBlue.TabIndex = 5;
            // 
            // DGWtimetable
            // 
            this.DGWtimetable.AllowUserToAddRows = false;
            this.DGWtimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGWtimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWtimetable.Location = new System.Drawing.Point(13, 108);
            this.DGWtimetable.Name = "DGWtimetable";
            this.DGWtimetable.Size = new System.Drawing.Size(714, 416);
            this.DGWtimetable.TabIndex = 6;
            this.DGWtimetable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGWtimetable_CellContentClick);
            // 
            // DocTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 536);
            this.Controls.Add(this.DGWtimetable);
            this.Controls.Add(this.lblClrBlue);
            this.Controls.Add(this.lblclrGreen);
            this.Controls.Add(this.lblclrRed);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblblue);
            this.Controls.Add(this.lblRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocTimeTable";
            this.Text = "DocTimeTable";
            ((System.ComponentModel.ISupportInitialize)(this.DGWtimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblblue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblclrRed;
        private System.Windows.Forms.Label lblclrGreen;
        private System.Windows.Forms.Label lblClrBlue;
        private System.Windows.Forms.DataGridView DGWtimetable;
    }
}