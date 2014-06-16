namespace kakei_boy
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbGENZAI = new System.Windows.Forms.Label();
            this.lbMOKUHYOU = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbCommentVar = new System.Windows.Forms.Label();
            this.lbCOMMENT = new System.Windows.Forms.Label();
            this.lbMokuhyouVar = new System.Windows.Forms.Label();
            this.lbGenzaiBar = new System.Windows.Forms.Label();
            this.lbKurikoshiVar = new System.Windows.Forms.Label();
            this.lbKURIKOSHI = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNedan = new System.Windows.Forms.Label();
            this.calDate = new System.Windows.Forms.MonthCalendar();
            this.btnInsertRecord = new System.Windows.Forms.Button();
            this.cmbKind = new System.Windows.Forms.ComboBox();
            this.txtNedan = new System.Windows.Forms.TextBox();
            this.lbHinmei = new System.Windows.Forms.Label();
            this.txtHinmei = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // lbGENZAI
            // 
            this.lbGENZAI.AutoSize = true;
            this.lbGENZAI.Location = new System.Drawing.Point(160, 76);
            this.lbGENZAI.Name = "lbGENZAI";
            this.lbGENZAI.Size = new System.Drawing.Size(65, 12);
            this.lbGENZAI.TabIndex = 0;
            this.lbGENZAI.Text = "現在使用額";
            // 
            // lbMOKUHYOU
            // 
            this.lbMOKUHYOU.AutoSize = true;
            this.lbMOKUHYOU.Location = new System.Drawing.Point(160, 20);
            this.lbMOKUHYOU.Name = "lbMOKUHYOU";
            this.lbMOKUHYOU.Size = new System.Drawing.Size(53, 12);
            this.lbMOKUHYOU.TabIndex = 1;
            this.lbMOKUHYOU.Text = "目標予算";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 326);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lbCommentVar);
            this.tabPage1.Controls.Add(this.lbCOMMENT);
            this.tabPage1.Controls.Add(this.lbMokuhyouVar);
            this.tabPage1.Controls.Add(this.lbGenzaiBar);
            this.tabPage1.Controls.Add(this.lbKurikoshiVar);
            this.tabPage1.Controls.Add(this.lbKURIKOSHI);
            this.tabPage1.Controls.Add(this.lbMOKUHYOU);
            this.tabPage1.Controls.Add(this.lbGENZAI);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(525, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // lbCommentVar
            // 
            this.lbCommentVar.AutoSize = true;
            this.lbCommentVar.Location = new System.Drawing.Point(114, 211);
            this.lbCommentVar.Name = "lbCommentVar";
            this.lbCommentVar.Size = new System.Drawing.Size(35, 12);
            this.lbCommentVar.TabIndex = 7;
            this.lbCommentVar.Text = "label1";
            // 
            // lbCOMMENT
            // 
            this.lbCOMMENT.AutoSize = true;
            this.lbCOMMENT.Location = new System.Drawing.Point(32, 178);
            this.lbCOMMENT.Name = "lbCOMMENT";
            this.lbCOMMENT.Size = new System.Drawing.Size(38, 12);
            this.lbCOMMENT.TabIndex = 6;
            this.lbCOMMENT.Text = "コメント";
            // 
            // lbMokuhyouVar
            // 
            this.lbMokuhyouVar.AutoSize = true;
            this.lbMokuhyouVar.Location = new System.Drawing.Point(296, 20);
            this.lbMokuhyouVar.Name = "lbMokuhyouVar";
            this.lbMokuhyouVar.Size = new System.Drawing.Size(35, 12);
            this.lbMokuhyouVar.TabIndex = 5;
            this.lbMokuhyouVar.Text = "label1";
            // 
            // lbGenzaiBar
            // 
            this.lbGenzaiBar.AutoSize = true;
            this.lbGenzaiBar.Location = new System.Drawing.Point(296, 76);
            this.lbGenzaiBar.Name = "lbGenzaiBar";
            this.lbGenzaiBar.Size = new System.Drawing.Size(35, 12);
            this.lbGenzaiBar.TabIndex = 4;
            this.lbGenzaiBar.Text = "label1";
            // 
            // lbKurikoshiVar
            // 
            this.lbKurikoshiVar.AutoSize = true;
            this.lbKurikoshiVar.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.lbKurikoshiVar.Location = new System.Drawing.Point(294, 125);
            this.lbKurikoshiVar.Name = "lbKurikoshiVar";
            this.lbKurikoshiVar.Size = new System.Drawing.Size(57, 20);
            this.lbKurikoshiVar.TabIndex = 3;
            this.lbKurikoshiVar.Text = "label1";
            // 
            // lbKURIKOSHI
            // 
            this.lbKURIKOSHI.AutoSize = true;
            this.lbKURIKOSHI.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.lbKURIKOSHI.Location = new System.Drawing.Point(136, 125);
            this.lbKURIKOSHI.Name = "lbKURIKOSHI";
            this.lbKURIKOSHI.Size = new System.Drawing.Size(89, 20);
            this.lbKURIKOSHI.TabIndex = 2;
            this.lbKURIKOSHI.Text = "繰越予測";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lbNedan);
            this.tabPage2.Controls.Add(this.calDate);
            this.tabPage2.Controls.Add(this.btnInsertRecord);
            this.tabPage2.Controls.Add(this.cmbKind);
            this.tabPage2.Controls.Add(this.txtNedan);
            this.tabPage2.Controls.Add(this.lbHinmei);
            this.tabPage2.Controls.Add(this.txtHinmei);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(525, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "種類";
            // 
            // lbNedan
            // 
            this.lbNedan.AutoSize = true;
            this.lbNedan.Location = new System.Drawing.Point(39, 67);
            this.lbNedan.Name = "lbNedan";
            this.lbNedan.Size = new System.Drawing.Size(29, 12);
            this.lbNedan.TabIndex = 9;
            this.lbNedan.Text = "値段";
            // 
            // calDate
            // 
            this.calDate.Location = new System.Drawing.Point(293, 25);
            this.calDate.Name = "calDate";
            this.calDate.TabIndex = 8;
            // 
            // btnInsertRecord
            // 
            this.btnInsertRecord.Location = new System.Drawing.Point(447, 271);
            this.btnInsertRecord.Name = "btnInsertRecord";
            this.btnInsertRecord.Size = new System.Drawing.Size(75, 23);
            this.btnInsertRecord.TabIndex = 7;
            this.btnInsertRecord.Text = "登録";
            this.btnInsertRecord.UseVisualStyleBackColor = true;
            this.btnInsertRecord.Click += new System.EventHandler(this.btnInsertRecord_Click);
            // 
            // cmbKind
            // 
            this.cmbKind.FormattingEnabled = true;
            this.cmbKind.Items.AddRange(new object[] {
            "食材",
            "外食"});
            this.cmbKind.Location = new System.Drawing.Point(134, 90);
            this.cmbKind.Name = "cmbKind";
            this.cmbKind.Size = new System.Drawing.Size(121, 20);
            this.cmbKind.TabIndex = 6;
            // 
            // txtNedan
            // 
            this.txtNedan.Location = new System.Drawing.Point(134, 64);
            this.txtNedan.Name = "txtNedan";
            this.txtNedan.Size = new System.Drawing.Size(100, 19);
            this.txtNedan.TabIndex = 2;
            // 
            // lbHinmei
            // 
            this.lbHinmei.AutoSize = true;
            this.lbHinmei.Location = new System.Drawing.Point(39, 42);
            this.lbHinmei.Name = "lbHinmei";
            this.lbHinmei.Size = new System.Drawing.Size(29, 12);
            this.lbHinmei.TabIndex = 1;
            this.lbHinmei.Text = "品名";
            // 
            // txtHinmei
            // 
            this.txtHinmei.Location = new System.Drawing.Point(134, 39);
            this.txtHinmei.Name = "txtHinmei";
            this.txtHinmei.Size = new System.Drawing.Size(100, 19);
            this.txtHinmei.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chartHistogram);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(525, 300);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chartHistogram
            // 
            chartArea1.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartHistogram.Legends.Add(legend1);
            this.chartHistogram.Location = new System.Drawing.Point(59, 66);
            this.chartHistogram.Name = "chartHistogram";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartHistogram.Series.Add(series1);
            this.chartHistogram.Size = new System.Drawing.Size(399, 177);
            this.chartHistogram.TabIndex = 1;
            this.chartHistogram.Text = "text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 340);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "家計-Boy♂";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbGENZAI;
        private System.Windows.Forms.Label lbMOKUHYOU;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbMokuhyouVar;
        private System.Windows.Forms.Label lbGenzaiBar;
        private System.Windows.Forms.Label lbKurikoshiVar;
        private System.Windows.Forms.Label lbKURIKOSHI;
        private System.Windows.Forms.Label lbCOMMENT;
        private System.Windows.Forms.Label lbCommentVar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnInsertRecord;
        private System.Windows.Forms.ComboBox cmbKind;
        private System.Windows.Forms.TextBox txtNedan;
        private System.Windows.Forms.Label lbHinmei;
        private System.Windows.Forms.TextBox txtHinmei;
        private System.Windows.Forms.Label lbNedan;
        private System.Windows.Forms.MonthCalendar calDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
    }
}

