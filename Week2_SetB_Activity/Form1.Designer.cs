namespace Week2_SetB_Activity
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
            this.rtb_name = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_Gname = new System.Windows.Forms.TextBox();
            this.Txt_Familyname = new System.Windows.Forms.TextBox();
            this.Txt_Fullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Show_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_name
            // 
            this.rtb_name.Location = new System.Drawing.Point(30, 29);
            this.rtb_name.Name = "rtb_name";
            this.rtb_name.Size = new System.Drawing.Size(238, 28);
            this.rtb_name.TabIndex = 0;
            this.rtb_name.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Click here";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_Gname
            // 
            this.Txt_Gname.Location = new System.Drawing.Point(172, 133);
            this.Txt_Gname.Name = "Txt_Gname";
            this.Txt_Gname.Size = new System.Drawing.Size(164, 22);
            this.Txt_Gname.TabIndex = 2;
            this.Txt_Gname.TextChanged += new System.EventHandler(this.Txt_Gname_TextChanged);
            // 
            // Txt_Familyname
            // 
            this.Txt_Familyname.Location = new System.Drawing.Point(172, 182);
            this.Txt_Familyname.Name = "Txt_Familyname";
            this.Txt_Familyname.Size = new System.Drawing.Size(164, 22);
            this.Txt_Familyname.TabIndex = 3;
            // 
            // Txt_Fullname
            // 
            this.Txt_Fullname.Location = new System.Drawing.Point(172, 227);
            this.Txt_Fullname.Name = "Txt_Fullname";
            this.Txt_Fullname.Size = new System.Drawing.Size(164, 22);
            this.Txt_Fullname.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Given Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Family Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Full Name";
            // 
            // Clear_btn
            // 
            this.Clear_btn.Location = new System.Drawing.Point(62, 289);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(109, 33);
            this.Clear_btn.TabIndex = 8;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Show_btn
            // 
            this.Show_btn.Location = new System.Drawing.Point(204, 289);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(132, 33);
            this.Show_btn.TabIndex = 9;
            this.Show_btn.Text = "Show Full Name";
            this.Show_btn.UseVisualStyleBackColor = true;
            this.Show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 533);
            this.Controls.Add(this.Show_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Fullname);
            this.Controls.Add(this.Txt_Familyname);
            this.Controls.Add(this.Txt_Gname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb_name);
            this.Name = "Form1";
            this.Text = "Set B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt_Gname;
        private System.Windows.Forms.TextBox Txt_Familyname;
        private System.Windows.Forms.TextBox Txt_Fullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Show_btn;
    }
}

