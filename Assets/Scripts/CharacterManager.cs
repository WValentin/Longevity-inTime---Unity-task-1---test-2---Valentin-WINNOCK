using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    private MainMenuManager _mainMenuManager;
    private GameObject character;

    void Start()
    {
        _mainMenuManager = GameObject.Find("UIManager").GetComponent<MainMenuManager>();
        character = GameObject.Find("Character");

        if (_mainMenuManager.age != "")
            character.transform.GetChild(1).gameObject.GetComponent<Text>().text = "AGE: " + _mainMenuManager.age + "\n";
        if (_mainMenuManager.weight != "")
            character.transform.GetChild(1).gameObject.GetComponent<Text>().text += "WEIGHT: " + _mainMenuManager.weight + "\n";
        if (_mainMenuManager.gender != "")
            character.transform.GetChild(1).gameObject.GetComponent<Text>().text += "GENDER: " + _mainMenuManager.gender;
    }
}
