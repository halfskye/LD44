﻿using UnityEngine;

public class BloodController : MonoBehaviour {

    public GameObject BloodLevel;
    private Vector3 _bloodLevelVisualStartPos;
    private Vector3 _bloodLevelVisualZeroPos;
    private float _bloodLevelMaxForVisual = 9000f;
    private float _bloodLevelMaxPosX = 0.01f;
    private float _bloodLevelMinPosX = -12.74f;

    // Use this for initialization
    void Start()
    {
        float scaleToZero = Player.Get().GetHealth() / _bloodLevelMaxForVisual * (_bloodLevelMaxPosX - _bloodLevelMinPosX);
        _bloodLevelVisualZeroPos = BloodLevel.transform.position;
        _bloodLevelVisualZeroPos.x = _bloodLevelMinPosX;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateBloodLevelVisual();
    }

    private void UpdateBloodLevelVisual()
    {
        float bloodScale = Mathf.Min(Player.Get().GetHealth(), _bloodLevelMaxForVisual) / _bloodLevelMaxForVisual * (_bloodLevelMaxPosX - _bloodLevelMinPosX);
        
        BloodLevel.transform.position = Vector3.Lerp(BloodLevel.transform.position, _bloodLevelVisualZeroPos + (Vector3.right * bloodScale), Time.deltaTime * 5);
        //Mathf.Lerp(_bloodLevelMaxPosX,_bloodLevelMinPosX, Vector3.right * bloodScale);
    }
}
