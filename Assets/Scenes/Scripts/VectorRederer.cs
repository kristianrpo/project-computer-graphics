using UnityEngine;

public class VectorRenderer : MonoBehaviour
{
    public Transform vector1;
    public Transform vector2;
    public Transform vector3;

    void Start()
    {
        GameManager.instance.v3 = Vector3.Cross(GameManager.instance.v1, GameManager.instance.v2);
        print(vector1.position);
        print(vector2.position);
        print(vector3.position);

    }
}
