using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;

using Nautilus.Handlers;
using Nautilius.Options;
using Nautilius.Json;
using Nautilus.Options.Attributes;

using HarmonyLib;
using UnityEngine;


namespace Rilay.ReaperMod
{
    [Menu("Reaper Options ")]
    public class ReaperModOptions : ModOptions
    {
        public ReaperModOptions() : base("Reaper Options")
        {

            [Slider("Reaper Slider", 1.0f, 100.0f, DefaultValue = 1.0f, Format = "{0:F2}")]

            OptionsPanelHandler.RegisterModOptions(this);

            
        }
    }
}
