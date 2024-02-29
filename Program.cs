using System;
using Singleton_Design_Pattern;


Thread t1 = new Thread(() =>
{
  Memory.Instance(1);
});


Thread t2 = new Thread(() =>
{
   Memory.Instance(2);
});


t1.Start(); 
t2.Start();

t1.Join();
t2.Join();

Console.WriteLine(Memory.Instance(1).Id.ToString());
Console.WriteLine(Memory.Instance(2).Id.ToString());