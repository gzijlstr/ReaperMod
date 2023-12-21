using Nautilus.Handlers;
using Nautilus.Options;

namespace ReaperMod
{
    public class ReaperModOptions : ModOptions
    {
        public ReaperModOptions() : base("Reaper Customizations")
        {
            AddItem(ModSliderOption.Create("SliderId", "Reaper Size", 0, 50, 15, 25));

            OptionsPanelHandler.RegisterModOptions(this);
        }
    }
}
