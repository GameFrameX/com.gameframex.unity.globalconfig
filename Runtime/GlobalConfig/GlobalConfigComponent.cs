using System;
using System.Collections.Generic;
using GameFrameX.Runtime;
using UnityEngine;

namespace GameFrameX.GlobalConfig.Runtime
{
    /// <summary>
    /// 全局配置组件。
    /// </summary>
    [DisallowMultipleComponent]
    [AddComponentMenu("Game Framework/Global Config")]
    public sealed class GlobalConfigComponent : GameFrameworkComponent
    {
        /// <summary>
        /// 检测App版本地址接口
        /// </summary>
        [SerializeField] private string m_checkAppVersionUrl = string.Empty;

        /// <summary>
        /// 检测App版本地址接口
        /// </summary>
        public string CheckAppVersionUrl
        {
            get { return m_checkAppVersionUrl; }
            set { m_checkAppVersionUrl = value; }
        }

        /// <summary>
        /// 检测资源版本地址接口
        /// </summary>
        [SerializeField] private string m_checkResourceVersionUrl = string.Empty;

        /// <summary>
        /// 检测资源版本地址接口
        /// </summary>
        public string CheckResourceVersionUrl
        {
            get { return m_checkResourceVersionUrl; }
            set { m_checkResourceVersionUrl = value; }
        }

        /// <summary>
        /// AOT代码列表
        /// </summary>
        [SerializeField] private string m_aotCodeList = string.Empty;

        /// <summary>
        /// AOT补充元数据列表
        /// </summary>
        [SerializeField] private List<string> m_aotCodeLists = new List<string>();

        /// <summary>
        /// 补充元数据列表
        /// </summary>
        public List<string> AOTCodeLists
        {
            get { return m_aotCodeLists; }
        }

        /// <summary>
        /// AOT代码列表
        /// </summary>
        public string AOTCodeList
        {
            get { return m_aotCodeList; }
            set
            {
                m_aotCodeList = value;
                try
                {
                    m_aotCodeLists = Utility.Json.ToObject<List<string>>(value);
                }
                catch (Exception e)
                {
                    Log.Fatal(e);
                }
            }
        }

        /// <summary>
        /// 附加内容
        /// </summary>
        [SerializeField] private string m_content = string.Empty;

        /// <summary>
        /// 附加内容
        /// </summary>
        public string Content
        {
            get => m_content;
            set => m_content = value;
        }

        /// <summary>
        /// 主机服务地址
        /// </summary>
        [SerializeField] private string m_hostServerUrl = string.Empty;

        /// <summary>
        /// 主机服务地址
        /// </summary>
        public string HostServerUrl
        {
            get { return m_hostServerUrl; }
            set { m_hostServerUrl = value; }
        }
        }

        protected override void Awake()
        {
            IsAutoRegister = false;
            base.Awake();
        }
    }
}