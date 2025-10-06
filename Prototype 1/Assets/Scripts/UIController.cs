using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public GameObject[] dogImages;
    public GameObject dogPicture;
    public Slider dogSlider;
    public TMP_Dropdown dogMenu;
    private float pictureAngle;
    private float pictureAngleIncrement;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pictureAngle = 0f;
        pictureAngleIncrement = 0f;
        SelectDog(); //  default 1st dog
    }

    // Update is called once per frame
    void Update()
    {
        pictureAngle += pictureAngleIncrement;
        dogPicture.transform.localEulerAngles = new Vector3(0f, 0f, pictureAngle);
    }

    public void HideDog()
    {
        dogPicture.SetActive(false);
    }

    public void RotateDog()
    {
        pictureAngleIncrement = 0.5f;
    }

    public void ScaleDog()
    {
        float scaleValue;
        scaleValue = 1 + dogSlider.value;
        Debug.Log("scaleValue: " + scaleValue);
        dogPicture.transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
    }

    public void SelectDog()
    {
        // Hide All the dogs
        for (int i = 0; i < 3; i++)
        {
            dogImages[i].SetActive(false);
        }
        // Unhide Selected dog
        dogImages[dogMenu.value].SetActive(true);
    }

}