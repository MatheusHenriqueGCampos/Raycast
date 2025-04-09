using UnityEngine;

public class CubeRecolor : MonoBehaviour, IHittable
{
    public void OnHit()
    {
        this.gameObject.GetComponent<Renderer>().material.color = new Color(0f, 0f, 0f, 0f);
        PlayerScore.currentScore += 15;
    }
}
