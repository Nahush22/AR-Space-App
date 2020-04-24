using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class PlanetOrbitScript : MonoBehaviour
{

    public int vertexCount = 40;
    public float lineWidth = 0.1f;
    public float radius;
    
    // public bool circleFillscreen;

    public Vector3 oldPos;

    private GameObject planetPos;
    private LineRenderer lineRenderer;


    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        SetupCircle();
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>

    private void SetupCircle()
    {
        lineRenderer.widthMultiplier = lineWidth;

        // lineRenderer.startWidth = 0.1f;
        // lineRenderer.endWidth = 0.1f;

        lineRenderer.startColor = Color.white;
        lineRenderer.endColor = Color.white;



        // if(circleFillscreen)
        // {
        //     radius = Vector3.Distance(Camera.main.ScreenToWorldPoint(new Vector3(0f, Camera.main.pixelRect.yMax, 0f)), Camera.main.ScreenToWorldPoint(new Vector3(0f, Camera.main.pixelRect.yMin, 0f))) * 0.5f - lineWidth;
        // }

        float deltaTheta = (2f * Mathf.PI) / vertexCount;
        float theta = 0f;

        lineRenderer.positionCount = vertexCount;
        for(int i=0; i<lineRenderer.positionCount; i++)
        {
            Vector3 pos = new Vector3(radius * Mathf.Cos(theta), 0f, radius * Mathf.Sin(theta));
            lineRenderer.SetPosition(i, pos);

            theta+=deltaTheta;
        }
    }


/// <summary>
/// Update is called every frame, if the MonoBehaviour is enabled.
/// </summary>

    // Start is called before the first frame update
    void Start()
    {
        oldPos = this.transform.position;
    }

    /// <summary>
    /// Callback to draw gizmos that are pickable and always drawn.
    /// </summary>

    // void OnDrawGizmos()
    // {
    //     float deltaTheta = (2f * Mathf.PI) / vertexCount;
    //     float theta = 0f;

    //     // Vector3 oldPos = Vector3.zero;

    //     for(int i=0;i<vertexCount+1;i++)
    //     {
    //         Vector3 pos = new Vector3(radius*Mathf.Cos(theta), 0f, radius*Mathf.Sin(theta));
            
    //         Gizmos.DrawLine(oldPos, transform.position + pos);
    //         oldPos = transform.position + pos;

    //         theta += deltaTheta;
    //     }
    // }

}
