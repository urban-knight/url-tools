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
            this.entryPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstRedirect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondRedirect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdRedirect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.innerdataGridView = new System.Windows.Forms.DataGridView();
            this.test_button = new System.Windows.Forms.Button();
            this.options_groupBox = new System.Windows.Forms.GroupBox();
            this.saveOuters_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.baseURL_comboBox = new System.Windows.Forms.ComboBox();
            this.urlPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resContentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resKeepAlive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resPoweredBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outerdataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.innerdataGridView)).BeginInit();
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
            this.selectMap_textBox.Size = new System.Drawing.Size(961, 20);
            this.selectMap_textBox.TabIndex = 1;
            // 
            // selectMap_button
            // 
            this.selectMap_button.Location = new System.Drawing.Point(1100, 16);
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
            this.tabControl1.Size = new System.Drawing.Size(1296, 507);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.outerdataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1288, 481);
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
            this.outerdataGridView.Size = new System.Drawing.Size(1292, 486);
            this.outerdataGridView.TabIndex = 0;
            this.outerdataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.outerdataGridView_CellValidating);
            this.outerdataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.outerdataGridView_RowsAdded);
            this.outerdataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.outerdataGridView_RowsRemoved);
            this.outerdataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.outerdataGridView_RowValidated);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.baseURL_comboBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.innerdataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1288, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inner Map";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // innerdataGridView
            // 
            this.innerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.innerdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urlPath,
            this.resCode,
            this.resLocation,
            this.resContentType,
            this.resKeepAlive,
            this.resServer,
            this.resPoweredBy});
            this.innerdataGridView.Location = new System.Drawing.Point(-4, 39);
            this.innerdataGridView.Name = "innerdataGridView";
            this.innerdataGridView.RowHeadersWidth = 40;
            this.innerdataGridView.Size = new System.Drawing.Size(1292, 446);
            this.innerdataGridView.TabIndex = 1;
            // 
            // test_button
            // 
            this.test_button.Location = new System.Drawing.Point(1104, 571);
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
            this.options_groupBox.Size = new System.Drawing.Size(1084, 48);
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
            this.saveOuters_button.Click += new System.EventHandler(this.saveMap_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose base-URL:";
            // 
            // baseURL_comboBox
            // 
            this.baseURL_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baseURL_comboBox.FormattingEnabled = true;
            this.baseURL_comboBox.Location = new System.Drawing.Point(119, 11);
            this.baseURL_comboBox.Name = "baseURL_comboBox";
            this.baseURL_comboBox.Size = new System.Drawing.Size(318, 21);
            this.baseURL_comboBox.TabIndex = 3;
            // 
            // urlPath
            // 
            this.urlPath.HeaderText = "URL Endpoint";
            this.urlPath.Name = "urlPath";
            this.urlPath.Width = 400;
            // 
            // resCode
            // 
            this.resCode.HeaderText = "Code";
            this.resCode.Name = "resCode";
            this.resCode.ReadOnly = true;
            this.resCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.resCode.Width = 120;
            // 
            // resLocation
            // 
            this.resLocation.HeaderText = "Location";
            this.resLocation.Name = "resLocation";
            this.resLocation.ReadOnly = true;
            this.resLocation.Width = 300;
            // 
            // resContentType
            // 
            this.resContentType.HeaderText = "Content-Type";
            this.resContentType.Name = "resContentType";
            this.resContentType.ReadOnly = true;
            this.resContentType.Width = 140;
            // 
            // resKeepAlive
            // 
            this.resKeepAlive.HeaderText = "Keep-Alive";
            this.resKeepAlive.Name = "resKeepAlive";
            this.resKeepAlive.ReadOnly = true;
            this.resKeepAlive.Width = 90;
            // 
            // resServer
            // 
            this.resServer.HeaderText = "Server";
            this.resServer.Name = "resServer";
            this.resServer.ReadOnly = true;
            // 
            // resPoweredBy
            // 
            this.resPoweredBy.HeaderText = "Powered By";
            this.resPoweredBy.Name = "resPoweredBy";
            this.resPoweredBy.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 626);
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
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.innerdataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView innerdataGridView;
        private System.Windows.Forms.Button test_button;
        private System.Windows.Forms.GroupBox options_groupBox;
        private System.Windows.Forms.Button saveOuters_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstRedirect;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondRedirect;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdRedirect;
        private System.Windows.Forms.DataGridViewTextBoxColumn endUrl;
        private System.Windows.Forms.ComboBox baseURL_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn resCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn resLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn resContentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn resKeepAlive;
        private System.Windows.Forms.DataGridViewTextBoxColumn resServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn resPoweredBy;
    }
}

