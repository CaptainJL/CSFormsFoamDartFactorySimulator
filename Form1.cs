using System.Runtime.InteropServices;

namespace CSFormsFoamDartFactorySimulator
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer1;

        private CreditsSystem cSystem;
        private FoamDartsSystem fdSystem;
        private float formFPS = 5;
        private ulong startingCredits = 1000;

        public Form1()
        {
            InitializeComponent();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(TickRun);
            timer1.Interval = 1000 / (int)formFPS;    // 1 FPS frames
            timer1.Start();

            cSystem = new CreditsSystem(startingCredits);
            fdSystem = new FoamDartsSystem();

            UpdateDisplay();
        }

        private void TickRun(object sender, EventArgs e)
        {
            UpdateValues();
            UpdateDisplay();
        }

        private void UpdateValues()
        {
            cSystem.CreditsSumList.Clear();
            cSystem.CreditsMultList.Clear();
            fdSystem.FoamDartsSumList.Clear();
            fdSystem.FoamDartsMultList.Clear();

            cSystem.CreditsSumList.Add(50);
            cSystem.CreditsMultList.Add(1.3333333);
            fdSystem.FoamDartsSumList.Add(1);

            cSystem.CreditsUpdate();
            fdSystem.FoamDartsUpdate();
            
        }

        public void UpdateDisplay()
        {
            creditsLabel.Text = cSystem.Credits.ToString();
            creditsTotalLabel.Text = cSystem.CreditsTotal.ToString();
            foamDartsLabel.Text = fdSystem.FoamDarts.ToString();
            foamDartsTotalLabel.Text = fdSystem.FoamDartsTotal.ToString();
        }


    }
}