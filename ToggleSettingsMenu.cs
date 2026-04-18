using UnityEngine;
using UnityEngine.SceneManagement;

public class ToggleSettingsMenu : MonoBehaviour
{
    [Header("Menu")]
    public GameObject menuCanvas;


    void Start()
    {
        if (menuCanvas != null) menuCanvas.SetActive(false);
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three)) // X button
        {
            ToggleMenu();
        }
    }


    public void ToggleMenu()
    {
        menuCanvas.SetActive(!menuCanvas.activeSelf);
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}
