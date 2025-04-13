namespace Clinic
{
    partial class patientform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patientform));
            this.label1 = new System.Windows.Forms.Label();
            this.Namebb = new System.Windows.Forms.TextBox();
            this.pgender = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.Follow = new System.Windows.Forms.CheckBox();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.okbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.pgender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // Namebb
            // 
            this.Namebb.Location = new System.Drawing.Point(204, 15);
            this.Namebb.Margin = new System.Windows.Forms.Padding(6);
            this.Namebb.Name = "Namebb";
            this.Namebb.Size = new System.Drawing.Size(748, 56);
            this.Namebb.TabIndex = 1;
            // 
            // pgender
            // 
            this.pgender.Controls.Add(this.female);
            this.pgender.Controls.Add(this.male);
            this.pgender.Location = new System.Drawing.Point(21, 115);
            this.pgender.Name = "pgender";
            this.pgender.Size = new System.Drawing.Size(882, 177);
            this.pgender.TabIndex = 2;
            this.pgender.TabStop = false;
            this.pgender.Text = "Gender";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(648, 94);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(197, 55);
            this.female.TabIndex = 4;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(401, 94);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(147, 55);
            this.male.TabIndex = 3;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // Follow
            // 
            this.Follow.AutoSize = true;
            this.Follow.Location = new System.Drawing.Point(21, 524);
            this.Follow.Name = "Follow";
            this.Follow.Size = new System.Drawing.Size(241, 55);
            this.Follow.TabIndex = 5;
            this.Follow.Text = "Follow-up";
            this.Follow.UseVisualStyleBackColor = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbtn.Location = new System.Drawing.Point(756, 520);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(178, 60);
            this.cancelbtn.TabIndex = 6;
            this.cancelbtn.Text = "Cancel";
            this.cancelbtn.UseVisualStyleBackColor = true;
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(572, 520);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(178, 60);
            this.okbtn.TabIndex = 7;
            this.okbtn.Text = "Ok";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 51);
            this.label2.TabIndex = 8;
            this.label2.Text = "Age :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 51);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 51);
            this.label4.TabIndex = 10;
            this.label4.Text = "Address :";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(222, 297);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(730, 56);
            this.textBoxAddress.TabIndex = 11;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(204, 375);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(321, 56);
            this.textBoxPhone.TabIndex = 12;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(204, 453);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(132, 56);
            this.textBoxAge.TabIndex = 13;
            // 
            // patientform
            // 
            this.AcceptButton = this.okbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(25F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.CancelButton = this.cancelbtn;
            this.ClientSize = new System.Drawing.Size(962, 592);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.Follow);
            this.Controls.Add(this.pgender);
            this.Controls.Add(this.Namebb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "patientform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient Info";
            this.pgender.ResumeLayout(false);
            this.pgender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Namebb;
        private System.Windows.Forms.GroupBox pgender;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.CheckBox Follow;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxAge;
    }
}