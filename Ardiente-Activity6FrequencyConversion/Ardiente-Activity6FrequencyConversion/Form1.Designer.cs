namespace Ardiente_Activity6FrequencyConversion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonS = new System.Windows.Forms.RadioButton();
            this.outputText = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(348, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "INPUT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(337, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "OUTPUT";
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(210, 26);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(111, 24);
            this.radioButtonF.TabIndex = 2;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "FREQUENCY";
            this.radioButtonF.UseVisualStyleBackColor = true;
            this.radioButtonF.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonS
            // 
            this.radioButtonS.AutoSize = true;
            this.radioButtonS.Location = new System.Drawing.Point(0, 26);
            this.radioButtonS.Name = "radioButtonS";
            this.radioButtonS.Size = new System.Drawing.Size(102, 24);
            this.radioButtonS.TabIndex = 3;
            this.radioButtonS.TabStop = true;
            this.radioButtonS.Text = "SECOND/S";
            this.radioButtonS.UseVisualStyleBackColor = true;
            this.radioButtonS.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // outputText
            // 
            this.outputText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outputText.AutoSize = true;
            this.outputText.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputText.Location = new System.Drawing.Point(167, 314);
            this.outputText.Name = "outputText";
            this.outputText.Padding = new System.Windows.Forms.Padding(200, 1, 200, 1);
            this.outputText.Size = new System.Drawing.Size(433, 29);
            this.outputText.TabIndex = 4;
            this.outputText.Text = "---";
            this.outputText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.outputText.Click += new System.EventHandler(this.outputText_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(252, 194);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(286, 27);
            this.inputText.TabIndex = 5;
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(311, 371);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(150, 41);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonF);
            this.groupBox1.Controls.Add(this.radioButtonS);
            this.groupBox1.Location = new System.Drawing.Point(236, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 67);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "input";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton radioButtonF;
        private RadioButton radioButtonS;
        private Label outputText;
        private TextBox inputText;
        private Button convertButton;
        private GroupBox groupBox1;
    }
}