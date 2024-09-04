

namespace Unit1Smp2
{
    partial class Unit1Smp2Form
    {

        private System.ComponentModel.IContainer components = null;
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
            saveButton = new Button();
            undoButton = new Button();
            changeLabel = new Label();
            editTextBox = new TextBox();
            logTextBox = new TextBox();
            stackLabel = new Label();
            stackLengthTextBox = new TextBox();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.Location = new Point(12, 56);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // undoButton
            // 
            undoButton.Location = new Point(93, 56);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(75, 23);
            undoButton.TabIndex = 1;
            undoButton.Text = "Undo";
            undoButton.UseVisualStyleBackColor = true;
            undoButton.Click += undoButton_Click;
            // 
            // changeLabel
            // 
            changeLabel.AutoSize = true;
            changeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            changeLabel.Location = new Point(12, 141);
            changeLabel.Name = "changeLabel";
            changeLabel.Size = new Size(97, 21);
            changeLabel.TabIndex = 2;
            changeLabel.Text = "Change log";
            // 
            // editTextBox
            // 
            editTextBox.Location = new Point(12, 27);
            editTextBox.Name = "editTextBox";
            editTextBox.Size = new Size(265, 23);
            editTextBox.TabIndex = 3;
            editTextBox.Text = "Edit this.";
            // 
            // logTextBox
            // 
            logTextBox.Location = new Point(12, 174);
            logTextBox.Multiline = true;
            logTextBox.Name = "logTextBox";
            logTextBox.ReadOnly = true;
            logTextBox.Size = new Size(265, 294);
            logTextBox.TabIndex = 4;
            // 
            // stackLabel
            // 
            stackLabel.AutoSize = true;
            stackLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            stackLabel.Location = new Point(12, 116);
            stackLabel.Name = "stackLabel";
            stackLabel.Size = new Size(109, 21);
            stackLabel.TabIndex = 5;
            stackLabel.Text = "Stack length:";
            // 
            // stackLengthTextBox
            // 
            stackLengthTextBox.Location = new Point(127, 114);
            stackLengthTextBox.Name = "stackLengthTextBox";
            stackLengthTextBox.ReadOnly = true;
            stackLengthTextBox.Size = new Size(29, 23);
            stackLengthTextBox.TabIndex = 6;
            stackLengthTextBox.Text = "0";
            // 
            // Unit1Smp2Form
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = undoButton;
            ClientSize = new Size(289, 480);
            Controls.Add(stackLengthTextBox);
            Controls.Add(stackLabel);
            Controls.Add(logTextBox);
            Controls.Add(editTextBox);
            Controls.Add(changeLabel);
            Controls.Add(undoButton);
            Controls.Add(saveButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Unit1Smp2Form";
            Text = "Unit1Smp2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private Button undoButton;
        private Label changeLabel;
        private TextBox editTextBox;
        private TextBox logTextBox;
        private Label stackLabel;
        private TextBox stackLengthTextBox;
    }
}