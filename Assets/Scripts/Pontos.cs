using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour
{
    public static Pontos levelManager;

    private int moedasAtual = 0;
    
    private float segundos;
    private int segundosToInt;
    private int minutos;

    public Text minutosText;
    public Text segundosText;
    public Text moedasText;
    public Text segundosText2;
    public Text moedasText2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake() {
        if (levelManager == null)
        {
            levelManager = this;
        }
        else if(levelManager != this)
        {
            Destroy(gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
        segundos += Time.deltaTime;

        if (segundos >= 60)
        {
            segundos = 0;
            minutos++;
            minutosText.text = minutos.ToString();
        }

        segundosToInt = (int) segundos;
        segundosText.text = segundosToInt.ToString();
        segundosText2.text = segundosToInt.ToString();
    }

    public void SetMoedas()
    {
        moedasAtual++;
        moedasText.text = moedasAtual.ToString();
        moedasText2.text = moedasAtual.ToString();

      
    }
      public int GetMoedas()
        {
            return moedasAtual;
        }

    
}
