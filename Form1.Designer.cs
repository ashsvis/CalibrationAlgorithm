namespace CalibrationAlgorithm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nudNear4mA = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudNear20mA = new System.Windows.Forms.NumericUpDown();
            this.btnTakeNear4mA = new System.Windows.Forms.Button();
            this.btnTakeNear20mA = new System.Windows.Forms.Button();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.btnCalibrateAt4mA = new System.Windows.Forms.Button();
            this.btnCalibrateAt20mA = new System.Windows.Forms.Button();
            this.lbTaked4mA = new System.Windows.Forms.Label();
            this.lbTaked20mA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudNear4mA)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNear20mA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNear4mA
            // 
            this.nudNear4mA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNear4mA.DecimalPlaces = 3;
            this.nudNear4mA.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudNear4mA.Location = new System.Drawing.Point(3, 18);
            this.nudNear4mA.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudNear4mA.Name = "nudNear4mA";
            this.nudNear4mA.Size = new System.Drawing.Size(84, 21);
            this.nudNear4mA.TabIndex = 0;
            this.nudNear4mA.Value = new decimal(new int[] {
            378,
            0,
            0,
            131072});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.nudNear4mA, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudNear20mA, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnTakeNear4mA, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnTakeNear20mA, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.nudValue, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCalibrateAt4mA, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCalibrateAt20mA, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbTaked4mA, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbTaked20mA, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbResult, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 5, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 126);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ток ~4 mA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ток ~20 mA";
            // 
            // nudNear20mA
            // 
            this.nudNear20mA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudNear20mA.DecimalPlaces = 3;
            this.nudNear20mA.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudNear20mA.Location = new System.Drawing.Point(3, 89);
            this.nudNear20mA.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudNear20mA.Name = "nudNear20mA";
            this.nudNear20mA.Size = new System.Drawing.Size(84, 21);
            this.nudNear20mA.TabIndex = 0;
            this.nudNear20mA.Value = new decimal(new int[] {
            2034,
            0,
            0,
            131072});
            // 
            // btnTakeNear4mA
            // 
            this.btnTakeNear4mA.Location = new System.Drawing.Point(93, 18);
            this.btnTakeNear4mA.Name = "btnTakeNear4mA";
            this.btnTakeNear4mA.Size = new System.Drawing.Size(75, 23);
            this.btnTakeNear4mA.TabIndex = 2;
            this.btnTakeNear4mA.Text = "Взять";
            this.btnTakeNear4mA.UseVisualStyleBackColor = true;
            this.btnTakeNear4mA.Click += new System.EventHandler(this.btnTakeNear4mA_Click);
            // 
            // btnTakeNear20mA
            // 
            this.btnTakeNear20mA.Location = new System.Drawing.Point(93, 89);
            this.btnTakeNear20mA.Name = "btnTakeNear20mA";
            this.btnTakeNear20mA.Size = new System.Drawing.Size(67, 23);
            this.btnTakeNear20mA.TabIndex = 2;
            this.btnTakeNear20mA.Text = "Взять";
            this.btnTakeNear20mA.UseVisualStyleBackColor = true;
            this.btnTakeNear20mA.Click += new System.EventHandler(this.btnTakeNear20mA_Click);
            // 
            // nudValue
            // 
            this.nudValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudValue.DecimalPlaces = 3;
            this.nudValue.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudValue.Location = new System.Drawing.Point(174, 47);
            this.nudValue.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(70, 21);
            this.nudValue.TabIndex = 0;
            // 
            // btnCalibrateAt4mA
            // 
            this.btnCalibrateAt4mA.Location = new System.Drawing.Point(250, 18);
            this.btnCalibrateAt4mA.Name = "btnCalibrateAt4mA";
            this.btnCalibrateAt4mA.Size = new System.Drawing.Size(147, 23);
            this.btnCalibrateAt4mA.TabIndex = 3;
            this.btnCalibrateAt4mA.Text = "Калибровать при 4 мА";
            this.btnCalibrateAt4mA.UseVisualStyleBackColor = true;
            this.btnCalibrateAt4mA.Click += new System.EventHandler(this.btnCalibrateAt4mA_Click);
            // 
            // btnCalibrateAt20mA
            // 
            this.btnCalibrateAt20mA.Location = new System.Drawing.Point(250, 89);
            this.btnCalibrateAt20mA.Name = "btnCalibrateAt20mA";
            this.btnCalibrateAt20mA.Size = new System.Drawing.Size(147, 23);
            this.btnCalibrateAt20mA.TabIndex = 3;
            this.btnCalibrateAt20mA.Text = "Калибровать при 20 мА";
            this.btnCalibrateAt20mA.UseVisualStyleBackColor = true;
            this.btnCalibrateAt20mA.Click += new System.EventHandler(this.btnCalibrateAt20mA_Click);
            // 
            // lbTaked4mA
            // 
            this.lbTaked4mA.AutoSize = true;
            this.lbTaked4mA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTaked4mA.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTaked4mA.Location = new System.Drawing.Point(403, 15);
            this.lbTaked4mA.Name = "lbTaked4mA";
            this.lbTaked4mA.Size = new System.Drawing.Size(147, 29);
            this.lbTaked4mA.TabIndex = 4;
            this.lbTaked4mA.Text = "0";
            this.lbTaked4mA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTaked20mA
            // 
            this.lbTaked20mA.AutoSize = true;
            this.lbTaked20mA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTaked20mA.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTaked20mA.Location = new System.Drawing.Point(403, 86);
            this.lbTaked20mA.Name = "lbTaked20mA";
            this.lbTaked20mA.Size = new System.Drawing.Size(147, 29);
            this.lbTaked20mA.TabIndex = 4;
            this.lbTaked20mA.Text = "0";
            this.lbTaked20mA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(403, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Поправки:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResult.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResult.Location = new System.Drawing.Point(625, 44);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(172, 27);
            this.lbResult.TabIndex = 4;
            this.lbResult.Text = "0";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(556, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "Результат:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 126);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Калибровочный алгоритм";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNear4mA)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNear20mA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown nudNear4mA;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private NumericUpDown nudNear20mA;
        private Button btnTakeNear4mA;
        private Button btnTakeNear20mA;
        private NumericUpDown nudValue;
        private Button btnCalibrateAt4mA;
        private Button btnCalibrateAt20mA;
        private Label lbTaked4mA;
        private Label lbTaked20mA;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Label lbResult;
        private Label label4;
    }
}