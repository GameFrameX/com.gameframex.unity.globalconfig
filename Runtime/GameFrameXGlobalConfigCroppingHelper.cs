using UnityEngine;
using UnityEngine.Scripting;

namespace GameFrameX.GlobalConfig.Runtime
{
    [Preserve]
    public class GameFrameXGlobalConfigCroppingHelper : MonoBehaviour
    {
        [Preserve]
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