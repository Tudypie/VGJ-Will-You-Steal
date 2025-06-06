using System;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public LayerMask collisionLayer;

    public event Action OnCollision;

    private void OnCollisionEnter(Collision collision)
    {
        if ((collisionLayer.value & (1 << collision.gameObject.layer)) != 0)
        {
            OnCollision?.Invoke();
        }
    }
}
