namespace BubtAnnexSystem2
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.buttonRoutine = new System.Windows.Forms.Button();
            this.buttonPresentCourse = new System.Windows.Forms.Button();
            this.buttonPreviousCourse = new System.Windows.Forms.Button();
            this.buttonAllCourse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 93);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(773, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bangladesh University of Business and Technology (BUBT)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.buttonAllCourse);
            this.panel2.Controls.Add(this.buttonPreviousCourse);
            this.panel2.Controls.Add(this.buttonPresentCourse);
            this.panel2.Controls.Add(this.buttonRoutine);
            this.panel2.Controls.Add(this.buttonStudent);
            this.panel2.Location = new System.Drawing.Point(99, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(775, 84);
            this.panel2.TabIndex = 5;
            // 
            // buttonStudent
            // 
            this.buttonStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(91)))));
            this.buttonStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudent.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudent.ForeColor = System.Drawing.Color.White;
            this.buttonStudent.Location = new System.Drawing.Point(10, 16);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(121, 48);
            this.buttonStudent.TabIndex = 0;
            this.buttonStudent.Text = "Student Add";
            this.buttonStudent.UseVisualStyleBackColor = false;
            this.buttonStudent.Click += new System.EventHandler(this.ButtonStudent_Click);
            // 
            // buttonRoutine
            // 
            this.buttonRoutine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(91)))));
            this.buttonRoutine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRoutine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoutine.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRoutine.ForeColor = System.Drawing.Color.White;
            this.buttonRoutine.Location = new System.Drawing.Point(164, 16);
            this.buttonRoutine.Name = "buttonRoutine";
            this.buttonRoutine.Size = new System.Drawing.Size(121, 48);
            this.buttonRoutine.TabIndex = 1;
            this.buttonRoutine.Text = "Routine Add";
            this.buttonRoutine.UseVisualStyleBackColor = false;
            this.buttonRoutine.Click += new System.EventHandler(this.ButtonRoutine_Click);
            // 
            // buttonPresentCourse
            // 
            this.buttonPresentCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(91)))));
            this.buttonPresentCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPresentCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPresentCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPresentCourse.ForeColor = System.Drawing.Color.White;
            this.buttonPresentCourse.Location = new System.Drawing.Point(323, 16);
            this.buttonPresentCourse.Name = "buttonPresentCourse";
            this.buttonPresentCourse.Size = new System.Drawing.Size(121, 48);
            this.buttonPresentCourse.TabIndex = 2;
            this.buttonPresentCourse.Text = "Prsent Course Add";
            this.buttonPresentCourse.UseVisualStyleBackColor = false;
            this.buttonPresentCourse.Click += new System.EventHandler(this.ButtonPresentCourse_Click);
            // 
            // buttonPreviousCourse
            // 
            this.buttonPreviousCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(91)))));
            this.buttonPreviousCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPreviousCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreviousCourse.ForeColor = System.Drawing.Color.White;
            this.buttonPreviousCourse.Location = new System.Drawing.Point(481, 16);
            this.buttonPreviousCourse.Name = "buttonPreviousCourse";
            this.buttonPreviousCourse.Size = new System.Drawing.Size(121, 48);
            this.buttonPreviousCourse.TabIndex = 3;
            this.buttonPreviousCourse.Text = "Previous Course Add";
            this.buttonPreviousCourse.UseVisualStyleBackColor = false;
            this.buttonPreviousCourse.Click += new System.EventHandler(this.ButtonPreviousCourse_Click);
            // 
            // buttonAllCourse
            // 
            this.buttonAllCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(44)))), ((int)(((byte)(91)))));
            this.buttonAllCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAllCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllCourse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllCourse.ForeColor = System.Drawing.Color.White;
            this.buttonAllCourse.Location = new System.Drawing.Point(640, 16);
            this.buttonAllCourse.Name = "buttonAllCourse";
            this.buttonAllCourse.Size = new System.Drawing.Size(121, 48);
            this.buttonAllCourse.TabIndex = 4;
            this.buttonAllCourse.Text = "All Course Add";
            this.buttonAllCourse.UseVisualStyleBackColor = false;
            this.buttonAllCourse.Click += new System.EventHandler(this.ButtonAllCourse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(510, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(304, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 186);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(99, 303);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(94, 38);
            this.buttonLogout.TabIndex = 11;
            this.buttonLogout.Text = "Log Out";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 491);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AdminForm";
            this.Text = "Admin Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonAllCourse;
        private System.Windows.Forms.Button buttonPreviousCourse;
        private System.Windows.Forms.Button buttonPresentCourse;
        private System.Windows.Forms.Button buttonRoutine;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.Button buttonLogout;
    }
}