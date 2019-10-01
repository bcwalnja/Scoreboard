using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace ScoreboardBLL
{
    public static class GameHorn
    {
        public static void Sound()
        {
            try
            {
                var generator = new SignalGenerator();
                generator.Type = SignalGeneratorType.SawTooth;
                generator.Frequency = 2500;

                var gameHorn = new WaveOut();
                gameHorn.Init(generator.ToWaveProvider());

                Task.Run(() =>
                {
                    EventMediator.GetEventMediator().OnGameClockSounding();
                    gameHorn.Play();
                    Thread.Sleep(2000);
                    gameHorn.Stop();
                    EventMediator.GetEventMediator().OnGameClockSounded();
                });
            }
            catch (System.Exception)
            {
                SoundPlayer player = new SoundPlayer { SoundLocation = @"C:\Windows\media\Windows Ringout.wav" };
                Task.Run(() =>
                {
                    player.PlayLooping();
                    Thread.Sleep(2000);
                    player.Stop();
                });
            }
        }
    }
}
