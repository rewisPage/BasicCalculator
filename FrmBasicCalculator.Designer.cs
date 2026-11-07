namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            txtNum1 = new TextBox();
            cboOperator = new ComboBox();
            txtNum2 = new TextBox();
            panel1 = new Panel();
            lblTotal = new Label();
            label2 = new Label();
            btnCompute = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 19);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(186, 32);
            label1.TabIndex = 0;
            label1.Text = "Basic Calculator";
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum1.Location = new Point(19, 64);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(253, 29);
            txtNum1.TabIndex = 1;
            txtNum1.TextAlign = HorizontalAlignment.Right;
            // 
            // cboOperator
            // 
            cboOperator.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboOperator.FormattingEnabled = true;
            cboOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cboOperator.Location = new Point(111, 99);
            cboOperator.Name = "cboOperator";
            cboOperator.Size = new Size(57, 28);
            cboOperator.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum2.Location = new Point(19, 133);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(253, 29);
            txtNum2.TabIndex = 3;
            txtNum2.TextAlign = HorizontalAlignment.Right;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(19, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 78);
            panel1.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(10, 45);
            lblTotal.Margin = new Padding(10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(233, 23);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "0";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 10);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 0;
            label2.Text = "Total:";
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(60, 259);
            btnCompute.Margin = new Padding(10);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(161, 35);
            btnCompute.TabIndex = 5;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click;
            // 
            // FrmBasicCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 307);
            Controls.Add(btnCompute);
            Controls.Add(panel1);
            Controls.Add(txtNum2);
            Controls.Add(cboOperator);
            Controls.Add(txtNum1);
            Controls.Add(label1);
            Name = "FrmBasicCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Basic Calculator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum1;
        private ComboBox cboOperator;
        private TextBox txtNum2;
        private Panel panel1;
        private Label label2;
        private Label lblTotal;
        private Button btnCompute;
    }
}
