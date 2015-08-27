using UnityEngine;

public class Ball : MonoBehaviour
{
    private GameObject ball;

    void Start()
    {
        ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        ball.name = "Ball";

        RandomizeBallPosition();
        ball.transform.localEulerAngles = new Vector3(0, 0, 0);
        ball.transform.localScale = new Vector3(.4f, .4f, .4f);

        Renderer rend = ball.GetComponent<MeshRenderer>();
        rend.material.color = new Color32(255, 255, 0, 255);

        ball.gameObject.AddComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RandomizeBallPosition();
        }
    }

    private void RandomizeBallPosition()
    {
        ball.transform.localPosition = new Vector3(0.5f, 5, Random.Range(-4.5f, 4.5f));
    }
}
