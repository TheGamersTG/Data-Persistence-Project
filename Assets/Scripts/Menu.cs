using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{

    public GameObject InputField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame(){
        SaveManager.instance.Name = InputField.GetComponent<TMP_InputField>().text;
        SceneManager.LoadScene(1);
    }
}
