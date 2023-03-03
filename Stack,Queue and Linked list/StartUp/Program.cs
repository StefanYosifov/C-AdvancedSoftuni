using Problem03.Queue;

MyQueue<int> nums = new MyQueue<int>();

nums.Enqueue(10);
nums.Enqueue(20);

foreach(var element in nums)
{
    Console.WriteLine(element);
}
Console.WriteLine(Environment.NewLine);

Console.WriteLine(nums.Dequeue());

Console.WriteLine(Environment.NewLine);


nums.Enqueue(10);
foreach (var element in nums)
{
    Console.WriteLine(element);
}