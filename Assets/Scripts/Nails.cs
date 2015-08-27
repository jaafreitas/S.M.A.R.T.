using UnityEngine;

public class Nails : MonoBehaviour
{
    private GameObject[] nails;
    private const int totalNail = 30;

    void Start()
    {
        CreateNails();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            RandomizeNailsPosition();
        }
    }

    private Vector3 NailPosition()
    {
        return new Vector3(.5f, Random.Range(-4f, 3f), Random.Range(-4.5f, 4.5f));
    }

    private void RandomizeNailsPosition()
    {
        for (int i = 0; i < totalNail; i++)
        {
            nails[i].transform.localPosition = NailPosition();
        }
    }

    private void CreateNails()
    {
        nails = new GameObject[totalNail];

        GameObject folder = new GameObject();
        folder.name = "Nails";
        for (int i = 0; i < totalNail; i++)
        {
            Vector3 position = NailPosition();

            GameObject nail = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            nail.name = "Nail (" + position.y.ToString() + ", " + position.z.ToString() + ")";
            nail.transform.SetParent(folder.transform);
            nail.transform.localPosition = position;
            nail.transform.localEulerAngles = new Vector3(0, 0, 90);
            nail.transform.localScale = new Vector3(.2f, .5f, .2f);
            nails[i] = nail;
        }
    }
}
