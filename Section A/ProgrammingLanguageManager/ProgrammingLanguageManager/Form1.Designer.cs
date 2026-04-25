namespace ProgrammingLanguageManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstLanguages;
        private System.Windows.Forms.Label lblDateTime;

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
            lblTitle = new Label();
            txtLanguage = new TextBox();
            btnAdd = new Button();
            btnRemove = new Button();
            lstLanguages = new ListBox();
            lblDateTime = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(177, 342);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(253, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Enter Programming Language:";
            lblTitle.Click += lblTitle_Click;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(177, 385);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.Size = new Size(200, 31);
            txtLanguage.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 192, 0);
            btnAdd.Location = new Point(177, 452);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(131, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Location = new Point(331, 452);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(131, 39);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lstLanguages
            // 
            lstLanguages.FormattingEnabled = true;
            lstLanguages.Location = new Point(177, 171);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(575, 129);
            lstLanguages.TabIndex = 4;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(177, 300);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(0, 25);
            lblDateTime.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 38);
            label1.Name = "label1";
            label1.Size = new Size(826, 60);
            label1.TabIndex = 6;
            label1.Text = " My Favourite Programming Language";
            label1.UseMnemonic = false;
            // 
            // Form1
            // 
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1221, 638);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(txtLanguage);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(lstLanguages);
            Controls.Add(lblDateTime);
            Name = "Form1";
            Text = "Programming Language Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
    }
}