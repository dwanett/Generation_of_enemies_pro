using UnityEngine;

public class TargetMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _pointMove;
    
    private Vector3 _pointStart;
    private float journeyLength;
    
    private void Awake()
    {
        _pointStart = transform.position;
    }
    
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _pointMove, Time.deltaTime * _speed);

        if (transform.position == _pointMove)
        {
            _pointMove = _pointStart;
            _pointStart = transform.position;
        }
    }
}
