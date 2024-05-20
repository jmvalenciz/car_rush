using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{
    [SerializeField] private float TiempoTotal;
    private float tiempoRestante;
    public Text textTiempo;
    void Start()
    {
        tiempoRestante = TiempoTotal;
        StartCoroutine(cuentaRegresiva());
    }

    // Update is called once per frame
    void Update()
    {
        int minutos = Mathf.FloorToInt(tiempoRestante / 60);
        int segundos = Mathf.FloorToInt(tiempoRestante % 60);
        textTiempo.text = "Tiempo: " + string.Format("{0:00}:{1:00}", minutos, segundos);
    }

    IEnumerator cuentaRegresiva()
    {
        while (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;
            yield return null;
        }
    }
}
