using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour {

    public enum FollowType
    {
        MoveToward,
        lerp
    }

    public FollowType Type = FollowType.MoveToward;
    public PathDefinition Path;
    public float speed = 1;
    public float MaxDistanceToGoal = .1f;

    private IEnumerator<Transform> _currentPoint;

	public void Start () {
	
        if(Path == null)
        {
            Debug.LogError("Path cannot be found ", this.gameObject);
            return;
        }

        _currentPoint = Path.GetPathsEnumerator();
        _currentPoint.MoveNext();


        if (_currentPoint.Current == null)
            return;

        this.gameObject.transform.position = _currentPoint.Current.position;
	}
	
	
	public void Update () {

        if (_currentPoint == null || _currentPoint.Current == null)
            return;

        if (Type == FollowType.MoveToward)
            transform.position = Vector3.MoveTowards(transform.position, _currentPoint.Current.position, Time.deltaTime * speed);

        else if (Type == FollowType.lerp)
            transform.position = Vector3.Lerp(transform.position, _currentPoint.Current.position, Time.deltaTime * speed);

        var distanceSquared = (transform.position - _currentPoint.Current.position).sqrMagnitude;
        if (distanceSquared < MaxDistanceToGoal * MaxDistanceToGoal)
            _currentPoint.MoveNext();
		
	}
}
