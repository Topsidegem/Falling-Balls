using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ball;
    [SerializeField] private int cantidadInicial; 
    [SerializeField] private int maximoObjetosActivos; 
    [SerializeField] private float tiempoEntreSpawns;

    private List<GameObject> ballspool = new List<GameObject>();
    private int objetosActivos = 0;

    private void Start()
    {
        for (int i = 0; i < cantidadInicial; i++)
        {
            GameObject objeto = Instantiate(ball, transform.position, Quaternion.identity);
            objeto.SetActive(false);
            ballspool.Add(objeto);
        }
        StartCoroutine(SpawnObjetos());
    }

    private IEnumerator SpawnObjetos()
    {
       while (true)
        {
            bool todosActivos = true;

            if (objetosActivos < maximoObjetosActivos)
            {
                GameObject objeto = ballspool.Find(o => !o.activeInHierarchy);

                if (objeto == null && ballspool.Count < maximoObjetosActivos)
                {
                    objeto = Instantiate(ball, transform.position, Quaternion.identity);
                    ballspool.Add(objeto);
                }

                if (objeto != null)
                {
                    objeto.transform.position = transform.position;
                    objeto.SetActive(true);
                    objetosActivos++;
                }
            }

            foreach (var objeto in ballspool)
            {
                if (!objeto.activeInHierarchy)
                {
                    todosActivos = false;
                    break;
                }
            }

            if (todosActivos)
            {
                //print("se detuvo");
                yield break;
            }

            yield return new WaitForSeconds(tiempoEntreSpawns);
        }
    }
}
