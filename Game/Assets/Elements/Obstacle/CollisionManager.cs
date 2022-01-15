using UnityEngine;

namespace Elements.Obstacle
{
    public class CollisionManager : MonoBehaviour
    {
        [SerializeField] private InstanceManager instanceManager;

        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log("COLLISION");
        }
    }
}
