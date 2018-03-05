using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject PlayButton, SoundButton, ShopButton, DifficultyScene, HelpScene;

    void Start ()
    {
        PlayButton.SetActive(true);
    }

    public void ShowHelpScene()
    {
        // Disable Play button
        PlayButton.SetActive(false);
        SoundButton.SetActive(false);
        ShopButton.SetActive(false);

        // Show Help scene
        HelpScene.SetActive(true);
    }

    public void ShowDifficultyScene ()
    {
        // Disable Help scene
        HelpScene.SetActive(false);

        // Show Difficulty scene
        DifficultyScene.SetActive(true);
    }

    public void PlayEasyLevel ()
    {
        // Scene EasyLevel
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayHardLevel ()
    {
        // Scene HardLevel
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

}
