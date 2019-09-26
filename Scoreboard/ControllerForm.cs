﻿using ScoreboardBLL;
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
        private PossessionController PossessionController;
        private TimeoutController TimeoutController;

        public ControllerForm()
        {
            InitializeComponent();
            InitializeControllerInstances();
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
            
        }

        private void ControllerForm_ClockChange(object sender, ClockChangeEventArgs e)
        {
            
        }

        private void ControllerForm_PossessionChange(object sender, PossessionChangeEventArgs e)
        {
            var awaySize = ArrowAwayPossession.Size;
            var homeSize = ArrowHomePossession.Size;
            var maxX = Math.Max(awaySize.Width, homeSize.Width);
            var maxY = Math.Max(awaySize.Height, homeSize.Height);

            if (e.Team == Team.Home)
            {
                ArrowAwayPossession.Size = new SizeF(0, 0);
                ArrowHomePossession.Size = new SizeF(maxX, maxY);
            }
            else
            {
                ArrowAwayPossession.Size = new SizeF(maxX, maxY);
                ArrowHomePossession.Size = new SizeF(0, 0);
            }
        }

        private void ControllerForm_TimeoutChange(object sender, TimeoutChangeEventArgs e)
        {
            
        }
    }
}