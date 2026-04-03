namespace WinFormsApp1
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
            textBoxA = new TextBox();
            numericUpDownA = new NumericUpDown();
            trackBarA = new TrackBar();
            trackBarB = new TrackBar();
            trackBarC = new TrackBar();
            numericUpDownB = new NumericUpDown();
            numericUpDownC = new NumericUpDown();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            labelA = new Label();
            labelB = new Label();
            labelC = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownC).BeginInit();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(86, 131);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(120, 23);
            textBoxA.TabIndex = 0;
            textBoxA.Leave += textBoxA_Leave;
            // 
            // numericUpDownA
            // 
            numericUpDownA.Location = new Point(86, 182);
            numericUpDownA.Name = "numericUpDownA";
            numericUpDownA.Size = new Size(120, 23);
            numericUpDownA.TabIndex = 1;
            numericUpDownA.ValueChanged += numericUpDownA_ValueChanged;
            // 
            // trackBarA
            // 
            trackBarA.Location = new Point(86, 222);
            trackBarA.Name = "trackBarA";
            trackBarA.Size = new Size(120, 45);
            trackBarA.TabIndex = 2;
            trackBarA.Scroll += trackBarA_Scroll;
            // 
            // trackBarB
            // 
            trackBarB.Location = new Point(327, 222);
            trackBarB.Name = "trackBarB";
            trackBarB.Size = new Size(120, 45);
            trackBarB.TabIndex = 3;
            trackBarB.Scroll += trackBarB_Scroll;
            // 
            // trackBarC
            // 
            trackBarC.Location = new Point(576, 222);
            trackBarC.Name = "trackBarC";
            trackBarC.Size = new Size(120, 45);
            trackBarC.TabIndex = 4;
            trackBarC.Scroll += trackBarC_Scroll;
            // 
            // numericUpDownB
            // 
            numericUpDownB.Location = new Point(327, 182);
            numericUpDownB.Name = "numericUpDownB";
            numericUpDownB.Size = new Size(120, 23);
            numericUpDownB.TabIndex = 5;
            numericUpDownB.ValueChanged += numericUpDownB_ValueChanged;
            // 
            // numericUpDownC
            // 
            numericUpDownC.Location = new Point(576, 182);
            numericUpDownC.Name = "numericUpDownC";
            numericUpDownC.Size = new Size(120, 23);
            numericUpDownC.TabIndex = 6;
            numericUpDownC.ValueChanged += numericUpDownC_ValueChanged;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(327, 131);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(120, 23);
            textBoxB.TabIndex = 7;
            textBoxB.Leave += textBoxB_Leave;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(576, 131);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(120, 23);
            textBoxC.TabIndex = 8;
            textBoxC.Leave += textBoxC_Leave;
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelA.Location = new Point(127, 76);
            labelA.Name = "labelA";
            labelA.Size = new Size(29, 32);
            labelA.TabIndex = 9;
            labelA.Text = "A";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelB.Location = new Point(371, 76);
            labelB.Name = "labelB";
            labelB.Size = new Size(28, 32);
            labelB.TabIndex = 10;
            labelB.Text = "B";
            // 
            // labelC
            // 
            labelC.AutoSize = true;
            labelC.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelC.Location = new Point(625, 76);
            labelC.Name = "labelC";
            labelC.Size = new Size(29, 32);
            labelC.TabIndex = 11;
            labelC.Text = "C";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelC);
            Controls.Add(labelB);
            Controls.Add(labelA);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(numericUpDownC);
            Controls.Add(numericUpDownB);
            Controls.Add(trackBarC);
            Controls.Add(trackBarB);
            Controls.Add(trackBarA);
            Controls.Add(numericUpDownA);
            Controls.Add(textBoxA);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownA).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarC).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private NumericUpDown numericUpDownA;
        private TrackBar trackBarA;
        private TrackBar trackBarB;
        private TrackBar trackBarC;
        private NumericUpDown numericUpDownB;
        private NumericUpDown numericUpDownC;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Label labelA;
        private Label labelB;
        private Label labelC;
    }
}
