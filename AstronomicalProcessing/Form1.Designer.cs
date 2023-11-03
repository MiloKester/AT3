namespace AstronomicalProcessing
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
            this.components = new System.ComponentModel.Container();
            this.ListBoxDisplay = new System.Windows.Forms.ListBox();
            this.textBox_Entry = new System.Windows.Forms.TextBox();
            this.Btn_BinSearch = new System.Windows.Forms.Button();
            this.Btn_Sort = new System.Windows.Forms.Button();
            this.Btn_InsertData = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip_Message = new System.Windows.Forms.ToolStripStatusLabel();
            this.Btn_ClearData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_MidEx = new System.Windows.Forms.Button();
            this.Btn_Mode = new System.Windows.Forms.Button();
            this.Btn_Ave = new System.Windows.Forms.Button();
            this.Btn_Range = new System.Windows.Forms.Button();
            this.Btn_SeqSearch = new System.Windows.Forms.Button();
            this.textBox_MidEx = new System.Windows.Forms.TextBox();
            this.Maths = new System.Windows.Forms.GroupBox();
            this.textBox_Range = new System.Windows.Forms.TextBox();
            this.textBox_Ave = new System.Windows.Forms.TextBox();
            this.textBox_Mode = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Maths.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxDisplay
            // 
            this.ListBoxDisplay.FormattingEnabled = true;
            this.ListBoxDisplay.Location = new System.Drawing.Point(6, 19);
            this.ListBoxDisplay.Name = "ListBoxDisplay";
            this.ListBoxDisplay.Size = new System.Drawing.Size(146, 316);
            this.ListBoxDisplay.TabIndex = 0;
            this.toolTip.SetToolTip(this.ListBoxDisplay, "Displays Data ");
            this.ListBoxDisplay.SelectedIndexChanged += new System.EventHandler(this.ListBoxDisplay_SelectedIndexChanged);
            // 
            // textBox_Entry
            // 
            this.textBox_Entry.Location = new System.Drawing.Point(7, 19);
            this.textBox_Entry.Name = "textBox_Entry";
            this.textBox_Entry.Size = new System.Drawing.Size(145, 20);
            this.textBox_Entry.TabIndex = 1;
            this.toolTip.SetToolTip(this.textBox_Entry, "Edit or Search for Values Here");
            // 
            // Btn_BinSearch
            // 
            this.Btn_BinSearch.Location = new System.Drawing.Point(6, 16);
            this.Btn_BinSearch.Name = "Btn_BinSearch";
            this.Btn_BinSearch.Size = new System.Drawing.Size(125, 23);
            this.Btn_BinSearch.TabIndex = 2;
            this.Btn_BinSearch.Text = "Binary Search";
            this.toolTip.SetToolTip(this.Btn_BinSearch, "Uses Binary Search to Find Specificed Value\r\n\r\nEnter Value to Search for in Input" +
        "\r\nPress Search");
            this.Btn_BinSearch.UseVisualStyleBackColor = true;
            this.Btn_BinSearch.Click += new System.EventHandler(this.Btn_BinSearch_Click);
            // 
            // Btn_Sort
            // 
            this.Btn_Sort.Location = new System.Drawing.Point(6, 74);
            this.Btn_Sort.Name = "Btn_Sort";
            this.Btn_Sort.Size = new System.Drawing.Size(125, 23);
            this.Btn_Sort.TabIndex = 3;
            this.Btn_Sort.Text = "Sort Data Set";
            this.toolTip.SetToolTip(this.Btn_Sort, "Sort the Data Numerically From Smallest to Largest");
            this.Btn_Sort.UseVisualStyleBackColor = true;
            this.Btn_Sort.Click += new System.EventHandler(this.Btn_Sort_Click);
            // 
            // Btn_InsertData
            // 
            this.Btn_InsertData.Location = new System.Drawing.Point(6, 16);
            this.Btn_InsertData.Name = "Btn_InsertData";
            this.Btn_InsertData.Size = new System.Drawing.Size(125, 23);
            this.Btn_InsertData.TabIndex = 0;
            this.Btn_InsertData.Text = "Add Data Set";
            this.toolTip.SetToolTip(this.Btn_InsertData, "Add a New Data Set to Program.\r\nWill Also Clear Maths and Input");
            this.Btn_InsertData.Click += new System.EventHandler(this.Btn_InsertData_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Location = new System.Drawing.Point(6, 45);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(125, 23);
            this.Btn_Edit.TabIndex = 6;
            this.Btn_Edit.Text = "Edit Data Point";
            this.toolTip.SetToolTip(this.Btn_Edit, "Edit Any Value from Data Box \r\n\r\nSelect Value from Data Box\r\nMake Correction in I" +
        "nput\r\nPress Edit");
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusStrip_Message});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(478, 22);
            this.statusStrip1.TabIndex = 20;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // statusStrip_Message
            // 
            this.statusStrip_Message.Name = "statusStrip_Message";
            this.statusStrip_Message.Size = new System.Drawing.Size(0, 17);
            // 
            // Btn_ClearData
            // 
            this.Btn_ClearData.Location = new System.Drawing.Point(6, 19);
            this.Btn_ClearData.Name = "Btn_ClearData";
            this.Btn_ClearData.Size = new System.Drawing.Size(125, 23);
            this.Btn_ClearData.TabIndex = 7;
            this.Btn_ClearData.Text = "Reset Program";
            this.toolTip.SetToolTip(this.Btn_ClearData, "Fully Resets Program (Data Box, Input Box, Maths)");
            this.Btn_ClearData.UseVisualStyleBackColor = true;
            this.Btn_ClearData.Click += new System.EventHandler(this.Btn_ClearData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_ClearData);
            this.groupBox1.Location = new System.Drawing.Point(177, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 51);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danger Zone";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_InsertData);
            this.groupBox2.Controls.Add(this.Btn_Sort);
            this.groupBox2.Controls.Add(this.Btn_Edit);
            this.groupBox2.Location = new System.Drawing.Point(177, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(137, 108);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_Entry);
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 50);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ListBoxDisplay);
            this.groupBox4.Location = new System.Drawing.Point(13, 69);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 346);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data";
            // 
            // Btn_MidEx
            // 
            this.Btn_MidEx.Location = new System.Drawing.Point(6, 19);
            this.Btn_MidEx.Name = "Btn_MidEx";
            this.Btn_MidEx.Size = new System.Drawing.Size(125, 23);
            this.Btn_MidEx.TabIndex = 12;
            this.Btn_MidEx.Text = "Calculate Mid-Extreme";
            this.toolTip.SetToolTip(this.Btn_MidEx, "Finds Mid-Extreme of the Data \r\n\r\nMid-Extreme is the Sum of the Largest and Small" +
        "est Values Divided by Two");
            this.Btn_MidEx.UseVisualStyleBackColor = true;
            this.Btn_MidEx.Click += new System.EventHandler(this.Btn_MidEx_Click);
            // 
            // Btn_Mode
            // 
            this.Btn_Mode.Location = new System.Drawing.Point(6, 48);
            this.Btn_Mode.Name = "Btn_Mode";
            this.Btn_Mode.Size = new System.Drawing.Size(125, 23);
            this.Btn_Mode.TabIndex = 13;
            this.Btn_Mode.Text = "Calculate Mode";
            this.toolTip.SetToolTip(this.Btn_Mode, "Finds Mode of the Data \r\n\r\nMode is the Most Reocurring Value");
            this.Btn_Mode.UseVisualStyleBackColor = true;
            this.Btn_Mode.Click += new System.EventHandler(this.Btn_Mode_Click);
            // 
            // Btn_Ave
            // 
            this.Btn_Ave.Location = new System.Drawing.Point(6, 77);
            this.Btn_Ave.Name = "Btn_Ave";
            this.Btn_Ave.Size = new System.Drawing.Size(125, 23);
            this.Btn_Ave.TabIndex = 14;
            this.Btn_Ave.Text = "Calculate Average";
            this.toolTip.SetToolTip(this.Btn_Ave, "Finds Average of the Data \r\n\r\nAverage is the Sum of All Values Divided by the Num" +
        "ber of Values");
            this.Btn_Ave.UseVisualStyleBackColor = true;
            this.Btn_Ave.Click += new System.EventHandler(this.Btn_Ave_Click);
            // 
            // Btn_Range
            // 
            this.Btn_Range.Location = new System.Drawing.Point(6, 106);
            this.Btn_Range.Name = "Btn_Range";
            this.Btn_Range.Size = new System.Drawing.Size(125, 23);
            this.Btn_Range.TabIndex = 15;
            this.Btn_Range.Text = "Calculate Range";
            this.toolTip.SetToolTip(this.Btn_Range, "Finds Range of the Data \r\n\r\nRange is the Smallest Value Subtracted from the Large" +
        "st Value\r\n");
            this.Btn_Range.UseVisualStyleBackColor = true;
            this.Btn_Range.Click += new System.EventHandler(this.Btn_Range_Click);
            // 
            // Btn_SeqSearch
            // 
            this.Btn_SeqSearch.Location = new System.Drawing.Point(6, 45);
            this.Btn_SeqSearch.Name = "Btn_SeqSearch";
            this.Btn_SeqSearch.Size = new System.Drawing.Size(125, 23);
            this.Btn_SeqSearch.TabIndex = 16;
            this.Btn_SeqSearch.Text = "Sequential Search";
            this.toolTip.SetToolTip(this.Btn_SeqSearch, "Uses Sequential Search to Find Specificed Value\r\n\r\nEnter Value to Search for in I" +
        "nput\r\nPress Search");
            this.Btn_SeqSearch.UseVisualStyleBackColor = true;
            this.Btn_SeqSearch.Click += new System.EventHandler(this.Btn_SeqSearch_Click);
            // 
            // textBox_MidEx
            // 
            this.textBox_MidEx.Location = new System.Drawing.Point(149, 19);
            this.textBox_MidEx.Name = "textBox_MidEx";
            this.textBox_MidEx.ReadOnly = true;
            this.textBox_MidEx.Size = new System.Drawing.Size(125, 20);
            this.textBox_MidEx.TabIndex = 17;
            // 
            // Maths
            // 
            this.Maths.Controls.Add(this.textBox_Range);
            this.Maths.Controls.Add(this.Btn_MidEx);
            this.Maths.Controls.Add(this.textBox_Ave);
            this.Maths.Controls.Add(this.Btn_Mode);
            this.Maths.Controls.Add(this.textBox_Mode);
            this.Maths.Controls.Add(this.Btn_Ave);
            this.Maths.Controls.Add(this.Btn_Range);
            this.Maths.Controls.Add(this.textBox_MidEx);
            this.Maths.Location = new System.Drawing.Point(177, 127);
            this.Maths.Name = "Maths";
            this.Maths.Size = new System.Drawing.Size(280, 141);
            this.Maths.TabIndex = 18;
            this.Maths.TabStop = false;
            this.Maths.Text = "Maths";
            // 
            // textBox_Range
            // 
            this.textBox_Range.Location = new System.Drawing.Point(149, 106);
            this.textBox_Range.Name = "textBox_Range";
            this.textBox_Range.ReadOnly = true;
            this.textBox_Range.Size = new System.Drawing.Size(124, 20);
            this.textBox_Range.TabIndex = 22;
            // 
            // textBox_Ave
            // 
            this.textBox_Ave.Location = new System.Drawing.Point(149, 77);
            this.textBox_Ave.Name = "textBox_Ave";
            this.textBox_Ave.ReadOnly = true;
            this.textBox_Ave.Size = new System.Drawing.Size(124, 20);
            this.textBox_Ave.TabIndex = 21;
            // 
            // textBox_Mode
            // 
            this.textBox_Mode.Location = new System.Drawing.Point(149, 48);
            this.textBox_Mode.Name = "textBox_Mode";
            this.textBox_Mode.ReadOnly = true;
            this.textBox_Mode.Size = new System.Drawing.Size(125, 20);
            this.textBox_Mode.TabIndex = 20;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Btn_BinSearch);
            this.groupBox5.Controls.Add(this.Btn_SeqSearch);
            this.groupBox5.Location = new System.Drawing.Point(320, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(137, 108);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search";
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 300;
            this.toolTip.AutoPopDelay = 999999;
            this.toolTip.InitialDelay = 300;
            this.toolTip.ReshowDelay = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 445);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Maths);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Astronomical Processing";
            this.toolTip.SetToolTip(this, "Get the Average of the Data set.\r\nAverage is the sum of all values, divided by th" +
        "e number of values");
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.Maths.ResumeLayout(false);
            this.Maths.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxDisplay;
        private System.Windows.Forms.TextBox textBox_Entry;
        private System.Windows.Forms.Button Btn_BinSearch;
        private System.Windows.Forms.Button Btn_Sort;
        private System.Windows.Forms.Button Btn_InsertData;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_Message;
        private System.Windows.Forms.Button Btn_ClearData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Btn_MidEx;
        private System.Windows.Forms.Button Btn_Mode;
        private System.Windows.Forms.Button Btn_Ave;
        private System.Windows.Forms.Button Btn_Range;
        private System.Windows.Forms.Button Btn_SeqSearch;
        private System.Windows.Forms.TextBox textBox_MidEx;
        private System.Windows.Forms.GroupBox Maths;
        private System.Windows.Forms.TextBox textBox_Range;
        private System.Windows.Forms.TextBox textBox_Ave;
        private System.Windows.Forms.TextBox textBox_Mode;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

