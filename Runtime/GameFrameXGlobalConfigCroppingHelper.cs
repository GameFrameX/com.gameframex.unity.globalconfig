using UnityEngine;

namespace GameFrameX.GlobalConfig.Runtime
{
    [UnityEngine.Scripting.Preserve]
    public class GameFrameXGlobalConfigCroppingHelper : MonoBehaviour
    {
        [UnityEngine.Scripting.Preserve]
        private void Start()
        {
            _ = typeof(GlobalConfigComponent);
            _ = typeof(ResponseGameAppVersion);
            _ = typeof(ResponseGlobalInfo);
            _ = typeof(ResponseGameAssetPackageVersion);
            _ = typeof(RequestGlobalInfo);
            _ = typeof(RequestGameAppVersion);
            _ = typeof(RequestGameAssetPackageVersion);
        }
    }
}