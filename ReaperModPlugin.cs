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


    [BepInPlugin(MyGuid, PluginName, VersionString)]
    [BepInDependency("com.snmodding.nautilus")] // marks Nautilus as a dependency for this mod


    public class ReaperModPlugin : BaseUnityPlugin
    {
        private const string MyGuid = "com.Rilay.ReaperMod";
        private const string PluginName = "Reaper Mod";
        private const string VersionString = "1.0.0";

        private static readonly Harmony Harmony = new.Harmony(MyGuid);


        public static ManualLogSource Log;

        // declaring mod options from ReaperModOptions.cs
        public static ReaperModOptions ModOptions;

        private void Awake()
        {
            ModOptions = OptionsPanelHandler.RegisterModOptions<ModOptions>();

            Harmony.PatchAll();
            Logger.LogInfo(PluginName + " " + VersionString + " " + "loaded.");
            Log = Logger;
        }
    }
}
