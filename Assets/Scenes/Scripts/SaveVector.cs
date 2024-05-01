using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class SaveVector : MonoBehaviour
{
    public TMP_InputField inputFieldInitialX;
    public TMP_InputField inputFieldInitialY;
    public TMP_InputField inputFieldInitialZ;
    public TMP_InputField inputFieldFinalX;
    public TMP_InputField inputFieldFinalY;
    public TMP_InputField inputFieldFinalZ;

    public int FlagVector;
    public Button button;

    private void Start()
    {
        button.onClick.AddListener(CreateVector);
        button.onClick.AddListener(ChangeScene);
    }

    public void CreateVector()
    {

        Vector3 initialPoint = new Vector3(float.Parse(inputFieldInitialX.text), float.Parse(inputFieldInitialY.text), float.Parse(inputFieldInitialZ.text));
        Vector3 finalPoint = new Vector3(float.Parse(inputFieldFinalX.text), float.Parse(inputFieldFinalY.text), float.Parse(inputFieldFinalZ.text));

        if (FlagVector==1){
            GameManager.instance.v1 = finalPoint-initialPoint;
        }
        else if (FlagVector==2){
            GameManager.instance.v2 = finalPoint-initialPoint;
        }
        else{
            GameManager.instance.v3 = finalPoint-initialPoint;
        }
        
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("VectorRender");
    }
}
