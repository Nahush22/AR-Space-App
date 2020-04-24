using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using Gizmos = Popcron.Gizmos;

[ExecuteAlways]
public class CircleScipt : MonoBehaviour
{
    public int vertexCount = 40;
    public float lineWidth = 0.1f;
    public float radius;
    public bool circleFillscreen;

    public Vector3 oldPos;

    public int count = 0;

    // private GameObject planetPos;
    // private LineRenderer lineRenderer;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>

    void Awake()
    {
        // lineRenderer = GetComponent<LineRenderer>();

        // Gizmos.CameraFilter += cam =>
        // {
        //     return cam.name == "ARCamera";
        // };
    }

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>

    void Start()
    {
        oldPos = this.transform.position;
    }

    /// <summary>
    /// This function is called when the object becomes enabled and active.
    /// </summary>

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>


/// <summary>
/// This function is called when the object becomes enabled and active.
/// </summary>

    void Update()
    {
        // oldPos = this.transform.position;
        // OnDrawGizmos();
    }

    void OnEnable()
    {
        // always sub in on enable, because OnEnable gets called when code gets recompiled AND on awake
        // Gizmos.CameraFilter += cam =>
        // {
        //     return cam.name == "ARCamera";
        // };
    }

    /// <summary>
    /// OnRenderObject is called after camera has rendered the scene.
    /// </summary>
    // void OnRenderObject()
    // {
    //     float deltaTheta = (2f * Mathf.PI) / 40f;
    //     float theta = 0f;

    //     // Vector3 oldPos = Vector3.zero;

    //     for(int i=0;i<vertexCount+1;i++)
    //     {
    //         Vector3 pos = new Vector3(radius*Mathf.Cos(theta), 0f, radius*Mathf.Sin(theta));
            
    //         // Gizmos.DrawLine(oldPos, transform.position + pos);

    //         Gizmos.Line(oldPos, transform.position + pos);
    //         oldPos = transform.position + pos;

    //         theta += deltaTheta;
    //     }
    // }

    /// <summary>
    /// Callback to draw gizmos that are pickable and always drawn.
    /// </summary>

    void OnDrawGizmos()
    {

            float deltaTheta = (2f * Mathf.PI) / vertexCount;   //It gives the angle between every point on the circle to its next point.The angles are always equal since we divide the total angle by no. of vertices.
            float theta = 0f;   //It denotes the angle between default angle between lineOf(centre,1st point of circle) & lineOf(centre,next point to be plotted in circle)

            // Vector3 oldPos = Vector3.zero;

            for(int i=0;i<vertexCount+1;i++)
            {
                Vector3 pos = new Vector3(radius*Mathf.Cos(theta), 0f, radius*Mathf.Sin(theta)); //Finding coordinates of new point based on angle between default 1st point & next point to plot
                
                Gizmos.DrawLine(oldPos, transform.position + pos);

                if(i==0)
                    oldPos = transform.position + pos; //Since first point is assigned to center of obj, we are reassigning it to 2nd point

                // Gizmos.Line(oldPos, transform.position + pos, Color.white); //oldPos->First Position; transform.position->Position of script attached obj; pos->coord.s of first point
                oldPos = transform.position + pos; //Setting 2nd point as new first point

                theta += deltaTheta; //Adding an angle to 1st point angle
            }
    }


}
