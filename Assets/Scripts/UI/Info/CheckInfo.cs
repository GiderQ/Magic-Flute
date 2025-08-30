using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class CheckInfo : MonoBehaviour
{
    string infoText;
    bool Active;
    public TextMeshProUGUI windowText;
    public GameObject DialogeWindow,DialogeInfo,DialogeIcon;

    public Sprite DialogeWindowInfo;
    void Update()
    {
        if (Active && Input.GetKeyDown(KeyCode.E))
        {
            PlayerController.pause = true;
            DialogeWindow.SetActive(true);
            TextMeshProUGUI DialogeText = DialogeInfo.gameObject.GetComponentInChildren<TextMeshProUGUI>();
            DialogeText.text = infoText;

            Image DialogeIcon = DialogeInfo.gameObject.GetComponentInChildren<Image>();
            DialogeIcon.sprite = DialogeWindowInfo;
        }

        else if (Active  && PlayerController.pause == true && (Input.GetKeyDown(KeyCode.Escape)) || (Input.GetKeyDown(KeyCode.A)) || (Input.GetKeyDown(KeyCode.S)) || (Input.GetKeyDown(KeyCode.D)) || (Input.GetKeyDown(KeyCode.W)) )
        {
            PlayerController.pause = false;
            DialogeWindow.SetActive(false);
        }
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.transform.tag == "Object")
        {
            InfoObject infoObject = other.gameObject.GetComponent<InfoObject>();
            infoText = infoObject.info;

            Active = true;
            Debug.Log(infoText);
        }
    }
}
