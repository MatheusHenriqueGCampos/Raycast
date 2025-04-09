using UnityEngine;

public class SphereHit : MonoBehaviour, IHittable
{
    public void OnHit()
    {
        GameObject thisSpere = Resources.Load<GameObject>("Sphere");
        GameObject thisObject = this.gameObject;
        //GameObject thisSpere = this.gameObject;
        Vector3 pos = new Vector3(thisObject.transform.position.x - 2f, thisObject.transform.position.y, thisObject.transform.position.z - 1f);
        Instantiate(thisObject, pos, Quaternion.identity);
        thisObject.gameObject.GetComponent<Renderer>().material.color = Color.green;
        PlayerScore.currentScore += 25;
    }
}