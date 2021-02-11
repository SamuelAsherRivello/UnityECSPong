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
        public RMC.Common.Entitas.Components.Audio.AudioSettingsComponent audioSettings { get { return (RMC.Common.Entitas.Components.Audio.AudioSettingsComponent)GetComponent(ComponentIds.AudioSettings); } }

        public bool hasAudioSettings { get { return HasComponent(ComponentIds.AudioSettings); } }

        public Entity AddAudioSettings(bool newIsMuted) {
            var component = CreateComponent<RMC.Common.Entitas.Components.Audio.AudioSettingsComponent>(ComponentIds.AudioSettings);
            component.isMuted = newIsMuted;
            return AddComponent(ComponentIds.AudioSettings, component);
        }

        public Entity ReplaceAudioSettings(bool newIsMuted) {
            var component = CreateComponent<RMC.Common.Entitas.Components.Audio.AudioSettingsComponent>(ComponentIds.AudioSettings);
            component.isMuted = newIsMuted;
            ReplaceComponent(ComponentIds.AudioSettings, component);
            return this;
        }

        public Entity RemoveAudioSettings() {
            return RemoveComponent(ComponentIds.AudioSettings);
        }
    }

    public partial class Pool {
        public Entity audioSettingsEntity { get { return GetGroup(Matcher.AudioSettings).GetSingleEntity(); } }

        public RMC.Common.Entitas.Components.Audio.AudioSettingsComponent audioSettings { get { return audioSettingsEntity.audioSettings; } }

        public bool hasAudioSettings { get { return audioSettingsEntity != null; } }

        public Entity SetAudioSettings(bool newIsMuted) {
            if (hasAudioSettings) {
                throw new EntitasException("Could not set audioSettings!\n" + this + " already has an entity with RMC.Common.Entitas.Components.Audio.AudioSettingsComponent!",
                    "You should check if the pool already has a audioSettingsEntity before setting it or use pool.ReplaceAudioSettings().");
            }
            var entity = CreateEntity();
            entity.AddAudioSettings(newIsMuted);
            return entity;
        }

        public Entity ReplaceAudioSettings(bool newIsMuted) {
            var entity = audioSettingsEntity;
            if (entity == null) {
                entity = SetAudioSettings(newIsMuted);
            } else {
                entity.ReplaceAudioSettings(newIsMuted);
            }

            return entity;
        }

        public void RemoveAudioSettings() {
            DestroyEntity(audioSettingsEntity);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherAudioSettings;

        public static IMatcher AudioSettings {
            get {
                if (_matcherAudioSettings == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.AudioSettings);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherAudioSettings = matcher;
                }

                return _matcherAudioSettings;
            }
        }
    }
}
