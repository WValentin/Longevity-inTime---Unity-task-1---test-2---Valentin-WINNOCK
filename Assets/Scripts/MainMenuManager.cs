using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public string age = "";
    public string weight = "";
    public string gender = "";

    public void AgeInput(string s)
    {
        age = s;
    }

    public void WeightInput(string s)
    {
        weight = s;
    }

    public void GenderInput(string s)
    {
        gender = s;
    }
}
