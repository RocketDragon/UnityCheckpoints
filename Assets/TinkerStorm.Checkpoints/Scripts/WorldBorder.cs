using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinkerStorm.Checkpoints
{
    public class WorldBorder : MonoBehaviour
    {
        private bool isTrigger;

        private void Start()
        {
            isTrigger = GetComponent<Collider>().isTrigger;
        }

        protected void Run(Transform transform)
        {
            Respawnable respawner = transform.GetComponent<Respawnable>();

            if(respawner)
                respawner.Respawn();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (!isTrigger)
                Run(collision.transform);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (isTrigger)
                Run(other.transform);
        }
    }
}