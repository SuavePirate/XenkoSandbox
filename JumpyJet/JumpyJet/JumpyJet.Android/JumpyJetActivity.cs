using Android.App;
using Android.OS;
using Android.Content.PM;

using SiliconStudio.Xenko.Engine;
using SiliconStudio.Xenko.Starter;

namespace JumpyJet
{
    [Activity(MainLauncher = true, 
              Icon = "@drawable/icon", 
              ScreenOrientation = ScreenOrientation.Portrait,
              ConfigurationChanges = ConfigChanges.UiMode | ConfigChanges.Orientation | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize)]
    public class JumpyJetActivity : AndroidXenkoActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Game = new Game();
            Game.Run(GameContext);
        }

        protected override void OnDestroy()
        {
            Game.Dispose();

            base.OnDestroy();
        }
    }
}
