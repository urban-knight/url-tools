namespace URL_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.selectMap_textBox = new System.Windows.Forms.TextBox();
            this.selectMap_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.outerdataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test_button = new System.Windows.Forms.Button();
            this.options_groupBox = new System.Windows.Forms.GroupBox();
            this.saveOuters_button = new System.Windows.Forms.Button();
            this.entryPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstRedirect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondRedirect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdRedirect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outerdataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.options_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to URL Map File";
            // 
            // selectMap_textBox
            // 
            this.selectMap_textBox.Location = new System.Drawing.Point(133, 18);
            this.selectMap_textBox.Name = "selectMap_textBox";
            this.selectMap_textBox.Size = new System.Drawing.Size(815, 20);
            this.selectMap_textBox.TabIndex = 1;
            // 
            // selectMap_button
            // 
            this.selectMap_button.Location = new System.Drawing.Point(954, 16);
            this.selectMap_button.Name = "selectMap_button";
            this.selectMap_button.Size = new System.Drawing.Size(200, 23);
            this.selectMap_button.TabIndex = 2;
            this.selectMap_button.Text = "Select file";
            this.selectMap_button.UseVisualStyleBackColor = true;
            this.selectMap_button.Click += new System.EventHandler(this.selectMap_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(10, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1148, 507);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.outerdataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1140, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Outer Map";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // outerdataGridView
            // 
            this.outerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outerdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entryPoint,
            this.firstRedirect,
            this.secondRedirect,
            this.thirdRedirect,
            this.endUrl});
            this.outerdataGridView.Location = new System.Drawing.Point(-4, -1);
            this.outerdataGridView.Name = "outerdataGridView";
            this.outerdataGridView.RowHeadersWidth = 40;
            this.outerdataGridView.Size = new System.Drawing.Size(1144, 486);
            this.outerdataGridView.TabIndex = 0;
            this.outerdataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.outerdataGridView_CellValidating);
            this.outerdataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.outerdataGridView_RowsAdded);
            this.outerdataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.outerdataGridView_RowsRemoved);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1140, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inner Map";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 40;
            this.dataGridView2.Size = new System.Drawing.Size(800, 364);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "URL Endpoint";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 400;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Response Header(s)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 226;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Response Code";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(954, 571);
            this.test_button.Name = "test_button";
            this.test_button.Size = new System.Drawing.Size(200, 42);
            this.test_button.TabIndex = 4;
            this.test_button.Text = "Test URLs";
            this.test_button.UseVisualStyleBackColor = true;
            this.test_button.Click += new System.EventHandler(this.test_button_Click);
            // 
            // options_groupBox
            // 
            this.options_groupBox.Controls.Add(this.saveOuters_button);
            this.options_groupBox.Location = new System.Drawing.Point(10, 566);
            this.options_groupBox.Name = "options_groupBox";
            this.options_groupBox.Size = new System.Drawing.Size(938, 48);
            this.options_groupBox.TabIndex = 5;
            this.options_groupBox.TabStop = false;
            this.options_groupBox.Text = "Options";
            this.options_groupBox.Visible = false;
            // 
            // saveOuters_button
            // 
            this.saveOuters_button.Location = new System.Drawing.Point(6, 16);
            this.saveOuters_button.Name = "saveOuters_button";
            this.saveOuters_button.Size = new System.Drawing.Size(170, 23);
            this.saveOuters_button.TabIndex = 6;
            this.saveOuters_button.Text = "Save map";
            this.saveOuters_button.UseVisualStyleBackColor = true;
            this.saveOuters_button.Click += new System.EventHandler(this.saveOuters_button_Click);
            // 
            // entryPoint
            // 
            this.entryPoint.HeaderText = "URL Entry Point";
            this.entryPoint.Name = "entryPoint";
            this.entryPoint.Width = 300;
            // 
            // firstRedirect
            // 
            this.firstRedirect.HeaderText = "First Redirect";
            this.firstRedirect.Name = "firstRedirect";
            this.firstRedirect.ReadOnly = true;
            this.firstRedirect.Width = 200;
            // 
            // secondRedirect
            // 
            this.secondRedirect.HeaderText = "Second Redirect";
            this.secondRedirect.Name = "secondRedirect";
            this.secondRedirect.ReadOnly = true;
            this.secondRedirect.Width = 200;
            // 
            // thirdRedirect
            // 
            this.thirdRedirect.HeaderText = "Third Redirect";
            this.thirdRedirect.Name = "thirdRedirect";
            this.thirdRedirect.ReadOnly = true;
            this.thirdRedirect.Width = 200;
            // 
            // endUrl
            // 
            this.endUrl.HeaderText = "URL End Point";
            this.endUrl.Name = "endUrl";
            this.endUrl.ReadOnly = true;
            this.endUrl.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 626);
            this.Controls.Add(this.options_groupBox);
            this.Controls.Add(this.test_button);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.selectMap_button);
            this.Controls.Add(this.selectMap_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "URL Tools by Hive Studio";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.outerdataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.options_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectMap_textBox;
        private System.Windows.Forms.Button selectMap_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView outerdataGridView;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox options_groupBox;
        private System.Windows.Forms.Button saveOuters_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstRedirect;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondRedirect;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdRedirect;
        private System.Windows.Forms.DataGridViewTextBoxColumn endUrl;
    }
}

