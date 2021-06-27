using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class Addierer : MonoBehaviour
{
    public Text textObstGesamt;
    public Text textObstTeil;
    public int rand_ObstkorbGesamt;
    public int rand_ObstkorbTeil;
    public InputField inputKind;
    // Start is called before the first frame update
    
        private void initRandoms()
    {
        rand_ObstkorbGesamt = Random.Range(1, 10);
        Debug.Log("randnumGesamt" + rand_ObstkorbGesamt);
        textObstGesamt.text = "=" + rand_ObstkorbGesamt;

        rand_ObstkorbTeil = Random.Range(1, rand_ObstkorbGesamt);
        Debug.Log("randnumTeil" + rand_ObstkorbTeil);
        textObstTeil.text = " " + rand_ObstkorbTeil + "+";

    }
    void Start()
    {

        initRandoms();
    }

    public void OnMouseUp()
    {
        if (inputKind.text != null&& !inputKind.text.Equals(""))
        { Debug.Log("geeeeeeeehhht" + inputKind.text);
            int eingabeKindInteger = int.Parse(inputKind.text);

            int result = eingabeKindInteger + rand_ObstkorbTeil;

            if (result== rand_ObstkorbGesamt)
            {
                Debug.Log("Rechnung ist richtig");
                initRandoms();
            }
            else
            {
                Debug.Log("Rechnung ist falsch, Ergebnis: " + result);
            }

        }

        else
        {
            Debug.Log("keine eingabe");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
