namespace Vectores
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
            btnGenerate = new Button();
            btnfill = new Button();
            btnshow = new Button();
            txtsize = new TextBox();
            listBoxResults = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 30);
            label1.TabIndex = 0;
            label1.Text = "Vector Size";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(12, 47);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(131, 23);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "Generate vector";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // btnfill
            // 
            btnfill.Location = new Point(12, 99);
            btnfill.Name = "btnfill";
            btnfill.Size = new Size(75, 23);
            btnfill.TabIndex = 2;
            btnfill.Text = "Fill Vector";
            btnfill.UseVisualStyleBackColor = true;
            btnfill.Click += btnfill_Click;
            // 
            // btnshow
            // 
            btnshow.Location = new Point(12, 255);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(131, 23);
            btnshow.TabIndex = 3;
            btnshow.Text = "Show Vector";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // txtsize
            // 
            txtsize.Location = new Point(180, 48);
            txtsize.Name = "txtsize";
            txtsize.Size = new Size(164, 23);
            txtsize.TabIndex = 4;
            // 
            // listBoxResults
            // 
            listBoxResults.FormattingEnabled = true;
            listBoxResults.ItemHeight = 15;
            listBoxResults.Location = new Point(93, 99);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(251, 139);
            listBoxResults.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 331);
            Controls.Add(listBoxResults);
            Controls.Add(txtsize);
            Controls.Add(btnshow);
            Controls.Add(btnfill);
            Controls.Add(btnGenerate);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGenerate;
        private Button btnfill;
        private Button btnshow;
        private TextBox txtsize;
        private ListBox listBoxResults;
    }
}
