using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SpawnCars : MonoBehaviour
{
    public GameObject[] cars;
    private float[] positions = {-1.32f, -0.52f, 0.33f, 1.15f};
    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {
            int carAmount = Random.Range(1, positions.Length);
            var positionAndCarDictionary = new Dictionary<float, GameObject>();

            while (carAmount > 0)
            {
                float position = positions[Random.Range(0, positions.Length)];
                GameObject car = cars[Random.Range(0, cars.Length)];
                if (positionAndCarDictionary.Keys.Contains(position)) continue;
                positionAndCarDictionary.Add(position, car);
                carAmount--;
            }

            foreach (var positionAndCar in positionAndCarDictionary)
            {
                Instantiate(
                    cars[Random.Range(0, cars.Length)],
                    new Vector3(positionAndCar.Key, 6.0f, 0),
                    Quaternion.Euler(new Vector3(90, 180, 0))
                );
            }

            yield return new WaitForSeconds(1.2f);
        }
    }
    
}
