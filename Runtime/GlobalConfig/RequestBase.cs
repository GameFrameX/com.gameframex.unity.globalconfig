namespace GameFrameX.GlobalConfig.Runtime
{
    /// <summary>
    /// 请求基类
    /// </summary>
    public abstract class RequestBase
    {
        /// <summary>
        /// 语言
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public string Language { get; set; }

        /// <summary>
        /// 程序版本
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public string AppVersion { get; set; }

        /// <summary>
        /// 运行平台
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public string Platform { get; set; }

        /// <summary>
        /// 包名
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public string PackageName { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public string Channel { get; set; }

        /// <summary>
        /// 子渠道
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public string SubChannel { get; set; }
    }
}