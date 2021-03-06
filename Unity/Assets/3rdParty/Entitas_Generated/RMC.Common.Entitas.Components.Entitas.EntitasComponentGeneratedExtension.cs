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
        public RMC.Common.Entitas.Components.Entitas.EntitasComponent entitas { get { return (RMC.Common.Entitas.Components.Entitas.EntitasComponent)GetComponent(ComponentIds.Entitas); } }

        public bool hasEntitas { get { return HasComponent(ComponentIds.Entitas); } }

        public Entity AddEntitas(Entitas.Systems newPausableUpdateSystems, Entitas.Systems newUnpausableUpdateSystems, Entitas.Systems newPausableFixedUpdateSystems) {
            var component = CreateComponent<RMC.Common.Entitas.Components.Entitas.EntitasComponent>(ComponentIds.Entitas);
            component.pausableUpdateSystems = newPausableUpdateSystems;
            component.unpausableUpdateSystems = newUnpausableUpdateSystems;
            component.pausableFixedUpdateSystems = newPausableFixedUpdateSystems;
            return AddComponent(ComponentIds.Entitas, component);
        }

        public Entity ReplaceEntitas(Entitas.Systems newPausableUpdateSystems, Entitas.Systems newUnpausableUpdateSystems, Entitas.Systems newPausableFixedUpdateSystems) {
            var component = CreateComponent<RMC.Common.Entitas.Components.Entitas.EntitasComponent>(ComponentIds.Entitas);
            component.pausableUpdateSystems = newPausableUpdateSystems;
            component.unpausableUpdateSystems = newUnpausableUpdateSystems;
            component.pausableFixedUpdateSystems = newPausableFixedUpdateSystems;
            ReplaceComponent(ComponentIds.Entitas, component);
            return this;
        }

        public Entity RemoveEntitas() {
            return RemoveComponent(ComponentIds.Entitas);
        }
    }

    public partial class Pool {
        public Entity entitasEntity { get { return GetGroup(Matcher.Entitas).GetSingleEntity(); } }

        public RMC.Common.Entitas.Components.Entitas.EntitasComponent entitas { get { return entitasEntity.entitas; } }

        public bool hasEntitas { get { return entitasEntity != null; } }

        public Entity SetEntitas(Entitas.Systems newPausableUpdateSystems, Entitas.Systems newUnpausableUpdateSystems, Entitas.Systems newPausableFixedUpdateSystems) {
            if (hasEntitas) {
                throw new EntitasException("Could not set entitas!\n" + this + " already has an entity with RMC.Common.Entitas.Components.Entitas.EntitasComponent!",
                    "You should check if the pool already has a entitasEntity before setting it or use pool.ReplaceEntitas().");
            }
            var entity = CreateEntity();
            entity.AddEntitas(newPausableUpdateSystems, newUnpausableUpdateSystems, newPausableFixedUpdateSystems);
            return entity;
        }

        public Entity ReplaceEntitas(Entitas.Systems newPausableUpdateSystems, Entitas.Systems newUnpausableUpdateSystems, Entitas.Systems newPausableFixedUpdateSystems) {
            var entity = entitasEntity;
            if (entity == null) {
                entity = SetEntitas(newPausableUpdateSystems, newUnpausableUpdateSystems, newPausableFixedUpdateSystems);
            } else {
                entity.ReplaceEntitas(newPausableUpdateSystems, newUnpausableUpdateSystems, newPausableFixedUpdateSystems);
            }

            return entity;
        }

        public void RemoveEntitas() {
            DestroyEntity(entitasEntity);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherEntitas;

        public static IMatcher Entitas {
            get {
                if (_matcherEntitas == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.Entitas);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherEntitas = matcher;
                }

                return _matcherEntitas;
            }
        }
    }
}
