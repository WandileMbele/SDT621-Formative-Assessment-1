public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnValidate_Click(object sender, EventArgs e)
    {
        CitizenProfile profile = new CitizenProfile(
            txtName.Text,
            txtID.Text,
            cmbCitizenship.Text
        );

        if (profile.ValidateID() == "ID is valid")
        {
            lblResult.Text = $"Valid ID. Citizen is {profile.Age} years old.";
        }
        else
        {
            lblResult.Text = profile.ValidateID();
        }
    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {
        CitizenProfile profile = new CitizenProfile(
            txtName.Text,
            txtID.Text,
            cmbCitizenship.Text
        );

        string validation = profile.ValidateID();

        string output = "===== DIGITAL CITIZEN SUMMARY =====\r\n" +
                        $"Name: {profile.FullName}\r\n" +
                        $"ID Number: {profile.IDNumber}\r\n" +
                        $"Age: {profile.Age}\r\n" +
                        $"Citizenship: {profile.CitizenshipStatus}\r\n" +
                        $"Validation: {validation}\r\n" +
                        $"Processed at: Home Affairs Digital Desk\r\n" +
                        $"Timestamp: {DateTime.Now:yyyy/MM/dd HH:mm:ss}";

        txtOutput.Text = output;
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void lblCitizen_Click(object sender, EventArgs e)
    {

    }

    private void lblID_Click(object sender, EventArgs e)
    {

    }

    private void lblName_Click(object sender, EventArgs e)
    {

    }
}
