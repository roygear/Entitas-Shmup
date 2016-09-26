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
        static readonly EnemyComponent enemyComponent = new EnemyComponent();

        public bool isEnemy {
            get { return HasComponent(CoreComponentIds.Enemy); }
            set {
                if(value != isEnemy) {
                    if(value) {
                        AddComponent(CoreComponentIds.Enemy, enemyComponent);
                    } else {
                        RemoveComponent(CoreComponentIds.Enemy);
                    }
                }
            }
        }

        public Entity IsEnemy(bool value) {
            isEnemy = value;
            return this;
        }
    }
}

    public partial class CoreMatcher {
        static IMatcher _matcherEnemy;

        public static IMatcher Enemy {
            get {
                if(_matcherEnemy == null) {
                    var matcher = (Matcher)Matcher.AllOf(CoreComponentIds.Enemy);
                    matcher.componentNames = CoreComponentIds.componentNames;
                    _matcherEnemy = matcher;
                }

                return _matcherEnemy;
            }
        }
    }
