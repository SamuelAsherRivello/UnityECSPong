using ECS;
using UnityEngine;

namespace RMC.ECSPong
{
    /// <summary>
    /// Main entry point.
    /// </summary>
    public class PrefabSpawner : ScriptBehaviour
    {

        // ------------------ Constants and statics

        // ------------------ Events

        // ------------------ Serialized fields and properties

        public GameObject _prefab;

        public Transform[] spawnPoints;

        [InjectDependency]
        private UnityEntityManager _entityManager;

        // ------------------ Non-serialized fields

        // ------------------ Methods

        protected void Start()
        {
            NativeArray<Entity> entities = new NativeArray<Entity>(spawnPoints.Length);
            NativeArray<GameObject> gameObjects = new NativeArray<GameObject>(spawnPoints.Length);
            _entityManager.InstantiateWithGameObject(_prefab, entities, gameObjects);

            for (int i = 0; i < gameObjects.Length; i++)
            {
                gameObjects[i].name += ": " + i;
                gameObjects[i].transform.position = spawnPoints[i].position;
            }
        }
    }
}