using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class player : MonoBehaviour
{
    [SerializeField] private Vector3 TargetPos;
    private NavMeshAgent _agent;
    public bool playerInRangeLaxatif;
    public bool playerInRangeAmpoule;
    public bool playerInRangeTissus;
    public bool playerInRangeSeringue;
    public bool playerInRangeClope;
    public bool playerInRangeSoju;
    public bool playerInRangeTirroir;
    public bool playerInRangeEcran;
    public Tirroir _tirroir;
    public GameObject zone;
    public Animator anim;
    public Vector2 stuckDistanceCheck;
    private Vector3 _scale;
    [SerializeField] private float perspectiveScale = 0.05f;
    [SerializeField] private float scaleRatio = 7f;
    public mur _mur;


    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        TargetPos = new Vector2(transform.position.x, transform.position.y);
        _agent.updateRotation = false;
        _agent.updateUpAxis = false;
        anim = GetComponent<Animator>();
        _scale = transform.localScale;
    }

    private void Update()
    {
        if (_mur.notdeplace == true)
        {
            UpdateAnimation();
            RescalePlayerDistance();
        }
        if (_mur.notdeplace == false)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                                if (Input.GetMouseButtonDown(0) && Time.timeScale == 1)
                                {
                                    TargetPos = new Vector2(mousePos.x, mousePos.y);
                                }
                    
                        
                                _agent.SetDestination(new Vector3(TargetPos.x, TargetPos.y, transform.position.z));
                                UpdateAnimation();
                                RescalePlayerDistance();
        }
        

    }
    
    private void RescalePlayerDistance()
    {
        _scale.x = perspectiveScale * (scaleRatio - transform.position.y);
        _scale.y = perspectiveScale * (scaleRatio - transform.position.y);
        transform.localScale = _scale;
    }
    
    private void UpdateAnimation()
    {
        float distance = Vector2.Distance(transform.position, TargetPos);
        if (Vector2.Distance(stuckDistanceCheck, transform.position) == 0)
        {
            anim.SetFloat("Distance",0f); return;

        }
        anim.SetFloat("Distance",distance);
        if (distance > 0.01f)
        {
            Vector3 direction = transform.position - new Vector3(TargetPos.x,TargetPos.y,transform.position.z);
            float angle = Mathf.Atan2(direction.x,direction.y) * Mathf.Rad2Deg;
            anim.SetFloat("Angle",angle);
            stuckDistanceCheck = transform.position;
        }

    }
    
     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Laxatiftrigger"))
        {
            playerInRangeLaxatif = true;
        }
        if (col.CompareTag("Ampouletrigger"))
        {
            playerInRangeAmpoule = true;
        }
        if (col.CompareTag("Tissustrigger"))
        {
            playerInRangeTissus = true;
        }
        if (col.CompareTag("Seringuetrigger"))
        {
            playerInRangeSeringue = true;
        }
        if (col.CompareTag("Clopetrigger"))
        {
            playerInRangeClope = true;
        }
        if (col.CompareTag("Sojutrigger"))
        {
            playerInRangeSoju = true;
        }
        if (col.CompareTag("Tirroirtrigger"))
        {
            playerInRangeTirroir = true;
        }
        if (col.CompareTag("Ecrantrigger"))
        {
            playerInRangeEcran = true;
        }
        
    }
        
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Laxatiftrigger"))
        {
            playerInRangeLaxatif = false;
        }
        if (other.CompareTag("Ampouletrigger"))
        {
            playerInRangeAmpoule = false;
        }

        if (other.CompareTag("Tissustrigger"))
        {
            playerInRangeTissus = false;
        }

        if (other.CompareTag("Seringuetrigger"))
        {
            playerInRangeSeringue = false;
        }

        if (other.CompareTag("Clopetrigger"))
        {
            playerInRangeClope = false;
        }

        if (other.CompareTag("Sojutrigger"))
        {
            playerInRangeSoju = false;
        }
        if (other.CompareTag("Tirroirtrigger"))
        {
            playerInRangeTirroir = false;
        }
        if (other.CompareTag("Ecrantrigger"))
        {
            playerInRangeEcran = false;
        }
            
    }
}
