using UGF.Application.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Serialize.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Serialize/SerializeModuleBuilder", order = 2000)]
    public class SerializeModuleBuilderAsset : ModuleBuilderAsset<ISerializeModule, SerializeModuleDescription>
    {
        protected override IApplicationModule OnBuild(IApplication application, SerializeModuleDescription description)
        {
            return new SerializeModule(description);
        }
    }
}
