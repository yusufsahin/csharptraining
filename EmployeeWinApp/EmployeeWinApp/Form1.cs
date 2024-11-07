using System.Data.SqlClient;

namespace EmployeeWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string firstname = txtFirstname.Text;
            string lastname = txtLastname.Text;
            int age = int.Parse(txtAge.Text);

            DialogResult dialogResult = MessageBox.Show("Kaydetmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes) {
                //Database i�lemleri
                string connectionString = @"Data Source=localhost;User ID=sa;Password=Passw0rd@2024;Connect Timeout=30;Initial Catalog=EmployeeData";
                string query = "INSERT INTO Employees (Firstname, Lastname, Age) OUTPUT INSERTED.Id VALUES (@Firstname, @Lastname, @Age)";

                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Firstname", firstname);
                            command.Parameters.AddWithValue("@Lastname", lastname);
                            command.Parameters.AddWithValue("@Age", age);

                            connection.Open();
                            int id = (int)command.ExecuteScalar();
                            connection.Close();

                            MessageBox.Show("Kay�t i�lemi ba�ar�l�. Eklenen kay�t Id: " + id, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Kay�t i�lemi s�ras�nda hata olu�tu. Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Kaydetme i�lemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
