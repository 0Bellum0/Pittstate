namespace Unit2Prb1
{
    partial class Unit2Prb1Form
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
            this.rowLabel = new System.Windows.Forms.Label();
            this.rowTextBox = new System.Windows.Forms.TextBox();
            this.columnLabel = new System.Windows.Forms.Label();
            this.columnTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.areaLabel = new System.Windows.Forms.Label();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.mapTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rowLabel
            // 
            this.rowLabel.AutoSize = true;
            this.rowLabel.Location = new System.Drawing.Point(19, 16);
            this.rowLabel.Name = "rowLabel";
            this.rowLabel.Size = new System.Drawing.Size(33, 15);
            this.rowLabel.TabIndex = 0;
            this.rowLabel.Text = "Row:";
            // 
            // rowTextBox
            // 
            this.rowTextBox.Location = new System.Drawing.Point(58, 13);
            this.rowTextBox.Name = "rowTextBox";
            this.rowTextBox.Size = new System.Drawing.Size(46, 23);
            this.rowTextBox.TabIndex = 1;
            // 
            // columnLabel
            // 
            this.columnLabel.AutoSize = true;
            this.columnLabel.Location = new System.Drawing.Point(-1, 47);
            this.columnLabel.Name = "columnLabel";
            this.columnLabel.Size = new System.Drawing.Size(53, 15);
            this.columnLabel.TabIndex = 2;
            this.columnLabel.Text = "Column:";
            // 
            // columnTextBox
            // 
            this.columnTextBox.Location = new System.Drawing.Point(58, 47);
            this.columnTextBox.Name = "columnTextBox";
            this.columnTextBox.Size = new System.Drawing.Size(46, 23);
            this.columnTextBox.TabIndex = 3;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(111, 13);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate ";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(111, 47);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(14, 83);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(34, 15);
            this.areaLabel.TabIndex = 6;
            this.areaLabel.Text = "Area:";
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(58, 80);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.ReadOnly = true;
            this.areaTextBox.Size = new System.Drawing.Size(128, 23);
            this.areaTextBox.TabIndex = 7;
            // 
            // mapTextBox
            // 
            this.mapTextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mapTextBox.Location = new System.Drawing.Point(192, 12);
            this.mapTextBox.Multiline = true;
            this.mapTextBox.Name = "mapTextBox";
            this.mapTextBox.ReadOnly = true;
            this.mapTextBox.Size = new System.Drawing.Size(323, 381);
            this.mapTextBox.TabIndex = 8;
            // 
            // Unit2Prb1Form
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.resetButton;
            this.ClientSize = new System.Drawing.Size(527, 405);
            this.Controls.Add(this.mapTextBox);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.columnTextBox);
            this.Controls.Add(this.columnLabel);
            this.Controls.Add(this.rowTextBox);
            this.Controls.Add(this.rowLabel);
            this.MaximizeBox = false;
            this.Name = "Unit2Prb1Form";
            this.Text = "Unit2Prb1 - Water area problem";
            this.Load += new System.EventHandler(this.Unit2Prb1Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label rowLabel;
        private TextBox rowTextBox;
        private Label columnLabel;
        private TextBox columnTextBox;
        private Button calculateButton;
        private Button resetButton;
        private Label areaLabel;
        private TextBox areaTextBox;
        private TextBox mapTextBox;
    }
}