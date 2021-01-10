using UnityEngine;

namespace TinkerStorm.Checkpoints
{
    public class Checkpoint : MonoBehaviour
    {
        [SerializeField]
        protected string targetTag;
        
        protected bool isTrigger;

        private void Start()
        {
            isTrigger = GetComponent<Collider>().isTrigger;
        }

        protected void Run(Transform other)
        {
            if(other.CompareTag(targetTag))
            {
                other.GetComponent<Respawnable>().SetRespawnAt(other);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (!isTrigger)
                Run(collision.transform);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (isTrigger)
                Run(other.transform);
        }
    }
}