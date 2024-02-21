namespace Classroom
{
    partial class Classroom_Form
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
            this.classroom_DataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.date_TextBox = new System.Windows.Forms.TextBox();
            this.room_TextBox = new System.Windows.Forms.TextBox();
            this.class_TextBox = new System.Windows.Forms.TextBox();
            this.teacher_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.search_TextBox = new System.Windows.Forms.TextBox();
            this.exit_Button = new System.Windows.Forms.Button();
            this.saveRAF_Button = new System.Windows.Forms.Button();
            this.find_Button = new System.Windows.Forms.Button();
            this.sort_Button = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.classroom_DataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // classroom_DataGridView
            // 
            this.classroom_DataGridView.BackgroundColor = System.Drawing.Color.White;
            this.classroom_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classroom_DataGridView.Location = new System.Drawing.Point(31, 81);
            this.classroom_DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.classroom_DataGridView.Name = "classroom_DataGridView";
            this.classroom_DataGridView.RowHeadersWidth = 62;
            this.classroom_DataGridView.RowTemplate.Height = 28;
            this.classroom_DataGridView.Size = new System.Drawing.Size(1128, 499);
            this.classroom_DataGridView.TabIndex = 1;
            this.classroom_DataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.classroom_DataGridView_CellValueChanged_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1185, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.date_TextBox);
            this.panel1.Controls.Add(this.room_TextBox);
            this.panel1.Controls.Add(this.class_TextBox);
            this.panel1.Controls.Add(this.teacher_TextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 50);
            this.panel1.TabIndex = 3;
            // 
            // date_TextBox
            // 
            this.date_TextBox.Location = new System.Drawing.Point(973, 19);
            this.date_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.date_TextBox.Name = "date_TextBox";
            this.date_TextBox.Size = new System.Drawing.Size(125, 20);
            this.date_TextBox.TabIndex = 8;
            // 
            // room_TextBox
            // 
            this.room_TextBox.Location = new System.Drawing.Point(691, 22);
            this.room_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.room_TextBox.Name = "room_TextBox";
            this.room_TextBox.Size = new System.Drawing.Size(82, 20);
            this.room_TextBox.TabIndex = 7;
            // 
            // class_TextBox
            // 
            this.class_TextBox.Location = new System.Drawing.Point(409, 23);
            this.class_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.class_TextBox.Name = "class_TextBox";
            this.class_TextBox.Size = new System.Drawing.Size(82, 20);
            this.class_TextBox.TabIndex = 6;
            // 
            // teacher_TextBox
            // 
            this.teacher_TextBox.Location = new System.Drawing.Point(82, 20);
            this.teacher_TextBox.Margin = new System.Windows.Forms.Padding(2);
            this.teacher_TextBox.Name = "teacher_TextBox";
            this.teacher_TextBox.Size = new System.Drawing.Size(107, 20);
            this.teacher_TextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(922, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(633, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Teacher:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1128, 1);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.UseMnemonic = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.search_TextBox);
            this.panel2.Controls.Add(this.exit_Button);
            this.panel2.Controls.Add(this.saveRAF_Button);
            this.panel2.Controls.Add(this.find_Button);
            this.panel2.Controls.Add(this.sort_Button);
            this.panel2.Controls.Add(this.save_Button);
            this.panel2.Controls.Add(this.clear_Button);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(31, 584);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 74);
            this.panel2.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(601, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(525, 1);
            this.label9.TabIndex = 11;
            this.label9.Text = "label9";
            this.label9.UseMnemonic = false;
            // 
            // search_TextBox
            // 
            this.search_TextBox.Location = new System.Drawing.Point(484, 33);
            this.search_TextBox.Multiline = true;
            this.search_TextBox.Name = "search_TextBox";
            this.search_TextBox.Size = new System.Drawing.Size(162, 27);
            this.search_TextBox.TabIndex = 10;
            // 
            // exit_Button
            // 
            this.exit_Button.BackColor = System.Drawing.SystemColors.Info;
            this.exit_Button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(978, 31);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(110, 27);
            this.exit_Button.TabIndex = 9;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = false;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // saveRAF_Button
            // 
            this.saveRAF_Button.BackColor = System.Drawing.SystemColors.Info;
            this.saveRAF_Button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveRAF_Button.Location = new System.Drawing.Point(825, 31);
            this.saveRAF_Button.Name = "saveRAF_Button";
            this.saveRAF_Button.Size = new System.Drawing.Size(110, 27);
            this.saveRAF_Button.TabIndex = 8;
            this.saveRAF_Button.Text = "Save RAF";
            this.saveRAF_Button.UseVisualStyleBackColor = false;
            this.saveRAF_Button.Click += new System.EventHandler(this.saveRAF_Button_Click);
            // 
            // find_Button
            // 
            this.find_Button.BackColor = System.Drawing.SystemColors.Info;
            this.find_Button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_Button.Location = new System.Drawing.Point(672, 31);
            this.find_Button.Name = "find_Button";
            this.find_Button.Size = new System.Drawing.Size(110, 27);
            this.find_Button.TabIndex = 7;
            this.find_Button.Text = "Find";
            this.find_Button.UseVisualStyleBackColor = false;
            this.find_Button.Click += new System.EventHandler(this.find_Button_Click);
            // 
            // sort_Button
            // 
            this.sort_Button.BackColor = System.Drawing.SystemColors.Info;
            this.sort_Button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sort_Button.Location = new System.Drawing.Point(338, 31);
            this.sort_Button.Name = "sort_Button";
            this.sort_Button.Size = new System.Drawing.Size(110, 27);
            this.sort_Button.TabIndex = 6;
            this.sort_Button.Text = "Sort";
            this.sort_Button.UseVisualStyleBackColor = false;
            this.sort_Button.Click += new System.EventHandler(this.sort_Button_Click);
            // 
            // save_Button
            // 
            this.save_Button.BackColor = System.Drawing.SystemColors.Info;
            this.save_Button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Button.Location = new System.Drawing.Point(171, 31);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(110, 27);
            this.save_Button.TabIndex = 5;
            this.save_Button.Text = "Save Changes";
            this.save_Button.UseVisualStyleBackColor = false;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.BackColor = System.Drawing.SystemColors.Info;
            this.clear_Button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(15, 31);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(99, 27);
            this.clear_Button.TabIndex = 4;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = false;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(545, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Search";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(596, -2);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(530, 1);
            this.label7.TabIndex = 2;
            this.label7.Text = "label7";
            this.label7.UseMnemonic = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-2, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(542, 1);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            this.label6.UseMnemonic = false;
            // 
            // Classroom_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 669);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.classroom_DataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Classroom_Form";
            this.Text = "Classroom Plan";
            ((System.ComponentModel.ISupportInitialize)(this.classroom_DataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView classroom_DataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox date_TextBox;
        private System.Windows.Forms.TextBox room_TextBox;
        private System.Windows.Forms.TextBox class_TextBox;
        private System.Windows.Forms.TextBox teacher_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox search_TextBox;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Button saveRAF_Button;
        private System.Windows.Forms.Button find_Button;
        private System.Windows.Forms.Button sort_Button;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label9;
    }
}

