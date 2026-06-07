<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX GlobalConfig

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.globalconfig)](https://github.com/GameFrameX/com.gameframex.unity.globalconfig/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.globalconfig)](https://github.com/GameFrameX/com.gameframex.unity.globalconfig/releases)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

インディゲーム開発者向けオールインワンソリューション · インディ開発者の夢を支援

<br />

[ドキュメント](https://gameframex.doc.alianblank.com) · [クイックスタート](#クイックスタート) · [QQグループ](https://qm.qq.com/q/5U9Fvebw)

<br />

[English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | **日本語** | [한국어](README.ko.md)

</div>
## プロジェクト概要

GameFrameX GlobalConfig コンポーネント - サーバーから取得した設定情報を記録するグローバル設定マネージャー。アプリケーションバージョンチェックURL、リソースバージョンチェックURL、およびその他のグローバルにアクセス可能な設定データを管理します。

## 特徴

- **アプリバージョン URL** - アプリケーションのバージョンアップデート確認用URLの保存と管理
- **リソースバージョン URL** - ゲームリソースのバージョンアップデート確認用URLの保存と管理
- **カスタムコンテンツ** - ゲーム内表示やビジネスロジック用の追加コンテンツやデータの保存
- **ホストサーバー URL** - バックエンドサーバー接続用のホストサーバーURLの保存

## インストール

### Git URL 経由（推奨）

1. Unity エディタで Package Manager を開く
2. "+" ボタンをクリックし "Add package from git URL" を選択
3. 以下の URL を入力：
   ```
   https://github.com/GameFrameX/com.gameframex.unity.globalconfig.git
   ```

### manifest.json 経由

プロジェクトの `Packages/manifest.json` に以下を追加：

```json
{
  "dependencies": {
    "com.gameframex.unity.globalconfig": "https://github.com/GameFrameX/com.gameframex.unity.globalconfig.git"
  }
}
```

### 手動インストール

1. 最新のリリースパッケージをダウンロード
2. プロジェクトの `Packages` ディレクトリに展開
3. Unity が自動的にパッケージを認識して読み込みます

## クイックスタート

### 設定

1. **コンポーネントの追加**：`GlobalConfigComponent` をUnityシーンの任意のGameObjectに追加
2. **プロパティの設定**：Unity Inspector パネルで `CheckAppVersionUrl`、`CheckResourceVersionUrl`、`Content`、`HostServerUrl` の値を設定、またはコードで実行時に動的に設定
3. **バージョン管理**：`CheckAppVersionUrl` と `CheckResourceVersionUrl` を使用してゲームのバージョン管理とリソース更新ワークフローを管理
4. **グローバルアクセス**：ゲーム内のどこからでも `GlobalConfigComponent` インスタンスにアクセスしてグローバル設定情報を取得

## 変更履歴

詳細は [CHANGELOG.md](CHANGELOG.md) をご覧ください。

## ライセンス

このプロジェクトは MIT ライセンスの下で公開されています。詳細は [LICENSE.md](LICENSE.md) をご覧ください。
