using ECS;
using RMC.ECSPong.Components;
using UnityEngine;

namespace RMC.ECSPong.Systems
{
    //use this tag to group systems for debugging purposes
    //[DebugSystemGroup("MyGroup")] 
    public class TakeInputSystem : ComponentSystem
    {

        // this will inject all entities with components of type MyComponent 
        // if you define multiple ComponentArrays with the [InjectTuple] tag
        // you will only receive those entities with both Components
        [InjectTuple]
        ComponentArray<MovementSpeed> rotationSpeedArray;

        [InjectTuple]
        ComponentArray<TransformComponent> transformArray;

        // Use this for standard unity update function
        public override void OnFixedUpdate()
        {
            float verticalAxis = Input.GetAxis("Vertical");

            if (verticalAxis != 0)
            {
                float dt = Time.fixedDeltaTime;
                for (int i = 0; i < transformArray.Length; i++)
                {
                    Debug.Log(rotationSpeedArray[i].Speed * dt * verticalAxis);
                    transformArray[i].transform.position = new Vector3(transformArray[i].transform.position.x,
                        transformArray[i].transform.position.y + rotationSpeedArray[i].Speed * dt * verticalAxis,
                        transformArray[i].transform.position.z);
                }
            }
        }
    }
}