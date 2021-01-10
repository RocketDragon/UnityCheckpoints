using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TinkerStorm.Checkpoints
{
    public class DebugTeleporter : MonoBehaviour
    {
        [SerializeField]
        Transform destination;

        bool isTrigger;

        void Start()
        {
            isTrigger = GetComponent<Collider>().isTrigger;
        }

        void Run(Transform other)
        {
            Respawnable respawner = other.GetComponent<Respawnable>();
            if(respawner != null)
            {
                respawner.SetRespawnAt(destination);
                respawner.Respawn();
            }
        }

        void OnCollisionEnter(Collision other)
        {
            if (!isTrigger)
                Run(other.transform);
        }

        void OnTriggerEnter(Collider other)
        {
            if (isTrigger)
                Run(other.transform);
        }
    }
}