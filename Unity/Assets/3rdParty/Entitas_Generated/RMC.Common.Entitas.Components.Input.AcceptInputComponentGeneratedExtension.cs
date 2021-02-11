//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        static readonly RMC.Common.Entitas.Components.Input.AcceptInputComponent acceptInputComponent = new RMC.Common.Entitas.Components.Input.AcceptInputComponent();

        public bool willAcceptInput {
            get { return HasComponent(ComponentIds.AcceptInput); }
            set {
                if (value != willAcceptInput) {
                    if (value) {
                        AddComponent(ComponentIds.AcceptInput, acceptInputComponent);
                    } else {
                        RemoveComponent(ComponentIds.AcceptInput);
                    }
                }
            }
        }

        public Entity WillAcceptInput(bool value) {
            willAcceptInput = value;
            return this;
        }
    }

    public partial class Matcher {
        static IMatcher _matcherAcceptInput;

        public static IMatcher AcceptInput {
            get {
                if (_matcherAcceptInput == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.AcceptInput);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherAcceptInput = matcher;
                }

                return _matcherAcceptInput;
            }
        }
    }
}
