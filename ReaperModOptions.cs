using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using Nautilus.Handlers;
using Nautilius.Options;
using Nautilius.Json;
using Nautilus.Options.Attributes;
using UnityEngine;
using System.Collections;
using System.IO;
using System;

namespace Rilay.ReaperMod
{





    [Menu("Knife Damage Mod")]
    public class ReaperModOptions : ModOptions
    {

        [Slider("Reaper Size", 1.0f, 100.0f, DefaultValue = 1.0f, Format = "{0:F2}")]

    }
}
