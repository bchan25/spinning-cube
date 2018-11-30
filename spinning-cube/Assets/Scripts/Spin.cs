using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spin : MonoBehaviour
{
    public Text buttonText;
    private bool _spin = false;

   
    void Update()
    {
        if(_spin)
            transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

    public void ButtonPressed()
    {
        _spin = !_spin;
        buttonText.text = _spin == true ? "STOP" : "SPIN";
    }
}
