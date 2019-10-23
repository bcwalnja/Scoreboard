using ScoreboardBLL;
using System;
using System.Windows.Forms;

namespace Scoreboard
{
    public partial class ControllerForm : Form
    {
        private ScoreController ScoreController;
        private FoulController FoulController;
        private ClockController ClockController;
        private PeriodController PeriodController;
        private PossessionController PossessionController;
        private TimeoutController TimeoutController;

        private delegate void HornDelegate(bool enabled);

        public ControllerForm()
        {
            InitializeComponent();
            InitializeControllerInstances();
            SubscribeToEvents();
        }

        private void InitializeControllerInstances()
        {
            this.ScoreController = ScoreboardBLL.ScoreController.GetScoreController();
            this.FoulController = ScoreboardBLL.FoulController.GetFoulController();
            this.ClockController = ScoreboardBLL.ClockController.GetClockController();
            this.PeriodController = ScoreboardBLL.PeriodController.GetPeriodController();
            this.PossessionController = ScoreboardBLL.PossessionController.GetPossessionController();
            this.TimeoutController = ScoreboardBLL.TimeoutController.GetTimeoutController();
        }

        private void SubscribeToEvents()
        {
            EventMediator mediator = EventMediator.GetEventMediator();
            mediator.ClockChange += ControllerForm_ClockChange;
            mediator.FoulsChange += ControllerForm_FoulsChange;
            mediator.ScoreChange += ControllerForm_ScoreChange;
            mediator.TimeoutChange += ControllerForm_TimeoutChange;
            mediator.PossessionChange += ControllerForm_PossessionChange;
            mediator.PeriodChange += ControllerForm_PeriodChange;
            mediator.GameClockExpire += ControllerForm_GameClockExpire;
            mediator.TimeoutClockExpire += ControllerForm_TimeoutClockExpire;
            mediator.GameClockSounding += ControllerForm_GameClockSounding;
            mediator.GameClockSounded += ControllerForm_GameClockSounded;
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
            PossessionController.ChangePossession();
        }

        private void BtnMinutesMinus_Click(object sender, EventArgs e)
        {
            if (!GameClockTimer.Enabled)
            {
                ClockController.AdjustMinutes(-1);
            }
        }

        private void BtnMinutesPlus_Click(object sender, EventArgs e)
        {
            if (!GameClockTimer.Enabled)
            {
                ClockController.AdjustMinutes(1);
            }
        }

        private void BtnSecondsMinus_Click(object sender, EventArgs e)
        {
            if (!GameClockTimer.Enabled)
            {
                ClockController.AdjustSeconds(-1);
            }
        }

        private void BtnSecondsPlus_Click(object sender, EventArgs e)
        {
            if (!GameClockTimer.Enabled)
            {
                ClockController.AdjustSeconds(1);
            }
        }

        private void BtnAwayMinus_Click(object sender, EventArgs e)
        {
            ScoreController.ScoreEvent(Team.Away, -1);
        }

        private void BtnAwayPlus_Click(object sender, EventArgs e)
        {
            ScoreController.ScoreEvent(Team.Away, 1);
        }

        private void BtnHomeFoulsMinus_Click(object sender, EventArgs e)
        {
            FoulController.DecrementFouls(Team.Home);
        }

        private void BtnHomeFoulsPlus_Click(object sender, EventArgs e)
        {
            FoulController.IncrementFouls(Team.Home);
        }

        private void BtnPeriod_Click(object sender, EventArgs e)
        {
            PeriodController.IncrementPeriod();
        }

        private void BtnTimeoutStart_Click(object sender, EventArgs e)
        {
            
            if (TimeoutController.GetSeconds() > 0)
            {
                TimeoutTimer.Enabled = true;
            }
        }

        private void BtnTimeoutPlus_Click(object sender, EventArgs e)
        {
            if (!TimeoutTimer.Enabled)
            {
                TimeoutController.IncrementTimeoutSeconds();
            }
        }

        private void BtnTimeoutClear_Click(object sender, EventArgs e)
        {
            TimeoutTimer.Enabled = false;
            TimeoutController.ResetTimeout();
        }

        private void BtnAwayFoulsMinus_Click(object sender, EventArgs e)
        {
            FoulController.DecrementFouls(Team.Away);
        }

        private void BtnAwayFoulsPlus_Click(object sender, EventArgs e)
        {
            FoulController.IncrementFouls(Team.Away);
        }

        private void ControllerForm_ScoreChange(object sender, ScoreChangeEventArgs e)
        {
            txtHomeScore.Text = e.GameScore.HomeScore.ToString();
            txtAwayScore.Text = e.GameScore.AwayScore.ToString();
        }

        private void ControllerForm_FoulsChange(object sender, FoulChangeEventArgs e)
        {
            SetFoulIndicators(e);
            SetFoulBonusIndicators(e);
        }

        private void SetFoulBonusIndicators(FoulChangeEventArgs e)
        {
            lightHomeBonus.StateIndex = e.GameFouls.HomeFouls() > 6 ? 3 : 0;
            lightHomeDoubleBonus.StateIndex = e.GameFouls.HomeFouls() > 9 ? 3 : 0;
            lightAwayBonus.StateIndex = e.GameFouls.AwayFouls() > 6 ? 3 : 0;
            lightAwayDoubleBonus.StateIndex = e.GameFouls.AwayFouls() > 9 ? 3 : 0;
        }

        private void SetFoulIndicators(FoulChangeEventArgs e)
        {
            txtHomeFouls.Text = e.GameFouls.HomeFouls().ToString();
            txtAwayFouls.Text = e.GameFouls.AwayFouls().ToString();
        }

        private void ControllerForm_ClockChange(object sender, ClockChangeEventArgs e)
        {
            string gametime = string.Empty;
            if (e.GameTime.Minutes > 0)
            {
                string minutes = e.GameTime.Minutes.ToString().PadLeft(2, '0');
                string seconds = e.GameTime.Seconds.ToString().PadLeft(2, '0');
                gametime = $"{minutes}:{seconds}";
            }
            else
            {
                string seconds = e.GameTime.Seconds.ToString().PadLeft(2, '0');
                string tenths = e.GameTime.Tenths.ToString();
                gametime = $"{seconds}.{tenths}";
            }
            txtGameTime.Text = gametime;
        }

        private void ControllerForm_PossessionChange(object sender, PossessionChangeEventArgs e)
        {
            if (e.Team == Team.Home)
            {
                lblAwayPossession.Text = string.Empty;
                lblHomePossession.Text = "◄";
            }
            else
            {
                lblAwayPossession.Text = "►";
                lblHomePossession.Text = string.Empty;
            }
        }

        private void ControllerForm_TimeoutChange(object sender, TimeoutChangeEventArgs e)
        {
            txtTimeout.Text = e.Seconds.ToString();
        }

        private void ControllerForm_PeriodChange(object sender, PeriodChangeEventArgs e)
        {
            txtPeriod.Text = e.Period.ToString();
        }

        private void ControllerForm_TimeoutClockExpire(object sender, EventArgs e)
        {
            TimeoutTimer.Enabled = false;
            GameHorn.Sound();
        }

        private void ControllerForm_GameClockExpire(object sender, EventArgs e)
        {
            GameClockTimer.Enabled = false;
            GameHorn.Sound();
        }

        private void ControllerForm_GameClockSounding(object sender, EventArgs e)
        {
            SetBtnHornEnabledTo(false);
        }

        private void ControllerForm_GameClockSounded(object sender, EventArgs e)
        {
            SetBtnHornEnabledTo(true);
        }

        private void SetBtnHornEnabledTo(bool enabled)
        {
            if (btnHorn.InvokeRequired)
            {
                HornDelegate del = new HornDelegate(SetBtnHornEnabledTo);
                this.BeginInvoke(del, enabled);
            }
            else
            {
                btnHorn.Enabled = enabled; 
            }
        }

        private void GameClockTimer_Tick(object sender, EventArgs e)
        {
            ClockController.DecrementGameTimeByTenth();
        }

        private void TimeoutTimer_Tick(object sender, EventArgs e)
        {
            TimeoutController.DecrementTimeout();
        }

        private void BtnClock_Click(object sender, EventArgs e)
        {
            var gametime = ClockController.GetGameTime();
            if (gametime.Minutes > 0 || gametime.Seconds > 0 || gametime.Tenths > 0)
            {
                GameClockTimer.Enabled = !GameClockTimer.Enabled;
            }
            else
            {
                GameClockTimer.Enabled = false;
            }
        }

        private void BtnHorn_Click(object sender, EventArgs e)
        {
            GameHorn.Sound();
        }

        private void btnShowDisplay_Click(object sender, EventArgs e)
        {
            var display = new DisplayForm();
            display.Show();
            display.BringToFront();
        }
    }
}