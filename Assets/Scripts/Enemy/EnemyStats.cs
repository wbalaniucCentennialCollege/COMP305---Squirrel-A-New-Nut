﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "AI/EnemyStats")]
public class EnemyStats : ScriptableObject
{
    // General Information
    [Header("General Information")]
    public int scoreValue = 10;

    // State Information
    [Header("State Information")]
    [Header("State - PATROL")]
    public float patrolSpeed = 1;

    [Header("State - CHASE")]
    public float chaseSpeed = 5;
    public float chaseRange = 5;

    [Header("State - ATTACK")]
    public float attackRange = 0.1f;
    public float attackRate = 1;
    public float attackDamage = 20;

    // Health Information

    // Audio Information
}
