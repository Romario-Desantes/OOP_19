namespace OOP_19
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
            txtBoxNum1 = new TextBox();
            txtBoxNum2 = new TextBox();
            txtBoxNum3 = new TextBox();
            lbl_1 = new Label();
            btn_1 = new Button();
            lbl_2 = new Label();
            SuspendLayout();
            // 
            // txtBoxNum1
            // 
            txtBoxNum1.Location = new Point(47, 134);
            txtBoxNum1.MaxLength = 1;
            txtBoxNum1.Name = "txtBoxNum1";
            txtBoxNum1.Size = new Size(125, 27);
            txtBoxNum1.TabIndex = 0;
            // 
            // txtBoxNum2
            // 
            txtBoxNum2.Location = new Point(269, 134);
            txtBoxNum2.MaxLength = 1;
            txtBoxNum2.Name = "txtBoxNum2";
            txtBoxNum2.Size = new Size(125, 27);
            txtBoxNum2.TabIndex = 1;
            // 
            // txtBoxNum3
            // 
            txtBoxNum3.Location = new Point(510, 134);
            txtBoxNum3.MaxLength = 1;
            txtBoxNum3.Name = "txtBoxNum3";
            txtBoxNum3.Size = new Size(125, 27);
            txtBoxNum3.TabIndex = 2;
            // 
            // lbl_1
            // 
            lbl_1.AutoSize = true;
            lbl_1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbl_1.Location = new Point(47, 223);
            lbl_1.Name = "lbl_1";
            lbl_1.Size = new Size(310, 26);
            lbl_1.TabIndex = 3;
            lbl_1.Text = "Число утворене з трьох цифр: ";
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_1.Location = new Point(246, 315);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(185, 61);
            btn_1.TabIndex = 4;
            btn_1.Text = "Cтворити";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_1_Click;
            // 
            // lbl_2
            // 
            lbl_2.AutoSize = true;
            lbl_2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_2.Location = new Point(108, 54);
            lbl_2.Name = "lbl_2";
            lbl_2.Size = new Size(476, 32);
            lbl_2.TabIndex = 5;
            lbl_2.Text = "Введіть цифри, щоб утворити число";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 481);
            Controls.Add(lbl_2);
            Controls.Add(btn_1);
            Controls.Add(lbl_1);
            Controls.Add(txtBoxNum3);
            Controls.Add(txtBoxNum2);
            Controls.Add(txtBoxNum1);
            Name = "Form1";
            ShowIcon = false;
            Text = "OOP 19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxNum1;
        private TextBox txtBoxNum2;
        private TextBox txtBoxNum3;
        private Label lbl_1;
        private Button btn_1;
        private Label lbl_2;
    }
}
