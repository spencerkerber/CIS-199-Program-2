namespace Program_2
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
            this.Last_name = new System.Windows.Forms.Label();
            this.grade_selelection_groupbox = new System.Windows.Forms.GroupBox();
            this.Senior = new System.Windows.Forms.RadioButton();
            this.Junior = new System.Windows.Forms.RadioButton();
            this.Sophomore = new System.Windows.Forms.RadioButton();
            this.Freshman = new System.Windows.Forms.RadioButton();
            this.last_name_textbox = new System.Windows.Forms.TextBox();
            this.registration_button = new System.Windows.Forms.Button();
            this.grade_selelection_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Last_name
            // 
            this.Last_name.AutoSize = true;
            this.Last_name.Location = new System.Drawing.Point(56, 153);
            this.Last_name.Name = "Last_name";
            this.Last_name.Size = new System.Drawing.Size(178, 13);
            this.Last_name.TabIndex = 1;
            this.Last_name.Text = "Enter the first letter of your last name";
            // 
            // grade_selelection_groupbox
            // 
            this.grade_selelection_groupbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grade_selelection_groupbox.Controls.Add(this.Senior);
            this.grade_selelection_groupbox.Controls.Add(this.Junior);
            this.grade_selelection_groupbox.Controls.Add(this.Sophomore);
            this.grade_selelection_groupbox.Controls.Add(this.Freshman);
            this.grade_selelection_groupbox.Location = new System.Drawing.Point(45, 12);
            this.grade_selelection_groupbox.Name = "grade_selelection_groupbox";
            this.grade_selelection_groupbox.Size = new System.Drawing.Size(200, 126);
            this.grade_selelection_groupbox.TabIndex = 2;
            this.grade_selelection_groupbox.TabStop = false;
            this.grade_selelection_groupbox.Text = "Select your grade";
            this.grade_selelection_groupbox.Enter += new System.EventHandler(this.grade_selelection_groupbox_Enter);
            // 
            // Senior
            // 
            this.Senior.AutoSize = true;
            this.Senior.Location = new System.Drawing.Point(60, 89);
            this.Senior.Name = "Senior";
            this.Senior.Size = new System.Drawing.Size(55, 17);
            this.Senior.TabIndex = 3;
            this.Senior.TabStop = true;
            this.Senior.Text = "Senior";
            this.Senior.UseVisualStyleBackColor = true;
            // 
            // Junior
            // 
            this.Junior.AutoSize = true;
            this.Junior.Location = new System.Drawing.Point(60, 66);
            this.Junior.Name = "Junior";
            this.Junior.Size = new System.Drawing.Size(53, 17);
            this.Junior.TabIndex = 2;
            this.Junior.TabStop = true;
            this.Junior.Text = "Junior";
            this.Junior.UseVisualStyleBackColor = true;
            // 
            // Sophomore
            // 
            this.Sophomore.AutoSize = true;
            this.Sophomore.Location = new System.Drawing.Point(60, 43);
            this.Sophomore.Name = "Sophomore";
            this.Sophomore.Size = new System.Drawing.Size(79, 17);
            this.Sophomore.TabIndex = 1;
            this.Sophomore.TabStop = true;
            this.Sophomore.Text = "Sophomore";
            this.Sophomore.UseVisualStyleBackColor = true;
            // 
            // Freshman
            // 
            this.Freshman.AutoSize = true;
            this.Freshman.Location = new System.Drawing.Point(60, 20);
            this.Freshman.Name = "Freshman";
            this.Freshman.Size = new System.Drawing.Size(71, 17);
            this.Freshman.TabIndex = 0;
            this.Freshman.TabStop = true;
            this.Freshman.Text = "Freshman";
            this.Freshman.UseVisualStyleBackColor = true;
            // 
            // last_name_textbox
            // 
            this.last_name_textbox.Location = new System.Drawing.Point(93, 181);
            this.last_name_textbox.Name = "last_name_textbox";
            this.last_name_textbox.Size = new System.Drawing.Size(100, 20);
            this.last_name_textbox.TabIndex = 3;
            // 
            // registration_button
            // 
            this.registration_button.Location = new System.Drawing.Point(84, 227);
            this.registration_button.Name = "registration_button";
            this.registration_button.Size = new System.Drawing.Size(119, 23);
            this.registration_button.TabIndex = 4;
            this.registration_button.Text = "When can I register?";
            this.registration_button.UseVisualStyleBackColor = true;
            this.registration_button.Click += new System.EventHandler(this.registration_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.registration_button);
            this.Controls.Add(this.last_name_textbox);
            this.Controls.Add(this.grade_selelection_groupbox);
            this.Controls.Add(this.Last_name);
            this.Name = "Form1";
            this.Text = "Program 2";
            this.grade_selelection_groupbox.ResumeLayout(false);
            this.grade_selelection_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Last_name;
        private System.Windows.Forms.GroupBox grade_selelection_groupbox;
        private System.Windows.Forms.RadioButton Sophomore;
        private System.Windows.Forms.RadioButton Freshman;
        private System.Windows.Forms.RadioButton Senior;
        private System.Windows.Forms.RadioButton Junior;
        private System.Windows.Forms.TextBox last_name_textbox;
        private System.Windows.Forms.Button registration_button;
    }
}

