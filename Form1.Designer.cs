namespace SamTestApp
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
            label1 = new Label();
            label2 = new Label();
            txtNumberOfDie = new TextBox();
            txtNumberOfRolls = new TextBox();
            btnRoll = new Button();
            formsPlot = new ScottPlot.FormsPlot();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Number of dice:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 63);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 1;
            label2.Text = "Number of rolls:";
            // 
            // txtNumberOfDie
            // 
            txtNumberOfDie.Location = new Point(147, 10);
            txtNumberOfDie.Name = "txtNumberOfDie";
            txtNumberOfDie.Size = new Size(100, 23);
            txtNumberOfDie.TabIndex = 2;
            txtNumberOfDie.Text = "10";
            // 
            // txtNumberOfRolls
            // 
            txtNumberOfRolls.Location = new Point(148, 55);
            txtNumberOfRolls.Name = "txtNumberOfRolls";
            txtNumberOfRolls.Size = new Size(100, 23);
            txtNumberOfRolls.TabIndex = 3;
            txtNumberOfRolls.Text = "100";
            // 
            // btnRoll
            // 
            btnRoll.Location = new Point(271, 59);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(75, 23);
            btnRoll.TabIndex = 4;
            btnRoll.Text = "Roll!";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // formsPlot
            // 
            formsPlot.Location = new Point(30, 120);
            formsPlot.Margin = new Padding(4, 3, 4, 3);
            formsPlot.Name = "formsPlot";
            formsPlot.Size = new Size(376, 281);
            formsPlot.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(formsPlot);
            Controls.Add(btnRoll);
            Controls.Add(txtNumberOfRolls);
            Controls.Add(txtNumberOfDie);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Dice Sim";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumberOfDie;
        private TextBox txtNumberOfRolls;
        private Button btnRoll;
        private ScottPlot.FormsPlot formsPlot;
    }
}