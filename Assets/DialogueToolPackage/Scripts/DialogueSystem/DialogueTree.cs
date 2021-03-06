﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DialogueSystem
{
    [CreateAssetMenu(fileName = "DialogueTreeAsset", menuName = "ScriptableObjects/DialogueTreeScriptableObject", order = 1)]
    public class DialogueTree : ScriptableObject
    {
        public List<DialogueNode> dialogueNodeElements = new List<DialogueNode>();
        public MultipleChoiceNode multipleChoiceNode = new MultipleChoiceNode();
        public DialogueTree nextDialogueTree;

        [System.Serializable]
        public struct DialogueNode
        {
            public string nodeCharacterName;

            [TextArea(10, 15)]
            public string nodeDialogueString;

            public AudioClip nodeDialogueAudioClip;
        }

        [System.Serializable]
        public struct MultipleChoiceNode
        {
            [TextArea(10, 15)]
            public string question;

            public List<MultipleChoiceAnswer> answers;
        }

        [System.Serializable]
        public struct MultipleChoiceAnswer
        {
            [TextArea(10, 15)]
            public string answer;

            public DialogueTree dialogueTreeResponse;
        }
    }
}