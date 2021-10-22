using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MediatorMenu : MonoBehaviour
{
    [SerializeField] private MainMenu _mainMenu;
    [SerializeField] private SettingsMenu _settingsMenu;
    [SerializeField] private PatternsMenu _patternsMenu;
  

    private void Awake()
    {
        _mainMenu.Configure(this);
        _settingsMenu.Configure(this);
        _patternsMenu.Configure(this);

        _mainMenu.Show();
        _settingsMenu.Hide();
        _patternsMenu.Hide();
    }

    public void ShowPatterns()
    {
        _mainMenu.Hide();
        _patternsMenu.Show();
    }

    public void ShowSettings()
    {
        _mainMenu.Hide();
        _settingsMenu.Show();
    }

    public void GoToMainMenu()
    {
        _mainMenu.Show();
        _settingsMenu.Hide();
        _patternsMenu.Hide();
    }

    public void GoToFactoryScene()
    {
        SceneManager.LoadScene("Factory Y abstract Factory");
    }

    public void GoToBuilderScene()
    {
        SceneManager.LoadScene("Builder");
    }

}
