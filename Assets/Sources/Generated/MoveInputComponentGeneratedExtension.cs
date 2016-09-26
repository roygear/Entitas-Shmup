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
        public MoveInputComponent moveInput { get { return (MoveInputComponent)GetComponent(InputComponentIds.MoveInput); } }

        public bool hasMoveInput { get { return HasComponent(InputComponentIds.MoveInput); } }

        public Entity AddMoveInput(UnityEngine.Vector3 newDirection) {
            var component = CreateComponent<MoveInputComponent>(InputComponentIds.MoveInput);
            component.direction = newDirection;
            return AddComponent(InputComponentIds.MoveInput, component);
        }

        public Entity ReplaceMoveInput(UnityEngine.Vector3 newDirection) {
            var component = CreateComponent<MoveInputComponent>(InputComponentIds.MoveInput);
            component.direction = newDirection;
            ReplaceComponent(InputComponentIds.MoveInput, component);
            return this;
        }

        public Entity RemoveMoveInput() {
            return RemoveComponent(InputComponentIds.MoveInput);
        }
    }
}

    public partial class InputMatcher {
        static IMatcher _matcherMoveInput;

        public static IMatcher MoveInput {
            get {
                if(_matcherMoveInput == null) {
                    var matcher = (Matcher)Matcher.AllOf(InputComponentIds.MoveInput);
                    matcher.componentNames = InputComponentIds.componentNames;
                    _matcherMoveInput = matcher;
                }

                return _matcherMoveInput;
            }
        }
    }
