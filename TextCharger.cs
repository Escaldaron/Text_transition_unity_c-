using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextCharger : MonoBehaviour
{
    public string Texto;
    char[] texto_array;

    private float timer;
    public float tiempo_delay;

    int index;
    string texto_completo;
    // Start is called before the first frame update
    void Start()
    {
        texto_array = Texto.ToCharArray();
        timer = 0;
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        if (timer >= tiempo_delay)
        {
            if (index < texto_array.Length)
            {
                this.GetComponent<TextMeshProUGUI>().text += texto_array[index];
                index += 1;
            }
            timer = 0;
        }
    }
}


/*
   __________ _____ 
  / __/ __/ //_/ _ |
 / _/_\ \/ ,< / __ |
/___/___/_/|_/_/ |_|
 intagram: @nikoo_penaloza

*/