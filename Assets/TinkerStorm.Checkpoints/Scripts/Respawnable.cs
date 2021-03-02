using UnityEngine;

namespace TinkerStorm.Checkpoints
{
    public class Respawnable : MonoBehaviour
    {
        protected Vector3 respawnPosition;
        protected Quaternion respawnRotation;

        private void Start()
        {
            SetRespawnAt(transform);
        }

        public void Respawn()
        {
            if (!enabled) return;

            transform.position = respawnPosition;
            transform.rotation = respawnRotation;
        }

        public void SetRespawnAt(Transform transform)
        {
            SetRespawnAt(transform.position, transform.rotation);
        }

        public void SetRespawnAt(Vector3 position, Quaternion rotation)
        {
            if (!enabled) return;

            respawnPosition = position;
            respawnRotation = rotation;
        }
    }
}
