using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsOfParticles : MonoBehaviour
{
    [SerializeField] private Vector3 VectorForParticles;
    void Awake()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        ParticleSystemRenderer renderer = ps.GetComponent<ParticleSystemRenderer>();
        Bounds bounds = renderer.bounds;
        bounds.size = new Vector3(VectorForParticles.x,VectorForParticles.y,VectorForParticles.z); // задайте новый размер bounds
        renderer.bounds = bounds;
    }

}
