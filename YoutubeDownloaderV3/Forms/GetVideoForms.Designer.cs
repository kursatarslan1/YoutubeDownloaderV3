namespace YoutubeDownloaderV3.Forms
{
    partial class GetVideoForms
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchBoxTxt = new System.Windows.Forms.TextBox();
            this.videoDgv = new System.Windows.Forms.DataGridView();
            this.thumbnailDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblQueu = new System.Windows.Forms.Label();
            this.changeLocation = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.mediaDownlad = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.mediaLink = new System.Windows.Forms.Label();
            this.mediaLinkTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.downladedMedia = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.videoDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(717, 17);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 43);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Video Ara:";
            // 
            // searchBoxTxt
            // 
            this.searchBoxTxt.Location = new System.Drawing.Point(140, 28);
            this.searchBoxTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBoxTxt.Name = "searchBoxTxt";
            this.searchBoxTxt.Size = new System.Drawing.Size(537, 22);
            this.searchBoxTxt.TabIndex = 20;
            // 
            // videoDgv
            // 
            this.videoDgv.AutoGenerateColumns = false;
            this.videoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videoDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thumbnailDataGridViewImageColumn,
            this.authorDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn});
            this.videoDgv.DataSource = this.videoBindingSource;
            this.videoDgv.Location = new System.Drawing.Point(42, 80);
            this.videoDgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.videoDgv.Name = "videoDgv";
            this.videoDgv.RowHeadersWidth = 51;
            this.videoDgv.RowTemplate.Height = 24;
            this.videoDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.videoDgv.Size = new System.Drawing.Size(798, 399);
            this.videoDgv.TabIndex = 21;
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
            this.authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "Url";
            this.urlDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.Width = 125;
            // 
            // videoBindingSource
            // 
            this.videoBindingSource.DataSource = typeof(YoutubeDownloaderV3.Video);
            // 
            // lblQueu
            // 
            this.lblQueu.AutoSize = true;
            this.lblQueu.Location = new System.Drawing.Point(1443, 476);
            this.lblQueu.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblQueu.Name = "lblQueu";
            this.lblQueu.Size = new System.Drawing.Size(149, 16);
            this.lblQueu.TabIndex = 44;
            this.lblQueu.Text = "Sırada olan şarkı sayısı:";
            // 
            // changeLocation
            // 
            this.changeLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.changeLocation.Location = new System.Drawing.Point(1675, 99);
            this.changeLocation.Margin = new System.Windows.Forms.Padding(5);
            this.changeLocation.Name = "changeLocation";
            this.changeLocation.Size = new System.Drawing.Size(101, 33);
            this.changeLocation.TabIndex = 43;
            this.changeLocation.Text = "···";
            this.changeLocation.UseVisualStyleBackColor = true;
            this.changeLocation.Click += new System.EventHandler(this.changeLocation_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(1239, 476);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 16);
            this.lblStatus.TabIndex = 42;
            this.lblStatus.Text = "indirme yok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1062, 476);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "İndirme Durumu: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(1062, 425);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(50, 16);
            this.lblTitle.TabIndex = 40;
            this.lblTitle.Text = "Başlık: ";
            // 
            // locationTxt
            // 
            this.locationTxt.Location = new System.Drawing.Point(1142, 101);
            this.locationTxt.Margin = new System.Windows.Forms.Padding(5);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(629, 22);
            this.locationTxt.TabIndex = 39;
            this.locationTxt.Click += new System.EventHandler(this.locationTxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1059, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Konum:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(1239, 425);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(16, 16);
            this.lblInfo.TabIndex = 37;
            this.lblInfo.Text = "...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(1066, 351);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(711, 34);
            this.progressBar1.TabIndex = 36;
            // 
            // mediaDownlad
            // 
            this.mediaDownlad.Location = new System.Drawing.Point(1062, 224);
            this.mediaDownlad.Margin = new System.Windows.Forms.Padding(5);
            this.mediaDownlad.Name = "mediaDownlad";
            this.mediaDownlad.Size = new System.Drawing.Size(711, 86);
            this.mediaDownlad.TabIndex = 35;
            this.mediaDownlad.Text = "İndir";
            this.mediaDownlad.UseVisualStyleBackColor = true;
            this.mediaDownlad.Click += new System.EventHandler(this.mediaDownlad_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1248, 170);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(55, 20);
            this.checkBox2.TabIndex = 34;
            this.checkBox2.Text = "mp4";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1076, 170);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 20);
            this.checkBox1.TabIndex = 32;
            this.checkBox1.Text = "mp3";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // mediaLink
            // 
            this.mediaLink.AutoSize = true;
            this.mediaLink.Location = new System.Drawing.Point(1059, 34);
            this.mediaLink.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.mediaLink.Name = "mediaLink";
            this.mediaLink.Size = new System.Drawing.Size(37, 16);
            this.mediaLink.TabIndex = 31;
            this.mediaLink.Text = "Link: ";
            // 
            // mediaLinkTxt
            // 
            this.mediaLinkTxt.Location = new System.Drawing.Point(1142, 30);
            this.mediaLinkTxt.Margin = new System.Windows.Forms.Padding(5);
            this.mediaLinkTxt.Name = "mediaLinkTxt";
            this.mediaLinkTxt.Size = new System.Drawing.Size(629, 22);
            this.mediaLinkTxt.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(841, 662);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "İndirilecekler Listesi";
            // 
            // downladedMedia
            // 
            this.downladedMedia.FormattingEnabled = true;
            this.downladedMedia.ItemHeight = 16;
            this.downladedMedia.Location = new System.Drawing.Point(42, 525);
            this.downladedMedia.Margin = new System.Windows.Forms.Padding(5);
            this.downladedMedia.Name = "downladedMedia";
            this.downladedMedia.Size = new System.Drawing.Size(1735, 132);
            this.downladedMedia.TabIndex = 45;
            // 
            // GetVideoForms
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1818, 711);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.downladedMedia);
            this.Controls.Add(this.lblQueu);
            this.Controls.Add(this.changeLocation);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.mediaDownlad);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.mediaLink);
            this.Controls.Add(this.mediaLinkTxt);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchBoxTxt);
            this.Controls.Add(this.videoDgv);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GetVideoForms";
            this.Text = "Video Bul";
            this.Load += new System.EventHandler(this.GetVideoForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.videoDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchBoxTxt;
        private System.Windows.Forms.DataGridView videoDgv;
        private System.Windows.Forms.BindingSource videoBindingSource;
        private System.Windows.Forms.Label lblQueu;
        private System.Windows.Forms.Button changeLocation;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button mediaDownlad;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label mediaLink;
        private System.Windows.Forms.TextBox mediaLinkTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox downladedMedia;
        private System.Windows.Forms.DataGridViewImageColumn thumbnailDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
    }
}