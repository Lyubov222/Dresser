
namespace DresserUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.DresserLengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BoxWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DresserHeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DresserWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BoxNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DresserShapeComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ErrorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.IsEnableShelvesCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DresserLengthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DresserHeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DresserWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxNumberNumericUpDown)).BeginInit();
            this.ErrorTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина комода:";
            // 
            // DresserLengthNumericUpDown
            // 
            this.DresserLengthNumericUpDown.Location = new System.Drawing.Point(164, 13);
            this.DresserLengthNumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.DresserLengthNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DresserLengthNumericUpDown.Name = "DresserLengthNumericUpDown";
            this.DresserLengthNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.DresserLengthNumericUpDown.TabIndex = 1;
            this.DresserLengthNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DresserLengthNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "от 1000 до 5000 мм";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ширина ящика:";
            // 
            // BoxWidthNumericUpDown
            // 
            this.BoxWidthNumericUpDown.Location = new System.Drawing.Point(164, 40);
            this.BoxWidthNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.BoxWidthNumericUpDown.Minimum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.BoxWidthNumericUpDown.Name = "BoxWidthNumericUpDown";
            this.BoxWidthNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.BoxWidthNumericUpDown.TabIndex = 4;
            this.BoxWidthNumericUpDown.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.BoxWidthNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "от 400 до 500 мм";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Высота комода:";
            // 
            // DresserHeightNumericUpDown
            // 
            this.DresserHeightNumericUpDown.Location = new System.Drawing.Point(164, 66);
            this.DresserHeightNumericUpDown.Maximum = new decimal(new int[] {
            1524,
            0,
            0,
            0});
            this.DresserHeightNumericUpDown.Minimum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.DresserHeightNumericUpDown.Name = "DresserHeightNumericUpDown";
            this.DresserHeightNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.DresserHeightNumericUpDown.TabIndex = 7;
            this.DresserHeightNumericUpDown.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.DresserHeightNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "от 700 до 1524 мм";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ширина комода:";
            // 
            // DresserWidthNumericUpDown
            // 
            this.DresserWidthNumericUpDown.Location = new System.Drawing.Point(164, 93);
            this.DresserWidthNumericUpDown.Maximum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.DresserWidthNumericUpDown.Minimum = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.DresserWidthNumericUpDown.Name = "DresserWidthNumericUpDown";
            this.DresserWidthNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.DresserWidthNumericUpDown.TabIndex = 10;
            this.DresserWidthNumericUpDown.Value = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.DresserWidthNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "от 450 до 550 мм";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Количество ящиков:";
            // 
            // BoxNumberNumericUpDown
            // 
            this.BoxNumberNumericUpDown.Location = new System.Drawing.Point(164, 122);
            this.BoxNumberNumericUpDown.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.BoxNumberNumericUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.BoxNumberNumericUpDown.Name = "BoxNumberNumericUpDown";
            this.BoxNumberNumericUpDown.Size = new System.Drawing.Size(60, 20);
            this.BoxNumberNumericUpDown.TabIndex = 13;
            this.BoxNumberNumericUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.BoxNumberNumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "от 3 до 7 шт";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Форма комода:";
            // 
            // DresserShapeComboBox
            // 
            this.DresserShapeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DresserShapeComboBox.FormattingEnabled = true;
            this.DresserShapeComboBox.Items.AddRange(new object[] {
            "Прямоугольник",
            "Трапеция",
            "Округлая"});
            this.DresserShapeComboBox.Location = new System.Drawing.Point(164, 150);
            this.DresserShapeComboBox.Name = "DresserShapeComboBox";
            this.DresserShapeComboBox.Size = new System.Drawing.Size(117, 21);
            this.DresserShapeComboBox.TabIndex = 16;
            this.DresserShapeComboBox.SelectedIndexChanged += new System.EventHandler(this.DresserShapeComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Открыть чертеж";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonOpenDrawing_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Построить модель\r\n\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonBuild_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ErrorLabel.Location = new System.Drawing.Point(3, 3);
            this.ErrorLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(425, 17);
            this.ErrorLabel.TabIndex = 0;
            this.ErrorLabel.Text = "label12";
            // 
            // ErrorTableLayoutPanel
            // 
            this.ErrorTableLayoutPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ErrorTableLayoutPanel.ColumnCount = 1;
            this.ErrorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ErrorTableLayoutPanel.Controls.Add(this.ErrorLabel, 0, 0);
            this.ErrorTableLayoutPanel.Location = new System.Drawing.Point(-3, 217);
            this.ErrorTableLayoutPanel.Name = "ErrorTableLayoutPanel";
            this.ErrorTableLayoutPanel.RowCount = 1;
            this.ErrorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ErrorTableLayoutPanel.Size = new System.Drawing.Size(431, 23);
            this.ErrorTableLayoutPanel.TabIndex = 19;
            this.ErrorTableLayoutPanel.Visible = false;
            // 
            // IsEnableShelvesCheckBox
            // 
            this.IsEnableShelvesCheckBox.AutoSize = true;
            this.IsEnableShelvesCheckBox.Location = new System.Drawing.Point(299, 152);
            this.IsEnableShelvesCheckBox.Name = "IsEnableShelvesCheckBox";
            this.IsEnableShelvesCheckBox.Size = new System.Drawing.Size(113, 17);
            this.IsEnableShelvesCheckBox.TabIndex = 20;
            this.IsEnableShelvesCheckBox.Text = "Построить полки";
            this.IsEnableShelvesCheckBox.UseVisualStyleBackColor = true;
            this.IsEnableShelvesCheckBox.CheckedChanged += new System.EventHandler(this.IsEnableShelvesCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 240);
            this.Controls.Add(this.IsEnableShelvesCheckBox);
            this.Controls.Add(this.ErrorTableLayoutPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DresserShapeComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BoxNumberNumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DresserWidthNumericUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DresserHeightNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxWidthNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DresserLengthNumericUpDown);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Плагин";
            ((System.ComponentModel.ISupportInitialize)(this.DresserLengthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DresserHeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DresserWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxNumberNumericUpDown)).EndInit();
            this.ErrorTableLayoutPanel.ResumeLayout(false);
            this.ErrorTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown DresserLengthNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown BoxWidthNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown DresserHeightNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown DresserWidthNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown BoxNumberNumericUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox DresserShapeComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label ErrorLabel;
		private System.Windows.Forms.TableLayoutPanel ErrorTableLayoutPanel;
		private System.Windows.Forms.CheckBox IsEnableShelvesCheckBox;
	}
}

