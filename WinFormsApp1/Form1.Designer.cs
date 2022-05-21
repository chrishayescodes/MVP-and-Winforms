namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(73, 138);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(548, 47);
            this.FirstName.TabIndex = 1;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(73, 295);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(548, 47);
            this.LastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(73, 613);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(548, 47);
            this.Phone.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(73, 456);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(548, 47);
            this.Email.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(433, 758);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(188, 58);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(73, 836);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 41);
            this.ErrorMessage.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 1234);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox FirstName;
        private TextBox LastName;
        private Label label2;
        private TextBox Phone;
        private Label label3;
        private TextBox Email;
        private Label label4;
        private Button Save;
        private Label ErrorMessage;
    }
}