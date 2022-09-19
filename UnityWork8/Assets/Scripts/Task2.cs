using UnityEngine;

public class Task2 : MonoBehaviour
{
    [SerializeField] private Transform[] _cars;
    [SerializeField] private float _speed;
    [SerializeField] private float _dst;
    private int _currentCar;
    private Vector3 _currentPosition;
    private Vector3 _targetPosition;

    private void Start()
    {
        _currentCar = 0;
    }
    private void Update()
    {
        _currentPosition = _cars[_currentCar].position;
        _targetPosition = _cars[_currentCar + 1].position;
        _cars[_currentCar].LookAt(_cars[_currentCar + 1]);
        _cars[_currentCar].transform.position = Vector3.MoveTowards(_currentPosition, _targetPosition, Time.deltaTime * _speed);

        if(_currentCar < _cars.Length - 1)
        {
            _cars[_currentCar].transform.position = Vector3.MoveTowards(_currentPosition, _targetPosition, Time.deltaTime * _speed);
            if (Vector3.Distance(_currentPosition, _targetPosition) <= _dst)
            {
                _currentCar += 1;
            }
        }
        if (_currentCar >= _cars.Length - 1)
        {
            _currentCar = 0;
        }


    }
}
