namespace DemoListViewDetails
{
    partial class ListviewDemoDetailsForm
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
            this.lvDemoListview = new System.Windows.Forms.ListView();
            this.btVoegRijToe = new System.Windows.Forms.Button();
            this.chKolom1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKolom2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKolom3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chKolom4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvDemoListview
            // 
            this.lvDemoListview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDemoListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chKolom1,
            this.chKolom2,
            this.chKolom3,
            this.chKolom4});
            this.lvDemoListview.Location = new System.Drawing.Point(12, 12);
            this.lvDemoListview.Name = "lvDemoListview";
            this.lvDemoListview.Size = new System.Drawing.Size(926, 348);
            this.lvDemoListview.TabIndex = 0;
            this.lvDemoListview.UseCompatibleStateImageBehavior = false;
            this.lvDemoListview.View = System.Windows.Forms.View.Details;
            // 
            // btVoegRijToe
            // 
            this.btVoegRijToe.Location = new System.Drawing.Point(944, 337);
            this.btVoegRijToe.Name = "btVoegRijToe";
            this.btVoegRijToe.Size = new System.Drawing.Size(116, 23);
            this.btVoegRijToe.TabIndex = 1;
            this.btVoegRijToe.Text = "Voeg Rij Toe";
            this.btVoegRijToe.UseVisualStyleBackColor = true;
            this.btVoegRijToe.Click += new System.EventHandler(this.btVoegRijToe_Click);
            // 
            // chKolom1
            // 
            this.chKolom1.Text = "Kolom 1";
            this.chKolom1.Width = 201;
            // 
            // chKolom2
            // 
            this.chKolom2.Text = "Kolom 2";
            this.chKolom2.Width = 219;
            // 
            // chKolom3
            // 
            this.chKolom3.Text = "Kolom 3";
            this.chKolom3.Width = 226;
            // 
            // chKolom4
            // 
            this.chKolom4.Text = "Kolom 4";
            this.chKolom4.Width = 148;
            // 
            // ListviewDemoDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 372);
            this.Controls.Add(this.btVoegRijToe);
            this.Controls.Add(this.lvDemoListview);
            this.Name = "ListviewDemoDetailsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvDemoListview;
        private System.Windows.Forms.ColumnHeader chKolom1;
        private System.Windows.Forms.ColumnHeader chKolom2;
        private System.Windows.Forms.ColumnHeader chKolom3;
        private System.Windows.Forms.ColumnHeader chKolom4;
        private System.Windows.Forms.Button btVoegRijToe;
    }
}

