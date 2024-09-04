

namespace Unit1Smp4
{
    partial class Unit1Smp4Form
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
            this.saveButton = new System.Windows.Forms.Button();
            this.undoButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.editTextBox = new System.Windows.Forms.TextBox();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.stackLabel = new System.Windows.Forms.Label();
            this.stackLengthTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 56);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // undoButton
            // 
            this.undoButton.Location = new System.Drawing.Point(93, 56);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(75, 23);
            this.undoButton.TabIndex = 1;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.Click += new System.EventHandler(this.undoButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeLabel.Location = new System.Drawing.Point(12, 141);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(97, 21);
            this.changeLabel.TabIndex = 2;
            this.changeLabel.Text = "Change log";
            // 
            // editTextBox
            // 
            this.editTextBox.Location = new System.Drawing.Point(12, 27);
            this.editTextBox.Name = "editTextBox";
            this.editTextBox.Size = new System.Drawing.Size(265, 23);
            this.editTextBox.TabIndex = 3;
            this.editTextBox.Text = "Edit this.";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(12, 174);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(265, 294);
            this.logTextBox.TabIndex = 4;
            // 
            // stackLabel
            // 
            this.stackLabel.AutoSize = true;
            this.stackLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stackLabel.Location = new System.Drawing.Point(12, 116);
            this.stackLabel.Name = "stackLabel";
            this.stackLabel.Size = new System.Drawing.Size(109, 21);
            this.stackLabel.TabIndex = 5;
            this.stackLabel.Text = "Stack length:";
            // 
            // stackLengthTextBox
            // 
            this.stackLengthTextBox.Location = new System.Drawing.Point(127, 114);
            this.stackLengthTextBox.Name = "stackLengthTextBox";
            this.stackLengthTextBox.ReadOnly = true;
            this.stackLengthTextBox.Size = new System.Drawing.Size(29, 23);
            this.stackLengthTextBox.TabIndex = 6;
            this.stackLengthTextBox.Text = "0";
            // 
            // Unit1Smp4Form
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.undoButton;
            this.ClientSize = new System.Drawing.Size(289, 480);
            this.Controls.Add(this.stackLengthTextBox);
            this.Controls.Add(this.stackLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.editTextBox);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.undoButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Unit1Smp4Form";
            this.Text = "Unit1Smp4";
            this.ResumeLayout(false);
            this.PerformLayout();

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