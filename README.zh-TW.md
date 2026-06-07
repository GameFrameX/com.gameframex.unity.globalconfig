<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX GlobalConfig

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.globalconfig)](https://github.com/GameFrameX/com.gameframex.unity.globalconfig/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.globalconfig)](https://github.com/GameFrameX/com.gameframex.unity.globalconfig/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

獨立遊戲前後端一體化解決方案 · 獨立遊戲開發者的圓夢大使

<br />

[文檔](https://gameframex.doc.alianblank.com) · [快速開始](#快速開始) · QQ群: 467608841 / 233840761

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | **繁體中文** | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>
## 項目簡介

GameFrameX GlobalConfig 元件 - 全域設定管理器，主要記錄從伺服器取得的設定資訊。管理應用程式版本檢查 URL、資源版本檢查 URL 以及其他全域存取的設定資料。

## 特性

- **應用版本 URL** - 儲存和管理檢查應用程式版本更新的 URL 位址
- **資源版本 URL** - 儲存和管理檢查遊戲資源版本更新的 URL 位址
- **自訂內容** - 儲存附加內容或資料，用於遊戲內顯示或其他業務邏輯
- **主機服務 URL** - 儲存主機服務的 URL，用作連線後端伺服器的位址

## 安裝

### 透過 Git URL 安裝（推薦）

1. 在 Unity 編輯器中開啟 Package Manager
2. 點擊 "+" 按鈕選擇 "Add package from git URL"
3. 輸入以下 URL：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.globalconfig.git
   ```

### 透過 manifest.json 安裝

在專案的 `Packages/manifest.json` 檔案中新增：

```json
{
  "dependencies": {
    "com.gameframex.unity.globalconfig": "https://github.com/GameFrameX/com.gameframex.unity.globalconfig.git"
  }
}
```

### 手動安裝

1. 下載最新版本發佈包
2. 解壓縮到專案的 `Packages` 目錄下
3. Unity 會自動辨識並載入包

## 快速開始

### 設定

1. **新增元件**：將 `GlobalConfigComponent` 作為元件新增到 Unity 場景中的任意一個遊戲物件上
2. **設定屬性**：在 Unity 的 Inspector 面板中設定 `CheckAppVersionUrl`、`CheckResourceVersionUrl`、`Content` 和 `HostServerUrl` 的值，或者透過程式碼在執行時動態設定
3. **版本管理**：使用 `CheckAppVersionUrl` 和 `CheckResourceVersionUrl` 來管理遊戲的版本控制和資源更新流程
4. **全域存取**：可以在遊戲的任何地方存取 `GlobalConfigComponent` 實例來取得所需的全域設定資訊

## 更新日誌

詳見 [CHANGELOG.md](CHANGELOG.md)。

## 開源協議

本專案基於 MIT 協議開源，詳見 [LICENSE.md](LICENSE.md)。
