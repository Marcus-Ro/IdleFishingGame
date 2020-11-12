﻿using UnityEngine;

    public class FishSetup : MonoBehaviour
    {
        public FishType[] Fishes;
        public FishUI prefab;

            private void Start()
            {
                foreach (var fish in Fishes)
                {
                    var newFish = Instantiate(prefab, transform);
                    newFish.transform.position = new Vector2(Random.Range(0,800) ,Random.Range(-100,100) );
                    newFish.setup(fish);
                }
            }
    }
