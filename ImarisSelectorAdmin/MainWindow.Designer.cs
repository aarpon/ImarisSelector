namespace ImarisSelectorAdmin
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.buttonImarisPath = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.labelExpl = new System.Windows.Forms.Label();
            this.labelProductsText = new System.Windows.Forms.Label();
            this.checkedListBoxProducts = new System.Windows.Forms.CheckedListBox();
            this.labelProductDescription = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabModules = new System.Windows.Forms.TabPage();
            this.tabTools = new System.Windows.Forms.TabPage();
            this.labelInfo = new System.Windows.Forms.Label();
            this.listCTXTPaths = new System.Windows.Forms.ListBox();
            this.buttonCTXTPathsRemove = new System.Windows.Forms.Button();
            this.buttonCTXTPathsAdd = new System.Windows.Forms.Button();
            this.labelCTXTPaths = new System.Windows.Forms.Label();
            this.maskedTextureCacheSizeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelTextureCacheLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabModules.SuspendLayout();
            this.tabTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonImarisPath
            // 
            this.buttonImarisPath.Location = new System.Drawing.Point(11, 42);
            this.buttonImarisPath.Name = "buttonImarisPath";
            this.buttonImarisPath.Size = new System.Drawing.Size(492, 32);
            this.buttonImarisPath.TabIndex = 0;
            this.buttonImarisPath.Text = "...";
            this.buttonImarisPath.UseVisualStyleBackColor = true;
            this.buttonImarisPath.Click += new System.EventHandler(this.buttonImarisPath_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Location = new System.Drawing.Point(447, 3);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(25, 25);
            this.buttonAbout.TabIndex = 9;
            this.buttonAbout.Text = "A";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(478, 3);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(25, 25);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // labelExpl
            // 
            this.labelExpl.AutoSize = true;
            this.labelExpl.Location = new System.Drawing.Point(11, 15);
            this.labelExpl.Name = "labelExpl";
            this.labelExpl.Size = new System.Drawing.Size(283, 13);
            this.labelExpl.TabIndex = 10;
            this.labelExpl.Text = "Click here to choose the Imaris executable to manage:";
            // 
            // labelProductsText
            // 
            this.labelProductsText.AutoSize = true;
            this.labelProductsText.Location = new System.Drawing.Point(3, 13);
            this.labelProductsText.Name = "labelProductsText";
            this.labelProductsText.Size = new System.Drawing.Size(301, 13);
            this.labelProductsText.TabIndex = 11;
            this.labelProductsText.Text = "Choose the products that will be visible in ImarisSelector:";
            // 
            // checkedListBoxProducts
            // 
            this.checkedListBoxProducts.CheckOnClick = true;
            this.checkedListBoxProducts.FormattingEnabled = true;
            this.checkedListBoxProducts.Location = new System.Drawing.Point(6, 37);
            this.checkedListBoxProducts.Name = "checkedListBoxProducts";
            this.checkedListBoxProducts.Size = new System.Drawing.Size(466, 225);
            this.checkedListBoxProducts.TabIndex = 12;
            this.checkedListBoxProducts.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxProducts_SelectedIndexChanged);
            // 
            // labelProductDescription
            // 
            this.labelProductDescription.AutoSize = true;
            this.labelProductDescription.Location = new System.Drawing.Point(11, 354);
            this.labelProductDescription.Name = "labelProductDescription";
            this.labelProductDescription.Size = new System.Drawing.Size(0, 13);
            this.labelProductDescription.TabIndex = 13;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(14, 381);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(486, 39);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabModules);
            this.tabControl.Controls.Add(this.tabTools);
            this.tabControl.Location = new System.Drawing.Point(14, 81);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(486, 294);
            this.tabControl.TabIndex = 15;
            // 
            // tabModules
            // 
            this.tabModules.Controls.Add(this.labelProductsText);
            this.tabModules.Controls.Add(this.checkedListBoxProducts);
            this.tabModules.Location = new System.Drawing.Point(4, 22);
            this.tabModules.Name = "tabModules";
            this.tabModules.Padding = new System.Windows.Forms.Padding(3);
            this.tabModules.Size = new System.Drawing.Size(478, 268);
            this.tabModules.TabIndex = 0;
            this.tabModules.Text = "Modules";
            this.tabModules.UseVisualStyleBackColor = true;
            // 
            // tabTools
            // 
            this.tabTools.Controls.Add(this.labelInfo);
            this.tabTools.Controls.Add(this.listCTXTPaths);
            this.tabTools.Controls.Add(this.buttonCTXTPathsRemove);
            this.tabTools.Controls.Add(this.buttonCTXTPathsAdd);
            this.tabTools.Controls.Add(this.labelCTXTPaths);
            this.tabTools.Controls.Add(this.maskedTextureCacheSizeTextBox);
            this.tabTools.Controls.Add(this.labelTextureCacheLabel);
            this.tabTools.Location = new System.Drawing.Point(4, 22);
            this.tabTools.Name = "tabTools";
            this.tabTools.Padding = new System.Windows.Forms.Padding(3);
            this.tabTools.Size = new System.Drawing.Size(478, 268);
            this.tabTools.TabIndex = 1;
            this.tabTools.Text = "Tools";
            this.tabTools.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(3, 13);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(278, 13);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Set the values that you want to override for all users:";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelInfo.Click += new System.EventHandler(this.labelInfo_Click);
            // 
            // listCTXTPaths
            // 
            this.listCTXTPaths.FormattingEnabled = true;
            this.listCTXTPaths.Location = new System.Drawing.Point(3, 75);
            this.listCTXTPaths.Name = "listCTXTPaths";
            this.listCTXTPaths.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listCTXTPaths.Size = new System.Drawing.Size(430, 43);
            this.listCTXTPaths.TabIndex = 5;
            // 
            // buttonCTXTPathsRemove
            // 
            this.buttonCTXTPathsRemove.Location = new System.Drawing.Point(439, 96);
            this.buttonCTXTPathsRemove.Name = "buttonCTXTPathsRemove";
            this.buttonCTXTPathsRemove.Size = new System.Drawing.Size(32, 22);
            this.buttonCTXTPathsRemove.TabIndex = 4;
            this.buttonCTXTPathsRemove.Text = "-";
            this.buttonCTXTPathsRemove.UseVisualStyleBackColor = true;
            this.buttonCTXTPathsRemove.Click += new System.EventHandler(this.buttonCTXTPathsRemove_Click);
            // 
            // buttonCTXTPathsAdd
            // 
            this.buttonCTXTPathsAdd.Location = new System.Drawing.Point(439, 75);
            this.buttonCTXTPathsAdd.Name = "buttonCTXTPathsAdd";
            this.buttonCTXTPathsAdd.Size = new System.Drawing.Size(32, 22);
            this.buttonCTXTPathsAdd.TabIndex = 3;
            this.buttonCTXTPathsAdd.Text = "+";
            this.buttonCTXTPathsAdd.UseVisualStyleBackColor = true;
            this.buttonCTXTPathsAdd.Click += new System.EventHandler(this.buttonCTXTPathsAdd_Click);
            // 
            // labelCTXTPaths
            // 
            this.labelCTXTPaths.AutoSize = true;
            this.labelCTXTPaths.Location = new System.Drawing.Point(3, 60);
            this.labelCTXTPaths.Name = "labelCTXTPaths";
            this.labelCTXTPaths.Size = new System.Drawing.Size(131, 13);
            this.labelCTXTPaths.TabIndex = 2;
            this.labelCTXTPaths.Text = "Custom tools: XT folders";
            this.labelCTXTPaths.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maskedTextureCacheSizeTextBox
            // 
            this.maskedTextureCacheSizeTextBox.Location = new System.Drawing.Point(371, 40);
            this.maskedTextureCacheSizeTextBox.Mask = "00000";
            this.maskedTextureCacheSizeTextBox.Name = "maskedTextureCacheSizeTextBox";
            this.maskedTextureCacheSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.maskedTextureCacheSizeTextBox.TabIndex = 1;
            this.maskedTextureCacheSizeTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // labelTextureCacheLabel
            // 
            this.labelTextureCacheLabel.AutoSize = true;
            this.labelTextureCacheLabel.Location = new System.Drawing.Point(3, 40);
            this.labelTextureCacheLabel.Name = "labelTextureCacheLabel";
            this.labelTextureCacheLabel.Size = new System.Drawing.Size(205, 13);
            this.labelTextureCacheLabel.TabIndex = 0;
            this.labelTextureCacheLabel.Text = "Graphics card: texture cache label (MB)";
            this.labelTextureCacheLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTextureCacheLabel.Click += new System.EventHandler(this.labelTextureCacheLabel_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 432);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelProductDescription);
            this.Controls.Add(this.labelExpl);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonImarisPath);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "ImarisSelector :: Admin";
            this.tabControl.ResumeLayout(false);
            this.tabModules.ResumeLayout(false);
            this.tabModules.PerformLayout();
            this.tabTools.ResumeLayout(false);
            this.tabTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonImarisPath;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Label labelExpl;
        private System.Windows.Forms.Label labelProductsText;
        private System.Windows.Forms.CheckedListBox checkedListBoxProducts;
        private System.Windows.Forms.Label labelProductDescription;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabModules;
        private System.Windows.Forms.TabPage tabTools;
        private System.Windows.Forms.Label labelTextureCacheLabel;
        private System.Windows.Forms.MaskedTextBox maskedTextureCacheSizeTextBox;
        private System.Windows.Forms.Label labelCTXTPaths;
        private System.Windows.Forms.ListBox listCTXTPaths;
        private System.Windows.Forms.Button buttonCTXTPathsRemove;
        private System.Windows.Forms.Button buttonCTXTPathsAdd;
        private System.Windows.Forms.Label labelInfo;
    }
}

