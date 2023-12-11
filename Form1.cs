using System.ComponentModel.DataAnnotations;

namespace Hasan.Badr.harjoitus14
{
    public partial class DiaryForm : Form
    {
        public DiaryForm()
        {
            InitializeComponent();
        }

        private void TallennaBT_Click(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText();
            teksti += SyottoTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.mm.yyyy.HH:mm") + "\n";
            Textweiter Text = new streeanwriter();
            Text.close();
            Application.Exit();

        }

        private void DiaryForm_Load(object sender, EventArgs e)
        {

        }
    }
}