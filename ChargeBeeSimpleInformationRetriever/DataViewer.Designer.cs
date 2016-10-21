namespace ChargeBeeSimpleInformationRetriever
{
    partial class DataViewer
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
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.loadData = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SiteUrl = new System.Windows.Forms.TextBox();
            this.ApiKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ApiKeyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.ItemHeight = 20;
            this.CustomerList.Location = new System.Drawing.Point(273, 12);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(508, 504);
            this.CustomerList.TabIndex = 0;
            this.CustomerList.SelectedIndexChanged += new System.EventHandler(this.CustomerList_SelectedIndexChanged);
            // 
            // loadData
            // 
            this.loadData.Location = new System.Drawing.Point(38, 60);
            this.loadData.Name = "loadData";
            this.loadData.Size = new System.Drawing.Size(193, 47);
            this.loadData.TabIndex = 1;
            this.loadData.Text = "Fetch data";
            this.loadData.UseVisualStyleBackColor = true;
            this.loadData.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Save List Item to Xml";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(38, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Save Data to JSON";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 47);
            this.button4.TabIndex = 4;
            this.button4.Text = "Save All to XML";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SiteUrl
            // 
            this.SiteUrl.Location = new System.Drawing.Point(57, 372);
            this.SiteUrl.Name = "SiteUrl";
            this.SiteUrl.Size = new System.Drawing.Size(143, 26);
            this.SiteUrl.TabIndex = 5;
            this.SiteUrl.Text = "dummy-test";
            // 
            // ApiKey
            // 
            this.ApiKey.Location = new System.Drawing.Point(57, 443);
            this.ApiKey.Name = "ApiKey";
            this.ApiKey.Size = new System.Drawing.Size(143, 26);
            this.ApiKey.TabIndex = 6;
            this.ApiKey.Text = "test_CAoGvnUyYyRVr09uj2NUhZm0l6YQewm0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Site";
            // 
            // ApiKeyLabel
            // 
            this.ApiKeyLabel.AutoSize = true;
            this.ApiKeyLabel.Location = new System.Drawing.Point(95, 420);
            this.ApiKeyLabel.Name = "ApiKeyLabel";
            this.ApiKeyLabel.Size = new System.Drawing.Size(62, 20);
            this.ApiKeyLabel.TabIndex = 8;
            this.ApiKeyLabel.Text = "Api Key";
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 533);
            this.Controls.Add(this.ApiKeyLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApiKey);
            this.Controls.Add(this.SiteUrl);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.loadData);
            this.Controls.Add(this.CustomerList);
            this.Name = "DataViewer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CustomerList;
        private System.Windows.Forms.Button loadData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox SiteUrl;
        private System.Windows.Forms.TextBox ApiKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ApiKeyLabel;
    }
}

