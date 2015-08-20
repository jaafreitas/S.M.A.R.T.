using UnityEngine;

public class Ball : MonoBehaviour
{
    void Start()
    {
        GameObject ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        ball.name = "Ball";

        ball.transform.localPosition = new Vector3(0.5f, 5, 0);
        ball.transform.localEulerAngles = new Vector3(0, 0, 0);
        ball.transform.localScale = new Vector3(1, 1, 1);

        Renderer rend = ball.GetComponent<MeshRenderer>();
        rend.material.color = new Color32(255, 255, 0, 255);

        ball.gameObject.AddComponent<Rigidbody>();
    }
}
