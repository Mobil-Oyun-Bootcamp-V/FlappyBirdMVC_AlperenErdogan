using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class PipeView : MonoBehaviour
{
    public GameObject pipePrefab;
    public UnityAction Tick;
    
    public float xPos, minY, maxY;
    private float _time = 0;
    private float _rate;
    public float Rate
    {
        set => _rate = value;
    }

    private void Start()
    {
        Tick?.Invoke();
    }

    private void Update()
    {
        _time += Time.deltaTime;
        if (!(_time >= _rate)) return;
        _time = 0;
        Tick?.Invoke();
    }

    public void InstantiatePipe(float speed,float lifetime)
    {
        var instantiated = Instantiate(pipePrefab);
        instantiated.transform.position = new Vector2(xPos, Random.Range(minY, maxY));
        Destroy(instantiated.gameObject,lifetime);
        var pipe = instantiated.GetComponent<PipePrefabView>();
        pipe.Speed = speed;
        pipe.StartMove();
    }

    // public void StopPipes()
    // {
    //     _freeze = true;
    //     var pipes = FindObjectsOfType<PipePrefabView>();
    //     foreach (var pipe in pipes)
    //     {
    //         pipe.Speed = 0;
    //     }
    // }
}
