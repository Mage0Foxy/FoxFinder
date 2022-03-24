namespace FoxFinder
{
    partial class Add_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Edit));
            this.IMG_Add = new System.Windows.Forms.PictureBox();
            this.URL = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Box_Name = new System.Windows.Forms.TextBox();
            this.category_Media = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IMG_Add
            // 
            this.IMG_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.IMG_Add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IMG_Add.Location = new System.Drawing.Point(12, 12);
            this.IMG_Add.Name = "IMG_Add";
            this.IMG_Add.Size = new System.Drawing.Size(150, 150);
            this.IMG_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IMG_Add.TabIndex = 0;
            this.IMG_Add.TabStop = false;
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(451, 12);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(169, 23);
            this.URL.TabIndex = 1;
            this.URL.Text = "URL";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(168, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(277, 101);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Description";
            // 
            // Box_Name
            // 
            this.Box_Name.Location = new System.Drawing.Point(168, 12);
            this.Box_Name.Name = "Box_Name";
            this.Box_Name.Size = new System.Drawing.Size(277, 23);
            this.Box_Name.TabIndex = 4;
            this.Box_Name.Text = "Name";
            // 
            // category_Media
            // 
            this.category_Media.FormattingEnabled = true;
            this.category_Media.Location = new System.Drawing.Point(626, 12);
            this.category_Media.Name = "category_Media";
            this.category_Media.Size = new System.Drawing.Size(121, 23);
            this.category_Media.TabIndex = 5;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(626, 41);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 23);
            this.category.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(666, 352);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Add_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.category);
            this.Controls.Add(this.category_Media);
            this.Controls.Add(this.Box_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.IMG_Add);
            this.Name = "Add_Edit";
            this.Text = "Add_Edit";
            ((System.ComponentModel.ISupportInitialize)(this.IMG_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox IMG_Add;
        private TextBox URL;
        private RichTextBox richTextBox1;
        private Label label1;
        private TextBox Box_Name;
        private ComboBox category_Media;
        private ComboBox category;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}