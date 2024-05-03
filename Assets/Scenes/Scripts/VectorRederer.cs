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
        print(GameManager.instance.v1);
        print(GameManager.instance.v2);
        print(GameManager.instance.v3);
        print(magnitudev1);
        print(magnitudev2);
        print(magnitudev3);
        if (magnitudev3 > 20){
            magnitudev3 = 20;
        }
        if (magnitudev2 > 20){
            if (magnitudev1 > magnitudev2){
                magnitudev2 = 10;
            } else {
                magnitudev2 = 15;
            }
        }
        if (magnitudev1 > 20){
            if (magnitudev2 > magnitudev1){
                magnitudev1 = 10;
            } else {
                magnitudev1 = 15;
            }
        }
        print(magnitudev1);
        print(magnitudev2);
        print(magnitudev3);

        vector1.localScale = new Vector3((float)0.5, (float)0.5, (float)magnitudev1/20*(float)0.5);
        vector2.localScale = new Vector3((float)0.5, (float)0.5, (float)magnitudev2/20*(float)0.5);
        vector3.localScale = new Vector3((float)0.5, (float)0.5, (float)magnitudev3/20*(float)0.5);
    }
}
