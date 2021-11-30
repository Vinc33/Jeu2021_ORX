using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMap : MonoBehaviour
{
    public Pathfinding Pathfinding;
    // Start is called before the first frame update
    private void Start()
    {
        Pathfinding = new Pathfinding(19 , 6);

    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPosition = UtilityClass.GetMouseWorldPosition();
            Pathfinding.GetGrid().GetXY(mouseWorldPosition, out int x, out int y);
            List<PathNode> path = Pathfinding.FindPath(0, 0, x, y);
            if(path != null)
            {
                for(int i=0; i<path.Count; i++)
                {
                    Debug.Log(path[i].x + " , " + path[i].y);
                }
            }
        }
    }
}
