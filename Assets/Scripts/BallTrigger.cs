using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallTrigger : MonoBehaviour
{
    [SerializeField] private float jump;

   public void ScaleBall()
    {
        gameObject.transform.localScale = new Vector3(2, 2, 2);
    }

    public void Bounce()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-0.5f, jump, 0f), ForceMode.Impulse);
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
