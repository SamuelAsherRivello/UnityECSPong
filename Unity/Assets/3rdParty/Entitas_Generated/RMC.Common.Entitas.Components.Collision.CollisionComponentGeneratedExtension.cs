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
        public RMC.Common.Entitas.Components.Collision.CollisionComponent collision { get { return (RMC.Common.Entitas.Components.Collision.CollisionComponent)GetComponent(ComponentIds.Collision); } }

        public bool hasCollision { get { return HasComponent(ComponentIds.Collision); } }

        public Entity AddCollision(object newLocalGameObject, object newOtherGameObject, RMC.Common.Entitas.Components.Collision.CollisionComponent.CollisionType newCollisionType) {
            var component = CreateComponent<RMC.Common.Entitas.Components.Collision.CollisionComponent>(ComponentIds.Collision);
            component.localGameObject = newLocalGameObject;
            component.otherGameObject = newOtherGameObject;
            component.collisionType = newCollisionType;
            return AddComponent(ComponentIds.Collision, component);
        }

        public Entity ReplaceCollision(object newLocalGameObject, object newOtherGameObject, RMC.Common.Entitas.Components.Collision.CollisionComponent.CollisionType newCollisionType) {
            var component = CreateComponent<RMC.Common.Entitas.Components.Collision.CollisionComponent>(ComponentIds.Collision);
            component.localGameObject = newLocalGameObject;
            component.otherGameObject = newOtherGameObject;
            component.collisionType = newCollisionType;
            ReplaceComponent(ComponentIds.Collision, component);
            return this;
        }

        public Entity RemoveCollision() {
            return RemoveComponent(ComponentIds.Collision);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherCollision;

        public static IMatcher Collision {
            get {
                if (_matcherCollision == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Collision);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherCollision = matcher;
                }

                return _matcherCollision;
            }
        }
    }
}
