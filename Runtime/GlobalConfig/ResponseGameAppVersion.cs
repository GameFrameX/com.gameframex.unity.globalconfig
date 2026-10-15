namespace GameFrameX.GlobalConfig.Runtime
{
    /// <summary>
    /// 游戏版本信息
    /// </summary>
    public class ResponseGameAppVersion
    {
        /// <summary>
        /// 是否强制升级
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public bool IsForce { get; set; }

        /// <summary>
        /// 程序下载地址
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public string AppDownloadUrl { get; set; }

        /// <summary>
        /// 是否需要更新
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public bool IsUpgrade { get; set; }

        /// <summary>
        /// 更新公告
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public string UpdateAnnouncement { get; set; }

        /// <summary>
        /// 更新标题
        /// </summary>
        [UnityEngine.Scripting.Preserve]
        public string UpdateTitle { get; set; }
    }
}