using MotoApp;

var stack = new Stack<double>();

var stackString = new Stack<string>();

var stackInt = new Stack<int>();

stack.Push(item: 4.8);
stack.Push(item: 43);
stack.Push(item: 333.4);

stackString.Push(item: "company");

stackInt.Push(item: 12);

double sum = 0.0;

while (stack.Count > 0)
{
    double item = stack.Pop();
    Console.WriteLine($"Item: {item}");
    sum += item;
}

Console.WriteLine($"Sum: {sum}");