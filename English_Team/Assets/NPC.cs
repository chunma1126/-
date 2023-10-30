using System;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    [SerializeField] private Transform _target;
    [SerializeField] private MessageSO _messageSo;

    [SerializeField] private TextMeshProUGUI[] buttons;
    
    private void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _navMeshAgent.SetDestination(_target.position);
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position , _target.position) <= 2f)
        {
            for (int i= 0; i <3; i++)
            {
                buttons[i].SetText(_messageSo.str[i]);
            }
        }
    }
}
