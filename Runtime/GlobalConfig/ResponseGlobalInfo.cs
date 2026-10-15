namespace GameFrameX.GlobalConfig.Runtime
{
    /// <summary>
    /// 全局信息响应对象
    /// </summary>
    public class ResponseGlobalInfo
    {
        /// <summary>
        /// 检测程序版本地址
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public string CheckAppVersionUrl { get; set; }

        /// <summary>
        /// 检测资源版本地址
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public string CheckResourceVersionUrl { get; set; }

        /// <summary>
        /// AOT代码列表
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public string AOTCodeList { get; set; }

        /// <summary>
        /// 扩展内容
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public string Content { get; set; }
    }
}