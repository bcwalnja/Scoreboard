using ScoreboardBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoreboard
{
    public partial class ControllerForm : Form
    {
        private ScoreController ScoreController;
        private FoulController FoulController;
        private ClockController ClockController;
        private PeriodController PeriodController;

        public ControllerForm()
        {
            InitializeComponent();
            InitializeControllerInstances();
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            EventMediator mediator = ScoreboardBLL.EventMediator.GetEventMediator();
            mediator.ClockChange += ControllerForm_ClockChange;
            mediator.FoulsChange += ControllerForm_FoulsChange;
            mediator.ScoreChange += ControllerForm_ScoreChange;
        }

        private void InitializeControllerInstances()
        {
            this.ScoreController = ScoreboardBLL.ScoreController.GetScoreController();
            this.FoulController = ScoreboardBLL.FoulController.GetFoulController();
            this.ClockController = ScoreboardBLL.ClockController.GetClockController();
            this.PeriodController = ScoreboardBLL.PeriodController.GetPeriodController();
        }

        private void BtnHomeMinus_Click(object sender, EventArgs e)
        {
            ScoreController.ScoreEvent(Team.Home, -1);
        }

        private void BtnHomePlus_Click(object sender, EventArgs e)
        {
            ScoreController.ScoreEvent(Team.Home, 1);
        }

        private void BtnPossession_Click(object sender, EventArgs e)
        {

        }

        private void BtnMinutesMinus_Click(object sender, EventArgs e)
        {

        }

        private void BtnMinutesPlus_Click(object sender, EventArgs e)
        {

        }

        private void BtnSecondsMinus_Click(object sender, EventArgs e)
        {

        }

        private void BtnSecondsPlus_Click(object sender, EventArgs e)
        {

        }

        private void BtnAwayMinus_Click(object sender, EventArgs e)
        {

        }

        private void BtnAwayPlus_Click(object sender, EventArgs e)
        {

        }

        private void BtnHomeFoulsMinus_Click(object sender, EventArgs e)
        {

        }

        private void BtnHomeFoulsPlus_Click(object sender, EventArgs e)
        {

        }

        private void BtnPeriod_Click(object sender, EventArgs e)
        {

        }

        private void BtnTimeoutStart_Click(object sender, EventArgs e)
        {

        }

        private void BtnTimeoutPlus_Click(object sender, EventArgs e)
        {

        }

        private void BtnTimeoutClear_Click(object sender, EventArgs e)
        {

        }

        private void BtnAwayFoulsMinus_Click(object sender, EventArgs e)
        {

        }

        private void BtnAwayFoulsPlus_Click(object sender, EventArgs e)
        {

        }

        private void ControllerForm_ScoreChange(object sender, ScoreChangeEventArgs e)
        {
            txtHomeScore.Text = e.GameScore.HomeScore.ToString();
            txtAwayScore.Text = e.GameScore.AwayScore.ToString();
        }

        private void ControllerForm_FoulsChange(object sender, FoulChangeEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ControllerForm_ClockChange(object sender, ClockChangeEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}