namespace applicationproject
{
    partial class Form1
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
            this.curList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.chngList = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.dnmBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.conBut = new System.Windows.Forms.Button();
            this.exitBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // curList
            // 
            this.curList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.curList.Location = new System.Drawing.Point(12, 76);
            this.curList.Name = "curList";
            this.curList.Size = new System.Drawing.Size(524, 330);
            this.curList.TabIndex = 0;
            this.curList.UseCompatibleStateImageBehavior = false;
            this.curList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Train ID";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Train Description Label";
            this.columnHeader2.Width = 216;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Train Location";
            this.columnHeader3.Width = 172;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current List";
            // 
            // chngList
            // 
            this.chngList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.chngList.Location = new System.Drawing.Point(625, 76);
            this.chngList.Name = "chngList";
            this.chngList.Size = new System.Drawing.Size(529, 330);
            this.chngList.TabIndex = 2;
            this.chngList.UseCompatibleStateImageBehavior = false;
            this.chngList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date/Time";
            this.columnHeader4.Width = 162;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Train ID";
            this.columnHeader5.Width = 152;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Operation";
            this.columnHeader6.Width = 176;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(625, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Change List";
            // 
            // dnmBox
            // 
            this.dnmBox.Location = new System.Drawing.Point(625, 412);
            this.dnmBox.Multiline = true;
            this.dnmBox.Name = "dnmBox";
            this.dnmBox.Size = new System.Drawing.Size(529, 167);
            this.dnmBox.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 412);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(524, 160);
            this.listBox1.TabIndex = 5;
            // 
            // conBut
            // 
            this.conBut.Location = new System.Drawing.Point(12, 13);
            this.conBut.Name = "conBut";
            this.conBut.Size = new System.Drawing.Size(75, 23);
            this.conBut.TabIndex = 6;
            this.conBut.Text = "Connect";
            this.conBut.UseVisualStyleBackColor = true;
            this.conBut.Click += new System.EventHandler(this.conBut_Click);
            // 
            // exitBut
            // 
            this.exitBut.Location = new System.Drawing.Point(93, 13);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(75, 23);
            this.exitBut.TabIndex = 7;
            this.exitBut.Text = "Exit";
            this.exitBut.UseVisualStyleBackColor = true;
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 591);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.conBut);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dnmBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chngList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.curList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Applicant Showcase Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView curList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView chngList;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dnmBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button conBut;
        private System.Windows.Forms.Button exitBut;
    }
}

