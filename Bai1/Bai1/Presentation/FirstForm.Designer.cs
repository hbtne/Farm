namespace Bai1.Presentation
{
    partial class FirstForm
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

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            bt_confirm = new Button();
            nud_cowAmount = new NumericUpDown();
            nud_sheepAmount = new NumericUpDown();
            nud_goatAmount = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nud_cowAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_sheepAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_goatAmount).BeginInit();
            SuspendLayout();
          
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(286, 25);
            label1.TabIndex = 1;
            label1.Text = "Nhập số lượng vật nuôi";
          
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(76, 53);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 2;
            label2.Text = "Số lượng Bò:";
         
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);trại";
            ((System.ComponentModel.ISupportInitialize)nud_cowAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_sheepAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_goatAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button bt_confirm;
        private NumericUpDown nud_cowAmount;
        private NumericUpDown nud_sheepAmount;
        private NumericUpDown nud_goatAmount;
    }
}
