using UnityEngine;

public class CylinderHit : MonoBehaviour, IHittable
{
    public void OnHit()
    {
        this.gameObject.AddComponent<Rigidbody>();
        this.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        PlayerScore.currentScore += 10;
    }
}
