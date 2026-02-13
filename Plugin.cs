using System.Collections.Generic;
using BepInEx;
using BepInEx.Configuration;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MapTweaks
{
    [BepInPlugin(Constants.Guid, Constants.Name, Constants.Version)]
    public class Plugin : BaseUnityPlugin
    {
        private const string _cityPath  = "City_Pretty/CosmeticsRoomAnchor/outsidestores_prefab/";
        private const string _stumpPath = "Environment Objects/LocalObjects_Prefab/TreeRoom/";
        private const string _videoPath = "City_Pretty/CosmeticsRoomAnchor/nicegorillastore_prefab/VideoPlayer ";
        private const string _superBtn  = "GameModeSelector_SuperToggleButton (prefab)";

        private void Start()
        {
            InitConfig();
            SceneManager.sceneLoaded                              += OnSceneLoaded;
            CosmeticsV2Spawner_Dirty.OnPostInstantiateAllPrefabs2 += OnCosmeticsLoaded;
        }

        // forest, but eh
        private void OnCosmeticsLoaded()
        {
            // Add
            /*ToggleObjects(true, new[]
            {

            });*/

            // Remove
            if (_removeVIMLobbies.Value)
                ToggleObjects(false, new[]
                {
                        $"{_stumpPath}TreeRoomInteractables/UI/GameModeSelector_JoinPublicSub_Forest",
                        $"{_stumpPath}GameModeSelector_JoinPublicSub_City",
                });

            if (_miscellaneousTweaks.Value)
                ToggleObjects(false, new[]
                {
                        $"{_stumpPath}SpectralGooPile (combined by EdMeshCombiner)",
                });

            // Move
            if (_moveSuperBtns.Value)
            {
                GameObject stumpSuperBtn =
                        GameObject.Find($"{_stumpPath}TreeRoomInteractables/UI/GameModeSelector/{_superBtn}");

                stumpSuperBtn.transform.position      = new Vector3(-63.9072f, 12.0673f, -81.7115f);
                stumpSuperBtn.transform.localRotation = Quaternion.Euler(328.3268f, 181.2001f, 0f);

                GameObject monkeblockssharedSuperBtn = GameObject.Find(
                        $"Environment Objects/LocalObjects_Prefab/SharedBlocksMapSelectLobby/BuilderFactory_SelectLobby_GameModeSelector/GameModeSelector/{_superBtn}");

                monkeblockssharedSuperBtn.transform.position      = new Vector3(-279.4951f, 30.9917f, -223.6514f);
                monkeblockssharedSuperBtn.transform.localRotation = Quaternion.Euler(318.6287f, 181.2003f, 0f);
            }

            if (_miscellaneousTweaks.Value)
            {
                GameObject drillOpenBtnB = GameObject.Find(
                        "Environment Objects/05Maze_PersistentObjects/GhostReactorElevatorManager/GhostReactorShuttles/HQ/GRShuttleAirLockStaging/OpenButtonB");

                drillOpenBtnB.transform.position   = new Vector3(-37.1827f, -27.7912f, -72.67f);
                drillOpenBtnB.transform.localScale = new Vector3(0.1233f,   0.1145f,   0.0654f);
            }
        }

        private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            switch (scene.name)
            {
                case "Cave": CaveMineScene(); break;
                //case "Canyon2": CanyonScene(); break;
                case "City":       CityScene(); break;
                case "Mountain":   MountainScene(); break;
                case "Skyjungle":  CloudsScene(); break;
                case "Basement":   BasementScene(); break;
                case "Beach":      BeachScene(); break;
                case "Metropolis": MetroScene(); break;
                //case "Bayou": BayouScene(); break;
                //case "MonkeBlocks": MonkeBlocksScene(); break;
                //case "Arena": ArenaScene(); break; // Blocked off
                case "Hoverboard":   HoverScene(); break;
                case "Critters":     CrittersScene(); break;
                case "GhostReactor": GhostScene(); break;
                //case "MonkeBlocksShared": MonkeBlocksSharedScene(); break;
                //case "Ranked": RankedScene(); break;
            }
        }

        private void CaveMineScene()
        {
            // Add
            /*ToggleObjects(true, new[]
            {

            });

            // Remove
            ToggleObjects(false, new[]
            {

            });*/

            // Move
            if (_moveSuperBtns.Value)
            {
                GameObject supertoggleBtn =
                        GameObject.Find($"Cave_Main_Prefab/NewCave/CaveComputer/GameModeSelector/{_superBtn}");

                supertoggleBtn.transform.position      = new Vector3(-76.4814f, -19.3947f, -24.0923f);
                supertoggleBtn.transform.localRotation = Quaternion.Euler(328.8175f, 180.9003f, 0f);
            }
        }

        private void CityScene()
        {
            // Add
            ToggleObjects(true, new[]
            {
                    "City_Pretty/HowManyMonkeSignAnchor/HowManyMonkeSign",
            });

            // Remove
            if (_removeTVs.Value)
                ToggleObjects(false, new[]
                {
                        $"{_cityPath}Top Layer/Huts/Hut_3D/Medical Hut/TV_Prefab (1)",
                        $"{_cityPath}Top Layer/Huts/Hut_3D/Medical Hut/TV_Prefab (2)",
                        $"{_cityPath}Top Layer/Huts/Hut_3D/Medical Hut/TV_Prefab (3)",
                        $"{_cityPath}Bottom Layer/OutsideBuildings/Hut_1C/TV_Prefab (4)",
                        $"{_cityPath}Bottom Layer/OutsideBuildings/TV_Prefab (5)",
                        "City_Pretty/Arcade_prefab/MainRoom/VRArea/NewMapsDisplay/TV_Prefab",

                        $"{_videoPath}(5)",
                        $"{_videoPath}(6)",
                        $"{_videoPath}(7)",
                        $"{_videoPath}(8)",
                        "City_Pretty/SuperCasual_City/SetDressing/VideoPlayer (9)",
                });

            if (_miscellaneousTweaks.Value)
                ToggleObjects(false, new[]
                {
                        "City_Pretty/HowManyMonkeSignAnchor/HowManyMonkeSign/Particle System",
                        "City_Pretty/CosmeticsRoomAnchor/nicegorillastore_prefab/SubscriptionKiosk_ScenePrefab Variant/SubscriptionKiosk_FBX (1)/ScreenTop/AttractVid",
                });

            // Move
            // Currently None
        }

        private void MountainScene()
        {
            // Add
            /*ToggleObjects(true, new[]
            {

            });

            // Remove
            ToggleObjects(false, new[]
            {

            });*/

            // Move
            if (_moveSuperBtns.Value)
            {
                GameObject supertoggleBtn =
                        GameObject.Find($"Mountain/Geometry/goodigloo/GameModeSelector/{_superBtn}");

                supertoggleBtn.transform.position      = new Vector3(-21.5196f, 18.0662f, -107.5614f);
                supertoggleBtn.transform.localRotation = Quaternion.Euler(325.2207f, 181.3003f, 0f);
            }
        }

        private void CloudsScene()
        {
            // Add
            /*ToggleObjects(true, new[]
            {

            });

            // Remove
            ToggleObjects(false, new[]
            {

            });*/

            // Move
            if (_moveSuperBtns.Value)
            {
                GameObject supertoggleBtn = GameObject.Find($"skyjungle/UI/GameModeSelector/{_superBtn}");
                supertoggleBtn.transform.position      = new Vector3(-73.9753f, 162.7437f, -97.7961f);
                supertoggleBtn.transform.localRotation = Quaternion.Euler(324.9999f, 182.0002f, 0f);
            }
        }

        private void BasementScene()
        {
            // Add
            /*ToggleObjects(true, new[]
            {

            });*/

            // Remove
            if (_removeTVs.Value)
                ToggleObjects(false, new[]
                {
                        "Basement/DungeonRoomAnchor/DungeonBasement/TV_Prefab",
                });

            // Move
            // Currently None
        }

        private void BeachScene()
        {
            // Add
            /*ToggleObjects(true, new[]
            {

            });

            // Remove
            ToggleObjects(false, new[]
            {

            });*/

            // Move
            if (_moveSuperBtns.Value)
            {
                GameObject supertoggleBtn = GameObject.Find($"Beach/BeachComputer (1)/GameModeSelector/{_superBtn}");
                supertoggleBtn.transform.position      = new Vector3(-19.9329f, 28.7041f, -23.1375f);
                supertoggleBtn.transform.localRotation = Quaternion.Euler(328.9999f, 181.4003f, 0f);
            }
        }

        private void MetroScene()
        {
            // Add
            /*ToggleObjects(true, new[]
            {

            });

            // Remove
            ToggleObjects(false, new[]
            {

            });*/

            // Move
            if (_moveSuperBtns.Value)
            {
                GameObject supertoggleBtn = GameObject.Find($"MetroMain/ComputerArea/GameModeSelector/{_superBtn}");
                supertoggleBtn.transform.position      = new Vector3(65.847f, 4.0367f, -239.0603f);
                supertoggleBtn.transform.localRotation = Quaternion.Euler(324.1577f, 181.2003f, 0f);
            }
        }

        private void HoverScene()
        {
            // Add
            /*ToggleObjects(true, new[]
            {

            });

            // Remove
            ToggleObjects(false, new[]
            {

            });*/

            // Move
            if (_moveSuperBtns.Value)
            {
                GameObject supertoggleBtn = GameObject.Find($"HoverboardLevel/UI (1)/GameModeSelector/{_superBtn}");
                supertoggleBtn.transform.position      = new Vector3(-92.7389f, -16.6623f, 29.0614f);
                supertoggleBtn.transform.localRotation = Quaternion.Euler(324.9999f, 181.0002f, 0f);
            }
        }

        private void CrittersScene()
        {
            // Add
            /*ToggleObjects(true, new[]
            {

            });

            // Remove

            ToggleObjects(false, new[]
            {

            });*/

            // Move
            if (_moveSuperBtns.Value)
            {
                GameObject supertoggleBtn = GameObject.Find($"Critters/UI Elements/UI/GameModeSelector/{_superBtn}");
                supertoggleBtn.transform.position      = new Vector3(94.2255f, -92.911f, 48.3016f);
                supertoggleBtn.transform.localRotation = Quaternion.Euler(327.5117f, 181.2003f, 0f);
            }
        }

        private void GhostScene()
        {
            // Add
            /*ToggleObjects(true, new[]
            {

            });

            // Remove

            ToggleObjects(false, new[]
            {

            });*/

            // Move
            // Currently None
        }

        private void ToggleObjects(bool state, IEnumerable<string> paths)
        {
            foreach (string path in paths)
            {
                GameObject obj = GameObject.Find(path);
                if (obj != null)
                    obj.SetActive(state);
            }
        }

#region Configuration

        // Added Objects

        // Removed Objects
        public ConfigEntry<bool> _removeVIMLobbies,
                                 _removeTVs;

        // Moved Objects
        public ConfigEntry<bool> _moveSuperBtns,
                                 _miscellaneousTweaks;

        public void InitConfig()
        {
            _miscellaneousTweaks = Config.Bind("Miscellaneous Tweaks", "MiscellaneousTweaks", true,
                    "Non-categorized objects, added, removed, moved etc.");

            //Added Objects

            _removeTVs        = Config.Bind("Removed Objects", "TVs",             true, "Remove TVs");
            _removeVIMLobbies = Config.Bind("Removed Objects", "VIMLobbyButtons", true, "Remove VIM Lobby Buttons");

            _moveSuperBtns = Config.Bind("Moved Objects", "SuperButtons", true, "Moves Super Toggle Buttons");
        }

#endregion
    }
}