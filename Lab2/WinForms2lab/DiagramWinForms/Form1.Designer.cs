namespace DiagramWinForms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.textbox11 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textbox22 = new System.Windows.Forms.TextBox();
            this.textbox33 = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listboxOutPutFirst = new System.Windows.Forms.ListBox();
            this.listboxOutPutSecond = new System.Windows.Forms.ListBox();
            this.listboxOutPutThird = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxGenerationRange
            // 
            this.textbox11.Location = new System.Drawing.Point(618, 54);
            this.textbox11.Margin = new System.Windows.Forms.Padding(2);
            this.textbox11.Name = "textBoxGenerationRange";
            this.textbox11.Size = new System.Drawing.Size(93, 20);
            this.textbox11.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxNumberOfRanges
            // 
            this.textbox22.Location = new System.Drawing.Point(618, 127);
            this.textbox22.Margin = new System.Windows.Forms.Padding(2);
            this.textbox22.Name = "textBoxNumberOfRanges";
            this.textbox22.Size = new System.Drawing.Size(92, 20);
            this.textbox22.TabIndex = 2;
            // 
            // textBoxNumberOfTests
            // 
            this.textbox33.Location = new System.Drawing.Point(618, 201);
            this.textbox33.Margin = new System.Windows.Forms.Padding(2);
            this.textbox33.Name = "textBoxNumberOfTests";
            this.textbox33.Size = new System.Drawing.Size(93, 20);
            this.textbox33.TabIndex = 3;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(614, 329);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(96, 91);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Згенерувати";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(9, 10);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(423, 121);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(11, 161);
            this.chart2.Margin = new System.Windows.Forms.Padding(2);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(421, 121);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(11, 329);
            this.chart3.Margin = new System.Windows.Forms.Padding(2);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(421, 121);
            this.chart3.TabIndex = 10;
            this.chart3.Text = "chart3";
            this.chart3.Click += new System.EventHandler(this.chart3_Click);
            // 
            // listboxOutPutFirst
            // 
            this.listboxOutPutFirst.FormattingEnabled = true;
            this.listboxOutPutFirst.Location = new System.Drawing.Point(463, 10);
            this.listboxOutPutFirst.Name = "listboxOutPutFirst";
            this.listboxOutPutFirst.Size = new System.Drawing.Size(134, 121);
            this.listboxOutPutFirst.TabIndex = 13;
            // 
            // listboxOutPutSecond
            // 
            this.listboxOutPutSecond.FormattingEnabled = true;
            this.listboxOutPutSecond.Location = new System.Drawing.Point(463, 161);
            this.listboxOutPutSecond.Name = "listboxOutPutSecond";
            this.listboxOutPutSecond.Size = new System.Drawing.Size(134, 121);
            this.listboxOutPutSecond.TabIndex = 14;
            // 
            // listboxOutPutThird
            // 
            this.listboxOutPutThird.FormattingEnabled = true;
            this.listboxOutPutThird.Location = new System.Drawing.Point(463, 329);
            this.listboxOutPutThird.Name = "listboxOutPutThird";
            this.listboxOutPutThird.Size = new System.Drawing.Size(134, 121);
            this.listboxOutPutThird.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Інтервал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Кількість стовпчиків";
            // 
            // name3
            // 
            this.name3.AutoSize = true;
            this.name3.Location = new System.Drawing.Point(603, 186);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(121, 13);
            this.name3.TabIndex = 18;
            this.name3.Text = "Кількість випробувань";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 481);
            this.Controls.Add(this.name3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listboxOutPutThird);
            this.Controls.Add(this.listboxOutPutSecond);
            this.Controls.Add(this.listboxOutPutFirst);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textbox33);
            this.Controls.Add(this.textbox22);
            this.Controls.Add(this.textbox11);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textbox22;
        private System.Windows.Forms.TextBox textbox33;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.ListBox listboxOutPutFirst;
        private System.Windows.Forms.ListBox listboxOutPutSecond;
        private System.Windows.Forms.ListBox listboxOutPutThird;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name3;
    }
}

