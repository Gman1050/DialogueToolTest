﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DialogueSystem
{
    [CreateAssetMenu(fileName = "DialogueTreeAsset", menuName = "ScriptableObjects/DialogueTreeScriptableObject", order = 1)]
    public class DialogueTree : ScriptableObject
    {
        public string characterName = "";

        [TextArea(10, 15)]
        public List<string> dialogueTreeElements = new List<string>();
        public List<AudioClip> dialogueTreeAudioClips = new List<AudioClip>();
    }
}