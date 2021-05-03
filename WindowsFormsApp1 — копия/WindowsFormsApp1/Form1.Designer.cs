
namespace WindowsFormsApp1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Variable1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Variable2 = new System.Windows.Forms.TextBox();
            this.Check_Interval = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Step1 = new System.Windows.Forms.TextBox();
            this.Step2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxV1 = new System.Windows.Forms.TextBox();
            this.MaxV2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Graphic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вираз:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Змінна Х1:";
            // 
            // Variable1
            // 
            this.Variable1.Location = new System.Drawing.Point(124, 188);
            this.Variable1.Name = "Variable1";
            this.Variable1.Size = new System.Drawing.Size(121, 22);
            this.Variable1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Змінна Х2:";
            // 
            // Variable2
            // 
            this.Variable2.Location = new System.Drawing.Point(124, 226);
            this.Variable2.Name = "Variable2";
            this.Variable2.Size = new System.Drawing.Size(121, 22);
            this.Variable2.TabIndex = 5;
            // 
            // Check_Interval
            // 
            this.Check_Interval.AutoSize = true;
            this.Check_Interval.Location = new System.Drawing.Point(43, 267);
            this.Check_Interval.Name = "Check_Interval";
            this.Check_Interval.Size = new System.Drawing.Size(177, 21);
            this.Check_Interval.TabIndex = 6;
            this.Check_Interval.Text = "Використати діапазон";
            this.Check_Interval.UseVisualStyleBackColor = true;
            this.Check_Interval.CheckedChanged += new System.EventHandler(this.Check_Interval_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Крок для Х1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Крок для Х2:";
            // 
            // Step1
            // 
            this.Step1.Location = new System.Drawing.Point(139, 301);
            this.Step1.Name = "Step1";
            this.Step1.Size = new System.Drawing.Size(127, 22);
            this.Step1.TabIndex = 9;
            // 
            // Step2
            // 
            this.Step2.Location = new System.Drawing.Point(139, 329);
            this.Step2.Name = "Step2";
            this.Step2.Size = new System.Drawing.Size(127, 22);
            this.Step2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Максимальне значення Х1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Максимальне значення Х2:";
            // 
            // MaxV1
            // 
            this.MaxV1.Location = new System.Drawing.Point(235, 358);
            this.MaxV1.Name = "MaxV1";
            this.MaxV1.Size = new System.Drawing.Size(111, 22);
            this.MaxV1.TabIndex = 13;
            // 
            // MaxV2
            // 
            this.MaxV2.Location = new System.Drawing.Point(235, 391);
            this.MaxV2.Name = "MaxV2";
            this.MaxV2.Size = new System.Drawing.Size(111, 22);
            this.MaxV2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 47);
            this.button1.TabIndex = 15;
            this.button1.Text = "Обчислити У";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 479);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 47);
            this.button2.TabIndex = 16;
            this.button2.Text = "Очистити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Graphic
            // 
            chartArea1.Name = "ChartArea1";
            this.Graphic.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Graphic.Legends.Add(legend1);
            this.Graphic.Location = new System.Drawing.Point(665, 47);
            this.Graphic.Name = "Graphic";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Y(X1)";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Y(X2)";
            this.Graphic.Series.Add(series1);
            this.Graphic.Series.Add(series2);
            this.Graphic.Size = new System.Drawing.Size(393, 420);
            this.Graphic.TabIndex = 18;
            this.Graphic.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.y;
            this.pictureBox1.Location = new System.Drawing.Point(27, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Y,
            this.X1,
            this.X2});
            this.table.Location = new System.Drawing.Point(412, 47);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(234, 420);
            this.table.TabIndex = 19;
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.MinimumWidth = 6;
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 60;
            // 
            // X1
            // 
            this.X1.HeaderText = "X1";
            this.X1.MinimumWidth = 6;
            this.X1.Name = "X1";
            this.X1.ReadOnly = true;
            this.X1.Width = 60;
            // 
            // X2
            // 
            this.X2.HeaderText = "X2";
            this.X2.MinimumWidth = 6;
            this.X2.Name = "X2";
            this.X2.ReadOnly = true;
            this.X2.Width = 60;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1089, 544);
            this.Controls.Add(this.table);
            this.Controls.Add(this.Graphic);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MaxV2);
            this.Controls.Add(this.MaxV1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Step2);
            this.Controls.Add(this.Step1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Check_Interval);
            this.Controls.Add(this.Variable2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Variable1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Graphic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Variable1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Variable2;
        private System.Windows.Forms.CheckBox Check_Interval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Step1;
        private System.Windows.Forms.TextBox Step2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MaxV1;
        private System.Windows.Forms.TextBox MaxV2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Graphic;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
    }
}

