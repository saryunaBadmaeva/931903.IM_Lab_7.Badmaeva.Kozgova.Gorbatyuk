
namespace _931903.gorbatyuk.anastasiya.lab7
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btStart = new System.Windows.Forms.Button();
            this.edTiсketPrice = new System.Windows.Forms.NumericUpDown();
            this.edBudget = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbSold = new System.Windows.Forms.Label();
            this.lbPriceTic = new System.Windows.Forms.Label();
            this.lbAviaCom = new System.Windows.Forms.Label();
            this.lbDemand = new System.Windows.Forms.Label();
            this.lbAviago = new System.Windows.Forms.Label();
            this.lbOutLS = new System.Windows.Forms.Label();
            this.lbInf = new System.Windows.Forms.Label();
            this.lbEvol = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edTiсketPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edBudget)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btStart);
            this.panel1.Controls.Add(this.edTiсketPrice);
            this.panel1.Controls.Add(this.edBudget);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 100);
            this.panel1.TabIndex = 0;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(661, 28);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(228, 55);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Старт";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // edTiсketPrice
            // 
            this.edTiсketPrice.DecimalPlaces = 1;
            this.edTiсketPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.edTiсketPrice.Location = new System.Drawing.Point(222, 60);
            this.edTiсketPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.edTiсketPrice.Name = "edTiсketPrice";
            this.edTiсketPrice.Size = new System.Drawing.Size(120, 22);
            this.edTiсketPrice.TabIndex = 3;
            this.edTiсketPrice.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // edBudget
            // 
            this.edBudget.DecimalPlaces = 1;
            this.edBudget.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.edBudget.Location = new System.Drawing.Point(222, 28);
            this.edBudget.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.edBudget.Name = "edBudget";
            this.edBudget.Size = new System.Drawing.Size(120, 22);
            this.edBudget.TabIndex = 2;
            this.edBudget.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Средняя цена билета(тыс)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бюджет аэропорта (млн)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbSold);
            this.panel2.Controls.Add(this.lbPriceTic);
            this.panel2.Controls.Add(this.lbAviaCom);
            this.panel2.Controls.Add(this.lbDemand);
            this.panel2.Controls.Add(this.lbAviago);
            this.panel2.Controls.Add(this.lbOutLS);
            this.panel2.Controls.Add(this.lbInf);
            this.panel2.Controls.Add(this.lbEvol);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 514);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1102, 100);
            this.panel2.TabIndex = 1;
            // 
            // lbSold
            // 
            this.lbSold.AutoSize = true;
            this.lbSold.Location = new System.Drawing.Point(995, 64);
            this.lbSold.Name = "lbSold";
            this.lbSold.Size = new System.Drawing.Size(0, 17);
            this.lbSold.TabIndex = 15;
            // 
            // lbPriceTic
            // 
            this.lbPriceTic.AutoSize = true;
            this.lbPriceTic.Location = new System.Drawing.Point(995, 25);
            this.lbPriceTic.Name = "lbPriceTic";
            this.lbPriceTic.Size = new System.Drawing.Size(0, 17);
            this.lbPriceTic.TabIndex = 14;
            // 
            // lbAviaCom
            // 
            this.lbAviaCom.AutoSize = true;
            this.lbAviaCom.Location = new System.Drawing.Point(699, 64);
            this.lbAviaCom.Name = "lbAviaCom";
            this.lbAviaCom.Size = new System.Drawing.Size(0, 17);
            this.lbAviaCom.TabIndex = 13;
            // 
            // lbDemand
            // 
            this.lbDemand.AutoSize = true;
            this.lbDemand.Location = new System.Drawing.Point(699, 25);
            this.lbDemand.Name = "lbDemand";
            this.lbDemand.Size = new System.Drawing.Size(0, 17);
            this.lbDemand.TabIndex = 12;
            // 
            // lbAviago
            // 
            this.lbAviago.AutoSize = true;
            this.lbAviago.Location = new System.Drawing.Point(472, 64);
            this.lbAviago.Name = "lbAviago";
            this.lbAviago.Size = new System.Drawing.Size(0, 17);
            this.lbAviago.TabIndex = 11;
            // 
            // lbOutLS
            // 
            this.lbOutLS.AutoSize = true;
            this.lbOutLS.Location = new System.Drawing.Point(472, 25);
            this.lbOutLS.Name = "lbOutLS";
            this.lbOutLS.Size = new System.Drawing.Size(0, 17);
            this.lbOutLS.TabIndex = 10;
            // 
            // lbInf
            // 
            this.lbInf.AutoSize = true;
            this.lbInf.Location = new System.Drawing.Point(183, 64);
            this.lbInf.Name = "lbInf";
            this.lbInf.Size = new System.Drawing.Size(0, 17);
            this.lbInf.TabIndex = 9;
            // 
            // lbEvol
            // 
            this.lbEvol.AutoSize = true;
            this.lbEvol.Location = new System.Drawing.Point(183, 25);
            this.lbEvol.Name = "lbEvol";
            this.lbEvol.Size = new System.Drawing.Size(0, 17);
            this.lbEvol.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(816, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Выручка от бил.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(816, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Цена билета";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Число авиаком.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(568, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Спрос";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(283, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Направления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Затраты на персонал";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Инфраструктура";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Коэф. развития";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 100);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsValueShownAsLabel = true;
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1102, 414);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 614);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edTiсketPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edBudget)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.NumericUpDown edTiсketPrice;
        private System.Windows.Forms.NumericUpDown edBudget;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbSold;
        private System.Windows.Forms.Label lbPriceTic;
        private System.Windows.Forms.Label lbAviaCom;
        private System.Windows.Forms.Label lbDemand;
        private System.Windows.Forms.Label lbAviago;
        private System.Windows.Forms.Label lbOutLS;
        private System.Windows.Forms.Label lbInf;
        private System.Windows.Forms.Label lbEvol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

