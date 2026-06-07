<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX GlobalConfig

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.globalconfig)](https://github.com/GameFrameX/com.gameframex.unity.globalconfig/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.globalconfig)](https://github.com/GameFrameX/com.gameframex.unity.globalconfig/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

独立游戏前后端一体化解决方案 · 独立游戏开发者的圆梦大使

<br />

[文档](https://gameframex.doc.alianblank.com) · [快速开始](#快速开始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | **简体中文** | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>
## 项目简介

GameFrameX GlobalConfig 组件 - 全局配置管理器，主要记录从服务器获取的配置信息。管理应用程序版本检查 URL、资源版本检查 URL 以及其他全局访问的配置数据。

## 特性

- **应用版本 URL** - 存储和管理检查应用版本更新的 URL 地址
- **资源版本 URL** - 存储和管理检查游戏资源版本更新的 URL 地址
- **自定义内容** - 存储附加内容或数据，用于游戏内显示或其他业务逻辑
- **主机服务 URL** - 存储主机服务的 URL，用作连接后端服务器的地址

## 安装

### 通过 Git URL 安装（推荐）

1. 在 Unity 编辑器中打开 Package Manager
2. 点击 "+" 按钮选择 "Add package from git URL"
3. 输入以下 URL：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.globalconfig.git
   ```

### 通过 manifest.json 安装

在项目的 `Packages/manifest.json` 文件中添加：

```json
{
  "dependencies": {
    "com.gameframex.unity.globalconfig": "https://github.com/GameFrameX/com.gameframex.unity.globalconfig.git"
  }
}
```

### 手动安装

1. 下载最新版本发布包
2. 解压到项目的 `Packages` 目录下
3. Unity 会自动识别并加载包

## 快速开始

### 配置

1. **添加组件**：将 `GlobalConfigComponent` 作为组件添加到 Unity 场景中的任意一个游戏对象上
2. **设置属性**：在 Unity 的 Inspector 面板中设置 `CheckAppVersionUrl`、`CheckResourceVersionUrl`、`Content` 和 `HostServerUrl` 的值，或者通过代码在运行时动态设置
3. **版本管理**：使用 `CheckAppVersionUrl` 和 `CheckResourceVersionUrl` 来管理游戏的版本控制和资源更新流程
4. **全局访问**：可以在游戏的任何地方访问 `GlobalConfigComponent` 实例来获取所需的全局配置信息

## 更新日志

详见 [CHANGELOG.md](CHANGELOG.md)。

## 开源协议

本项目基于 MIT 协议开源，详见 [LICENSE.md](LICENSE.md)。
