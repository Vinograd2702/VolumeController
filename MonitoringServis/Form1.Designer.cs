namespace MonitoringServis
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
            myControl = new MyControl.MyControl();
            currentValueBox = new TextBox();
            SuspendLayout();
            // 
            // myControl
            // 
            myControl.Location = new Point(407, 82);
            myControl.Name = "myControl";
            myControl.Size = new Size(200, 200);
            myControl.TabIndex = 1;
            myControl.Text = "myControl1";
            myControl.Click += myControl_Click;
            myControl.MouseMove += myControl_MouseMove;
            // 
            // currentValueBox
            // 
            currentValueBox.Location = new Point(176, 151);
            currentValueBox.Name = "currentValueBox";
            currentValueBox.Size = new Size(100, 23);
            currentValueBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(currentValueBox);
            Controls.Add(myControl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MyControl.MyControl myControl;
        private TextBox currentValueBox;
    }
}
