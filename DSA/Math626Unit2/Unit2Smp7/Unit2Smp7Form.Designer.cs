namespace Unit2Smp7
{
    partial class Unit2Smp7Form
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
            knapsackTextBox = new TextBox();
            knapsackLabel = new Label();
            calculateButton = new Button();
            optimalSelectionLabel = new Label();
            optimalTextBox = new TextBox();
            maxProfitLabel = new Label();
            maxProfitTextBox = new TextBox();
            recursiveCallsTextBox = new TextBox();
            recursiveCallsLabel = new Label();
            loadButton = new Button();
            maxWeightLabel = new Label();
            maxWeightTextBox = new TextBox();
            solutionWeightLabel = new Label();
            solWeightTextBox = new TextBox();
            SuspendLayout();
            // 
            // knapsackTextBox
            // 
            knapsackTextBox.BackColor = Color.FromArgb(192, 255, 255);
            knapsackTextBox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            knapsackTextBox.Location = new Point(3, 41);
            knapsackTextBox.Multiline = true;
            knapsackTextBox.Name = "knapsackTextBox";
            knapsackTextBox.ReadOnly = true;
            knapsackTextBox.Size = new Size(169, 446);
            knapsackTextBox.TabIndex = 0;
            // 
            // knapsackLabel
            // 
            knapsackLabel.AutoSize = true;
            knapsackLabel.Location = new Point(3, 12);
            knapsackLabel.Name = "knapsackLabel";
            knapsackLabel.Size = new Size(83, 15);
            knapsackLabel.TabIndex = 1;
            knapsackLabel.Text = "Knapsack data";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(3, 493);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(151, 23);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Get Optimal Profit";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // optimalSelectionLabel
            // 
            optimalSelectionLabel.AutoSize = true;
            optimalSelectionLabel.Location = new Point(212, 12);
            optimalSelectionLabel.Name = "optimalSelectionLabel";
            optimalSelectionLabel.Size = new Size(101, 15);
            optimalSelectionLabel.TabIndex = 3;
            optimalSelectionLabel.Text = "Optimal Selection";
            // 
            // optimalTextBox
            // 
            optimalTextBox.BackColor = Color.FromArgb(255, 192, 192);
            optimalTextBox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            optimalTextBox.Location = new Point(178, 41);
            optimalTextBox.Multiline = true;
            optimalTextBox.Name = "optimalTextBox";
            optimalTextBox.ReadOnly = true;
            optimalTextBox.Size = new Size(165, 446);
            optimalTextBox.TabIndex = 4;
            // 
            // maxProfitLabel
            // 
            maxProfitLabel.AutoSize = true;
            maxProfitLabel.Location = new Point(178, 557);
            maxProfitLabel.Name = "maxProfitLabel";
            maxProfitLabel.Size = new Size(65, 15);
            maxProfitLabel.TabIndex = 5;
            maxProfitLabel.Text = "Max profit:";
            // 
            // maxProfitTextBox
            // 
            maxProfitTextBox.BackColor = Color.FromArgb(255, 192, 192);
            maxProfitTextBox.Location = new Point(249, 554);
            maxProfitTextBox.Name = "maxProfitTextBox";
            maxProfitTextBox.ReadOnly = true;
            maxProfitTextBox.Size = new Size(94, 23);
            maxProfitTextBox.TabIndex = 6;
            maxProfitTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // recursiveCallsTextBox
            // 
            recursiveCallsTextBox.Location = new Point(249, 592);
            recursiveCallsTextBox.Name = "recursiveCallsTextBox";
            recursiveCallsTextBox.ReadOnly = true;
            recursiveCallsTextBox.Size = new Size(94, 23);
            recursiveCallsTextBox.TabIndex = 7;
            recursiveCallsTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // recursiveCallsLabel
            // 
            recursiveCallsLabel.AutoSize = true;
            recursiveCallsLabel.Location = new Point(99, 595);
            recursiveCallsLabel.Name = "recursiveCallsLabel";
            recursiveCallsLabel.Size = new Size(144, 15);
            recursiveCallsLabel.TabIndex = 8;
            recursiveCallsLabel.Text = "Number of recursive calls:";
            // 
            // loadButton
            // 
            loadButton.Location = new Point(85, 8);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(69, 23);
            loadButton.TabIndex = 9;
            loadButton.Text = "Load New";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // maxWeightLabel
            // 
            maxWeightLabel.AutoSize = true;
            maxWeightLabel.Location = new Point(3, 524);
            maxWeightLabel.Name = "maxWeightLabel";
            maxWeightLabel.Size = new Size(106, 15);
            maxWeightLabel.TabIndex = 10;
            maxWeightLabel.Text = "Maximum Weight:";
            // 
            // maxWeightTextBox
            // 
            maxWeightTextBox.BackColor = Color.FromArgb(192, 255, 255);
            maxWeightTextBox.Location = new Point(115, 521);
            maxWeightTextBox.Name = "maxWeightTextBox";
            maxWeightTextBox.ReadOnly = true;
            maxWeightTextBox.Size = new Size(57, 23);
            maxWeightTextBox.TabIndex = 11;
            maxWeightTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // solutionWeightLabel
            // 
            solutionWeightLabel.AutoSize = true;
            solutionWeightLabel.Location = new Point(178, 529);
            solutionWeightLabel.Name = "solutionWeightLabel";
            solutionWeightLabel.Size = new Size(108, 15);
            solutionWeightLabel.TabIndex = 12;
            solutionWeightLabel.Text = "Weight of solution:";
            // 
            // solWeightTextBox
            // 
            solWeightTextBox.BackColor = Color.FromArgb(255, 192, 192);
            solWeightTextBox.Location = new Point(292, 525);
            solWeightTextBox.Name = "solWeightTextBox";
            solWeightTextBox.ReadOnly = true;
            solWeightTextBox.Size = new Size(51, 23);
            solWeightTextBox.TabIndex = 13;
            solWeightTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Unit2Smp7Form
            // 
            AcceptButton = calculateButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 629);
            Controls.Add(solWeightTextBox);
            Controls.Add(solutionWeightLabel);
            Controls.Add(maxWeightTextBox);
            Controls.Add(maxWeightLabel);
            Controls.Add(loadButton);
            Controls.Add(recursiveCallsLabel);
            Controls.Add(recursiveCallsTextBox);
            Controls.Add(maxProfitTextBox);
            Controls.Add(maxProfitLabel);
            Controls.Add(optimalTextBox);
            Controls.Add(optimalSelectionLabel);
            Controls.Add(calculateButton);
            Controls.Add(knapsackLabel);
            Controls.Add(knapsackTextBox);
            MaximizeBox = false;
            Name = "Unit2Smp7Form";
            Text = "Unit2Smp7 - 0-1 Knapsack Problem";
            Load += Unit2Smp7Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox knapsackTextBox;
        private Label knapsackLabel;
        private Button calculateButton;
        private Label optimalSelectionLabel;
        private TextBox optimalSelectionTextBox;
        private Label maxProfitLabel;
        private TextBox maxProfitTextBox;
        private TextBox recursiveCallsTextBox;
        private Label recursiveCallsLabel;
        private Button loadButton;
        private TextBox optimalTextBox;
        private Label maxWeightLabel;
        private TextBox maxWeightTextBox;
        private Label solutionWeightLabel;
        private TextBox solWeightTextBox;
    }
}