using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
  [SerializeField] private float _maxTime = 1.5f;
  [SerializeField] private float _heightRange = .45f;
  [SerializeField] private GameObject _pipe;

  private float timer;

  private void Start()
  {
    SpawnPipe();
  }
  private void Update()
  {
    if (timer > _maxTime)
    {
      SpawnPipe();
      timer = 0;
    }
    timer += Time.deltaTime;
  }

  private void SpawnPipe()
  {
    Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
    GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);

    Destroy(pipe, 10f);
  }
}
