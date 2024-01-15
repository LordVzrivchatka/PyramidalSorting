namespace КУРСАЧ
{
    partial class App
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonGen = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.Testb = new System.Windows.Forms.TextBox();
            this.EnterRand = new System.Windows.Forms.NumericUpDown();
            this.ButAuthExit = new System.Windows.Forms.Button();
            this.BoxFrom = new System.Windows.Forms.TextBox();
            this.BoxTo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.appBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnterRand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.appBindingSource;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(344, 98);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(428, 313);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pricedown Rus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(490, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "График";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pricedown Rus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(76, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "Данные";
            // 
            // EnterData
            // 
            this.EnterData.Location = new System.Drawing.Point(32, 127);
            this.EnterData.Name = "EnterData";
            this.EnterData.Size = new System.Drawing.Size(292, 20);
            this.EnterData.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pricedown Rus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "ввод чисел";
            // 
            // ButtonGen
            // 
            this.ButtonGen.Font = new System.Drawing.Font("Pricedown Rus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonGen.Location = new System.Drawing.Point(32, 171);
            this.ButtonGen.Name = "ButtonGen";
            this.ButtonGen.Size = new System.Drawing.Size(204, 28);
            this.ButtonGen.TabIndex = 19;
            this.ButtonGen.Text = "СГенерировать";
            this.ButtonGen.UseVisualStyleBackColor = true;
            this.ButtonGen.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Font = new System.Drawing.Font("Pricedown Rus", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSort.Location = new System.Drawing.Point(32, 215);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(204, 55);
            this.ButtonSort.TabIndex = 21;
            this.ButtonSort.Text = "Сортировать";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // Testb
            // 
            this.Testb.Location = new System.Drawing.Point(32, 368);
            this.Testb.Name = "Testb";
            this.Testb.Size = new System.Drawing.Size(292, 20);
            this.Testb.TabIndex = 22;
            this.Testb.TextChanged += new System.EventHandler(this.Testb_TextChanged);
            // 
            // EnterRand
            // 
            this.EnterRand.Location = new System.Drawing.Point(268, 178);
            this.EnterRand.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.EnterRand.Name = "EnterRand";
            this.EnterRand.Size = new System.Drawing.Size(56, 20);
            this.EnterRand.TabIndex = 24;
            this.EnterRand.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // ButAuthExit
            // 
            this.ButAuthExit.Font = new System.Drawing.Font("Pricedown Rus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButAuthExit.Location = new System.Drawing.Point(12, 413);
            this.ButAuthExit.Name = "ButAuthExit";
            this.ButAuthExit.Size = new System.Drawing.Size(64, 25);
            this.ButAuthExit.TabIndex = 25;
            this.ButAuthExit.Text = "Выход";
            this.ButAuthExit.UseVisualStyleBackColor = true;
            this.ButAuthExit.Click += new System.EventHandler(this.ButAuthExit_Click);
            // 
            // BoxFrom
            // 
            this.BoxFrom.Location = new System.Drawing.Point(268, 225);
            this.BoxFrom.Name = "BoxFrom";
            this.BoxFrom.Size = new System.Drawing.Size(56, 20);
            this.BoxFrom.TabIndex = 26;
            this.BoxFrom.Text = "0";
            // 
            // BoxTo
            // 
            this.BoxTo.Location = new System.Drawing.Point(268, 272);
            this.BoxTo.Name = "BoxTo";
            this.BoxTo.Size = new System.Drawing.Size(56, 20);
            this.BoxTo.TabIndex = 27;
            this.BoxTo.Text = "1000";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Pricedown Rus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(32, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 28);
            this.button1.TabIndex = 28;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Pricedown Rus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(28, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "результат сортировки";;
            // 
            // appBindingSource
            // 
            this.appBindingSource.DataSource = typeof(КУРСАЧ.App);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pricedown Rus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(263, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "кол-во";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pricedown Rus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(277, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 21);
            this.label6.TabIndex = 31;
            this.label6.Text = "от";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Pricedown Rus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(277, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 21);
            this.label7.TabIndex = 32;
            this.label7.Text = "до";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoxTo);
            this.Controls.Add(this.BoxFrom);
            this.Controls.Add(this.ButAuthExit);
            this.Controls.Add(this.EnterRand);
            this.Controls.Add(this.Testb);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonGen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnterData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Пирамидальная сортировка";
            this.Load += new System.EventHandler(this.App_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnterRand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnterData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonGen;
        private System.Windows.Forms.BindingSource appBindingSource;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.TextBox Testb;
        private System.Windows.Forms.NumericUpDown EnterRand;
        private System.Windows.Forms.Button ButAuthExit;
        private System.Windows.Forms.TextBox BoxFrom;
        private System.Windows.Forms.TextBox BoxTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}