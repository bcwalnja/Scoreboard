using ScoreboardBLL;
using System;
using System.Windows.Forms;

namespace Scoreboard
{
    public partial class DisplayForm : DevExpress.XtraEditors.XtraForm
    {
        public DisplayForm()
        {
            InitializeComponent();
            SubscribeToEvents();
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
            txtHomeFouls.Text = e.GameFouls?.HomeFouls().ToString();
            txtAwayFouls.Text = e.GameFouls?.AwayFouls().ToString();
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
    }
}