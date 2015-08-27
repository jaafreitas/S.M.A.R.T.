using UnityEngine;

public class Board : MonoBehaviour
{
    void Start()
    {
        GameObject folder = new GameObject();
        folder.name = "Board";

        GameObject mainWall = GameObject.CreatePrimitive(PrimitiveType.Plane);
        mainWall.name = "Main Wall";
        mainWall.transform.SetParent(folder.transform);
        mainWall.transform.localEulerAngles = new Vector3(0, 0, -90);
        Renderer rend = mainWall.GetComponent<MeshRenderer>();
        rend.material.color = new Color32(0, 32, 64, 255);

        CreateWall(folder, "West Wall",       0, -5,  10, .2f);
        CreateWall(folder, "East Wall",       0,  5,  10, .2f);
        CreateWall(folder, "Bottom Wall", -4.9f,  0, .2f,  10);

        // Slots.
        for (float i = -5; i <= 5; i++)
        {
            CreateWall(folder, "div", -4.55f, i, .5f, .2f);
        }
    }

    private void CreateWall(GameObject parent, string name, float py, float pz, float sy, float sz)
    {
        GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        wall.name = name;
        wall.transform.SetParent(parent.transform);
        wall.transform.localPosition = new Vector3(.5f, py, pz);
        wall.transform.localScale = new Vector3(1, sy, sz);
    }
}
