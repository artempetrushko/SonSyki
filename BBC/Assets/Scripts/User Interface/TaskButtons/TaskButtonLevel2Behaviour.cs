﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskButtonLevel2Behaviour : MonoBehaviour
{
    private GameObject player;
    private GameObject codeField;
    private InputField taskField;
    private int taskNumber;
    private string taskDescription;

    public void ShowTask1()
    {
        taskNumber = 1;
        taskDescription = @"                                                               Задание
Мой компьютер опять замерз, помоги с этой штукой, то что ты получишь в результате, будет недостающей частью моего пароля";
        ShowTask();
    }

    public void ShowTask2()
    {
        taskNumber = 2;
        taskDescription = @"                                                               Задание
Я потерял листочек с кодом, можешь дописать?";
        ShowTask();
    }

    public void ShowTask3()
    {
        taskNumber = 3;
        taskDescription = @"                                                               Задание
Исправь ошибки, заполнив пропуски. Не забудь про медведя";
        ShowTask();
    }

    public void ShowTask4()
    {
        taskNumber = 4;
        taskDescription = @"                                                               Задание
Ученик который был здесь до тебя написал программу, но в ней что-то работает неправильно, помоги найти ошибки";
        ShowTask();
    }

    private void ShowTask()
    {
        codeField = GameObject.Find("Panel_Task" + taskNumber);
        player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        taskField.transform.position = taskField.GetComponent<TaskFieldBehaviour>().TurnOnPosition;
        codeField.transform.position = codeField.GetComponent<PanelTaskBehaviour>().TurnOnPosition;
        taskField.text = taskDescription;
        foreach (var answers in codeField.GetComponentsInChildren<InputField>())
            answers.interactable = true;
    }

    private void Start()
    {
        player = GameObject.Find("Snowman");
        taskField = GameObject.Find("TaskField").GetComponent<InputField>();
        var taskPanels = GameObject.Find("Task Panels");
        foreach (var answers in taskPanels.GetComponentsInChildren<InputField>())
            answers.interactable = false;
    }
}
