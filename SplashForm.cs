using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Casino_Bet_And_Win
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        public void timer1_Tick(object sender, EventArgs e) { 
            timer1.Stop();
            this.Close();
            ClassforObjects.menu.Show();
        }
    }
}
