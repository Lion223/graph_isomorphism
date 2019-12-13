namespace FormUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.graphTb = new System.Windows.Forms.RichTextBox();
            this.readfileBtn = new MetroFramework.Controls.MetroButton();
            this.fileTb = new System.Windows.Forms.RichTextBox();
            this.checkIsoBtn = new MetroFramework.Controls.MetroButton();
            this.fileLbl = new MetroFramework.Controls.MetroLabel();
            this.fileTb2 = new System.Windows.Forms.RichTextBox();
            this.fileLbl2 = new MetroFramework.Controls.MetroLabel();
            this.readfileBtn2 = new MetroFramework.Controls.MetroButton();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.graphTb2 = new System.Windows.Forms.RichTextBox();
            this.resTb = new System.Windows.Forms.RichTextBox();
            this.graphViewer = new Microsoft.Glee.GraphViewerGdi.GViewer();
            this.graphViewer2 = new Microsoft.Glee.GraphViewerGdi.GViewer();
            this.SuspendLayout();
            // 
            // graphTb
            // 
            this.graphTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphTb.Location = new System.Drawing.Point(23, 346);
            this.graphTb.Name = "graphTb";
            this.graphTb.Size = new System.Drawing.Size(164, 217);
            this.graphTb.TabIndex = 21;
            this.graphTb.Text = "";
            // 
            // readfileBtn
            // 
            this.readfileBtn.Location = new System.Drawing.Point(23, 272);
            this.readfileBtn.Name = "readfileBtn";
            this.readfileBtn.Size = new System.Drawing.Size(164, 68);
            this.readfileBtn.TabIndex = 22;
            this.readfileBtn.Text = "Read data from a text file";
            this.readfileBtn.UseSelectable = true;
            this.readfileBtn.Click += new System.EventHandler(this.readfileBtn_Click);
            // 
            // fileTb
            // 
            this.fileTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileTb.Location = new System.Drawing.Point(23, 92);
            this.fileTb.Name = "fileTb";
            this.fileTb.ReadOnly = true;
            this.fileTb.Size = new System.Drawing.Size(164, 174);
            this.fileTb.TabIndex = 23;
            this.fileTb.Text = "";
            // 
            // checkIsoBtn
            // 
            this.checkIsoBtn.Location = new System.Drawing.Point(900, 63);
            this.checkIsoBtn.Name = "checkIsoBtn";
            this.checkIsoBtn.Size = new System.Drawing.Size(156, 68);
            this.checkIsoBtn.TabIndex = 24;
            this.checkIsoBtn.Text = "Execute";
            this.checkIsoBtn.UseSelectable = true;
            this.checkIsoBtn.Click += new System.EventHandler(this.checkIsoBtn_Click);
            // 
            // fileLbl
            // 
            this.fileLbl.AutoSize = true;
            this.fileLbl.Location = new System.Drawing.Point(23, 63);
            this.fileLbl.Name = "fileLbl";
            this.fileLbl.Size = new System.Drawing.Size(97, 19);
            this.fileLbl.TabIndex = 25;
            this.fileLbl.Text = "No file opened";
            this.fileLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileTb2
            // 
            this.fileTb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileTb2.Location = new System.Drawing.Point(202, 92);
            this.fileTb2.Name = "fileTb2";
            this.fileTb2.ReadOnly = true;
            this.fileTb2.Size = new System.Drawing.Size(164, 174);
            this.fileTb2.TabIndex = 29;
            this.fileTb2.Text = "";
            // 
            // fileLbl2
            // 
            this.fileLbl2.AutoSize = true;
            this.fileLbl2.Location = new System.Drawing.Point(202, 63);
            this.fileLbl2.Name = "fileLbl2";
            this.fileLbl2.Size = new System.Drawing.Size(97, 19);
            this.fileLbl2.TabIndex = 30;
            this.fileLbl2.Text = "No file opened";
            this.fileLbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // readfileBtn2
            // 
            this.readfileBtn2.Location = new System.Drawing.Point(202, 272);
            this.readfileBtn2.Name = "readfileBtn2";
            this.readfileBtn2.Size = new System.Drawing.Size(164, 68);
            this.readfileBtn2.TabIndex = 31;
            this.readfileBtn2.Text = "Read data from a text file";
            this.readfileBtn2.UseSelectable = true;
            this.readfileBtn2.Click += new System.EventHandler(this.readfileBtn2_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // graphTb2
            // 
            this.graphTb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphTb2.Location = new System.Drawing.Point(202, 346);
            this.graphTb2.Name = "graphTb2";
            this.graphTb2.Size = new System.Drawing.Size(164, 217);
            this.graphTb2.TabIndex = 32;
            this.graphTb2.Text = "";
            // 
            // resTb
            // 
            this.resTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resTb.Location = new System.Drawing.Point(900, 137);
            this.resTb.Name = "resTb";
            this.resTb.Size = new System.Drawing.Size(156, 426);
            this.resTb.TabIndex = 33;
            this.resTb.Text = "";
            // 
            // graphViewer
            // 
            this.graphViewer.AsyncLayout = false;
            this.graphViewer.AutoScroll = true;
            this.graphViewer.BackwardEnabled = false;
            this.graphViewer.ForwardEnabled = false;
            this.graphViewer.Graph = null;
            this.graphViewer.Location = new System.Drawing.Point(384, 63);
            this.graphViewer.MouseHitDistance = 0.05D;
            this.graphViewer.Name = "graphViewer";
            this.graphViewer.NavigationVisible = true;
            this.graphViewer.PanButtonPressed = false;
            this.graphViewer.SaveButtonVisible = true;
            this.graphViewer.Size = new System.Drawing.Size(510, 247);
            this.graphViewer.TabIndex = 34;
            this.graphViewer.ZoomF = 1D;
            this.graphViewer.ZoomFraction = 0.5D;
            this.graphViewer.ZoomWindowThreshold = 0.05D;
            // 
            // graphViewer2
            // 
            this.graphViewer2.AsyncLayout = false;
            this.graphViewer2.AutoScroll = true;
            this.graphViewer2.BackwardEnabled = false;
            this.graphViewer2.ForwardEnabled = false;
            this.graphViewer2.Graph = null;
            this.graphViewer2.Location = new System.Drawing.Point(384, 316);
            this.graphViewer2.MouseHitDistance = 0.05D;
            this.graphViewer2.Name = "graphViewer2";
            this.graphViewer2.NavigationVisible = true;
            this.graphViewer2.PanButtonPressed = false;
            this.graphViewer2.SaveButtonVisible = true;
            this.graphViewer2.Size = new System.Drawing.Size(510, 247);
            this.graphViewer2.TabIndex = 35;
            this.graphViewer2.ZoomF = 1D;
            this.graphViewer2.ZoomFraction = 0.5D;
            this.graphViewer2.ZoomWindowThreshold = 0.05D;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 582);
            this.Controls.Add(this.graphViewer2);
            this.Controls.Add(this.graphViewer);
            this.Controls.Add(this.resTb);
            this.Controls.Add(this.graphTb2);
            this.Controls.Add(this.readfileBtn2);
            this.Controls.Add(this.fileLbl2);
            this.Controls.Add(this.fileTb2);
            this.Controls.Add(this.fileLbl);
            this.Controls.Add(this.checkIsoBtn);
            this.Controls.Add(this.fileTb);
            this.Controls.Add(this.readfileBtn);
            this.Controls.Add(this.graphTb);
            this.Name = "MainForm";
            this.Resizable = false;
            this.Text = "Graph isomorphism";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox graphTb;
        private MetroFramework.Controls.MetroButton readfileBtn;
        public System.Windows.Forms.RichTextBox fileTb;
        private MetroFramework.Controls.MetroButton checkIsoBtn;
        private MetroFramework.Controls.MetroLabel fileLbl;
        public System.Windows.Forms.RichTextBox fileTb2;
        private MetroFramework.Controls.MetroLabel fileLbl2;
        private MetroFramework.Controls.MetroButton readfileBtn2;
        private System.Windows.Forms.OpenFileDialog ofd;
        public System.Windows.Forms.RichTextBox graphTb2;
        public System.Windows.Forms.RichTextBox resTb;
        private Microsoft.Glee.GraphViewerGdi.GViewer graphViewer;
        private Microsoft.Glee.GraphViewerGdi.GViewer graphViewer2;
    }
}

