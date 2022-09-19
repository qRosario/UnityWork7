using UnityEngine;

public class Task1 : MonoBehaviour
{
    [SerializeField] private Transform[] _flags;
    [SerializeField] private float _speed;
    [SerializeField] private float _dst;
    private Vector3 _target;
    private bool _forward;


    private void Start()
    {
        _forward = true;
        _target = _flags[1].position;
    }

    private void Update()
    {
        transform.LookAt(_target);

        if(_forward == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, Time.deltaTime * _speed);
        }
        if(Vector3.Distance(transform.position, _target) < _dst && _target == _flags[1].position)
        {
            _target = _flags[2].position;
        }
        else if(Vector3.Distance(transform.position, _target) < _dst && _target == _flags[2].position)
        {
            _target = _flags[0].position;
        }
        else if (Vector3.Distance(transform.position, _target) < _dst && _target == _flags[0].position)
        {
            _target = _flags[1].position;
        }



    }
  
}
