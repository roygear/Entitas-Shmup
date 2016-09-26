//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {
    public partial class Entity {
        public AssetComponent asset { get { return (AssetComponent)GetComponent(BulletsComponentIds.Asset); } }

        public bool hasAsset { get { return HasComponent(BulletsComponentIds.Asset); } }

        public Entity AddAsset(string newName) {
            var component = CreateComponent<AssetComponent>(BulletsComponentIds.Asset);
            component.name = newName;
            return AddComponent(BulletsComponentIds.Asset, component);
        }

        public Entity ReplaceAsset(string newName) {
            var component = CreateComponent<AssetComponent>(BulletsComponentIds.Asset);
            component.name = newName;
            ReplaceComponent(BulletsComponentIds.Asset, component);
            return this;
        }

        public Entity RemoveAsset() {
            return RemoveComponent(BulletsComponentIds.Asset);
        }
    }
}

    public partial class BulletsMatcher {
        static IMatcher _matcherAsset;

        public static IMatcher Asset {
            get {
                if(_matcherAsset == null) {
                    var matcher = (Matcher)Matcher.AllOf(BulletsComponentIds.Asset);
                    matcher.componentNames = BulletsComponentIds.componentNames;
                    _matcherAsset = matcher;
                }

                return _matcherAsset;
            }
        }
    }

    public partial class CoreMatcher {
        static IMatcher _matcherAsset;

        public static IMatcher Asset {
            get {
                if(_matcherAsset == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.Asset);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherAsset = matcher;
                }

                return _matcherAsset;
            }
        }
    }
