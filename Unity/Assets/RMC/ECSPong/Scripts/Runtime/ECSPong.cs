using ECS;
using RMC.ECSPong.Systems;

namespace RMC.ECSPong
{
    /// <summary>
    /// Main entry point.
    /// </summary>
    public class ECSPong : ECSController<UnityStandardSystemRoot, UnityEntityManager>
    {

        // ------------------ Constants and statics

        // ------------------ Events

        // ------------------ Serialized fields and properties

        // ------------------ Non-serialized fields

        // ------------------ Methods
        protected override void Initialize()
        {
            AddSystem<RotateObjectSystem>();
            AddSystem<TakeInputSystem>();
        }
    }
}