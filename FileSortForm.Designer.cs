
namespace FileSort
{
    partial class FileSortForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileSortForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selectionSortRadioButton = new System.Windows.Forms.RadioButton();
            this.insertSortRadioButton = new System.Windows.Forms.RadioButton();
            this.bubbleSortRadioButton = new System.Windows.Forms.RadioButton();
            this.sortFilebutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sortedListBox = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sort Algorithm";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(156, 33);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(125, 27);
            this.fileNameTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(298, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 29);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.selectionSortRadioButton);
            this.panel1.Controls.Add(this.insertSortRadioButton);
            this.panel1.Controls.Add(this.bubbleSortRadioButton);
            this.panel1.Location = new System.Drawing.Point(156, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 107);
            this.panel1.TabIndex = 3;
            // 
            // selectionSortRadioButton
            // 
            this.selectionSortRadioButton.AutoSize = true;
            this.selectionSortRadioButton.Location = new System.Drawing.Point(4, 71);
            this.selectionSortRadioButton.Name = "selectionSortRadioButton";
            this.selectionSortRadioButton.Size = new System.Drawing.Size(91, 24);
            this.selectionSortRadioButton.TabIndex = 5;
            this.selectionSortRadioButton.TabStop = true;
            this.selectionSortRadioButton.Text = "Selection";
            this.selectionSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // insertSortRadioButton
            // 
            this.insertSortRadioButton.AutoSize = true;
            this.insertSortRadioButton.Location = new System.Drawing.Point(4, 37);
            this.insertSortRadioButton.Name = "insertSortRadioButton";
            this.insertSortRadioButton.Size = new System.Drawing.Size(87, 24);
            this.insertSortRadioButton.TabIndex = 4;
            this.insertSortRadioButton.TabStop = true;
            this.insertSortRadioButton.Text = "Insertion";
            this.insertSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // bubbleSortRadioButton
            // 
            this.bubbleSortRadioButton.AutoSize = true;
            this.bubbleSortRadioButton.Location = new System.Drawing.Point(4, 4);
            this.bubbleSortRadioButton.Name = "bubbleSortRadioButton";
            this.bubbleSortRadioButton.Size = new System.Drawing.Size(77, 24);
            this.bubbleSortRadioButton.TabIndex = 3;
            this.bubbleSortRadioButton.TabStop = true;
            this.bubbleSortRadioButton.Text = "Bubble";
            this.bubbleSortRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortFilebutton
            // 
            this.sortFilebutton.Location = new System.Drawing.Point(156, 180);
            this.sortFilebutton.Name = "sortFilebutton";
            this.sortFilebutton.Size = new System.Drawing.Size(135, 29);
            this.sortFilebutton.TabIndex = 6;
            this.sortFilebutton.Text = "Sort File";
            this.sortFilebutton.UseVisualStyleBackColor = true;
            this.sortFilebutton.Click += new System.EventHandler(this.sortFilebutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sorted Results";
            // 
            // sortedListBox
            // 
            this.sortedListBox.FormattingEnabled = true;
            this.sortedListBox.ItemHeight = 20;
            this.sortedListBox.Location = new System.Drawing.Point(40, 249);
            this.sortedListBox.Name = "sortedListBox";
            this.sortedListBox.Size = new System.Drawing.Size(413, 184);
            this.sortedListBox.TabIndex = 8;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FileSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sortedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sortFilebutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FileSortForm";
            this.Text = "File Sort";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton selectionSortRadioButton;
        private System.Windows.Forms.RadioButton insertSortRadioButton;
        private System.Windows.Forms.RadioButton bubbleSortRadioButton;
        private System.Windows.Forms.Button sortFilebutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox sortedListBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

