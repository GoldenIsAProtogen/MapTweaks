using System.Collections.Generic;
using BepInEx;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MapTweaks
{
    [BepInPlugin(Constants.Guid, Constants.Name, Constants.Version)]
    public class Plugin : BaseUnityPlugin
    {
        private const string cityPath  = "City_Pretty/CosmeticsRoomAnchor/outsidestores_prefab/";
        private const string stumpPath = "Environment Objects/LocalObjects_Prefab/TreeRoom/";
        private const string videoPath = "City_Pretty/CosmeticsRoomAnchor/nicegorillastore_prefab/VideoPlayer ";

        private const string superBtn = "GameModeSelector_SuperToggleButton (prefab)";

        private void Start()
        {
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
            ToggleObjects(false, new[]
            {
                    $"{stumpPath}TreeRoomInteractables/UI/GameModeSelector_JoinPublicSub_Forest",
                    $"{stumpPath}GameModeSelector_JoinPublicSub_City",
                    $"{stumpPath}SpectralGooPile (combined by EdMeshCombiner)",
            });

            // Move
            GameObject stumpSuperBtn = GameObject.Find($"{stumpPath}TreeRoomInteractables/UI/GameModeSelector/{superBtn}");
            stumpSuperBtn.transform.position      = new Vector3(-63.9072f, 12.0673f, -81.7115f);
            stumpSuperBtn.transform.localRotation = Quaternion.Euler(328.3268f, 181.2001f, 0f);
            
            GameObject monkeblockssharedSuperBtn = GameObject.Find($"Environment Objects/LocalObjects_Prefab/SharedBlocksMapSelectLobby/BuilderFactory_SelectLobby_GameModeSelector/GameModeSelector/{superBtn}");
            monkeblockssharedSuperBtn.transform.position      = new Vector3(-279.4951f, 30.9917f, -223.6514f);
            monkeblockssharedSuperBtn.transform.localRotation = Quaternion.Euler(318.6287f, 181.2003f, 0f);

            GameObject drillOpenBtnB = GameObject.Find("Environment Objects/05Maze_PersistentObjects/GhostReactorElevatorManager/GhostReactorShuttles/HQ/GRShuttleAirLockStaging/OpenButtonB");
            drillOpenBtnB.transform.position   = new Vector3(-37.1827f, -27.7912f, -72.67f);
            drillOpenBtnB.transform.localScale = new Vector3(0.1233f,   0.1145f,   0.0654f);
        }

        private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            switch (scene.name)
            {
                case "Cave": CaveMineScene(); break;
                //case "Canyon2": CanyonScene(); break;
                case "City":      CityScene(); break;
                case "Mountain":  MountainScene(); break;
                case "Skyjungle": CloudsScene(); break;
                case "Basement":  BasementScene(); break;
                case "Beach":     BeachScene(); break;
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
            GameObject supertoggleBtn = GameObject.Find($"Cave_Main_Prefab/NewCave/CaveComputer/GameModeSelector/{superBtn}");
            supertoggleBtn.transform.position      = new Vector3(-76.4814f, -19.3947f, -24.0923f);
            supertoggleBtn.transform.localRotation = Quaternion.Euler(328.8175f, 180.9003f, 0f);
        }

        private void CityScene()
        {
            // Add
            ToggleObjects(true, new[]
            {
                    "City_Pretty/HowManyMonkeSignAnchor/HowManyMonkeSign",
            });

            // Remove
            ToggleObjects(false, new[]
            {
                    "City_Pretty/HowManyMonkeSignAnchor/HowManyMonkeSign/Particle System",
                    "City_Pretty/CosmeticsRoomAnchor/nicegorillastore_prefab/SubscriptionKiosk_ScenePrefab Variant/SubscriptionKiosk_FBX (1)/ScreenTop/AttractVid",

                    $"{cityPath}Top Layer/Huts/Hut_3D/Medical Hut/TV_Prefab (1)",
                    $"{cityPath}Top Layer/Huts/Hut_3D/Medical Hut/TV_Prefab (2)",
                    $"{cityPath}Top Layer/Huts/Hut_3D/Medical Hut/TV_Prefab (3)",
                    $"{cityPath}Bottom Layer/OutsideBuildings/Hut_1C/TV_Prefab (4)",
                    $"{cityPath}Bottom Layer/OutsideBuildings/TV_Prefab (5)",
                    "City_Pretty/Arcade_prefab/MainRoom/VRArea/NewMapsDisplay/TV_Prefab",

                    $"{videoPath}(5)",
                    $"{videoPath}(6)",
                    $"{videoPath}(7)",
                    $"{videoPath}(8)",
                    "City_Pretty/SuperCasual_City/SetDressing/VideoPlayer (9)",
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
            GameObject supertoggleBtn = GameObject.Find($"Mountain/Geometry/goodigloo/GameModeSelector/{superBtn}");
            supertoggleBtn.transform.position      = new Vector3(-21.5196f, 18.0662f, -107.5614f);
            supertoggleBtn.transform.localRotation = Quaternion.Euler(325.2207f, 181.3003f, 0f);
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
            GameObject supertoggleBtn = GameObject.Find($"skyjungle/UI/GameModeSelector/{superBtn}");
            supertoggleBtn.transform.position      = new Vector3(-73.9753f, 162.7437f, -97.7961f);
            supertoggleBtn.transform.localRotation = Quaternion.Euler(324.9999f, 182.0002f, 0f);
        }

        private void BasementScene()
        {
            // Add
            /*ToggleObjects(true, new[]
            {

            });*/

            // Remove
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
            GameObject supertoggleBtn = GameObject.Find($"Beach/BeachComputer (1)/GameModeSelector/{superBtn}");
            supertoggleBtn.transform.position      = new Vector3(-19.9329f, 28.7041f, -23.1375f);
            supertoggleBtn.transform.localRotation = Quaternion.Euler(328.9999f, 181.4003f, 0f);
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
            GameObject supertoggleBtn = GameObject.Find($"MetroMain/ComputerArea/GameModeSelector/{superBtn}");
            supertoggleBtn.transform.position      = new Vector3(65.847f, 4.0367f, -239.0603f);
            supertoggleBtn.transform.localRotation = Quaternion.Euler(324.1577f, 181.2003f, 0f);
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
            GameObject supertoggleBtn = GameObject.Find($"HoverboardLevel/UI (1)/GameModeSelector/{superBtn}");
            supertoggleBtn.transform.position      = new Vector3(-92.7389f, -16.6623f, 29.0614f);
            supertoggleBtn.transform.localRotation = Quaternion.Euler(324.9999f, 181.0002f, 0f);
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
            GameObject supertoggleBtn = GameObject.Find($"Critters/UI Elements/UI/GameModeSelector/{superBtn}");
            supertoggleBtn.transform.position      = new Vector3(94.2255f, -92.911f, 48.3016f);
            supertoggleBtn.transform.localRotation = Quaternion.Euler(327.5117f, 181.2003f, 0f);
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
    }
}