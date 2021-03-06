namespace Termie
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
            this.textboxStatus = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClearScreen = new System.Windows.Forms.Button();
            this.checkboxToggleAutoScroll = new System.Windows.Forms.CheckBox();
            this.comboboxSend = new System.Windows.Forms.ComboBox();
            this.labelSend = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.textboxFilter = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonSTOP = new System.Windows.Forms.Button();
            this.buttonSTART = new System.Windows.Forms.Button();
            this.outputList = new System.Windows.Forms.ListBox();
            this.buttonSendFile = new System.Windows.Forms.Button();
            this.SettingsFormMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutFormMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxStatus
            // 
            this.textboxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxStatus.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxStatus.Location = new System.Drawing.Point(74, 11);
            this.textboxStatus.Name = "textboxStatus";
            this.textboxStatus.ReadOnly = true;
            this.textboxStatus.Size = new System.Drawing.Size(449, 22);
            this.textboxStatus.TabIndex = 0;
            this.textboxStatus.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsFormMenuItem,
            this.AboutFormMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClearScreen);
            this.panel1.Controls.Add(this.checkboxToggleAutoScroll);
            this.panel1.Controls.Add(this.comboboxSend);
            this.panel1.Controls.Add(this.buttonSendFile);
            this.panel1.Controls.Add(this.labelSend);
            this.panel1.Controls.Add(this.buttonSend);
            this.panel1.Controls.Add(this.labelFilter);
            this.panel1.Controls.Add(this.textboxFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 104);
            this.panel1.TabIndex = 4;
            // 
            // buttonClearScreen
            // 
            this.buttonClearScreen.Location = new System.Drawing.Point(73, 64);
            this.buttonClearScreen.Name = "buttonClearScreen";
            this.buttonClearScreen.Size = new System.Drawing.Size(133, 23);
            this.buttonClearScreen.TabIndex = 9;
            this.buttonClearScreen.Text = "Clear Screen";
            this.buttonClearScreen.UseVisualStyleBackColor = true;
            this.buttonClearScreen.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkboxToggleAutoScroll
            // 
            this.checkboxToggleAutoScroll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkboxToggleAutoScroll.AutoSize = true;
            this.checkboxToggleAutoScroll.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxToggleAutoScroll.Location = new System.Drawing.Point(541, 10);
            this.checkboxToggleAutoScroll.Name = "checkboxToggleAutoScroll";
            this.checkboxToggleAutoScroll.Size = new System.Drawing.Size(145, 18);
            this.checkboxToggleAutoScroll.TabIndex = 8;
            this.checkboxToggleAutoScroll.Text = "Toggle AutoScroll";
            this.checkboxToggleAutoScroll.UseVisualStyleBackColor = true;
            this.checkboxToggleAutoScroll.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboboxSend
            // 
            this.comboboxSend.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboboxSend.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboboxSend.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxSend.FormattingEnabled = true;
            this.comboboxSend.Location = new System.Drawing.Point(73, 36);
            this.comboboxSend.Name = "comboboxSend";
            this.comboboxSend.Size = new System.Drawing.Size(461, 22);
            this.comboboxSend.TabIndex = 5;
            // 
            // labelSend
            // 
            this.labelSend.AutoSize = true;
            this.labelSend.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSend.Location = new System.Drawing.Point(26, 39);
            this.labelSend.Name = "labelSend";
            this.labelSend.Size = new System.Drawing.Size(42, 14);
            this.labelSend.TabIndex = 11;
            this.labelSend.Text = "Send:";
            // 
            // buttonSend
            // 
            this.buttonSend.Font = new System.Drawing.Font("Wingdings 3", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonSend.Location = new System.Drawing.Point(541, 34);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(34, 24);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(12, 11);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(56, 14);
            this.labelFilter.TabIndex = 9;
            this.labelFilter.Text = "Filter:";
            // 
            // textboxFilter
            // 
            this.textboxFilter.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxFilter.Location = new System.Drawing.Point(73, 8);
            this.textboxFilter.Name = "textboxFilter";
            this.textboxFilter.Size = new System.Drawing.Size(461, 22);
            this.textboxFilter.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelStatus);
            this.panel2.Controls.Add(this.buttonSTOP);
            this.panel2.Controls.Add(this.buttonSTART);
            this.panel2.Controls.Add(this.textboxStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 44);
            this.panel2.TabIndex = 5;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(12, 14);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(56, 14);
            this.labelStatus.TabIndex = 10;
            this.labelStatus.Text = "Status:";
            // 
            // buttonSTOP
            // 
            this.buttonSTOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSTOP.BackColor = System.Drawing.Color.Red;
            this.buttonSTOP.ForeColor = System.Drawing.Color.White;
            this.buttonSTOP.Location = new System.Drawing.Point(611, 10);
            this.buttonSTOP.Name = "buttonSTOP";
            this.buttonSTOP.Size = new System.Drawing.Size(75, 23);
            this.buttonSTOP.TabIndex = 2;
            this.buttonSTOP.Text = "STOP";
            this.buttonSTOP.UseVisualStyleBackColor = false;
            this.buttonSTOP.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSTART
            // 
            this.buttonSTART.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSTART.BackColor = System.Drawing.Color.Green;
            this.buttonSTART.ForeColor = System.Drawing.Color.White;
            this.buttonSTART.Location = new System.Drawing.Point(530, 10);
            this.buttonSTART.Name = "buttonSTART";
            this.buttonSTART.Size = new System.Drawing.Size(75, 23);
            this.buttonSTART.TabIndex = 1;
            this.buttonSTART.Text = "START";
            this.buttonSTART.UseVisualStyleBackColor = false;
            this.buttonSTART.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputList
            // 
            this.outputList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputList.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputList.FormattingEnabled = true;
            this.outputList.HorizontalScrollbar = true;
            this.outputList.IntegralHeight = false;
            this.outputList.Location = new System.Drawing.Point(0, 68);
            this.outputList.Name = "outputList";
            this.outputList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.outputList.Size = new System.Drawing.Size(694, 293);
            this.outputList.TabIndex = 3;
            // 
            // buttonSendFile
            // 
            this.buttonSendFile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendFile.Image = global::Termie.Properties.Resources.page_go;
            this.buttonSendFile.Location = new System.Drawing.Point(581, 34);
            this.buttonSendFile.Name = "buttonSendFile";
            this.buttonSendFile.Size = new System.Drawing.Size(101, 24);
            this.buttonSendFile.TabIndex = 7;
            this.buttonSendFile.Text = "SendFile";
            this.buttonSendFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSendFile.UseVisualStyleBackColor = true;
            this.buttonSendFile.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // SettingsFormMenuItem
            // 
            this.SettingsFormMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsFormMenuItem.Image = global::Termie.Properties.Resources.cog;
            this.SettingsFormMenuItem.Name = "SettingsFormMenuItem";
            this.SettingsFormMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.SettingsFormMenuItem.Size = new System.Drawing.Size(91, 20);
            this.SettingsFormMenuItem.Text = "&Settings";
            this.SettingsFormMenuItem.Click += new System.EventHandler(this.serialPortSettingsToolStripMenuItem_Click);
            // 
            // AboutFormMenuItem
            // 
            this.AboutFormMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutFormMenuItem.Image = global::Termie.Properties.Resources.information;
            this.AboutFormMenuItem.Name = "AboutFormMenuItem";
            this.AboutFormMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.AboutFormMenuItem.Size = new System.Drawing.Size(70, 20);
            this.AboutFormMenuItem.Text = "&About";
            this.AboutFormMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 465);
            this.Controls.Add(this.outputList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(710, 159);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termie2";
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

        private System.Windows.Forms.TextBox textboxStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsFormMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutFormMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboboxSend;
        private System.Windows.Forms.Button buttonSendFile;
        private System.Windows.Forms.Label labelSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.TextBox textboxFilter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox outputList;
        private System.Windows.Forms.Button buttonSTOP;
        private System.Windows.Forms.Button buttonSTART;
        private System.Windows.Forms.CheckBox checkboxToggleAutoScroll;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonClearScreen;


    }
}

