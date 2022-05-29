using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalInformationManagementSystem
{
    public partial class StartLoadingWindow : Form
    {
        public StartLoadingWindow()
        {
            InitializeComponent();
        }
        //Timer
        int timerBeginning = 0;

        //Times the timer to tick for 500 seconds then displays the Login form menu
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerBeginning += 1;
            loadingBar.Value = timerBeginning;
            if (loadingBar.Value == 50)
            {
                loadingBar.Value = 0;
                timer.Stop();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }
        //Starts the timer as soon as the window is loaded
        private void StartLoadingWindow_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

    }
}
