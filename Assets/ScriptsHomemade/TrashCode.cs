using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TrashCode : MonoBehaviour
{
    public float sizeMultiply;
    public float offsetDown;
    public Slider downSlider;
    public Slider scaleSlider;
    public TextMeshProUGUI downOutputText;
    public TextMeshProUGUI scaleOutputText;
    public GameObject debugMenu;
    public GameObject newPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void toggleDebugMenu(){
        if(debugMenu.activeInHierarchy){
            debugMenu.SetActive(false);
        }else{
            debugMenu.SetActive(true);
        }
    }
    public void sliderUpdate(){
        offsetDown = downSlider.value;
        downOutputText.text = offsetDown.ToString();
        sizeMultiply = scaleSlider.value;
        scaleOutputText.text = sizeMultiply.ToString();
     }
    void Start()
    {
        newPrefab.transform.position = new Vector3(newPrefab.transform.position.x, newPrefab.transform.position.y * offsetDown, newPrefab.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
