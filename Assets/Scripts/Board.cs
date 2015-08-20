using UnityEngine;

public class Board : MonoBehaviour
{
    private GameObject boardFolder;

    void Start()
    {
        boardFolder = new GameObject();
        boardFolder.name = "Board";

        GameObject mainWall = GameObject.CreatePrimitive(PrimitiveType.Plane);
        mainWall.name = "Main Wall";
        mainWall.transform.SetParent(boardFolder.transform);
        mainWall.transform.localEulerAngles = new Vector3(0, 0, -90);
        Renderer rend = mainWall.GetComponent<MeshRenderer>();
        rend.material.color = new Color32(0, 32, 64, 255);

        CreateWall("West Wall",       0, -5,  10, .2f);
        CreateWall("East Wall",       0,  5,  10, .2f);
        CreateWall("Bottom Wall", -4.9f,  0, .2f,  10);

        CreateNail(-1.5f, -1.4f);
        CreateNail(    1,  0.5f);
    }

    void CreateWall(string name, float py, float pz, float sy, float sz)
    {
        GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        wall.name = name;
        wall.transform.SetParent(boardFolder.transform);
        wall.transform.localPosition = new Vector3(.5f, py, pz);
        wall.transform.localScale = new Vector3(1, sy, sz);
    }

    void CreateNail(float y, float z)
    {
        GameObject nail = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        nail.name = "Nail (" + y.ToString() + ", " + z.ToString() + ")";
        nail.transform.SetParent(boardFolder.transform);
        nail.transform.localPosition = new Vector3(.5f, y, z);
        nail.transform.localEulerAngles = new Vector3(0, 0, 90);
        nail.transform.localScale = new Vector3(.25f, .5f, .25f);
    }
}
