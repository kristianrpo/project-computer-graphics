using UnityEngine;

public class VectorRenderer : MonoBehaviour
{
    public Transform vector1;
    public Transform vector2;
    public Transform vector3;

    void Start()
    {
        GameManager.instance.v3 = Vector3.Cross(GameManager.instance.v1, GameManager.instance.v2);
        Quaternion rotation = Quaternion.LookRotation(GameManager.instance.v1);

        vector1.localRotation = rotation;
        rotation = Quaternion.LookRotation(GameManager.instance.v2);
        vector2.localRotation = rotation;
        rotation = Quaternion.LookRotation(GameManager.instance.v3);
        vector3.localRotation = rotation;

        float magnitudev1 = GameManager.instance.v1.magnitude;
        float magnitudev2 = GameManager.instance.v2.magnitude;
        float magnitudev3 = GameManager.instance.v3.magnitude;
        print(magnitudev1);
        print(magnitudev2);
        print(magnitudev3);
        print(GameManager.instance.v3);

        vector1.localScale = new Vector3((float)0.5, (float)0.5, (float)magnitudev1/20);
        vector2.localScale = new Vector3((float)0.5, (float)0.5, (float)magnitudev2/20);
        vector3.localScale = new Vector3((float)0.5, (float)0.5, (float)magnitudev3/20);
    }
}
