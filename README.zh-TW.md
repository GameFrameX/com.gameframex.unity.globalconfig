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

## 快速開始

### 安裝

編輯 Unity 專案的 `Packages/manifest.json`，添加 `scopedRegistries` 部分：

```json
{
  "scopedRegistries": [
    {
      "name": "GameFrameX",
      "url": "https://gameframex.upm.alianblank.uk",
      "scopes": [
        "com.gameframex"
      ]
    }
  ]
}
```

`scopes` 控制哪些套件透過此註冊表解析。只有以 `com.gameframex` 開頭的套件才會從這個註冊表取得。

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.globalconfig": "1.3.2"
  }
}
```

## 更新日誌

詳見 [CHANGELOG.md](CHANGELOG.md)。


## 依賴

| 套件 | 說明 |
|------|------|
| `com.gameframex.unity` | 1.1.1 |
| `com.gameframex.unity.web` | 1.1.2 |

## 文檔與資源

- [官方文檔](https://gameframex.doc.alianblank.com)

## 社區與支援

- QQ群: 467608841 / 233840761
## 開源協議

詳見 [LICENSE.md](LICENSE.md) 檔案。
