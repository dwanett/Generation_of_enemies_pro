using UnityEngine;

public class Enemie : MonoBehaviour
{
    [SerializeField] protected float _speed;
    
    protected TargetMove _targetMove;

    protected void Update()
    {
        Move();
    }

    protected void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetMove.transform.position, Time.deltaTime * _speed);
    }
    
    public void SetTargetMove(TargetMove targetMove)
    {
        _targetMove = targetMove;
    }
    
}
