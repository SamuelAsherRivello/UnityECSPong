using System;
using ECS;

namespace RMC.ECSPong.Components
{
    [Serializable]
    public struct MovementSpeed : IComponent
    {
        public float Speed;
    }

    // this wrapps the component tfor Scene & Prefab workflow
    public class MovementSpeedComponent : ComponentDataWrapper<MovementSpeed> { }
}
