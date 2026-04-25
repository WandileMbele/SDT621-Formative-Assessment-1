partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private Label lblName;
    private Label lblID;
    private Label lblCitizen;
    private Label lblResult;

    private TextBox txtName;
    private TextBox txtID;
    private TextBox txtOutput;

    private ComboBox cmbCitizenship;

    private Button btnValidate;
    private Button btnGenerate;

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        lblName = new Label();
        lblID = new Label();
        lblCitizen = new Label();
        lblResult = new Label();
        txtName = new TextBox();
        txtID = new TextBox();
        txtOutput = new TextBox();
        cmbCitizenship = new ComboBox();
        btnValidate = new Button();
        btnGenerate = new Button();
        lblTitle = new Label();
        SuspendLayout();
        // 
        // lblName
        // 
        lblName.Location = new Point(20, 76);
        lblName.Name = "lblName";
        lblName.Size = new Size(100, 23);
        lblName.TabIndex = 0;
        lblName.Text = "Full Name:";
        lblName.Click += lblName_Click;
        // 
        // lblID
        // 
        lblID.Location = new Point(21, 115);
        lblID.Name = "lblID";
        lblID.Size = new Size(100, 23);
        lblID.TabIndex = 1;
        lblID.Text = "ID Number:";
        lblID.Click += lblID_Click;
        // 
        // lblCitizen
        // 
        lblCitizen.Location = new Point(21, 149);
        lblCitizen.Name = "lblCitizen";
        lblCitizen.Size = new Size(100, 23);
        lblCitizen.TabIndex = 2;
        lblCitizen.Text = "Citizenship:";
        lblCitizen.Click += lblCitizen_Click;
        // 
        // lblResult
        // 
        lblResult.Location = new Point(20, 270);
        lblResult.Name = "lblResult";
        lblResult.Size = new Size(100, 23);
        lblResult.TabIndex = 3;
        lblResult.Text = "Result:";
        // 
        // txtName
        // 
        txtName.Location = new Point(150, 73);
        txtName.Name = "txtName";
        txtName.Size = new Size(200, 31);
        txtName.TabIndex = 4;
        // 
        // txtID
        // 
        txtID.Location = new Point(150, 107);
        txtID.Name = "txtID";
        txtID.Size = new Size(200, 31);
        txtID.TabIndex = 5;
        // 
        // txtOutput
        // 
        txtOutput.BackColor = Color.White;
        txtOutput.Font = new Font("Consolas", 10F);
        txtOutput.Location = new Point(20, 300);
        txtOutput.Multiline = true;
        txtOutput.Name = "txtOutput";
        txtOutput.ReadOnly = true;
        txtOutput.Size = new Size(638, 288);
        txtOutput.TabIndex = 6;
        // 
        // cmbCitizenship
        // 
        cmbCitizenship.Items.AddRange(new object[] { "Citizen", "Permanent Resident", "Visitor" });
        cmbCitizenship.Location = new Point(150, 146);
        cmbCitizenship.Name = "cmbCitizenship";
        cmbCitizenship.Size = new Size(200, 33);
        cmbCitizenship.TabIndex = 7;
        // 
        // btnValidate
        // 
        btnValidate.BackColor = Color.Green;
        btnValidate.ForeColor = Color.White;
        btnValidate.Location = new Point(20, 188);
        btnValidate.Name = "btnValidate";
        btnValidate.Size = new Size(101, 34);
        btnValidate.TabIndex = 8;
        btnValidate.Text = "Validate ID";
        btnValidate.UseVisualStyleBackColor = false;
        btnValidate.Click += btnValidate_Click;
        // 
        // btnGenerate
        // 
        btnGenerate.BackColor = Color.Green;
        btnGenerate.ForeColor = Color.White;
        btnGenerate.Location = new Point(205, 188);
        btnGenerate.Name = "btnGenerate";
        btnGenerate.Size = new Size(107, 34);
        btnGenerate.TabIndex = 9;
        btnGenerate.Text = "Generate Profile";
        btnGenerate.UseVisualStyleBackColor = false;
        btnGenerate.Click += btnGenerate_Click;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitle.ForeColor = Color.FromArgb(0, 192, 0);
        lblTitle.Location = new Point(31, 9);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(613, 37);
        lblTitle.TabIndex = 10;
        lblTitle.Text = "Home Affairs Digital Identity Processor";
        lblTitle.Click += label1_Click;
        // 
        // Form1
        // 
        BackColor = Color.FromArgb(255, 192, 128);
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Zoom;
        ClientSize = new Size(1284, 616);
        Controls.Add(lblTitle);
        Controls.Add(lblName);
        Controls.Add(lblID);
        Controls.Add(lblCitizen);
        Controls.Add(lblResult);
        Controls.Add(txtName);
        Controls.Add(txtID);
        Controls.Add(txtOutput);
        Controls.Add(cmbCitizenship);
        Controls.Add(btnValidate);
        Controls.Add(btnGenerate);
        DoubleBuffered = true;
        Name = "Form1";
        Text = "Home Affairs Digital Identity Processor";
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblTitle;
}
