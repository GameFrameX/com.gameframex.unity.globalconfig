<div align="center">
  <img src="https://download.alianblank.com/gameframex/gameframex_logo_320.png" alt="GameFrameX Logo" width="160" />

  # GameFrameX GlobalConfig

  [![Version](https://img.shields.io/github/v/release/GameFrameX/com.gameframex.unity.globalconfig)](https://github.com/GameFrameX/com.gameframex.unity.globalconfig/releases)
  [![License](https://img.shields.io/badge/license-MIT-orange.svg)](LICENSE.md)
  [![Documentation](https://img.shields.io/badge/docs-gameframex-blue.svg)](https://gameframex.doc.alianblank.com)

  인디 게임 개발자를 위한 올인원 솔루션 · 인디 개발자의 꿈을 실현

  [문서](https://gameframex.doc.alianblank.com) | [빠른 시작](#빠른-시작)

  [English](README.md) | [简体中文](README.zh-CN.md) | [繁體中文](README.zh-TW.md) | [日本語](README.ja.md) | **한국어**
</div>

---

## 프로젝트 개요

GameFrameX GlobalConfig 컴포넌트 - 서버에서 가져온 구성 정보를 기록하는 전역 구성 관리자입니다. 애플리케이션 버전 확인 URL, 리소스 버전 확인 URL 및 기타 전역적으로 액세스 가능한 구성 데이터를 관리합니다.

## 특징

- **앱 버전 URL** - 애플리케이션 버전 업데이트 확인용 URL 저장 및 관리
- **리소스 버전 URL** - 게임 리소스 버전 업데이트 확인용 URL 저장 및 관리
- **사용자 정의 콘텐츠** - 게임 내 표시 또는 비즈니스 로직을 위한 추가 콘텐츠 및 데이터 저장
- **호스트 서버 URL** - 백엔드 서버 연결용 호스트 서버 URL 저장

## 설치

### Git URL을 통해 설치 (권장)

1. Unity 에디터에서 Package Manager 열기
2. "+" 버튼을 클릭하고 "Add package from git URL" 선택
3. 다음 URL 입력:
   ```
   https://github.com/GameFrameX/com.gameframex.unity.globalconfig.git
   ```

### manifest.json을 통해 설치

프로젝트의 `Packages/manifest.json`에 다음을 추가:

```json
{
  "dependencies": {
    "com.gameframex.unity.globalconfig": "https://github.com/GameFrameX/com.gameframex.unity.globalconfig.git"
  }
}
```

### 수동 설치

1. 최신 릴리스 패키지 다운로드
2. 프로젝트의 `Packages` 디렉토리에 압축 해제
3. Unity가 자동으로 패키지를 인식하고 로드합니다

## 빠른 시작

### 구성

1. **컴포넌트 추가**：`GlobalConfigComponent`를 Unity 씬의 아무 GameObject에 추가
2. **속성 설정**：Unity Inspector 패널에서 `CheckAppVersionUrl`、`CheckResourceVersionUrl`、`Content`、`HostServerUrl` 값을 설정하거나 코드를 통해 런타임에 동적으로 설정
3. **버전 관리**：`CheckAppVersionUrl`과 `CheckResourceVersionUrl`을 사용하여 게임의 버전 관리 및 리소스 업데이트 워크플로 관리
4. **전역 액세스**：게임 내 어디서든 `GlobalConfigComponent` 인스턴스에 액세스하여 전역 구성 정보 가져오기

## 변경 로그

자세한 내용은 [CHANGELOG.md](CHANGELOG.md)를 참조하세요.

## 라이선스

이 프로젝트는 MIT 라이선스에 따라 배포됩니다. 자세한 내용은 [LICENSE.md](LICENSE.md)를 참조하세요.
