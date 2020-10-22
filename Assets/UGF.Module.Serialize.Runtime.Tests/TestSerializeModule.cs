using NUnit.Framework;
using UGF.Application.Runtime;
using UnityEngine;

namespace UGF.Module.Serialize.Runtime.Tests
{
    public class TestSerializeModule
    {
        [Test]
        public void Initialize()
        {
            var asset = Resources.Load<SerializeModuleAsset>("Module");
            var application = new ApplicationConfigured(new ApplicationResources { new ApplicationConfig { Modules = { asset } } });

            application.Initialize();
        }

        [Test]
        public void Uninitialize()
        {
            var asset = Resources.Load<SerializeModuleAsset>("Module");
            var application = new ApplicationConfigured(new ApplicationResources { new ApplicationConfig { Modules = { asset } } });

            application.Initialize();
            application.Uninitialize();
        }
    }
}
