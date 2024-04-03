namespace kohonenNetwork
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
            numClusters = new NumericUpDown();
            label1 = new Label();
            selfTrain = new Button();
            label2 = new Label();
            numParams = new NumericUpDown();
            outputBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numClusters).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numParams).BeginInit();
            SuspendLayout();
            // 
            // numClusters
            // 
            numClusters.Location = new Point(99, 175);
            numClusters.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numClusters.Name = "numClusters";
            numClusters.Size = new Size(120, 23);
            numClusters.TabIndex = 0;
            numClusters.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 179);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Кластеров";
            // 
            // selfTrain
            // 
            selfTrain.Location = new Point(289, 198);
            selfTrain.Name = "selfTrain";
            selfTrain.Size = new Size(100, 23);
            selfTrain.TabIndex = 2;
            selfTrain.Text = "Распределить";
            selfTrain.UseVisualStyleBackColor = true;
            selfTrain.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(422, 177);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 4;
            label2.Text = "Параметров";
            // 
            // numParams
            // 
            numParams.Location = new Point(503, 175);
            numParams.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numParams.Name = "numParams";
            numParams.Size = new Size(120, 23);
            numParams.TabIndex = 5;
            numParams.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // outputBox
            // 
            outputBox.BorderStyle = BorderStyle.None;
            outputBox.Dock = DockStyle.Bottom;
            outputBox.Location = new Point(0, 262);
            outputBox.Multiline = true;
            outputBox.Name = "outputBox";
            outputBox.ScrollBars = ScrollBars.Vertical;
            outputBox.Size = new Size(672, 232);
            outputBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 494);
            Controls.Add(numParams);
            Controls.Add(label2);
            Controls.Add(outputBox);
            Controls.Add(selfTrain);
            Controls.Add(label1);
            Controls.Add(numClusters);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numClusters).EndInit();
            ((System.ComponentModel.ISupportInitialize)numParams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numClusters;
        private Label label1;
        private Button selfTrain;
        private Label label2;
        private NumericUpDown numParams;
        private TextBox outputBox;
    }
}