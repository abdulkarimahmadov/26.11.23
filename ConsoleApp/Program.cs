
using MyCustomNamespace;

CustomGenList<int> customGenList = new();

customGenList.Add(1);
customGenList.Add(2);
customGenList.Add(3);
customGenList.Add(4);
customGenList.Add(5);
customGenList.Add(6);
customGenList.Add(7);
customGenList.Add(8);
customGenList.Add(9);
customGenList.Add(10);

Console.WriteLine(customGenList.Count);
Console.WriteLine(customGenList.Capacity);
