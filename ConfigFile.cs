using Nautilus.Handlers;
using Nautilus.Options;


namespace ReaperMod
{
    public class ReaperModOptions : ModOptions
    {
        public TextureReplacerOptions() : base("Reaper Customizations")
        {
            var writeLogsOption = Main.WriteLogs.ToModToggleOption();
            writeLogsOption.OnChanged += OnWriteLogsChanged;
            AddItem(writeLogsOption);

            OptionsPanelHandler.RegisterModOptions(this);

            // slider for changing reaper spawn size
            // AddItem(ModSliderOption.Create("SliderId", "My Slider", 0, 50, 15, 25));

            //     OptionsPanelHandler.RegisterModOptions(this);
        }

        private void OnWriteLogsChanged(object sender, ToggleChangedEventArgs e)
        {
            Main.WriteLogs.Value = e.Value;
        }
    }
}

