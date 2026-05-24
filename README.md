<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX GlobalConfig

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.globalconfig)](https://github.com/GameFrameX/com.gameframex.unity.globalconfig/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

  [Documentation](https://gameframex.doc.alianblank.com) | [Quick Start](#quick-start)

  **English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)
</div>

---

## Project Overview

GameFrameX GlobalConfig Component - A global configuration manager that stores configuration information retrieved from the server. It manages application version check URLs, resource version check URLs, and other globally accessible configuration data.

## Features

- **App Version URL** - Store and manage the URL for checking application version updates
- **Resource Version URL** - Store and manage the URL for checking game resource version updates
- **Custom Content** - Store additional content or data for in-game display or business logic
- **Host Server URL** - Store the host server URL for backend server connections

## Installation

### Via Git URL (Recommended)

1. Open Package Manager in Unity Editor
2. Click the "+" button and select "Add package from git URL"
3. Enter the following URL:
   ```
   https://github.com/GameFrameX/com.gameframex.unity.globalconfig.git
   ```

### Via manifest.json

Add the following to your project's `Packages/manifest.json`:

```json
{
  "dependencies": {
    "com.gameframex.unity.globalconfig": "https://github.com/GameFrameX/com.gameframex.unity.globalconfig.git"
  }
}
```

### Manual Installation

1. Download the latest release package
2. Extract it to your project's `Packages` directory
3. Unity will automatically recognize and load the package

## Quick Start

### Configuration

1. **Add Component**: Add `GlobalConfigComponent` to any GameObject in your Unity scene
2. **Set Properties**: Configure `CheckAppVersionUrl`, `CheckResourceVersionUrl`, `Content`, and `HostServerUrl` values in the Unity Inspector panel, or set them dynamically via code at runtime
3. **Version Management**: Use `CheckAppVersionUrl` and `CheckResourceVersionUrl` to manage game version control and resource update workflows
4. **Global Access**: Access the `GlobalConfigComponent` instance from anywhere in your game to retrieve global configuration information

## Changelog

See [CHANGELOG.md](CHANGELOG.md) for details.

## License

This project is licensed under the MIT License - see [LICENSE.md](LICENSE.md) for details.
