using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: test failed expect charlie but actual is bob
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 3);
        priorityQueue.Enqueue("Charlie", 2);
        priorityQueue.Enqueue("Alice", 1);

        Assert.AreEqual("Bob", priorityQueue.Dequeue());     // Highest priority (3)
        Assert.AreEqual("Charlie", priorityQueue.Dequeue()); // Next highest (2)
        Assert.AreEqual("Alice", priorityQueue.Dequeue());   // Lowest (1)
    }


    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found:  test failed expect b but actual is c
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 5);
        priorityQueue.Enqueue("D", 1);

        Assert.AreEqual("B", priorityQueue.Dequeue()); // Highest priority (5), first in
        Assert.AreEqual("C", priorityQueue.Dequeue()); // Next highest (5), second in
        Assert.AreEqual("A", priorityQueue.Dequeue()); // Next highest (2)
        Assert.AreEqual("D", priorityQueue.Dequeue()); // Lowest (1)
    }

    // Add more test cases as needed below.
    
     [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: Throws InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: No defect found if exception is thrown correctly.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue(), "The queue is empty.");
    }
}