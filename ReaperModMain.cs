using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using CyclopsBeaconDeployer.Items;
using HarmonyLib;
using Nautilus.Handlers;
using System.Collections;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace ReaperMod
{
    public class ReaperModMain : MonoBehaviour
    {
        // Instantiate the mod options
        private static ReaperModOptions modOptions;

        private void Awake()
        {
            Logger.LogInfo("ReaperModMain Awake() is called.");

            try
            {
                modOptions = new ReaperModOptions();
                Logger.LogInfo("ReaperModOptions created successfully.");
            }
            catch (Exception ex)
            {
                Logger.LogError($"Error creating ReaperModOptions: {ex.Message}");
            }

            bool writeLogs = Main.WriteLogs.Value;

        }
    }
}
