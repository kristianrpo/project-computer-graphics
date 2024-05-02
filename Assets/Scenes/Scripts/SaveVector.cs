using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SaveVector : MonoBehaviour
{
    public TMP_InputField inputFieldInitialX;
    public TMP_InputField inputFieldInitialY;
    public TMP_InputField inputFieldInitialZ;

    public int FlagVector;
    public Button button;

    private void Start()
    {
        button.onClick.AddListener(CreateVector);
        button.onClick.AddListener(ChangeScene);
    }

    public void CreateVector()
    {

        Vector3 vector = new Vector3(float.Parse(inputFieldInitialX.text), float.Parse(inputFieldInitialY.text), float.Parse(inputFieldInitialZ.text));

        if (FlagVector==1){
            GameManager.instance.v1 = vector;
        }
        else if (FlagVector==2){
            GameManager.instance.v2 = vector;
        }
        else{
            GameManager.instance.v3 = vector;
        }
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("VectorRender");
    }
}
