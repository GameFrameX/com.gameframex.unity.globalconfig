<div align="center">

<img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="Game Frame X Logo" width="160" />

# GameFrameX GlobalConfig

[![License](https://img.shields.io/github/license/GameFrameX/com.gameframex.unity.globalconfig)](https://github.com/GameFrameX/com.gameframex.unity.globalconfig/blob/main/LICENSE.md)
[![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.globalconfig)](https://github.com/GameFrameX/com.gameframex.unity.globalconfig/releases)
[![Unity Version](https://img.shields.io/badge/Unity-2019.4-black?logo=unity)](https://unity.com/)
[![Documentation](https://img.shields.io/badge/Documentation-docs-blue)](https://gameframex.doc.alianblank.com)

All-in-One Solution for Indie Game Development · Empowering Indie Developers' Dreams

<br />

[Documentation](https://gameframex.doc.alianblank.com) · [Quick Start](#quick-start) · QQ Group: 467608841 / 233840761

<br />

**English** | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | [한국어](README.ko.md)

</div>

## Project Overview

GameFrameX GlobalConfig Component - A global configuration manager that stores configuration information retrieved from the server. It manages application version check URLs, resource version check URLs, and other globally accessible configuration data.

## Features

- **App Version URL** - Store and manage the URL for checking application version updates
- **Resource Version URL** - Store and manage the URL for checking game resource version updates
- **Custom Content** - Store additional content or data for in-game display or business logic
- **Host Server URL** - Store the host server URL for backend server connections

## Quick Start

### Installation

Edit your Unity project's `Packages/manifest.json` and add the `scopedRegistries` section:

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

`scopes` controls which packages are resolved through this registry. Only packages whose names start with `com.gameframex` will be fetched from it.

Then add the package to `dependencies`:

```json
{
  "dependencies": {
    "com.gameframex.unity.globalconfig": "1.3.2"
  }
}
```


## Changelog

See [CHANGELOG.md](CHANGELOG.md) for details.


## Dependencies

| Package | Description |
|---------|-------------|
| `com.gameframex.unity` | 1.1.1 |
| `com.gameframex.unity.web` | 1.1.2 |

## Documentation & Resources

- [Documentation](https://gameframex.doc.alianblank.com)

## Community & Support

- QQ Group: 467608841 / 233840761
## License

This project is licensed - see [LICENSE.md](LICENSE.md) for details.
