namespace YoutubeDownloaderV3
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimized = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchBoxTxt = new System.Windows.Forms.TextBox();
            this.videoDgv = new System.Windows.Forms.DataGridView();
            this.lblQueu = new System.Windows.Forms.Label();
            this.changeLocation = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.mediaDownlad = new System.Windows.Forms.Button();
            this.mp4Cb = new System.Windows.Forms.CheckBox();
            this.mp3Cb = new System.Windows.Forms.CheckBox();
            this.mediaLink = new System.Windows.Forms.Label();
            this.mediaLinkTxt = new System.Windows.Forms.TextBox();
            this.downladedMedia = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.thumbnailDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTitleBar.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            this.panelTitleBar.Controls.Add(this.btnMinimized);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1868, 94);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown_1);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimized.FlatAppearance.BorderSize = 0;
            this.btnMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimized.ForeColor = System.Drawing.Color.Gold;
            this.btnMinimized.Location = new System.Drawing.Point(1740, 0);
            this.btnMinimized.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(64, 94);
            this.btnMinimized.TabIndex = 5;
            this.btnMinimized.Text = "O";
            this.btnMinimized.UseVisualStyleBackColor = true;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1804, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 94);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "O";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(799, 29);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(226, 29);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Youtube Downlader";
            // 
            // panelHome
            // 
            this.panelHome.Controls.Add(this.label5);
            this.panelHome.Controls.Add(this.downladedMedia);
            this.panelHome.Controls.Add(this.lblQueu);
            this.panelHome.Controls.Add(this.changeLocation);
            this.panelHome.Controls.Add(this.lblStatus);
            this.panelHome.Controls.Add(this.label2);
            this.panelHome.Controls.Add(this.label1);
            this.panelHome.Controls.Add(this.locationTxt);
            this.panelHome.Controls.Add(this.label3);
            this.panelHome.Controls.Add(this.lblInfo);
            this.panelHome.Controls.Add(this.progressBar1);
            this.panelHome.Controls.Add(this.mediaDownlad);
            this.panelHome.Controls.Add(this.mp4Cb);
            this.panelHome.Controls.Add(this.mp3Cb);
            this.panelHome.Controls.Add(this.mediaLink);
            this.panelHome.Controls.Add(this.mediaLinkTxt);
            this.panelHome.Controls.Add(this.btnSearch);
            this.panelHome.Controls.Add(this.label4);
            this.panelHome.Controls.Add(this.searchBoxTxt);
            this.panelHome.Controls.Add(this.videoDgv);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 94);
            this.panelHome.Margin = new System.Windows.Forms.Padding(4);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1868, 955);
            this.panelHome.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(926, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(199, 53);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Video Ara:";
            // 
            // searchBoxTxt
            // 
            this.searchBoxTxt.Location = new System.Drawing.Point(138, 22);
            this.searchBoxTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBoxTxt.Name = "searchBoxTxt";
            this.searchBoxTxt.Size = new System.Drawing.Size(753, 22);
            this.searchBoxTxt.TabIndex = 24;
            // 
            // videoDgv
            // 
            this.videoDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoDgv.AutoGenerateColumns = false;
            this.videoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videoDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thumbnailDataGridViewImageColumn,
            this.authorDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn});
            this.videoDgv.DataSource = this.videoBindingSource;
            this.videoDgv.Location = new System.Drawing.Point(40, 74);
            this.videoDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.videoDgv.Name = "videoDgv";
            this.videoDgv.RowHeadersWidth = 51;
            this.videoDgv.RowTemplate.Height = 24;
            this.videoDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.videoDgv.Size = new System.Drawing.Size(1784, 362);
            this.videoDgv.TabIndex = 25;
            this.videoDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.videoDgv_CellClick);
            // 
            // lblQueu
            // 
            this.lblQueu.AutoSize = true;
            this.lblQueu.Location = new System.Drawing.Point(427, 910);
            this.lblQueu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQueu.Name = "lblQueu";
            this.lblQueu.Size = new System.Drawing.Size(149, 16);
            this.lblQueu.TabIndex = 58;
            this.lblQueu.Text = "Sırada olan şarkı sayısı:";
            // 
            // changeLocation
            // 
            this.changeLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.changeLocation.Location = new System.Drawing.Point(663, 535);
            this.changeLocation.Margin = new System.Windows.Forms.Padding(5);
            this.changeLocation.Name = "changeLocation";
            this.changeLocation.Size = new System.Drawing.Size(101, 33);
            this.changeLocation.TabIndex = 57;
            this.changeLocation.Text = "···";
            this.changeLocation.UseVisualStyleBackColor = true;
            this.changeLocation.Click += new System.EventHandler(this.changeLocation_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(223, 910);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 16);
            this.lblStatus.TabIndex = 56;
            this.lblStatus.Text = "indirme yok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 910);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "İndirme Durumu: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 859);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 54;
            this.label1.Text = "Başlık: ";
            // 
            // locationTxt
            // 
            this.locationTxt.Location = new System.Drawing.Point(130, 537);
            this.locationTxt.Margin = new System.Windows.Forms.Padding(5);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(629, 22);
            this.locationTxt.TabIndex = 53;
            this.locationTxt.Click += new System.EventHandler(this.locationTxt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 541);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Konum:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(223, 859);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(16, 16);
            this.lblInfo.TabIndex = 51;
            this.lblInfo.Text = "...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 785);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(711, 34);
            this.progressBar1.TabIndex = 50;
            // 
            // mediaDownlad
            // 
            this.mediaDownlad.Location = new System.Drawing.Point(50, 660);
            this.mediaDownlad.Margin = new System.Windows.Forms.Padding(5);
            this.mediaDownlad.Name = "mediaDownlad";
            this.mediaDownlad.Size = new System.Drawing.Size(711, 86);
            this.mediaDownlad.TabIndex = 49;
            this.mediaDownlad.Text = "İndir";
            this.mediaDownlad.UseVisualStyleBackColor = true;
            this.mediaDownlad.Click += new System.EventHandler(this.mediaDownlad_Click);
            // 
            // mp4Cb
            // 
            this.mp4Cb.AutoSize = true;
            this.mp4Cb.Location = new System.Drawing.Point(236, 606);
            this.mp4Cb.Margin = new System.Windows.Forms.Padding(5);
            this.mp4Cb.Name = "mp4Cb";
            this.mp4Cb.Size = new System.Drawing.Size(55, 20);
            this.mp4Cb.TabIndex = 48;
            this.mp4Cb.Text = "mp4";
            this.mp4Cb.UseVisualStyleBackColor = true;
            this.mp4Cb.CheckedChanged += new System.EventHandler(this.mp4Cb_CheckedChanged);
            // 
            // mp3Cb
            // 
            this.mp3Cb.AutoSize = true;
            this.mp3Cb.Location = new System.Drawing.Point(64, 606);
            this.mp3Cb.Margin = new System.Windows.Forms.Padding(5);
            this.mp3Cb.Name = "mp3Cb";
            this.mp3Cb.Size = new System.Drawing.Size(55, 20);
            this.mp3Cb.TabIndex = 46;
            this.mp3Cb.Text = "mp3";
            this.mp3Cb.UseVisualStyleBackColor = true;
            this.mp3Cb.CheckedChanged += new System.EventHandler(this.mp3Cb_CheckedChanged);
            // 
            // mediaLink
            // 
            this.mediaLink.AutoSize = true;
            this.mediaLink.Location = new System.Drawing.Point(47, 470);
            this.mediaLink.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mediaLink.Name = "mediaLink";
            this.mediaLink.Size = new System.Drawing.Size(37, 16);
            this.mediaLink.TabIndex = 45;
            this.mediaLink.Text = "Link: ";
            // 
            // mediaLinkTxt
            // 
            this.mediaLinkTxt.Location = new System.Drawing.Point(130, 466);
            this.mediaLinkTxt.Margin = new System.Windows.Forms.Padding(5);
            this.mediaLinkTxt.Name = "mediaLinkTxt";
            this.mediaLinkTxt.Size = new System.Drawing.Size(629, 22);
            this.mediaLinkTxt.TabIndex = 47;
            // 
            // downladedMedia
            // 
            this.downladedMedia.FormattingEnabled = true;
            this.downladedMedia.ItemHeight = 16;
            this.downladedMedia.Location = new System.Drawing.Point(840, 466);
            this.downladedMedia.Margin = new System.Windows.Forms.Padding(5);
            this.downladedMedia.Name = "downladedMedia";
            this.downladedMedia.Size = new System.Drawing.Size(984, 356);
            this.downladedMedia.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1288, 837);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "İndirilecekler Listesi";
            // 
            // thumbnailDataGridViewImageColumn
            // 
            this.thumbnailDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thumbnailDataGridViewImageColumn.DataPropertyName = "Thumbnail";
            this.thumbnailDataGridViewImageColumn.HeaderText = "Thumbnail";
            this.thumbnailDataGridViewImageColumn.MinimumWidth = 6;
            this.thumbnailDataGridViewImageColumn.Name = "thumbnailDataGridViewImageColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 270;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 270;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.Width = 290;
            // 
            // videoBindingSource
            // 
            this.videoBindingSource.DataSource = typeof(YoutubeDownloaderV3.Video);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1868, 1049);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnMinimized;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchBoxTxt;
        private System.Windows.Forms.DataGridView videoDgv;
        private System.Windows.Forms.Label lblQueu;
        private System.Windows.Forms.Button changeLocation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button mediaDownlad;
        private System.Windows.Forms.CheckBox mp4Cb;
        private System.Windows.Forms.CheckBox mp3Cb;
        private System.Windows.Forms.Label mediaLink;
        private System.Windows.Forms.TextBox mediaLinkTxt;
        private System.Windows.Forms.ListBox downladedMedia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource videoBindingSource;
        private System.Windows.Forms.DataGridViewImageColumn thumbnailDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
    }
}

