﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    [SerializeField] float DestroyTime;
   public void DoDestroy()
    {
        Destroy(gameObject);
    }
}
