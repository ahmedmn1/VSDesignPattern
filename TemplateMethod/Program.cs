// See https://aka.ms/new-console-template for more information
//TemplateMethod pattern
//Problem: in banking system, we need to save record trail for each task, task name and who did it. we created a task class for each task
// cause if we put the task inside say the Account, each time we have to change it we need to change the account. 


//TransferMoney task
//GenerateReport task

using TemplateMethod;

var transferMoney = new TransferMoneyTask();

transferMoney.Execute();



var transferMoney2 = new TransferMoneyTask(new AuditTrail());

transferMoney2.Execute();








