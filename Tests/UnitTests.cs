using GameFrameX.GlobalConfig.Runtime;
using NUnit.Framework;

namespace GameFrameX.GlobalConfig.Tests
{
    internal class UnitTests
    {
        [Test]
        public void ResponseGlobalInfo_DefaultValues_AreNull()
        {
            var response = new ResponseGlobalInfo();
            Assert.IsNull(response.CheckAppVersionUrl);
            Assert.IsNull(response.CheckResourceVersionUrl);
            Assert.IsNull(response.AOTCodeList);
            Assert.IsNull(response.Content);
        }

        [Test]
        public void ResponseGlobalInfo_PropertiesCanBeSet()
        {
            var response = new ResponseGlobalInfo
            {
                CheckAppVersionUrl = "https://example.com/app",
                CheckResourceVersionUrl = "https://example.com/res",
                AOTCodeList = "[\"Assembly\"]",
                Content = "extra"
            };
            Assert.AreEqual("https://example.com/app", response.CheckAppVersionUrl);
            Assert.AreEqual("https://example.com/res", response.CheckResourceVersionUrl);
            Assert.AreEqual("[\"Assembly\"]", response.AOTCodeList);
            Assert.AreEqual("extra", response.Content);
        }

        [Test]
        public void ResponseGameAppVersion_DefaultValues()
        {
            var response = new ResponseGameAppVersion();
            Assert.IsFalse(response.IsForce);
            Assert.IsFalse(response.IsUpgrade);
            Assert.IsNull(response.AppDownloadUrl);
            Assert.IsNull(response.UpdateAnnouncement);
            Assert.IsNull(response.UpdateTitle);
        }

        [Test]
        public void ResponseGameAssetPackageVersion_DefaultValues_AreNull()
        {
            var response = new ResponseGameAssetPackageVersion();
            Assert.IsNull(response.Language);
            Assert.IsNull(response.Version);
            Assert.IsNull(response.AssetPackageName);
            Assert.IsNull(response.AssetPackagePath);
            Assert.IsNull(response.Platform);
            Assert.IsNull(response.RootPath);
            Assert.IsNull(response.PackageName);
            Assert.IsNull(response.AppVersion);
            Assert.IsNull(response.Channel);
        }

        [Test]
        public void RequestGameAssetPackageVersion_InheritsRequestBase()
        {
            var request = new RequestGameAssetPackageVersion
            {
                Language = "zh",
                AppVersion = "1.0",
                Platform = "Android",
                PackageName = "com.test",
                Channel = "default",
                SubChannel = "sub",
                AssetPackageName = "main"
            };
            Assert.AreEqual("zh", request.Language);
            Assert.AreEqual("1.0", request.AppVersion);
            Assert.AreEqual("Android", request.Platform);
            Assert.AreEqual("com.test", request.PackageName);
            Assert.AreEqual("default", request.Channel);
            Assert.AreEqual("sub", request.SubChannel);
            Assert.AreEqual("main", request.AssetPackageName);
        }
    }
}
